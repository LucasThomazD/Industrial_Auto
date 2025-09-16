using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;

using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;



namespace windowsFormOI
{



    public partial class Form1 : Form
    {
        public Excel.Application excelApp;
        public Excel.Workbook workbook;
        private string caminhoImprimir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "imprimir");
        private Dictionary<string, Layout> layouts;
        private string ultimoStatus = "";
        private string caminhoArquivo = "include/log.txt"; // Caminho do arquiv
        private PdfViewer pdfViewer = new PdfViewer();
        private string caminhoConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        private Configuracao config;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Evita flickering (tremulação)
            LoadLayouts();
            LayoutComboBox();
            bloqueador();
            CarregarConfiguracao();
            PreencherCampos();
            CarregarTabelas();
            PCP_01.Checked = true;
            Comparativos_aba.Checked = true;


            this.Paint += new PaintEventHandler(FormPrincipal_Paint);

            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;


            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            dataGridView1.KeyDown += dataGridView1_KeyDown;

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.BackColor = Color.Transparent;

            //Container2.DrawMode = TabDrawMode.OwnerDrawFixed;
            //Container2.Appearance = TabAppearance.FlatButtons;
            //Container2.ItemSize = new Size(0, 1);
            //Container2.SizeMode = TabSizeMode.Fixed;
            //Container2.BackColor = Color.Transparent;

            textInicio.Enabled = false;
            textFim.Enabled = false;
            boxAbaCSD.Enabled = false;
            Box_Nomear.Enabled = false;

