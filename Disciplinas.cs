using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace windowsFormOI
{
    
    public partial class Disciplinas : UserControl
    {
        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        public string ValorCombo1 ;
        public string ValorCombo2 ;
        public string ValorTextBox ;
        public bool checkBoxStatus;
        public Disciplinas(Excel.Application app, Excel.Workbook wb)
        {
            InitializeComponent();
            excelApp = app;
            workbook = wb;
        }
        private void FecharExcel()
        {
            try
            {
                if (workbook != null)
                {
                
                    workbook.Close(false);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    workbook = null;
                    
                }

                if (excelApp != null)
                {
                
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                    excelApp = null;
                    
                }
                // Libera os objetos COM
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar o Excel: " + ex.Message);
                AtualizarStatus($"Error", 0);
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

        private void Close_Dcp_Click(object sender, EventArgs e)
        {
            FecharExcel();
            this.Parent.Controls.Remove(this);
            this.Dispose();
            
        }

        private void bElet_Click(object sender, EventArgs e)
        {
            try
            {
                
                 filtrarDisciplinas("eletrica", "Elétrica");

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
                
                    filtrarDisciplinas("CBINC", "Combate à Incêndio");
                
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
                
                 filtrarDisciplinas("instrumentos", "Intrumentos");
                
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Error{ex}");
            }
        }

        private void bInst_Click(object sender, EventArgs e)
        {
            try
            {
                
                filtrarDisciplinas("instrumentacao", "Intrumentação");
                
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
                
                 filtrarDisciplinas("tubulacao", "Tubulação");
                
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
                
                filtrarDisciplinas("supTub", "Suporte de Tubulação");
                
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
                
                filtrarDisciplinas("processarDisciplinas", "Todas as Disciplinas da Industrial");
                
            }
            catch (Exception ex)
            {
                AtualizarStatus($"Error{ex}");
            }
        }
    }

}
