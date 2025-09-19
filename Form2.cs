using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


namespace windowsFormOI
{
    public partial class Form2 : Form
    {
        private string resultado;

        private string caminhoArquivo = "include/log.txt"; // Caminho do arquivo
        private string ultimoStatus = "";
        private PdfViewer pdfViewer;
        private System.Windows.Forms.TextBox txtPaginaAtual;
        string caminhoSalvar;
        string nomeSalvar;
        string temporarioSav;
        bool statusSave = true;
        bool existencia = false;

        private bool ordem;
        Process pythonProcess2;
        public Form2()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            
            //todasBox.CheckedChanged += todasBox_CheckedChanged;
            //HorBox.CheckedChanged += HorBox_CheckedChanged;
            //AntiBox.CheckedChanged += AntiBox_CheckedChanged;
            //c90Box.CheckedChanged += c90Box_CheckedChanged;
            //c180Box.CheckedChanged += c180Box_CheckedChanged;
            //c270Box.CheckedChanged += c270Box_CheckedChanged;

            inicializarPdfViewer();


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Form carregado!");
            
        }

        
        private void inicializarPdfViewer()
        {
            pdfViewer = new PdfViewer
            {
                Dock = DockStyle.Fill,
                

            };
            PN_PDF.Controls.Add(pdfViewer);
           // pdfViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;


            // Evento para atualizar página atual
            // pdfViewer.Renderer.Scroll += Renderer_Scroll;
        }

        private void AtualizarPaginaAtual()
        {
            if (pdfViewer.Document != null)
            {
                int paginaAtual = pdfViewer.Renderer.Page + 1; // índice começa em 0
                txtPaginaAtual.Text = paginaAtual.ToString();
            }
        }

        private void Renderer_Scroll(object sender, ScrollEventArgs e)
        {
            AtualizarPaginaAtual();
        }

        private void BtnAbri_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de texto (*.pdf)|*.pdf"; // Filtro de arquivos
            openFileDialog.Title = "Selecione um arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                resultado = openFileDialog.FileName; // Armazena o caminho do arquivo
                string nomeOriginal = Path.GetFileName(resultado);
               
                caminhoSalvar = resultado;
                nomeSalvar = nomeOriginal;

