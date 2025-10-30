using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;


namespace windowsFormOI
{
    public partial class Form2 : Form
    {
        private string resultado;
        public System.Windows.Forms.Timer timertab2;

        private string caminhoArquivo = "include/log.txt"; // Caminho do arquivo
        private string ultimoStatus = "";
        private PdfViewer pdfViewer;
        private System.Windows.Forms.TextBox txtPaginaAtual;
        string caminhoSalvar;
        string nomeSalvar;
        string temporarioSav;
        bool statusSave = true;
        bool existencia = false;
        private PdfDocument doc;
        private int _paginaAnterior = -1;
        private PipeServer _pipeServer;
        private System.Windows.Forms.Timer _timerVerificacao;

        private bool ordem;
        Process pythonProcess2;
        public Form2()
        {
            InitializeComponent();
            timertab2 = new System.Windows.Forms.Timer();
            timertab2.Interval = 1000;
            timertab2.Tick += timer1_Tick;

            // Configura timer para observar mudança de página
            _timerVerificacao = new System.Windows.Forms.Timer();
            _timerVerificacao.Interval = 300; // verifica a cada 0,3s
            _timerVerificacao.Tick += TimerVerificacao_Tick;
            _timerVerificacao.Start();

            inicializarPdfViewer();
            


        }
        public System.Windows.Forms.Timer MeuTimer => timertab2;

        private async void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Form carregado!");


            try
            {
                // Cria a pipe somente ao abrir o form
                _pipeServer = new PipeServer("PDFPipe2");

                // Lê PDF original em memória
                byte[] pdfOriginal = File.ReadAllBytes("teste.pdf");

                // Envia para Python e recebe PDF modificado
                byte[] pdfModificado = await _pipeServer.SendAndReceivePDFAsync(pdfOriginal);

                // Carrega o PDF no PdfViewer já existente no form
                using (var ms = new MemoryStream(pdfModificado))
                {
                    var doc = PdfiumViewer.PdfDocument.Load(ms);
                    pdfViewer.Document?.Dispose(); // libera PDF anterior, se houver
                    pdfViewer.Document = doc;       // atribui o novo PDF
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pipe: " + ex.Message);
            }




        }

        private void TimerVerificacao_Tick(object sender, EventArgs e)
        {
            if (pdfViewer.Renderer == null)
                return;

            int paginaAtual = pdfViewer.Renderer.Page + 1;

            if (paginaAtual != _paginaAnterior)
            {
                _paginaAnterior = paginaAtual;
                contadora.Text = paginaAtual.ToString();
            }
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
                doc = PdfDocument.Load(caminhoTemporario);
                pdfViewer.Document = doc;

                
                // Atualiza os TextBox iniciais
                AtualizarInformacoesPagina();

                

                // Evento disparado quando a página muda
                // Remove a linha que tenta adicionar o evento PageChanged
                // pdfViewer.Renderer.PageChanged += Renderer_PageChanged;

                // Substitua por um evento que realmente existe, como ZoomChanged
                pdfViewer.Renderer.ZoomChanged += Renderer_ZoomChanged;
                

                // Evento para mudar de página ao editar o txtPaginaAtual
                txtPaginaAtual.KeyDown += TxtPaginaAtual_KeyDown;

                MessageBox.Show("Total de páginas: " + doc.PageCount);


                // Atualiza total de páginas
                //lblTotalPaginas.Text = $"/ {doc.PageCount}";

                //AtualizarPaginaAtual();

            }
            //webBrowser1.Navigate(resultado);
        }

