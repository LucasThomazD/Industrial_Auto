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
    public partial class FormPopUp : Form
    {
        public Form2 FormPai { get; set; }
        public FormPopUp(UserControl conteudo, string texto)
        {
            InitializeComponent();
            this.MaximizeBox = false; // sem maximizar
            this.MinimizeBox = false; // sem minimizar
            this.ControlBox = false;  // remove toda a barra de controle (inclui o X)
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.Manual;
            this.Deactivate += (s, e) => this.Close();
            this.Text = texto;
            // Ajusta tamanho do pop-up para caber o UserControl
            this.ClientSize = conteudo.Size;

            // Adiciona o UserControl ao formulário
            conteudo.Dock = DockStyle.Fill;
            this.Controls.Add(conteudo);
            this.Opacity = 0.90; // Define a opacidade para 95%
        }
    }
}
