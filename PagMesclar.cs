using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace windowsFormOI
{
    public partial class PagMesclar : UserControl
    {
        public Form2 FormPai { get; set; }
        public Form2 _form;


        public PagMesclar(Form2 form)
        {
            InitializeComponent();
            _form = form;

        }

        Process pythonProcess;
        
        private string NomeArquivo() {
            string arquivo;

            if (boxNome.Text == "") 
            {
            arquivo = "ArquivoMesclado";
            return arquivo;
            }
            else
            {
                arquivo = boxNome.Text;
                return arquivo;
            }
        
        
        }

        private void IniciarTimer()
        {
            Form2 form = this.FindForm() as Form2;
            if (form != null)
            {
                form.MeuTimer.Start(); // ou Start(), Interval, etc.
            }
        }

        private void unificar(System.Windows.Forms.TextBox PathBox)
        {
           
            _form.IniciarTimer();
            string nomear = NomeArquivo();
            string caminho = PathBox.Text;
            string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "MesclarPDF.py");
           // AtualizarStatus("", 0);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
            startInfo.Arguments = $"\"{scriptpath}\" \"{caminho}\" \" {nomear}"; // Substitua pelo caminho do seu script Python
            startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            pythonProcess = Process.Start(startInfo);
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(PathSalvar.Text))
                {

                    unificar(PathSalvar);

                }

                else
                {
                   // AtualizarStatus("Por Favor Inserir o Caminho e Tente Novamente!");

                }
            }
            catch (Exception ex)
            {
                //AtualizarStatus($"Erro {ex.Message}");
            }
        }
    }
}
