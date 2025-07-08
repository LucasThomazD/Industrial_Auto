using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ClosedXML.Excel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Diagnostics;
using System.Drawing.Text;
using System.Threading;
using PdfiumViewer;
using System.Diagnostics.Eventing.Reader;



namespace windowsFormOI
{



    public partial class Form1 : Form
    {
        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        private string caminhoImprimir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "imprimir");
        private Dictionary<string, Layout> layouts;
        private string ultimoStatus = "";
        private string caminhoArquivo = "include/log.txt"; // Caminho do arquiv
        private PdfViewer pdfViewer = new PdfViewer();
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Evita flickering (tremulação)
            LoadLayouts();
            LayoutComboBox();
            checkTimbrado.Enabled = false;
            checkBranco.Enabled = false;
            comboBranco.Enabled = false;
            comboTim.Enabled = false;
            PanelConsolidar.Enabled = false;
            PanelFiltrar.Enabled = false;
            PanelBuscar.Enabled = false;
            checkBox2.Visible = false;
            checkBox4.Visible = false;
            checkBox3.Visible = false;
            checkFiltrar.Visible = false;
            panel1.Enabled = false;
            panel9.Enabled = false;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;


            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            dataGridView1.KeyDown += dataGridView1_KeyDown;
            boxModeloPDF.SelectedIndexChanged += boxModeloPDF_SelectedIndexChanged;
            checkTimbrado.CheckedChanged += checkTimbrado_CheckedChanged;
            checkBranco.CheckedChanged += checkBranco_CheckedChanged;
  