            //SetRoundedBorder(15, button1, button2, button3, button4, botUnificar, bArquivo, bAplicarInfo, bUnico, bElet, bCBINC, bMentos, bInst, bTub, bSupTub, bMulti, bConsolidado);
            SetRoundedBorder(10, panel7, panel8, panel1, panel2);
        }

        private void FormPrincipal_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Rectangle rect = this.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(235, 235, 235),   // Cor inicial
                Color.FromArgb(20, 194, 204), // Cor final
                LinearGradientMode.Vertical)) // Pode ser Horizontal, ForwardDiagonal, etc.
            {
                g.FillRectangle(brush, rect);
            }
        }

        private void CarregarConfiguracao()
        {
            if (File.Exists(caminhoConfig))
            {
                string json = File.ReadAllText(caminhoConfig);
                config = JsonConvert.DeserializeObject<Configuracao>(json);
            }
            else
            {

                config = new Configuracao();
                CreatConfig();
            }
        }

        private void CreatConfig()
        {
            padraoSalvar();
            padraoPDF();
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(caminhoConfig, json);
        }

        // TABEELAS
        private void CarregarTabelas()
        {
            try
            {
                string caminhoBanco = CaminhoDB.Text;// ajuste aqui
                string conexaoString = $"Data Source={caminhoBanco};Version=3;";

                using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
                {
                    conexao.Open();
                    string query = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";

                    using (SQLiteCommand comando = new SQLiteCommand(query, conexao))
                    using (SQLiteDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            ATTabelaBox.Items.Add(leitor["name"].ToString());
                            DeletarTabelaBox.Items.Add(leitor["name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Erro ao carregar tabelas: {ex.Message}");
            }
        }
        string nometabela;


        private void DeletarTabelabt_CheckedChanged(object sender, EventArgs e)
        {
            if (DeletarTabelabt.Checked == true)
            {

                ModeloVarredura.Text = "Deletar";
            }
            else
            {
                ModeloVarredura.Text = "Selecione";
            }
        }
        private void verificarVarredura()
        {
            if (ATTabelaBt.Checked == true)
            {
                nometabela = ATTabelaBox.Text;
            }
            else if (NewTabelaBt.Checked == true)
            {
                nometabela = NewTabelaBox.Text;
            }
            else if (DeletarTabelabt.Checked == true)
            {
                nometabela = DeletarTabelaBox.Text;
            }

        }


        private void DB_BT_Click(object sender, EventArgs e)
        {
            if (DeletarTabelabt.Checked == true || NewTabelaBt.Checked == true || ATTabelaBt.Checked == true)
            {
                verificarVarredura();
                string modoTab = ModeloVarredura.Text;

                string caminhotab = CaminhoVarredura.Text;
                timer1.Start();
                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "vasculhar.py");
                AtualizarStatus("", 0);
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                startInfo.Arguments = $"\"{scriptpath}\" \"{modoTab}\" \"{nometabela}\" \"{caminhotab}"; // Substitua pelo caminho do seu script Python
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;
                pythonProcess = Process.Start(startInfo);
            }
            else
            {
                AtualizarStatus("Selecione um modo de tabela");
            }
        }

        private void RecarregarTab_Click(object sender, EventArgs e)
        {
            ATTabelaBox.Items.Clear();
            DeletarTabelaBox.Items.Clear();
            CarregarTabelas();
        }


        // PADRÕES

        private void padraoSalvar()
        {
            config.Salvar.salvarFornecimento = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "fornecimento");
            config.Salvar.SalvarFisico = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "fisico");
            config.Salvar.SalvarConsolidado = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Consolidado");
            config.Salvar.SalvarTimbrado = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Timbrado");
            config.Salvar.SalvarCapas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Capas");
            config.Salvar.SalvarTemplates = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Templates");
        }


        private void padraoPDF()
        {
            config.PDF.Cat_letra_Size = "18";
            config.PDF.Sub_letra_Size = "16";
            config.PDF.Fornecedor_letra_Size = "30";
            config.PDF.Cat_Espa_Size = "7";
            config.PDF.Sub1_Espa_Size = "6";
            config.PDF.Sub2_Espa_Size = "6";

        }

        private void padraoGeral()
        {
            impressoras();
            config.Geral.Impressora = ImpressoraBox.Text;
            config.Geral.tema = "Claro";
            config.Geral.DataBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "src", "dados_arquivos.db");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string resultado = ""; // Variável para armazenar o resultado
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Dados (*.db)|*.db"; // Filtro de arquivos
            openFileDialog.Title = "Selecione um arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                resultado = openFileDialog.FileName; // Armazena o caminho do arquivo
                CaminhoDB.Text = resultado;
            }


        }

        private void impressoras()
        {
            ImpressoraBox.Items.Clear();

            foreach (string impressora in PrinterSettings.InstalledPrinters)
            {
                ImpressoraBox.Items.Add(impressora);
            }

            // Seleciona a impressora padrão, se estiver na lista
            string impressoraPadrao = new PrinterSettings().PrinterName;
            if (ImpressoraBox.Items.Contains(impressoraPadrao))
            {
                ImpressoraBox.SelectedItem = impressoraPadrao;
            }
        }

        private void carregarImpressora()
        {
            ImpressoraBox.Items.Clear();

            foreach (string impressora in PrinterSettings.InstalledPrinters)
            {
                ImpressoraBox.Items.Add(impressora);
            }

        }
        private void PreencherCampos()
        {

            // PDF
            TamL_Cat.Text = config.PDF.Cat_letra_Size.ToString();
            TamL_Sub.Text = config.PDF.Sub_letra_Size.ToString();
            TamL_Fornecedor.Text = config.PDF.Fornecedor_letra_Size.ToString();
            Espa_Cat.Text = config.PDF.Cat_Espa_Size.ToString();
            Espa_sub1.Text = config.PDF.Sub1_Espa_Size.ToString();
            Espa_sub2.Text = config.PDF.Sub2_Espa_Size.ToString();


            // Geral
            carregarImpressora();
            ImpressoraBox.Text = config.Geral.Impressora;
            TemaBox.Text = config.Geral.tema;
            CaminhoDB.Text = config.Geral.DataBase;

            // Salvar
            Sav_Excel_1.Text = config.Salvar.salvarFornecimento;
            Sav_Excel_2.Text = config.Salvar.SalvarFisico;
            Sav_Excel_3.Text = config.Salvar.SalvarConsolidado;
            Sav_PDF_1.Text = config.Salvar.SalvarTimbrado;
            Sav_PDF_2.Text = config.Salvar.SalvarCapas;
            Sav_PPQ_1.Text = config.Salvar.SalvarTemplates;
        }

        private void bot_sav_Click_1(object sender, EventArgs e)
        {
            // Salvar
            config.Salvar.salvarFornecimento = Sav_Excel_1.Text;
            config.Salvar.SalvarFisico = Sav_Excel_2.Text;
            config.Salvar.SalvarConsolidado = Sav_Excel_3.Text;
            config.Salvar.SalvarTimbrado = Sav_PDF_1.Text;
            config.Salvar.SalvarCapas = Sav_PDF_2.Text;
            config.Salvar.SalvarTemplates = Sav_PPQ_1.Text;

            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(caminhoConfig, json);
            AtualizarStatus("Configuração Salva", 0);



        }
        private void bot_reset_Click(object sender, EventArgs e)
        {
            padraoSalvar();
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(caminhoConfig, json);
            PreencherCampos();
            AtualizarStatus("Configuração Reiniciada", 0);
        }

        private void Capas_Reset_Bot_Click(object sender, EventArgs e)
        {
            padraoPDF();
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(caminhoConfig, json);
            PreencherCampos();
            AtualizarStatus("Configuração Reiniciada", 0);
        }

        private void Capas_Sav_Bot_Click(object sender, EventArgs e)
        {
            config.PDF.Cat_letra_Size = TamL_Cat.Text;
            config.PDF.Sub_letra_Size = TamL_Sub.Text;
            config.PDF.Fornecedor_letra_Size = TamL_Fornecedor.Text;
            config.PDF.Cat_Espa_Size = Espa_Cat.Text;
            config.PDF.Sub1_Espa_Size = Espa_sub1.Text;
            config.PDF.Sub2_Espa_Size = Espa_sub2.Text;
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(caminhoConfig, json);
            AtualizarStatus("Configuração Salva", 0);
        }

        private void Geral_Sav_Bot_Click(object sender, EventArgs e)
        {
            config.Geral.Impressora = ImpressoraBox.Text;
            config.Geral.tema = TemaBox.Text;
            config.Geral.DataBase = CaminhoDB.Text;
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(caminhoConfig, json);
            AtualizarStatus("Configuração Salva", 0);
        }

        private void Geral_Reset_Bot_Click(object sender, EventArgs e)
        {
            padraoGeral();
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(caminhoConfig, json);
            PreencherCampos();
            AtualizarStatus("Configuração Reiniciada", 0);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            try
            {

                if (File.Exists(caminhoArquivo))
                {

                    string novoStatus = File.ReadAllText(caminhoArquivo);

                    if (novoStatus == "Tarefa Concluida")
                    {

                        timer1.Stop();

                    }
                    if (novoStatus != ultimoStatus)
                    {
                        AtualizarStatus(novoStatus);
                        ultimoStatus = novoStatus;

                    }

                }
            }
            catch (Exception ex)
            {

                AtualizarStatus($"Erro ao ler o arquivo de log: {ex.Message}");
            }
        }
        private void valorIndice()
        {
            try
            {
                if (comboBox2.Text != null && textBoxEntrega != null)
                {
                    string texto1 = comboBox2.Text.Trim();
                    string texto2 = textBoxEntrega.Text.Trim();

                    string area = texto1.Length == 4 ? texto1.Substring(0, 1) : texto1;
                    string entrega = texto2.Length == 4 ? texto2.Substring(0, 3) : texto2;



                    string indice = $"6{area}{entrega}001";

                    valorDeIndice.Text = indice;
                }
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Erro ao calcular o índice: {ex.Message}", 0);
                valorDeIndice.Text = "Erro";
            }
        }
        private void ExportarParaExcel(DataGridView dgv)
        {
            var excelApp = new Excel.Application();
            excelApp.DisplayAlerts = false; // <- Desativa mensagens de aviso
            excelApp.Workbooks.Add();
            Excel._Worksheet planilha = (Excel._Worksheet)excelApp.ActiveSheet;

            // Cabeçalhos
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                planilha.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }

            // Dados
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    planilha.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }


            // Salvar arquivo
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Exportado.xlsx");
            planilha.SaveAs(caminho);
            excelApp.DisplayAlerts = true; // <- Desativa mensagens de aviso
            excelApp.Quit();

            MessageBox.Show("Arquivo Excel gerado com sucesso em: " + caminho);
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V) // Detecta Ctrl+V
            {
                string clipboardText = Clipboard.GetText();
                string[] lines = clipboardText.Split('\n'); // Quebra as linhas copiadas

                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int colIndex = dataGridView1.CurrentCell.ColumnIndex;

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue; // Ignora linhas vazias

                    string[] cells = line.Split('\t'); // Quebra células por TAB (como no Excel)

                    // Verifica se há linhas suficientes no DataGridView, se não, cria novas
                    if (rowIndex >= dataGridView1.RowCount - 1)
                    {
                        dataGridView1.Rows.Add();
                    }

                    for (int i = 0; i < cells.Length; i++)
                    {
                        if (colIndex + i >= dataGridView1.ColumnCount) break; // Evita ultrapassar limite de colunas
                        dataGridView1.Rows[rowIndex].Cells[colIndex + i].Value = cells[i].Trim();
                    }

                    rowIndex++; // Move para a próxima linha
                }
            }
        }



        private void botoespdf(System.Windows.Forms.Button button2, System.Windows.Forms.Button button4, System.Windows.Forms.Button botUnificar)
        {
            if (button2.Enabled == true || button4.Enabled == true || botUnificar.Enabled == true)
            {
                button2.Enabled = false;
                button4.Enabled = false;
                botUnificar.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button4.Enabled = true;
                botUnificar.Enabled = true;
            }
        }
        private void SetRoundedBorder(int radius, params System.Windows.Forms.Control[] controls)
        {
            foreach (System.Windows.Forms.Control control in controls)
            {
                control.Paint += (sender, e) =>
                {
                    Graphics g = e.Graphics;
                    g.SmoothingMode = SmoothingMode.AntiAlias; // Ativa antialiasing
                    this.DoubleBuffered = true;
                    GraphicsPath path = new GraphicsPath();
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    control.Region = new Region(path);
                };

                control.Invalidate(); // Força a atualização do controle
            }
        }



        Process pythonProcess;
        string perso = "Personalizar";

        private void bloqueador()
        {
            Sav_Excel_1.Enabled = false;
            Sav_Excel_2.Enabled = false;
            Sav_Excel_3.Enabled = false;
            Sav_PDF_1.Enabled = false;
            Sav_PDF_2.Enabled = false;
            Sav_PPQ_1.Enabled = false;

            //

            panel9.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 12; // Define 8 colunas
            dataGridView1.Columns[0].Name = "Entrega";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Name = "RM";
            dataGridView1.Columns[2].Name = "Área";
            dataGridView1.Columns[3].Name = "Oficina";
            dataGridView1.Columns[4].Name = "Serviço";
            dataGridView1.Columns[5].Name = "Disciplina";
            dataGridView1.Columns[6].Name = "Descrição";
            dataGridView1.Columns[6].Width = 300;
            dataGridView1.Columns[7].Name = "Tag";
            dataGridView1.Columns[8].Name = "Quantidade";
            dataGridView1.Columns[8].Width = 70;
            dataGridView1.Columns[9].Name = "Tipo";
            dataGridView1.Columns[9].Width = 50;
            dataGridView1.Columns[10].Name = "Valor";
            dataGridView1.Columns[11].Name = "Indice Item";
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;





            TA1_Box.Items.Add("Selecione");
            TA1_Box.Items.Add("TA 24");
            TA1_Box.Items.Add("TA 25");
            TA1_Box.Items.Add("TA 26");
            TA1_Box.Items.Add("TA 27");
            TA1_Box.Items.Add("TA 28");
            TA1_Box.Items.Add("TA 29");
            TA1_Box.Items.Add("TA 30");
            TA1_Box.Items.Add("TA 31");
            TA1_Box.Items.Add("TA 32");
            TA1_Box.Items.Add("TA 33");
            TA1_Box.Items.Add("TA 34");
            TA1_Box.Items.Add("TA 35");
            TA1_Box.Items.Add("TA 36");
            TA1_Box.Items.Add("TA 37");
            TA1_Box.Items.Add("TA 38");
            TA1_Box.Items.Add("TA 39");
            TA1_Box.Items.Add("TA 40");
            TA1_Box.SelectedIndex = 0;





            TA2_Box.Items.Add("Selecione");
            TA2_Box.Items.Add("TA 24");
            TA2_Box.Items.Add("TA 25");
            TA2_Box.Items.Add("TA 26");
            TA2_Box.Items.Add("TA 27");
            TA2_Box.Items.Add("TA 28");
            TA2_Box.Items.Add("TA 29");
            TA2_Box.Items.Add("TA 30");
            TA2_Box.Items.Add("TA 31");
            TA2_Box.Items.Add("TA 32");
            TA2_Box.Items.Add("TA 33");
            TA2_Box.Items.Add("TA 34");
            TA2_Box.Items.Add("TA 35");
            TA2_Box.Items.Add("TA 36");
            TA2_Box.Items.Add("TA 37");
            TA2_Box.Items.Add("TA 38");
            TA2_Box.Items.Add("TA 39");
            TA2_Box.Items.Add("TA 40");
            TA2_Box.SelectedIndex = 0;


            area_box.Items.Add("Selecione");
            area_box.Items.Add("1000");
            area_box.Items.Add("2000");
            area_box.Items.Add("2502");
            area_box.Items.Add("2511");
            area_box.Items.Add("2706");
            area_box.Items.Add("2721");
            area_box.Items.Add("2722");
            area_box.Items.Add("2737");
            area_box.Items.Add("2744");
            area_box.Items.Add("3000");
            area_box.Items.Add("4000");
            area_box.Items.Add("5000");
            area_box.Items.Add("6000");
            area_box.Items.Add("7000");
            area_box.Items.Add("7816");
            area_box.Items.Add("7818");
            area_box.Items.Add("8000");
            area_box.SelectedIndex = 0;

            BoxModelo.Items.Add("Selecione");
            BoxModelo.Items.Add("PADRÃO");
            BoxModelo.Items.Add("REDES");
            BoxModelo.Items.Add("COMPLEMENTO");
            BoxModelo.Items.Add("ENTREGAS");
            BoxModelo.Items.Add("PPQ");
            BoxModelo.Items.Add("Fis. Financeiro");
            BoxModelo.Items.Add("Crit. Med");
            BoxModelo.Items.Add("Resumo Fis.");
            BoxModelo.SelectedIndex = 0;




            comboBox2.Items.Add("1000");
            comboBox2.Items.Add("2000");
            comboBox2.Items.Add("2502");
            comboBox2.Items.Add("2511");
            comboBox2.Items.Add("2706");
            comboBox2.Items.Add("2721");
            comboBox2.Items.Add("2722");
            comboBox2.Items.Add("2737");
            comboBox2.Items.Add("2744");
            comboBox2.Items.Add("3000");
            comboBox2.Items.Add("4000");
            comboBox2.Items.Add("5000");
            comboBox2.Items.Add("6000");
            comboBox2.Items.Add("7000");
            comboBox2.Items.Add("7816");
            comboBox2.Items.Add("7818");
            comboBox2.Items.Add("8000");

            ModeloVarredura.Items.Add("Arquivos e Data");
            ModeloVarredura.Items.Add("Arquivos e Pastas");
            ModeloVarredura.Items.Add("Apenas Pastas");
            ModeloVarredura.SelectedIndex = 0;



            textInicio.Text = "1";
            textFim.Text = "1";
            Delimitador_Box.Text = "-";

            //Configurar ToolTip
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.SetToolTip(LBCataMilho, "Ferramenta de transferência de arquivos de um diretório pra outro");
            this.toolTip1.SetToolTip(labelRaiz, "Pasta Alvo");
            this.toolTip1.SetToolTip(labelDestino, "Destino dos arquivos transferidos da pasta alvo");
            this.toolTip1.SetToolTip(Bt_Organizar, "Organiza os arquivos na pasta out gerando-as no formato do TA");
            this.toolTip1.SetToolTip(PB_BT_Stop_1, "Interrompe o processo do cata milho (Fuga de emergência)");
            //this.toolTip1.SetToolTip(PB_gerenciador_1, "Abre no gerenciador de arquivos a pasta de saida dos arquivos Excel");
            //this.toolTip1.SetToolTip(bAplicarInfo, "Iniciar o arquivo Excel e atualiza as informações de cabeçalho ");
            //this.toolTip1.SetToolTip(bDerrubar, "Fecha o Excel");
            //this.toolTip1.SetToolTip(BtArquivoUnico, "Busca Apenas um arquivo, quando não há o mesmo no TA anterior");
            //this.toolTip1.SetToolTip(PB_buscar_1, "Inicia o diálogo de diretorio permitindo a busca manual do caminho com os arquivos");
            this.toolTip1.SetToolTip(textBox2, "Cole aqui o caminho da pasta com os arquivos a serem unificados");
            //this.toolTip1.SetToolTip(button2, "Gera arquivos PDF a partir de uma planilha excel, usando as margens continadas nos modelos");
            //this.toolTip1.SetToolTip(button4, "Aplica mesclagens no PDF, adicionando timbrado e página em branco");
            this.toolTip1.SetToolTip(Unificar_Bt, "Inicia um PopUp Contendo a ferramenta de Conversão de números");
            //this.toolTip1.SetToolTip(labelCabeçalho1, "Indica em que Linha Começar a Copiar no Primeiro Arquivo");
            this.toolTip1.SetToolTip(bot_sav, "Salvar");
            this.toolTip1.SetToolTip(bot_reset, "Resetar Configurações");
        }
        public void filtrarDisciplinas(string disciplina, string texto)
        {
            try
            {
                AtualizarStatus($"Gerando Comparativo de {texto}", 15);
                excelApp.Run(disciplina);
                AtualizarStatus($"Gerando Comparativo de {texto}", 56);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Comparativo de {texto} Gerado", 100);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Comparativo de {texto} Gerado", 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentCell != null && e.Button == MouseButtons.Left)
            {
                string valorSelecionado = dataGridView1.CurrentCell.Value?.ToString();

                if (!string.IsNullOrEmpty(valorSelecionado) &&
                    ((DataGridViewComboBoxColumn)dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex]).Items.Contains(valorSelecionado))
                {
                    int colIndex = dataGridView1.CurrentCell.ColumnIndex;
                    int rowIndexInicial = dataGridView1.CurrentCell.RowIndex;

                    // Percorre as células abaixo até onde houver linhas
                    for (int i = rowIndexInicial + 1; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[colIndex].Value == null) // Só preenche células vazias
                        {
                            dataGridView1.Rows[i].Cells[colIndex].Value = valorSelecionado;
                        }
                    }
                }
            }
        }



        private void LoadLayouts()
        {
            try
            {
                // Supondo que o arquivo "layouts.json" esteja na pasta de execução
                string jsonFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "layouts_papel.json");
                string jsonText = File.ReadAllText(jsonFile);
                layouts = JsonConvert.DeserializeObject<Dictionary<string, Layout>>(jsonText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o arquivo JSON: " + ex.Message);
            }
        }



        private void LayoutComboBox()
        {
            // Suponha que você tenha uma ComboBox chamada comboBoxLayouts no formulário
            BoxTimbrado.Items.Clear();


            if (layouts != null)
            {
                foreach (string key in layouts.Keys)
                {
                    BoxTimbrado.Items.Add(key);

                }
            }
        }




        public void AtualizarStatus(string mensagem, int progresso = -1)
        {
            // Atualiza o texto da StatusLabel
            toolStripStatusLabel1.Text = mensagem;

            // Atualiza o progresso, se fornecido
            if (progresso >= 0)
            {
                toolStripProgressBar1.Value = progresso;
            }

            // Força a atualização da interface
            statusStrip1.Refresh();
        }



        private void EnviarParaExcel(string opcao)
        {
            try
            {
                // Inicializa o Excel
                var excelApp = new Excel.Application();
                string caminhoMacro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "src", "macros.xlsm");

                // Abre o arquivo Excel
                workbook = excelApp.Workbooks.Open(caminhoMacro);

                // Torna o Excel visível
                excelApp.Visible = true;

                // Executa a macro com o parâmetro
                excelApp.Run("MinhaMacroComParametro", opcao);

                // Opcional: Fechar o Excel após a execução
                // workbook.Close(false);
                // excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }

        private void ComboBoxTArea(System.Windows.Forms.ComboBox BoxTA1, System.Windows.Forms.ComboBox BoxTA2, System.Windows.Forms.ComboBox BoxArea, System.Windows.Forms.ComboBox BoxModelo, System.Windows.Forms.TextBox textInicio, System.Windows.Forms.TextBox textFim)
        {
            try
            {
                var worksheet = (Excel.Worksheet)workbook.Sheets[1]; // Seleciona a primeira planilha
                if (BoxTA1.SelectedIndex > 0 || BoxTA2.SelectedIndex > 0 || BoxArea.SelectedIndex > 0 || BoxArea.SelectedIndex > 0 || textFim.Text != null || textInicio.Text != null)
                {
                    AtualizarStatus($"Atualizando Informações", 75);
                    string json = File.ReadAllText(caminhoConfig);
                    config = JsonConvert.DeserializeObject<Configuracao>(json);



                    // Define os valores em células específicas
                    worksheet.Cells[1, 1] = BoxTA1.SelectedItem.ToString(); // Célula A1
                    worksheet.Cells[1, 2] = BoxTA2.SelectedItem.ToString(); // Célula B1
                    worksheet.Cells[1, 3] = BoxArea.SelectedItem.ToString(); // Célula C1
                    worksheet.Cells[2, 2] = textInicio.Text.ToString(); // Célula B2
                    worksheet.Cells[2, 3] = textFim.Text.ToString(); // Célula C2
                    worksheet.Cells[2, 1] = BoxModelo.SelectedItem.ToString(); // Célula A2
                    worksheet.Cells[3, 1] = config.Salvar.salvarFornecimento; // Célula A3
                    worksheet.Cells[3, 2] = config.Salvar.SalvarFisico; // Célula B3
                    worksheet.Cells[3, 3] = config.Salvar.SalvarConsolidado; // Célula C3
                    AtualizarStatus($"Informações Atualizadas", 100);
                    System.Threading.Thread.Sleep(2000);
                    AtualizarStatus($"Pronto Para Buscar Arquivos Comparativos", 0);
                    MessageBox.Show("Informações Atualizadas");
                    return;
                }

                //string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "src", "macros.xlsm");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar valores no Excel: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }

        private void AbrirMacros()
        {
            try
            {
                // Inicializa o Excel apenas se ainda não estiver inicializado
                if (excelApp == null)
                {
                    AtualizarStatus($"Iniciando Macro", 25);
                    excelApp = new Excel.Application();
                    string caminhoMacro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "macros.xlsm");

                    // Abre o arquivo Excel
                    workbook = excelApp.Workbooks.Open(caminhoMacro);
                    AtualizarStatus($"Macro Iniciada", 50);

                    // Torna o Excel visível (opcional)
                    excelApp.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Abrir Arquivo Macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }
        private void FecharExcel()
        {
            try
            {
                if (workbook != null)
                {
                    AtualizarStatus($"Fechando Planilha", 45);
                    workbook.Close(false);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    workbook = null;
                    AtualizarStatus($"Planilha Fechada", 60);
                }

                if (excelApp != null)
                {
                    AtualizarStatus($"Saindo da Aplicação", 78);
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                    excelApp = null;
                    AtualizarStatus($"Finalizando Excel", 96);
                    System.Threading.Thread.Sleep(2000);
                    AtualizarStatus($"Planilha Fechada Com Sucesso", 0);
                }
                // Libera os objetos COM
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);


                AtualizarStatus("Excel fechado com sucesso!", 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar o Excel: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }


        }
        private void abrirDiretórioRaizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exemplo: Abre a pasta "src" no diretório base do aplicativo
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out");
            AbrirGerenciadorArquivos(caminho);
        }

        private void visualizarExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (excelApp.Visible == false)
                {
                    excelApp.Visible = true;
                }
                else
                {
                    excelApp.Visible = false;
                }

                AtualizarStatus($"Visibilidade do Excel Alterada", 0);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Visibilidade do Excel" + ex.Message);
            }
        }

        private void AbrirGerenciadorArquivos(string caminho)
        {
            try
            {
                AtualizarStatus($"Abrindo Gerenciador de Arquivos", 40);
                // Abre o Gerenciador de Arquivos no caminho especificado
                System.Diagnostics.Process.Start("explorer.exe", caminho);
                AtualizarStatus($"Caminho Encontrado", 80);
                System.Threading.Thread.Sleep(2000);
                AtualizarStatus($"Gerenciador Aberto em {caminho}", 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Gerenciador de Arquivos: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }


        private void informaçõesSuplementaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1-As Combo Box '1° TA' e '2° TA' servem para escolher os ta's dos arquivos selecionados posteriormente. \n" +
                "2-'Instanciar' serve para abrir o arquivo excel que contem as macros. \n" +
                "3-'Derrubar' fecha o arquivo excel, mas não se preocupe com isso ele ja fecha junto com o app.", "Informações Suplementares", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void filtrarDisciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1-Cada botão desse gera um arquivo comparativo de sua respectiva disciplina. \n" +
                "2-O botão multi-disciplinar gera de todas as disciplinas contidas nos arquivos. \n" +
                "3-Lembre-se que para a disciplina de instrumentos os tags dos itens devem ser adicionados caso não os encontre.", "Filtrar Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buscarunicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Sem comparativo' tem como função gerar um comparativo com apenas um arquivo informativo ou seja sem comparar nada.\n", "Sem Comparativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linhasDeCabeçalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1- As linhas de cabeçalho servem apenas no modelo 'padrão'. \n" +
                "2-'Cabeçalho no 1°' é onde se indicar em qual linha começa o cabeçalho desejado caso queira, senão só por a ultima linha dele. \n" +
                "3-'Nos Demais Copiar' indica a partir de que linha copiar os arquivos depois do primeiro.", "Cabeçalho", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// ----------------------- Aba PDF --------------------------------



        private string SelecionarArquivoOuPastaExcel()
        {
            string resultado = null; // Variável para armazenar o resultado

            if (radioArquivo.Checked) // Quando o RadioButton para arquivo é selecionado
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Arquivos Excel (*.xls*)|*.xls*"; // Filtro de arquivos
                openFileDialog.Title = "Selecione um arquivo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    resultado = openFileDialog.FileName; // Armazena o caminho do arquivo
                }
            }
            else if (radioPasta.Checked) // Quando o RadioButton para pasta é selecionado
            {
                resultado = Pathpdfs.Text;
            }

            return resultado; // Retorna o valor selecionado
        }
        private string SelecionarArquivoOuPastaPDF()
        {

            string resultado = null; // Variável para armazenar o resultado

            if (radioArquivo.Checked) // Quando o RadioButton para arquivo é selecionado
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Arquivos de texto (*.pdf)|*.pdf"; // Filtro de arquivos
                openFileDialog.Title = "Selecione um arquivo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    resultado = openFileDialog.FileName; // Armazena o caminho do arquivo
                }
            }
            else if (radioPasta.Checked) // Quando o RadioButton para pasta é selecionado
            {
                resultado = Pathpdfs.Text;
            }

            return resultado; // Retorna o valor selecionado
        }



        private void iniciarPythonExcel(System.Windows.Forms.ComboBox boxModeloPDF)

        {
            timer1.Start();
            string selecionado = SelecionarArquivoOuPastaExcel();

            if (selecionado != null)
            {
                string par1 = boxModeloPDF.SelectedItem.ToString();
                string imprimirpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Imprimir");

                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "Excel_to_PDF.py");


                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                startInfo.Arguments = $"\"{scriptpath}\" \"{par1}\" \"{imprimirpath}\" \"{selecionado}\""; // Substitua pelo caminho do seu script Python
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;

                pythonProcess = Process.Start(startInfo);

            }
            else
            {
                AtualizarStatus("Erro Ao Selecionar Pasta ou Arquivo!", 0);
            }
        }

        private void unificar(System.Windows.Forms.TextBox PathBox)
        {
            timer1.Start();
            string caminho = PathBox.Text;
            string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "MesclarPDF.py");
            AtualizarStatus("", 0);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
            startInfo.Arguments = $"\"{scriptpath}\" \"{caminho}\""; // Substitua pelo caminho do seu script Python
            startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            pythonProcess = Process.Start(startInfo);
        }


        private void pythonEscolha(string imprimir, string item, int escolha)
        {
            timer1.Start();
            string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "Excel_PDF_Timbrado.py");
            string par1 = BoxTimbrado.SelectedItem.ToString();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
            startInfo.Arguments = $"\"{scriptpath}\" \"{par1}\" \"{imprimir}\" \"{item}\" \"{escolha}\""; // Substitua pelo caminho do seu script Python
            startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            pythonProcess = Process.Start(startInfo);
        }
        private string verificar()
        {
            string verificar = "";
            if (radioArquivo.Checked == true)
            {
                verificar = "Arquivo";
                return verificar;

            }
            else if (radioPasta.Checked == true)
            {
                verificar = "Pasta";
                return verificar;

            }
            return verificar;
        }
        private string salvarPDF()
        {
            string json = File.ReadAllText(caminhoConfig);
            config = JsonConvert.DeserializeObject<Configuracao>(json);
            string caminho = "";
            if (checkBox5.Checked == true)
            {
                caminho = PathSalvar.Text;
                if (!Directory.Exists(caminho))
                {

                    caminho = config.Salvar.SalvarTimbrado;
                }
            }
            else
            {
                caminho = config.Salvar.SalvarTimbrado;
                if (!Directory.Exists(caminho))
                {
                    Directory.CreateDirectory(caminho);
                }
                return caminho;
            }
            return caminho;
        }


        private void genPDF_Click(object sender, EventArgs e)
        {
            try
            {

                string ver = verificar();
                if (ver != "" && BoxTimbrado.SelectedIndex.ToString() != null)
                {
                    AtualizarStatus($"Gerando PDF com Modelo {BoxTimbrado.SelectedItem.ToString()}", 0);
                    string imprimirpath = salvarPDF();
                    string Escolha = SelecionarArquivoOuPastaExcel();
                    if (Escolha != null)
                    {
                        AtualizarStatus("Inicianto script");

                        pythonEscolha(imprimirpath, Escolha, 1);
                    }
                    else
                    {
                        AtualizarStatus("Falha ao selecionar o arquivo(s)");
                        timer1.Stop();
                    }

                }
                else
                {
                    AtualizarStatus("Por Favor, Selecione um Modelo e um Arquivo ou Pasta para Gerar o PDF", 0);
                    timer1.Stop();
                }
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Erro {ex.Message}");
                timer1.Stop();
            }
        }
        private void btTimbrado_Click(object sender, EventArgs e)
        {
            try
            {

                string ver = verificar();
                if (ver != "" && BoxTimbrado.SelectedIndex.ToString() != null)
                {
                    AtualizarStatus($"Gerando PDF com Modelo {BoxTimbrado.SelectedItem.ToString()}", 0);
                    string imprimirpath = salvarPDF();
                    string Escolha = SelecionarArquivoOuPastaPDF();
                    if (Escolha != null)
                    {
                        AtualizarStatus("Inicianto script");

                        pythonEscolha(imprimirpath, Escolha, 2);
                    }
                    else
                    {
                        AtualizarStatus("Falha ao selecionar o arquivo(s)");
                        timer1.Stop();
                    }

                }
                else
                {
                    AtualizarStatus("Por Favor, Selecione um Modelo e um Arquivo ou Pasta para Gerar o PDF", 0);
                    timer1.Stop();
                }
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Erro {ex.Message}");
                timer1.Stop();
            }
        }

        private void btBranco_Click(object sender, EventArgs e)
        {
            try
            {

                string ver = verificar();
                if (ver != "" && BoxTimbrado.SelectedIndex.ToString() != null)
                {
                    AtualizarStatus($"Gerando PDF com Modelo {BoxTimbrado.SelectedItem.ToString()}", 0);
                    string imprimirpath = salvarPDF();
                    string Escolha = SelecionarArquivoOuPastaPDF();
                    if (Escolha != null)
                    {
                        AtualizarStatus("Inicianto script");

                        pythonEscolha(imprimirpath, Escolha, 3);
                    }
                    else
                    {
                        AtualizarStatus("Falha ao selecionar o arquivo(s)");
                        timer1.Stop();
                    }

                }
                else
                {
                    AtualizarStatus("Por Favor, Selecione um Modelo e um Arquivo ou Pasta para Gerar o PDF", 0);
                    timer1.Stop();
                }
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Erro {ex.Message}");
                timer1.Stop();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", "txtConvert.exe");

            if (File.Exists(appPath))
            {
                Process.Start(appPath); // Inicia sua aplicação
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string resultado = null;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Selecione uma pasta";


            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                resultado = folderBrowserDialog.SelectedPath; // Armazena o caminho da pasta
                textBox2.Text = resultado;
            }
            else
            {
                AtualizarStatus("Erro Ao Selecionar Pasta!");

            }
        }

        private void botUnificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {

                    unificar(textBox2);

                }

                else
                {
                    AtualizarStatus("Por Favor Inserir o Caminho e Tente Novamente!");

                }
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Erro {ex.Message}");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AtualizarStatus("Timer1_Tick foi chamado");
        }




        public void Form2() // Construtor padrão
        {
            InitializeComponent();
        }

        private void visualizarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 novoForm = new Form2();
                novoForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir Form2: {ex.Message}");
            }

        }
        private void caminhoPDFs_Click(object sender, EventArgs e)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out");
            AbrirGerenciadorArquivos(caminho);
        }
        private void gerarPDFHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste concluido");
        }
        private void mesclarHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste concluido");
        }
        private void excelTimHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste concluido");
        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FecharExcel();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancela o fechamento do formulário
            }
        }

        //Tools Aba




        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                boxPathOrg.Enabled = true;
            }
            else
            {
                boxPathOrg.Enabled = false;
            }

        }
        private void organizarPasta(System.Windows.Forms.TextBox boxPathOrg)
        {
            string caminho = null;
            if (radioButton2.Checked == true)
            {
                int caso = 5;
                caminho = boxPathOrg.Text;
                timer1.Start();
                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "main.py");
                AtualizarStatus("", 0);
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                startInfo.Arguments = $"\"{scriptpath}\" \"{caso}\" \"{caminho}\""; // Substitua pelo caminho do seu script Python
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;
                pythonProcess = Process.Start(startInfo);

            }

            else if (radioButton1.Checked == true)
            {
                int caso = 5;
                caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out");
                timer1.Start();
                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "main.py");
                AtualizarStatus("", 0);
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                startInfo.Arguments = $"\"{scriptpath}\" \"{caso}\" \"{caminho}\""; // Substitua pelo caminho do seu script Python
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;
                pythonProcess = Process.Start(startInfo);
            }


        }
        private void Bt_Organizar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                organizarPasta(boxPathOrg);
            }
            else
            {
                AtualizarStatus("Selecione um dos modos de operação");
            }
        }



        public void ExportarParaCSV(DataGridView dgv)
        {
            StringBuilder sb = new StringBuilder();

            // Adicionar cabeçalhos das colunas
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                sb.Append(dgv.Columns[i].HeaderText + ";");
            }
            sb.AppendLine();

            // Adicionar os dados das linhas
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    sb.Append(row.Cells[i].Value?.ToString() + ";");
                }
                sb.AppendLine();
            }

            File.WriteAllText("temp.csv", sb.ToString(), Encoding.UTF8);

            AtualizarStatus("Tratando Planilha", 21);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            AtualizarStatus("Exportando Planilha", 0);
            ExportarParaExcel(dataGridView1);
            AtualizarStatus("Gerando Templates", 48);
            AbrirMacros();
            AtualizarStatus("Abrindo Excel", 60);
            excelApp.Run("ImportarCSVparaTemp");
            AtualizarStatus("Templates Gerados", 100);
            System.Threading.Thread.Sleep(2000);
            AtualizarStatus("Templates Salvos na Pasta out/Siseng", 0);

        }



        private void butImpTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                string caminhoOriginal = Path.Combine(Directory.GetCurrentDirectory(), @"assets\Template", "TemplatePPQ.xlsx");
                string nomeArquivo = "Template.xlsx";
                string caminhoDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string caminhoNovo = System.IO.Path.Combine(caminhoDesktop, nomeArquivo);

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbookOriginal = excelApp.Workbooks.Open(caminhoOriginal);

                // Cria uma cópia em memória
                workbookOriginal.SaveCopyAs(caminhoNovo);

                // Fecha sem salvar alterações
                workbookOriginal.Close(false);
                excelApp.Quit();

                Excel.Application excelApp2 = new Excel.Application();
                excelApp2.Visible = true;

                // Abre o novo workbook
                Excel.Workbook workbookNovo2 = excelApp2.Workbooks.Open(caminhoNovo);
                excelApp2.WindowState = Excel.XlWindowState.xlNormal;

                // Libera recursos
                //Marshal.ReleaseComObject(workbookOriginal);
                //Marshal.ReleaseComObject(excelApp);



                AtualizarStatus("Template Exportado", 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int checarValor = 0;
        string nomeCapa;
        private void checarMetodo()
        {
            if (ClPropComercial.Checked == true && ClPropTecnica.Checked == true)
            {
                checarValor = 1;
                nomeCapa = "Técnica/Comercial";


                return;
            }
            else if (ClPropComercial.Checked == true ^ ClPropTecnica.Checked == true)
            {
                checarValor = 2;
                nomeCapa = "Técnica/Comercial";

                return;
            }
            else if (checkFornecedor.Checked == true)
            {
                checarValor = 3;
                nomeCapa = "Fornecedores";

                return;

            }
            else if (ClSubCat.Checked == true)
            {

                checarValor = 4;
                nomeCapa = "Sub-Categorias";

                return;
            }
        }
        private void CBPropComercial_CheckedChanged(object sender, EventArgs e)
        {
            if (ClPropComercial.Checked == true)
            {
                TBPropComercial.ReadOnly = false;
                ClSubCat.Checked = false;
                checkFornecedor.Checked = false;

            }
            else if (ClPropComercial.Checked == false)
            {
                TBPropComercial.ReadOnly = true;
                TBPropComercial.Text = "Proposta Comercial";
            }
        }

        private void CBPropTecnica_CheckedChanged(object sender, EventArgs e)
        {
            if (ClPropTecnica.Checked == true)
            {
                TBPropTecnica.ReadOnly = false;
                ClSubCat.Checked = false;
                checkFornecedor.Checked = false;

            }
            else if (ClPropTecnica.Checked == false)
            {
                TBPropTecnica.ReadOnly = true;
                TBPropTecnica.Text = "Proposta Técnica";
            }
        }
        private void checkFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFornecedor.Checked == true)
            {
                ClSubCat.Checked = false;
                ClPropTecnica.Checked = false;
                ClPropComercial.Checked = false;
                Capa_fornecedores.ReadOnly = false;
                Capa_fornecedores.Text = "Insira a RM Aqui";
            }
            else
            {
                Capa_fornecedores.ReadOnly = true;
                Capa_fornecedores.Text = "Fornecedores";
            }
        }

        private void ClSubCat_CheckedChanged(object sender, EventArgs e)
        {
            checkFornecedor.Checked = false;
            ClPropTecnica.Checked = false;
            ClPropComercial.Checked = false;
        }





        private void pycapas()
        {
            string area = TB_Area.Text;
            string descri = TB_Descri.Text;
            timer1.Start();
            string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "Capas.py");
            AtualizarStatus("", 0);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
            startInfo.Arguments = $"\"{scriptpath}\" \"{area}\" \"{descri}\" \"{checarValor}"; // Substitua pelo caminho do seu script Python
            startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            pythonProcess = Process.Start(startInfo);
        }


        private void BTCapa_Click(object sender, EventArgs e)
        {
            if (ClPropComercial.Checked == true || ClPropTecnica.Checked == true || checkFornecedor.Checked == true || ClSubCat.Checked == true)
            {
                var categorias = new Dictionary<string, List<string>>();

                void AdicionarSeCheckMarcado(System.Windows.Forms.CheckBox chk, System.Windows.Forms.TextBox txtCategoria, RichTextBox rtbItens)
                {
                    if (!chk.Checked) return;

                    string categoria = txtCategoria.Text.Trim();
                    if (string.IsNullOrWhiteSpace(categoria)) return;

                    string[] itensRaw = rtbItens.Text.Split(';');
                    var itens = new List<string>();
                    foreach (var item in itensRaw)
                    {
                        string limpo = item.Trim();
                        if (!string.IsNullOrEmpty(limpo))
                            itens.Add(limpo);
                    }

                    if (itens.Count > 0)
                        categorias[categoria] = itens;
                }

                // Verifica cada bloco
                AdicionarSeCheckMarcado(ClPropComercial, TBPropComercial, richTextBox1);
                AdicionarSeCheckMarcado(ClPropTecnica, TBPropTecnica, richTextBox2);
                AdicionarSeCheckMarcado(checkFornecedor, Capa_fornecedores, richTextBox3);
                AdicionarSeCheckMarcado(ClSubCat, TxSubCat, richTextBox4);

                if (categorias.Count == 0)
                {
                    MessageBox.Show("Nenhuma categoria foi selecionada para exportação.");
                    return;
                }

                // Exporta o JSON formatado
                string json = JsonConvert.SerializeObject(categorias, Formatting.Indented);
                File.WriteAllText("include/categorias.json", json);
                checarMetodo();
                pycapas();
                return;

            }
            else
            {
                AtualizarStatus("Por Favor, Selecione Pelo Menos Uma Opção Para Gerar a Capa");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                // Se o checkbox estiver marcado, habilita o TextBox
                PathSalvar.Enabled = true;
            }
            else if (checkBox5.Checked == false)
            {
                // Se o checkbox não estiver marcado, desabilita o TextBox
                PathSalvar.Enabled = false;
            }
        }



        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = PDF_Config;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Salvar_Config;
        }




        private void Sav_Excel_01_CheckedChanged(object sender, EventArgs e)
        {
            if (Sav_Excel_01.Checked == true)
            {
                Sav_Excel_1.Enabled = true;
            }
            else
            {
                Sav_Excel_1.Enabled = false;
            }
        }


        private void Sav_Excel_02_CheckedChanged(object sender, EventArgs e)
        {
            if (Sav_Excel_02.Checked == true)
            {
                Sav_Excel_2.Enabled = true;
            }
            else
            {
                Sav_Excel_2.Enabled = false;
            }
        }

        private void Sav_Excel_03_CheckedChanged(object sender, EventArgs e)
        {
            if (Sav_Excel_03.Checked == true)
            {
                Sav_Excel_3.Enabled = true;
            }
            else
            {
                Sav_Excel_3.Enabled = false;
            }
        }

        private void Sav_PDF_01_CheckedChanged(object sender, EventArgs e)
        {
            if (Sav_PDF_01.Checked == true)
            {
                Sav_PDF_1.Enabled = true;
            }
            else
            {
                Sav_PDF_1.Enabled = false;
            }
        }

        private void Sav_PDF_02_CheckedChanged(object sender, EventArgs e)
        {
            if (Sav_PDF_02.Checked == true)
            {
                Sav_PDF_2.Enabled = true;
            }
            else
            {
                Sav_PDF_2.Enabled = false;
            }
        }

        private void Sav_PPQ_01_CheckedChanged(object sender, EventArgs e)
        {
            if (Sav_PPQ_01.Checked == true)
            {
                Sav_PPQ_1.Enabled = true;
            }
            else
            {
                Sav_PPQ_1.Enabled = false;
            }
        }


        private void MostrarComFade(System.Windows.Forms.Control controle)
        {
            controle.Visible = true;
            controle.BringToFront();
            controle.BackColor = Color.Transparent;

            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 30;

            double opacity = 0;
            controle.ForeColor = Color.FromArgb(0, controle.ForeColor); // começa invisível

            fadeTimer.Tick += (s, e) =>
            {
                opacity += 0.1;
                if (opacity >= 1)
                {
                    fadeTimer.Stop();
                    fadeTimer.Dispose();
                }
                else
                {
                    int alpha = (int)(opacity * 255);
                    controle.ForeColor = Color.FromArgb(alpha, controle.ForeColor);
                }
            };

            fadeTimer.Start();
        }


        private void UC_Comparar()
        {
            var dcp = new Disciplinas(excelApp, workbook);
            dcp.Dock = DockStyle.Fill;

            dcp.ValorCombo1 = TA1_Box.SelectedItem?.ToString();
            dcp.ValorCombo2 = TA2_Box.SelectedItem?.ToString();
            dcp.ValorTextBox = area_box.Text;

            // Garante que o controle fique acima dos outros
            Fornecimento_tab.Controls.Add(dcp);
            dcp.BringToFront();

        }
        private void Bt_Fornecimento_Click(object sender, EventArgs e)
        {

            if (R_Arquivos.Checked == true)
            {
                AbrirMacros();
                ComboBoxTArea(TA1_Box, TA2_Box, area_box, BoxModelo, textInicio, textFim);
                AtualizarStatus($"Buscando Arquivos de Comparação CPU", 30);
                //tenta iniciar macro
                excelApp.Run("ComparativoCpuArea");
                AtualizarStatus($"Quase Lá", 91);
                System.Threading.Thread.Sleep(2000);
                AtualizarStatus($"Arquivos Prontos Para Serem Filtrados", 0);
                UC_Comparar();

            }
            else if (R_Unico.Checked == true)
            {
                AbrirMacros();
                ComboBoxTArea(TA1_Box, TA2_Box, area_box, BoxModelo, textInicio, textFim);
                AtualizarStatus($"Buscando Arquivo de Comparação CPU", 30);
                //tenta iniciar macro
                excelApp.Run("gerarUnico");
                AtualizarStatus($"Quase Lá", 91);
                System.Threading.Thread.Sleep(2000);
                AtualizarStatus($"Arquivos Prontos Para Serem Filtrados", 0);
                UC_Comparar();
            }
            else
            {
                MessageBox.Show("Selecione uma opção de busca de arquivo");
                AtualizarStatus("Erro ao buscar arquivos", 0);

            }

        }



        private void button9_Click(object sender, EventArgs e)
        {
            if (R_Arquivos.Checked == true)
            {
                AbrirMacros();
                ComboBoxTArea(TA1_Box, TA2_Box, area_box, BoxModelo, textInicio, textFim);
                AtualizarStatus($"Buscando Arquivos de Comparação PPQ", 30);
                //tenta iniciar macro
                excelApp.Run("Fisc_buscar");
                AtualizarStatus($"Quase Lá", 91);
                System.Threading.Thread.Sleep(2000);
                AtualizarStatus($"Comparativo Físico-Financeiro Gerado", 0);

                FecharExcel();
            }
            else if (R_Unico.Checked == true)

            {
                AbrirMacros();
                ComboBoxTArea(TA1_Box, TA2_Box, area_box, BoxModelo, textInicio, textFim);
                AtualizarStatus($"Em desenvolvimento", 0);

                FecharExcel();
            }
            else
            {
                MessageBox.Show("Selecione uma opção de busca de arquivo");
                AtualizarStatus("Erro ao buscar arquivos", 0);

            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxModelo.Text != "" && textInicio.Text != "" && textFim.Text != "" && boxAbaCSD.Text != "" && Box_Nomear.Text != "")
                {

                    AbrirMacros();
                    ComboBoxTArea(TA1_Box, TA2_Box, area_box, BoxModelo, textInicio, textFim);
                    AtualizarStatus($"Gerando Consolidado", 20);
                    excelApp.Run("ModelosEscolha");
                    AtualizarStatus($"Finalizando Consolidado", 90);
                    System.Threading.Thread.Sleep(1500);
                    AtualizarStatus($"Consolidado Gerado", 100);
                    System.Threading.Thread.Sleep(1500);
                    AtualizarStatus($"Arquivos Salvos na Pasta {"./out"} Lembre de Conferir Quais Arquivos Foram adicionados à pasta", 0);
                    System.Threading.Thread.Sleep(6000);
                    AtualizarStatus($"Pronto", 0);
                    FecharExcel();
                }
                else
                {
                    AtualizarStatus("Por favor preencha todos os campos!", 0);
                }
            }

            catch
            {
                AtualizarStatus($"Error", 0);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AtualizarStatus("Exportando Planilha", 0);
            ExportarParaExcel(dataGridView1);
            AtualizarStatus("Gerando Templates", 48);
            AbrirMacros();
            AtualizarStatus("Abrindo Excel", 60);
            excelApp.Run("ImportarCSVparaTemp");
            AtualizarStatus("Templates Gerados", 100);
            System.Threading.Thread.Sleep(2000);
            AtualizarStatus("Templates Salvos na Pasta out/Siseng", 0);
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox3.Text != null)
            {
                string rm = textBox3.Text.ToString();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells["Tag"].Value != null)
                    {
                        dataGridView1.Rows[i].Cells["RM"].Value = rm;
                    }
                }
            }
        }

        private void textBoxEntrega_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxEntrega.Text != null)
            {
                string entrega = textBoxEntrega.Text.ToString() + "ª";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells["Tag"].Value != null)
                    {
                        dataGridView1.Rows[i].Cells["Entrega"].Value = entrega;
                    }
                }
                valorIndice();

            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string areaSelecionada = comboBox2.SelectedItem.ToString();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells["Tag"].Value != null)
                    {
                        dataGridView1.Rows[i].Cells["Área"].Value = areaSelecionada;
                    }
                }
                valorIndice();
            }
        }

        private void BoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoxModelo.Text == "PADRÃO")
            {
                textInicio.Enabled = true;
                textFim.Enabled = true;
                boxAbaCSD.Enabled = true;
                Box_Nomear.Enabled = true;
            }
            else
            {
                Box_Nomear.Enabled = false;
                textInicio.Enabled = false;
                textFim.Enabled = false;
                boxAbaCSD.Enabled = false;
                textInicio.Text = "1";
                textFim.Text = "1";

            }
        }

        // Navegação PCP Aba

        private void resetColorsPCP()
        {
            Aba_PDF.BackColor = Color.FromArgb(62, 131, 140);
            Aba_PDF.ForeColor = Color.White;
            Aba_Excel.BackColor = Color.FromArgb(62, 131, 140);
            Aba_Excel.ForeColor = Color.White;
            Aba_Ferramentas.BackColor = Color.FromArgb(62, 131, 140);
            Aba_Ferramentas.ForeColor = Color.White;
            Aba_Config.BackColor = Color.FromArgb(62, 131, 140);
            Aba_Config.ForeColor = Color.White;
        }

        private void selecionarAba()
        {
            if (PCP_01.Checked == true)
            {
                resetColorsPCP();
                Aba_PDF.BackColor = Color.FromArgb(236, 225, 195);
                Aba_PDF.ForeColor = Color.Black;

            }
            else if (PCP_02.Checked == true)
            {
                resetColorsPCP();
                Aba_Excel.BackColor = Color.FromArgb(236, 225, 195);
                Aba_Excel.ForeColor = Color.Black;
            }
            else if (PCP_03.Checked == true)
            {
                resetColorsPCP();
                Aba_Ferramentas.BackColor = Color.FromArgb(236, 225, 195);
                Aba_Ferramentas.ForeColor = Color.Black;
            }
            else if (PCP_04.Checked == true)
            {
                resetColorsPCP();
                Aba_Config.BackColor = Color.FromArgb(236, 225, 195);
                Aba_Config.ForeColor = Color.Black;
            }

        }

        private void Aba_PDF_Click(object sender, EventArgs e)
        {
            PCP_01.Checked = true;
            Container_01.SelectedTab = PDF_Pag;
        }

        private void Aba_Excel_Click(object sender, EventArgs e)
        {
            PCP_02.Checked = true;
            Container_01.SelectedTab = Excel_Pag;
        }

        private void Aba_Ferramentas_Click(object sender, EventArgs e)
        {
            PCP_03.Checked = true;
            Container_01.SelectedTab = Ferr_pag;
        }


        private void Aba_Config_Click(object sender, EventArgs e)
        {
            PCP_04.Checked = true;
            Container_01.SelectedTab = Config_pag;
        }

        private void PCP_01_CheckedChanged(object sender, EventArgs e)
        {
            if (PCP_01.Checked == true)
            {
                PCP_02.Checked = false;
                PCP_03.Checked = false;
                PCP_04.Checked = false;
                selecionarAba();
            }
        }

        private void PCP_02_CheckedChanged(object sender, EventArgs e)
        {
            if (PCP_02.Checked == true)
            {
                PCP_01.Checked = false;
                PCP_03.Checked = false;
                PCP_04.Checked = false;
                selecionarAba();
            }
        }

        private void PCP_03_CheckedChanged(object sender, EventArgs e)
        {
            if (PCP_03.Checked == true)
            {
                PCP_02.Checked = false;
                PCP_01.Checked = false;
                PCP_04.Checked = false;
                selecionarAba();
            }
        }

        private void PCP_04_CheckedChanged(object sender, EventArgs e)
        {
            if (PCP_04.Checked == true)
            {
                PCP_02.Checked = false;
                PCP_03.Checked = false;
                PCP_01.Checked = false;
                selecionarAba();
            }
        }

        // Navegação Abas Excel

        private void resetColorsExcel()
        {
            button2.BackColor = Color.FromArgb(62, 131, 140);
            button2.ForeColor = Color.White;
            button4.BackColor = Color.FromArgb(62, 131, 140);
            button4.ForeColor = Color.White;
            button5.BackColor = Color.FromArgb(62, 131, 140);
            button5.ForeColor = Color.White;
            button9.BackColor = Color.FromArgb(62, 131, 140);
            button9.ForeColor = Color.White;
        }

        private void selecionarExcel()
        {
            if (Comparativos_aba.Checked == true)
            {
                resetColorsExcel();
                button2.BackColor = Color.FromArgb(236, 225, 195);
                button2.ForeColor = Color.Black;

            }
            else if (Consolidar_Aba.Checked == true)
            {
                resetColorsExcel();
                button4.BackColor = Color.FromArgb(236, 225, 195);
                button4.ForeColor = Color.Black;
            }
            else if (Servi_Aba.Checked == true)
            {
                resetColorsExcel();
                button5.BackColor = Color.FromArgb(236, 225, 195);
                button5.ForeColor = Color.Black;
            }
            else if (Mont_Aba.Checked == true)
            {
                resetColorsExcel();
                button9.BackColor = Color.FromArgb(236, 225, 195);
                button9.ForeColor = Color.Black;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Comparativos_aba.Checked = true;
            Container2.SelectedTab = Fornecimento_tab;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consolidar_Aba.Checked = true;
            Container2.SelectedTab = Consolidar_Tab;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Servi_Aba.Checked = true;
            Container2.SelectedTab = Servi_Tab;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Mont_Aba.Checked = true;
            Container2.SelectedTab = Criar_PPQ_Bt;
        }

        private void Comparativos_aba_CheckedChanged(object sender, EventArgs e)
        {
            if (Comparativos_aba.Checked == true)
            {
                Consolidar_Aba.Checked = false;
                Servi_Aba.Checked = false;
                Mont_Aba.Checked = false;
                selecionarExcel();
            }
        }

        private void Consolidar_Aba_CheckedChanged(object sender, EventArgs e)
        {
            if (Consolidar_Aba.Checked == true)
            {
                Comparativos_aba.Checked = false;
                Servi_Aba.Checked = false;
                Mont_Aba.Checked = false;
                selecionarExcel();
            }
        }

        private void Servi_Aba_CheckedChanged(object sender, EventArgs e)
        {
            if (Servi_Aba.Checked == true)
            {
                Consolidar_Aba.Checked = false;
                Comparativos_aba.Checked = false;
                Mont_Aba.Checked = false;
                selecionarExcel();
            }
        }

        private void Mont_Aba_CheckedChanged(object sender, EventArgs e)
        {
            if (Mont_Aba.Checked == true)
            {
                Consolidar_Aba.Checked = false;
                Servi_Aba.Checked = false;
                Comparativos_aba.Checked = false;
                selecionarExcel();
            }
        }

        private void Abrir_out_01_Click(object sender, EventArgs e)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out");
            AbrirGerenciadorArquivos(caminho);
        }

        private void PDF_QP_bt_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 novoForm = new Form2();
                novoForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir Form2: {ex.Message}");
            }
        }

        private void Conversor_N_Click(object sender, EventArgs e)
        {
            string appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", "txtConvert.exe");

            if (File.Exists(appPath))
            {
                Process.Start(appPath); // Inicia sua aplicação
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Unificar_Bt_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {

                    unificar(textBox2);

                }

                else
                {
                    AtualizarStatus("Por Favor Inserir o Caminho e Tente Novamente!");

                }
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Erro {ex.Message}");
            }
        }
    }
    //public class TabControlSemGuias : System.Windows.Forms.TabControl
    //{
    //    public TabControlSemGuias()
    //    {
    //        this.Appearance = TabAppearance.FlatButtons;
    //        this.ItemSize = new Size(0, 1);
    //        this.SizeMode = TabSizeMode.Fixed;
    //    }

    //    protected override void WndProc(ref Message m)
    //    {
    //        // Remove bordas
    //        if (m.Msg == 0x1328) // TCM_ADJUSTRECT
    //        {
    //            if (!this.Multiline)
    //            {
    //                m.Result = (IntPtr)1;
    //                return;
    //            }
    //        }
    //        base.WndProc(ref m);
    //    }

    //}

    public class Layout
    {
        public string fundo { get; set; }
        public string repetido { get; set; }
        public List<int> tamanho { get; set; }  // O JSON usará uma lista, já que tuplas não existem no JSON
        public int topMarg { get; set; }
        public int botMarg { get; set; }
        public int leftMarg { get; set; }
        public int rightMarg { get; set; }
        public int papel { get; set; }
        public int orientacao { get; set; }
    }

   

}
   

