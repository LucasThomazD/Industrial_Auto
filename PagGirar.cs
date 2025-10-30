using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormOI
{
    public partial class PagGirar : UserControl

    {
        public Form2 FormPai { get; set; }
        public PagGirar()
        {
            InitializeComponent();
        }

        private int grausSelect()
        {
            int graus = 0;
            if (c90Box.Checked)
            {
                graus = 90;
            }
            else if (c180Box.Checked)
            {
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

        private void todasBox_CheckedChanged(object sender, EventArgs e)
        {
            if (todasBox.Checked)
            {
               // numerBox.Text = "None";
               // numerBox.Enabled = false;

            }
            else
            {
                //numerBox.Enabled = true;
               // numerBox = null;

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

        }

        private void c180Box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void c270Box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int graus = grausSelect();
            //if (numerBox != null && graus != 0)
            //{
            //    timer1.Start();
            //    int caso = 4;
            //    string pagina = numerBox.Text;
            //    string caminho = resultado;
            //    string sentido = sentindoVirar();
            //    string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "main.py");
            //    ProcessStartInfo startInfo = new ProcessStartInfo();
            //    startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
            //    startInfo.Arguments = $"\"{scriptpath}\" \"{caso}\" \"{caminho}\" \"{pagina}\" \"{graus}\" \"{sentido}\""; // Substitua pelo caminho do seu script Python
            //    startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //    startInfo.UseShellExecute = false;
            //    startInfo.RedirectStandardOutput = true;
            //    startInfo.CreateNoWindow = true;

            //    //webBrowser1.Navigate("");
            //    pythonProcess2 = Process.Start(startInfo);


            //}
            //else
            //{
            //    AtualizarStatus("Digite o N° da Página ou Selecione o Grau de Rotação");
            //}
        }
    }
}