            //SetRoundedBorder(15, button1, button2, button3, button4, botUnificar, bArquivo, bAplicarInfo, bUnico, bElet, bCBINC, bMentos, bInst, bTub, bSupTub, bMulti, bConsolidado);
            SetRoundedBorder(10, PanelFiltrar, BtFis, panel4, panel6, panel7, panel8, PanelBuscar, PanelConsolidar,panel1,panel2);
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
                AtualizarStatus($"Erro ao calcular o índice: {ex.Message}",0);
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
        private void SetRoundedBorder(int radius, params Control[] controls)
        {
            foreach (Control control in controls)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount =12; // Define 8 colunas
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
            
            




            BoxTA1.Items.Add("Selecione");
            BoxTA1.Items.Add("TA 24");
            BoxTA1.Items.Add("TA 25");
            BoxTA1.Items.Add("TA 26");
            BoxTA1.Items.Add("TA 27");
            BoxTA1.Items.Add("TA 28");
            BoxTA1.Items.Add("TA 29");
            BoxTA1.Items.Add("TA 30");
            BoxTA1.Items.Add("TA 31");
            BoxTA1.Items.Add("TA 32");
            BoxTA1.Items.Add("TA 33");
            BoxTA1.Items.Add("TA 34");
            BoxTA1.Items.Add("TA 35");
            BoxTA1.Items.Add("TA 36");
            BoxTA1.Items.Add("TA 37");
            BoxTA1.Items.Add("TA 38");
            BoxTA1.Items.Add("TA 39");
            BoxTA1.Items.Add("TA 40");
            BoxTA1.SelectedIndex = 0;

            BoxTA2.Items.Add("Selecione");
            BoxTA2.Items.Add("TA 24");
            BoxTA2.Items.Add("TA 25");
            BoxTA2.Items.Add("TA 26");
            BoxTA2.Items.Add("TA 27");
            BoxTA2.Items.Add("TA 28");
            BoxTA2.Items.Add("TA 29");
            BoxTA2.Items.Add("TA 30");
            BoxTA2.Items.Add("TA 31");
            BoxTA2.Items.Add("TA 32");
            BoxTA2.Items.Add("TA 33");
            BoxTA2.Items.Add("TA 34");
            BoxTA2.Items.Add("TA 35");
            BoxTA2.Items.Add("TA 36");
            BoxTA2.Items.Add("TA 37");
            BoxTA2.Items.Add("TA 38");
            BoxTA2.Items.Add("TA 39");
            BoxTA2.Items.Add("TA 40");
            BoxTA2.SelectedIndex = 0;

            BoxArea.Items.Add("Selecione");
            BoxArea.Items.Add("1000");
            BoxArea.Items.Add("2000");
            BoxArea.Items.Add("2502");
            BoxArea.Items.Add("2511");
            BoxArea.Items.Add("2706");
            BoxArea.Items.Add("2721");
            BoxArea.Items.Add("2722");
            BoxArea.Items.Add("2737");
            BoxArea.Items.Add("2744");
            BoxArea.Items.Add("3000");
            BoxArea.Items.Add("4000");
            BoxArea.Items.Add("5000");
            BoxArea.Items.Add("6000");
            BoxArea.Items.Add("7000");
            BoxArea.Items.Add("7816");
            BoxArea.Items.Add("7818");
            BoxArea.Items.Add("8000");
            BoxArea.SelectedIndex = 0;

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

            comboBranco.Items.Add("A3 Paisagem");
            comboBranco.Items.Add("A4 Retrato");
            comboBranco.Items.Add("A4 Paisagem");


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


            boxModeloPDF.Items.Add("Personalizar");
            boxModeloPDF.SelectedIndex = 0;

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
            this.toolTip1.SetToolTip(bAplicarInfo, "Iniciar o arquivo Excel e atualiza as informações de cabeçalho ");
            this.toolTip1.SetToolTip(bDerrubar, "Fecha o Excel");
            this.toolTip1.SetToolTip(BtArquivoUnico, "Busca Apenas um arquivo, quando não há o mesmo no TA anterior");
            this.toolTip1.SetToolTip(PB_buscar_1, "Inicia o diálogo de diretorio permitindo a busca manual do caminho com os arquivos");
            this.toolTip1.SetToolTip(PathBox, "Cole aqui o caminho da pasta com os arquivos a serem unificados");
            this.toolTip1.SetToolTip(button2, "Gera arquivos PDF a partir de uma planilha excel, usando as margens continadas nos modelos");
            this.toolTip1.SetToolTip(button4, "Aplica mesclagens no PDF, adicionando timbrado e página em branco");
            this.toolTip1.SetToolTip(button1, "Inicia um PopUp Contendo a ferramenta de Conversão de números");
            this.toolTip1.SetToolTip(labelCabeçalho1, "Indica em que Linha Começar a Copiar no Primeiro Arquivo");
        }
        public  void filtrarDisciplinas(string disciplina, string texto)
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
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Checked = false; // Desmarca a outra CheckBox
                checkBox2.Checked = false;

            }
            PanelConsolidar.Enabled = checkBox4.Checked;
            PanelBuscar.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) 
            {
                checkBox4.Checked = false; // Desmarca a outra CheckBox
                checkBox2.Checked = false;
            }
            PanelBuscar.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox3.Checked = false; // Desmarca a outra CheckBox
                checkBox4.Checked = false;
            }
           
            PanelFiltrar.Enabled = checkBox2.Checked;
            PanelBuscar.Enabled = true;
        }
        private void LayoutComboBox()
        {
            // Suponha que você tenha uma ComboBox chamada comboBoxLayouts no formulário
            boxModeloPDF.Items.Clear();
            comboTim.Items.Clear();

            if (layouts != null)
            {
                foreach (string key in layouts.Keys)
                {
                    boxModeloPDF.Items.Add(key);
                    comboTim.Items.Add(key);
                }
            }
        }
        private void boxModeloPDF_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se a opção "Personalizar" está selecionada
            if (boxModeloPDF.SelectedItem != null && boxModeloPDF.SelectedItem.ToString() == "Personalizar")
            {
                // Habilita os CheckedListBox
                checkTimbrado.Enabled = true;
                checkBranco.Enabled = true;
            }
            else
            {
                // Desabilita os CheckedListBox
                checkTimbrado.Enabled = false;
                checkBranco.Enabled = false;

                // Opcional: Limpa as seleções
                checkTimbrado.Checked = false;
                checkBranco.Checked = false;
            }
        }

        private void checkTimbrado_CheckedChanged(object sender, EventArgs e)
        {
            // Habilita ou desabilita a ComboBox com base no estado do CheckBox
            if (checkTimbrado.Checked)
            {
                checkBranco.Checked = false; // Desmarca a outra CheckBox

            }

            // Habilita ou desabilita a ComboBox com base no estado do CheckBox
            comboTim.Enabled = checkTimbrado.Checked;
        }

        private void checkBranco_CheckedChanged(object sender, EventArgs e)
        {
            // Habilita ou desabilita a ComboBox com base no estado do CheckBox
            if (checkBranco.Checked)
            {
                checkTimbrado.Checked = false; // Desmarca a outra CheckBox
            }

            // Habilita ou desabilita a ComboBox com base no estado do CheckBox
            comboBranco.Enabled = checkBranco.Checked;
        }



        private void AtualizarStatus(string mensagem, int progresso = -1)
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


                    // Define os valores em células específicas
                    worksheet.Cells[1, 1] = BoxTA1.SelectedItem.ToString(); // Célula A1
                    worksheet.Cells[1, 2] = BoxTA2.SelectedItem.ToString(); // Célula B1
                    worksheet.Cells[1, 3] = BoxArea.SelectedItem.ToString(); // Célula C1
                    worksheet.Cells[2, 2] = textInicio.Text.ToString(); // Célula B2
                    worksheet.Cells[2, 3] = textFim.Text.ToString(); // Célula C2
                    worksheet.Cells[2, 1] = BoxModelo.SelectedItem.ToString(); // Célula A2
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
                    AtualizarStatus($"Abrindo Aquivo Excel Fornecedor", 25);
                    excelApp = new Excel.Application();
                    string caminhoMacro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "macros.xlsm");

                    // Abre o arquivo Excel
                    workbook = excelApp.Workbooks.Open(caminhoMacro);
                    AtualizarStatus($"Arquivo Pronto", 50);
                    bAplicarInfo.Text = "ATUALIZAR";
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


                AtualizarStatus("Excel fechado com sucesso!",0);
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

        private void BtFornecimento_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void BtFisico_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }

        private void BtGerarConsolidado_Click(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
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
        private void bArquivo_Click(object sender, EventArgs e)
        {

            try
            {
                if (bAplicarInfo.Text == "ATUALIZAR")
                {
                    if (checkBox2.Checked == true)
                    {
                        if (BtArquivos.Checked == true)
                        {
                            AtualizarStatus($"Buscando Arquivos de Comparação CPU", 30);
                            //tenta iniciar macro
                            excelApp.Run("ComparativoCpuArea");
                            AtualizarStatus($"Quase Lá", 91);
                            System.Threading.Thread.Sleep(2000);
                            AtualizarStatus($"Arquivos Prontos Para Serem Filtrados", 0);
                            checkFiltrar.Checked = true;
                        }
                        else if (BtArquivoUnico.Checked == true)
                        {
                            AtualizarStatus($"Buscando Arquivo de Comparação CPU", 30);
                            //tenta iniciar macro
                            excelApp.Run("gerarUnico");
                            AtualizarStatus($"Quase Lá", 91);
                            System.Threading.Thread.Sleep(2000);
                            AtualizarStatus($"Arquivos Prontos Para Serem Filtrados", 0);
                            checkFiltrar.Checked = true;
                        }
                        else
                        {
                            MessageBox.Show("Selecione uma opção de busca de arquivo");
                            AtualizarStatus("Erro ao buscar arquivos", 0);
                            checkFiltrar.Checked = false;
                        }
                        
                    }
                    else if(checkBox3.Checked == true)
                    {
                        if (BtArquivos.Checked == true)
                        {
                            AtualizarStatus($"Buscando Arquivos de Comparação PPQ", 30);
                            //tenta iniciar macro
                            excelApp.Run("Fisc_buscar");
                            AtualizarStatus($"Quase Lá", 91);
                            System.Threading.Thread.Sleep(2000);
                            AtualizarStatus($"Comparativo Físico-Financeiro Gerado", 0);
                            checkFiltrar.Checked = true;
                        }
                        else if(BtArquivoUnico.Checked == true)

                        {
                            AtualizarStatus($"Em desenvolvimento", 0);
                            checkFiltrar.Checked = false;

                        }
                        else
                        {
                            MessageBox.Show("Selecione uma opção de busca de arquivo");
                            AtualizarStatus("Erro ao buscar arquivos", 0);
                            checkFiltrar.Checked = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor, Instancie as Informações Antes de Buscar os Arquivos");
                    checkFiltrar.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex}");
                checkFiltrar.Checked = false;
            }
        }



        private void bAplicarInfo_Click(object sender, EventArgs e)
        {
            AbrirMacros();
            ComboBoxTArea(BoxTA1, BoxTA2, BoxArea, BoxModelo, textInicio, textFim);

        }

      
        private void bElet_Click(object sender, EventArgs e)
        {
            try 
            {
                if (checkFiltrar.Checked == true)
                {
                    filtrarDisciplinas("eletrica", "Elétrica");

                }
                else
                {
                    AtualizarStatus("Por Favor, Selecione Buscar para encontrar os itens arquivos comparaveis");
                }
            }
            catch (Exception ex) 
            {
                AtualizarStatus($"Error{ex}");
            }

        }

        private void bCBINC_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkFiltrar.Checked == true)
                {
                    filtrarDisciplinas("CBINC", "Combate à Incêndio");
                }
            else
            {
                AtualizarStatus("Por Favor, Selecione Buscar para encontrar os itens arquivos comparaveis");
            }
        }
            catch (Exception ex) 
            {
                AtualizarStatus($"Error{ex}");
    }

}

        private void bMentos_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkFiltrar.Checked == true)
                {
                    filtrarDisciplinas("instrumentos", "Intrumentos");
                }
            
            else
            {
                AtualizarStatus("Por Favor, Selecione Buscar para encontrar os itens arquivos comparaveis");
            }
        }
            catch (Exception ex) 
            {
                AtualizarStatus($"Error{ex}");
    }

}

        private void bInst_Click(object sender, EventArgs e)
        {
            try { 
                if (checkFiltrar.Checked == true)
                {
                    filtrarDisciplinas("instrumentacao", "Intrumentação");
                }
                else
                {
                    AtualizarStatus("Por Favor, Selecione Buscar para encontrar os itens arquivos comparaveis");
                }
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Error{ex}");
            }
        }

        private void bTub_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkFiltrar.Checked == true)
                {
                    filtrarDisciplinas("tubulacao", "Tubulação");
                }
                else
                {
                    AtualizarStatus("Por Favor, Selecione Buscar para encontrar os itens arquivos comparaveis");
                }
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Error{ex}");
            }
        }

        private void bSupTub_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkFiltrar.Checked == true)
                {
                    filtrarDisciplinas("supTub", "Suporte de Tubulação");
                }
                else
                {
                    AtualizarStatus("Por Favor, Selecione Buscar para encontrar os itens arquivos comparaveis");
                }
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Error{ex}");
            }
        }

        private void bMulti_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkFiltrar.Checked == true)
                {
                    filtrarDisciplinas("processarDisciplinas", "Todas as Disciplinas da Industrial");
                }
                else
                {
                    AtualizarStatus("Por Favor, Selecione Buscar para encontrar os itens arquivos comparaveis");
                }
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Error{ex}");
            }

        }


        private void bDerrubar_Click(object sender, EventArgs e)
        {
            FecharExcel();
            bAplicarInfo.Text = "INSTANCIAR";
            checkFiltrar.Checked = false;
        }



        private void bConsolidado_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarStatus($"Gerando Consolidado", 20);
                excelApp.Run("ModelosEscolha");
                AtualizarStatus($"Finalizando Consolidado", 90);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Consolidado Gerado", 100);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Arquivos Salvos na Pasta {"./out"} Lembre de Conferir Quais Arquivos Foram adicionados à pasta", 0);
                System.Threading.Thread.Sleep(6000);
                AtualizarStatus($"Pronto", 0);

            }

            catch
            {
                MessageBox.Show("Abra o Excel e Atualize as Informações: ");
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
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Selecione uma pasta";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    resultado = folderBrowserDialog.SelectedPath; // Armazena o caminho da pasta
                }
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
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Selecione uma pasta";


                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    resultado = folderBrowserDialog.SelectedPath; // Armazena o caminho da pasta
                }
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
        private void iniciarPython(System.Windows.Forms.ComboBox boxModeloPDF)

        {
            timer1.Start();
            string selecionado = SelecionarArquivoOuPastaPDF();

            if (selecionado != null)
            {
                string par1 = boxModeloPDF.SelectedItem.ToString();
                string imprimirpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Imprimir");

                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "InserirModelo.py");


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


        private void pythonPerso(System.Windows.Forms.ComboBox comboTim, System.Windows.Forms.ComboBox comboBranco)
        {
            timer1.Start();
            string selecionado = SelecionarArquivoOuPastaPDF();

            if (selecionado != null)
            {


                string imprimirpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Imprimir");
                string scriptpath1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "timbrado.py");
                string scriptpath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "PaginaRepetida.py");

                if (checkTimbrado.Checked == true && comboTim.SelectedItem.ToString() != null) {
                    string par1 = comboTim.SelectedItem.ToString();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                    startInfo.Arguments = $"\"{scriptpath1}\" \"{par1}\" \"{imprimirpath}\" \"{selecionado}\""; // Substitua pelo caminho do seu script Python
                    startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.CreateNoWindow = true;
                    pythonProcess = Process.Start(startInfo);

                }
                else if (checkBranco.Checked == true && comboBranco.Text != null)
                {
                    string par2 = comboBranco.SelectedItem.ToString();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                    startInfo.Arguments = $"\"{scriptpath2}\" \"{par2}\" \"{imprimirpath}\" \"{selecionado}\""; // Substitua pelo caminho do seu script Python
                    startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.CreateNoWindow = true;
                    pythonProcess = Process.Start(startInfo);
                }

                else
                {
                    AtualizarStatus("Lembre-se de Escolher um Item Na ComboBox", 0);
                    timer1.Stop();
                }


            }
            else
            {
                AtualizarStatus("Erro Ao Selecionar Pasta ou Arquivo!", 0);

                timer1.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AtualizarStatus("Nada Atribuido a Este Botão Ainda!");
        }

        private void button4_Click(object sender, EventArgs e)
        {


            try
            {

                if (radioArquivo.Checked || radioPasta.Checked)
                {
                    if (boxModeloPDF.SelectedItem.ToString() == perso) {

                        pythonPerso(comboTim, comboBranco);
                    }
                    else if (boxModeloPDF.SelectedItem.ToString() != perso)
                    {

                        iniciarPython(boxModeloPDF);


                    }
                }
                else
                {
                    AtualizarStatus("Lembre-se de selecionar umas das opções: Pasta ou Arquivo");

                }
            }


            catch
            {

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (radioArquivo.Checked || radioPasta.Checked)
                {
                    if (boxModeloPDF.SelectedItem.ToString() != perso)
                    {
                        AtualizarStatus("Iniciando Processo");
                        iniciarPythonExcel(boxModeloPDF);
                    }


                    else
                    {
                        AtualizarStatus("Modelo Incompativel Com Essa Tarefa");
                    }
                }
                else
                {
                    AtualizarStatus("Lembre-se de selecionar umas das opções: Pasta ou Arquivo");

                }
            }


            catch
            {

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
                PathBox.Text = resultado;
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

                if (!string.IsNullOrWhiteSpace(PathBox.Text))
                {

                    unificar(PathBox);

                }

                else
                {
                    AtualizarStatus("Por Favor Inserir o Caminho e Tente Novamente!");

                }
            }
            catch (Exception ex) {
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
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "imprimir");
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

        private void tabPage4_Click(object sender, EventArgs e)
        {

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

            else if(radioButton1.Checked == true)
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

            AtualizarStatus("Tratando Planilha",21);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void textBoxEntrega_TextChanged(object sender, EventArgs e)
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

        private void butImpTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirMacros();
                System.Threading.Thread.Sleep(5000);
                excelApp.Run("exportarTemp");
                excelApp.Visible = true;
                var wbOriginal = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "macros.xlsm");
                excelApp.ScreenUpdating = true;
                excelApp.WindowState = XlWindowState.xlMaximized;
                excelApp.ActiveWindow.WindowState = XlWindowState.xlNormal;
                excelApp.ActiveWindow.WindowState = XlWindowState.xlMaximized;
               
             



                AtualizarStatus("Template Exportado",0);
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
        private void checarMetodo()
        {
            if (ClPropComercial.Checked == true && ClPropTecnica.Checked == true)
            {
                checarValor = 1;
           
                return;
            }
            else if (ClPropComercial.Checked == false && ClPropTecnica.Checked == true && CBOnlySub.Checked == false || ClPropComercial.Checked == true && ClPropTecnica.Checked == false && CBOnlySub.Checked == false)
            {
                checarValor = 2;
      
                return;
            }
            else if (ClPropComercial.Checked == true && CBOnlySub.Checked == true)
            {
                checarValor = 3;

                return;
               
            }
        }
        private void CBPropComercial_CheckedChanged(object sender, EventArgs e)
        {
            if (ClPropComercial.Checked == true)
            {
                TBPropComercial.ReadOnly = false;

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

            }
            else if (ClPropTecnica.Checked == false)
            {
                TBPropTecnica.ReadOnly = true;
                TBPropTecnica.Text = "Proposta Técnica";
            }
        }

        private void CBOnlySub_CheckedChanged(object sender, EventArgs e)
        {
            if( CBOnlySub.Checked == true)
            {
                richTextBox2.Enabled = false;
            }
            else if (CBOnlySub.Checked == false)
            {
                richTextBox2.Enabled = true;
            }
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
            if (ClPropComercial.Checked == true || ClPropTecnica.Checked == true )
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
                AtualizarStatus("Capas Geradas Com Sucesso",0); return;
            }
            else { 
                AtualizarStatus("Por Favor, Selecione Pelo Menos Uma Opção Para Gerar a Capa");
            }
        }
    }
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
   

