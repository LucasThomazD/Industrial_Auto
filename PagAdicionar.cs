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

    public partial class PagAdicionar : UserControl
    {
        public Form2 FormPai { get; set; }
        public PagAdicionar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormPai != null)
            {
                FormPai.Extrair_pag.Text = "Vazio";
            }
            
            }
    }
}