                // Caminho da pasta ./src (relativo ao executável)
                string pastaSrc = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "src");

                // Cria a pasta se não existir
                if (!Directory.Exists(pastaSrc))
                    Directory.CreateDirectory(pastaSrc);

                // Nome temporário único
                string nomeTemporario = Guid.NewGuid().ToString() + ".pdf";

                // Caminho final do arquivo temporário
                string caminhoTemporario = Path.Combine(pastaSrc, nomeTemporario);

                // Copia o arquivo para a pasta ./src
                File.Copy(resultado, caminhoTemporario, true);
                temporarioSav = caminhoTemporario;


                // Carrega o PDF
                var doc = PdfDocument.Load(caminhoTemporario);
                pdfViewer.Document = doc;

                // Atualiza total de páginas
                //lblTotalPaginas.Text = $"/ {doc.PageCount}";

                //AtualizarPaginaAtual();

            }
            //webBrowser1.Navigate(resultado);
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

        private void timer1_Tick(object sender, EventArgs e)
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
                    else if (novoStatus == "Atualizando PDF")
                    {
                       // webBrowser1.Navigate(resultado);
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


        private string buscarpdf() {
            string resultado = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos PDF (*.pdf*)|*.pdf*"; // Filtro de arquivos
            openFileDialog.Title = "Selecione um arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                resultado = openFileDialog.FileName; // Armazena o caminho do arquivo
            }
            return resultado;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            //if (numerBox != null && radioButton2.Checked || radioButton1.Checked)
            //{
            //    timer1.Start();
            //    int caso = 1;
            //    string adicionar = buscarpdf();
            //    string pagina = numerBox.Text;
            //    bool ordem = ordemSelect();
            //    string caminho = resultado;
            //    string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "main.py");
            //    ProcessStartInfo startInfo = new ProcessStartInfo();
            //    startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
            //    startInfo.Arguments = $"\"{scriptpath}\" \"{caso}\" \"{caminho}\" \"{pagina}\" \"{adicionar}\" \"{ordem}\""; // Substitua pelo caminho do seu script Python
            //    startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //    startInfo.UseShellExecute = false;
            //    startInfo.RedirectStandardOutput = true;
            //    startInfo.CreateNoWindow = true;
            //    if (adicionar != null)
            //    {
            //        //webBrowser1.Navigate("");
            //        pythonProcess2 = Process.Start(startInfo);
            //    }
            //    else
            //    {
            //        AtualizarStatus("Erro ao Selecionar Arquivo");
            //    }
               
            //}
            //else {
            //    AtualizarStatus($"Erro Digite o Número da Página ou Selecione {"Antes"} ou {"Depois"}");
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (numerBox != null )
            {
                timer1.Start();
                int caso = 2;
                string pagina = numerBox.Text;
                string caminho = resultado;
                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "main.py");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                startInfo.Arguments = $"\"{scriptpath}\" \"{caso}\" \"{caminho}\" \"{pagina}\""; // Substitua pelo caminho do seu script Python
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;
                
               // webBrowser1.Navigate("");
                pythonProcess2 = Process.Start(startInfo);
                

            }
            else
            {
                AtualizarStatus("Digite o N° da Página!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (numerBox != null)
            {
                timer1.Start();
                int caso = 3;
                string pagina = numerBox.Text;
                string caminho = resultado;
                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "main.py");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                startInfo.Arguments = $"\"{scriptpath}\" \"{caso}\" \"{caminho}\" \"{pagina}\""; // Substitua pelo caminho do seu script Python
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;

               // webBrowser1.Navigate("");
                pythonProcess2 = Process.Start(startInfo);


            }
            else
            {
                AtualizarStatus("Digite o N° da Página!");
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
        //    int graus = grausSelect();
        //    if (numerBox != null && graus != 0 )
        //    {
        //        timer1.Start();
        //        int caso = 4;
        //        string pagina = numerBox.Text;
        //        string caminho = resultado;                
        //        string sentido = sentindoVirar();
        //        string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "main.py");
        //        ProcessStartInfo startInfo = new ProcessStartInfo();
        //        startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
        //        startInfo.Arguments = $"\"{scriptpath}\" \"{caso}\" \"{caminho}\" \"{pagina}\" \"{graus}\" \"{sentido}\""; // Substitua pelo caminho do seu script Python
        //        startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
        //        startInfo.UseShellExecute = false;
        //        startInfo.RedirectStandardOutput = true;
        //        startInfo.CreateNoWindow = true;

        //        //webBrowser1.Navigate("");
        //        pythonProcess2 = Process.Start(startInfo);


        //    }
        //    else
        //    {
        //        AtualizarStatus("Digite o N° da Página ou Selecione o Grau de Rotação");
        //    }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sem Ajuda!");
        }

        private void Extrair_pag_Click(object sender, EventArgs e)
        {
            // Cria o pop-up
            var Uc = new PagAdicionar();
            FormPopUp popup = new FormPopUp(Uc, "testando");

            Uc.FormPai = this;

            popup.FormPai = this;

            // Calcula posição do botão na tela
            var botao = sender as System.Windows.Forms.Button;
            var posicaoBotao = botao.PointToScreen(System.Drawing.Point.Empty);

            // Define posição do pop-up (à direita do botão)
            popup.StartPosition = FormStartPosition.Manual;
            popup.Location = new System.Drawing.Point(
                posicaoBotao.X + botao.Width,
                posicaoBotao.Y
            );

            // Mostra como não modal (para permitir clique fora)
            popup.Show();
        }

        private void PN_PDF_SizeChanged(object sender, EventArgs e)
        {
            // Mantém a página atual visível
            int paginaAtual = pdfViewer.Renderer.Page;
            pdfViewer.Renderer.Page = paginaAtual;
        }

        private void PN_PDF_Resize(object sender, EventArgs e)
        {
            pdfViewer.Size = PN_PDF.ClientSize; // garante que o tamanho seja igual ao do painel
            pdfViewer.PerformLayout();
            pdfViewer.Renderer.Invalidate(); // força redesenho
        }

        private void Abrir_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de texto (*.pdf)|*.pdf"; // Filtro de arquivos
            openFileDialog.Title = "Selecione um arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                resultado = openFileDialog.FileName; // Armazena o caminho do arquivo
                string nomeOriginal = Path.GetFileName(resultado);

                caminhoSalvar = resultado;
                nomeSalvar = nomeOriginal;

                // Caminho da pasta ./src (relativo ao executável)
                string pastaSrc = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "src");

                // Cria a pasta se não existir
                if (!Directory.Exists(pastaSrc))
                    Directory.CreateDirectory(pastaSrc);

                // Nome temporário único
                string nomeTemporario = Guid.NewGuid().ToString() + ".pdf";

                // Caminho final do arquivo temporário
                string caminhoTemporario = Path.Combine(pastaSrc, nomeTemporario);

                // Copia o arquivo para a pasta ./src
                File.Copy(resultado, caminhoTemporario, true);
                temporarioSav = caminhoTemporario;


                // Carrega o PDF
                var doc = PdfDocument.Load(caminhoTemporario);
                pdfViewer.Document = doc;

                // Atualiza total de páginas
                //lblTotalPaginas.Text = $"/ {doc.PageCount}";

                //AtualizarPaginaAtual();

            }
            //webBrowser1.Navigate(resultado);
        }
    }
}