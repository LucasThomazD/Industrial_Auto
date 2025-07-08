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
        
        private bool ordem;
        Process pythonProcess2;
        public Form2()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

            todasBox.CheckedChanged += todasBox_CheckedChanged;
            HorBox.CheckedChanged += HorBox_CheckedChanged;
            AntiBox.CheckedChanged += AntiBox_CheckedChanged;
            c90Box.CheckedChanged += c90Box_CheckedChanged;
            c180Box.CheckedChanged += c180Box_CheckedChanged;
            c270Box.CheckedChanged += c270Box_CheckedChanged;
            

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Form carregado!");
        }

        private void BtnAbri_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de texto (*.pdf)|*.pdf"; // Filtro de arquivos
            openFileDialog.Title = "Selecione um arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                resultado = openFileDialog.FileName; // Armazena o caminho do arquivo
                
            }
            webBrowser1.Navigate(resultado);
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
                        webBrowser1.Navigate(resultado);
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
        private bool ordemSelect()
        {
            
            if (radioButton1.Checked)
            {
                ordem = true;
            }
            else if (radioButton2.Checked)
            {
                ordem = false;
            }
            return ordem;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (numerBox != null && radioButton2.Checked || radioButton1.Checked)
            {
                timer1.Start();
                int caso = 1;
                string adicionar = buscarpdf();
                string pagina = numerBox.Text;
                bool ordem = ordemSelect();
                string caminho = resultado;
                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "main.py");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                startInfo.Arguments = $"\"{scriptpath}\" \"{caso}\" \"{caminho}\" \"{pagina}\" \"{adicionar}\" \"{ordem}\""; // Substitua pelo caminho do seu script Python
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;
                if (adicionar != null)
                {
                    webBrowser1.Navigate("");
                    pythonProcess2 = Process.Start(startInfo);
                }
                else
                {
                    AtualizarStatus("Erro ao Selecionar Arquivo");
                }
               
            }
            else {
                AtualizarStatus($"Erro Digite o Número da Página ou Selecione {"Antes"} ou {"Depois"}");
            }

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
                
                webBrowser1.Navigate("");
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

                webBrowser1.Navigate("");
                pythonProcess2 = Process.Start(startInfo);


            }
            else
            {
                AtualizarStatus("Digite o N° da Página!");
            }
        }
        private int grausSelect() {
            int graus = 0;
            if (c90Box.Checked)
            {
                graus = 90;
            }
            else if (c180Box.Checked) {
                graus = 180;
            }
            else if (c270Box.Checked)
            {
                graus = 270;
            }

            return graus;
        }

        private string sentindoVirar()
        {
            string sentido = null;
            if (HorBox.Checked)
            {
                sentido = "horario";
            }
            else if (AntiBox.Checked)
            {
                sentido = "anti-horario";

            }
            return sentido;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int graus = grausSelect();
            if (numerBox != null && graus != 0 )
            {
                timer1.Start();
                int caso = 4;
                string pagina = numerBox.Text;
                string caminho = resultado;                
                string sentido = sentindoVirar();
                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "main.py");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                startInfo.Arguments = $"\"{scriptpath}\" \"{caso}\" \"{caminho}\" \"{pagina}\" \"{graus}\" \"{sentido}\""; // Substitua pelo caminho do seu script Python
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;

                webBrowser1.Navigate("");
                pythonProcess2 = Process.Start(startInfo);


            }
            else
            {
                AtualizarStatus("Digite o N° da Página ou Selecione o Grau de Rotação");
            }
        }

        private void HorBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HorBox.Checked)
            {
                AntiBox.Checked = false; // Desmarca a outra CheckBox
                

            }
        }

        private void AntiBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AntiBox.Checked)
            {
                HorBox.Checked = false; // Desmarca a outra CheckBox
                

            }
        }

        private void c90Box_CheckedChanged(object sender, EventArgs e)
        {
            if (c90Box.Checked)
            {
                c180Box.Checked = false;
                c270Box.Checked = false;
               
          

            }
        }

        private void c180Box_CheckedChanged(object sender, EventArgs e)
        {
            if (c180Box.Checked)
            {
                c90Box.Checked = false;
                c270Box.Checked = false;
                
          
            }

        }

        private void c270Box_CheckedChanged(object sender, EventArgs e)
        {
            if (c270Box.Checked)
            {
                c180Box.Checked = false;
                c90Box.Checked = false;
               
            }

        }

       

        private void todasBox_CheckedChanged(object sender, EventArgs e)
        {
            if (todasBox.Checked)
            {
                numerBox.Text = "None";
                numerBox.Enabled = false;

            }
            else 
            {
                numerBox.Enabled = true;
                numerBox = null;
                            
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sem Ajuda!");
        }
    }
}