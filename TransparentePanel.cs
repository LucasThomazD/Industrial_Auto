using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormOI
{
    internal class TransparentePanel : System.Windows.Forms.Panel
    {

        private int _alpha = 128; // 0 = transparente, 255 = opaco

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Define a opacidade do painel (0-255)")]
        public int Alpha
        {
            get { return _alpha; }
            set
            {
                _alpha = Math.Max(0, Math.Min(255, value));
                Invalidate(); // Redesenha o painel
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(_alpha, this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