        private void TxtPaginaAtual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && doc != null)
            {
                e.SuppressKeyPress = true; // evita beep do Enter

                if (int.TryParse(contadora.Text, out int novaPagina))
                {
                    int total = doc.PageCount;

                    if (novaPagina < 1)
                        novaPagina = 1;
                    else if (novaPagina > total)
                        novaPagina = total;

                    pdfViewer.Renderer.Page = novaPagina - 1;
                    AtualizarInformacoesPagina();
                }
            }
        }

        private void Renderer_PageChanged(object sender, EventArgs e)
        {
            AtualizarInformacoesPagina();
        }

        private void AtualizarInformacoesPagina()
        {
            if (doc == null)
                return;

            int paginaAtual = pdfViewer.Renderer.Page + 1; // Page é zero-based
            int totalPaginas = doc.PageCount;

            contadora.Text = paginaAtual.ToString();
            totalBox.Text = totalPaginas.ToString();
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

                        timertab2.Stop();

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

        public void IniciarTimer()
        {
            if (!timertab2.Enabled)
            {
                timertab2.Start();
                Console.WriteLine("Timer iniciado pelo Form2!");
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

            // Cria o pop-up
            var Uc = new PagAdicionar();
            FormPopUp popup = new FormPopUp(Uc, "Adicionar Página");

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

        private void button2_Click(object sender, EventArgs e)
        {

            //if (numerBox != null )
            //{
            //    timer1.Start();
            //    int caso = 2;
            //    string pagina = numerBox.Text;
            //    string caminho = resultado;
            //    string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "main.py");
            //    ProcessStartInfo startInfo = new ProcessStartInfo();
            //    startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
            //    startInfo.Arguments = $"\"{scriptpath}\" \"{caso}\" \"{caminho}\" \"{pagina}\""; // Substitua pelo caminho do seu script Python
            //    startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //    startInfo.UseShellExecute = false;
            //    startInfo.RedirectStandardOutput = true;
            //    startInfo.CreateNoWindow = true;

            //   // webBrowser1.Navigate("");
            //    pythonProcess2 = Process.Start(startInfo);


            //}
            //else
            //{
            //    AtualizarStatus("Digite o N° da Página!");
            //}

            var Uc = new PagRCE();
            FormPopUp popup = new FormPopUp(Uc, "Remover Página");

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

        private void button3_Click(object sender, EventArgs e)
        {

            //if (numerBox != null)
            //{
            //    timer1.Start();
            //    int caso = 3;
            //    string pagina = numerBox.Text;
            //    string caminho = resultado;
            //    string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "main.py");
            //    ProcessStartInfo startInfo = new ProcessStartInfo();
            //    startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
            //    startInfo.Arguments = $"\"{scriptpath}\" \"{caso}\" \"{caminho}\" \"{pagina}\""; // Substitua pelo caminho do seu script Python
            //    startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //    startInfo.UseShellExecute = false;
            //    startInfo.RedirectStandardOutput = true;
            //    startInfo.CreateNoWindow = true;

            //   // webBrowser1.Navigate("");
            //    pythonProcess2 = Process.Start(startInfo);


            //}
            //else
            //{
            //    AtualizarStatus("Digite o N° da Página!");
            //}

            var Uc = new PagRCE();
            FormPopUp popup = new FormPopUp(Uc, "Copiar Página");

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

            // Cria o pop-up
            var Uc = new PagGirar();
            FormPopUp popup = new FormPopUp(Uc, "Girar Página(s)");

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

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sem Ajuda!");
        }

        private void Extrair_pag_Click(object sender, EventArgs e)
        {
            // Cria o pop-up
            var Uc = new PagRCE();
            FormPopUp popup = new FormPopUp(Uc, "Extrair Página");

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
            if (doc != null)
            {
                pdfViewer.Document?.Dispose();
                doc.Dispose();
                doc = null;
            }
            else{
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
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Cria o pop-up
            var Uc = new PagMesclar(this);
            FormPopUp popup = new FormPopUp(Uc, "Mesclar Páginas");

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

        private void button5_Click(object sender, EventArgs e)
        {
            var Uc = new PagDividir();
            FormPopUp popup = new FormPopUp(Uc, "Dividir Documento");

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

        private void button7_Click(object sender, EventArgs e)
        {
            var Uc = new PagSequencial();
            FormPopUp popup = new FormPopUp(Uc, "Inserir Sequencialmente");

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

        private void button8_Click(object sender, EventArgs e)
        {
            var Uc = new PagMarca();
            FormPopUp popup = new FormPopUp(Uc, "Marca D'água");

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

        // Adicione o método de evento correspondente
        private void Renderer_ZoomChanged(object sender, EventArgs e)
        {
            AtualizarInformacoesPagina();
        }

        private void Cloase_Bt_Click(object sender, EventArgs e)
        {
            if(pdfViewer.Document != null)
            {
                pdfViewer.Document?.Dispose();
                pdfViewer.Document = null;
            }
            


        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Fecha a pipe quando o form fechar
            _pipeServer?.Dispose();
        }
    }
}