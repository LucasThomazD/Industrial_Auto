using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsFormOI
{
    public class PDFConfig
    {
        public string Cat_letra_Size { get; set; }
        public string Sub_letra_Size { get; set; }
        public string Fornecedor_letra_Size { get; set; }
        public string Cat_Espa_Size { get; set; }
        public string Sub1_Espa_Size { get; set; }
        public string Sub2_Espa_Size { get; set; }
       
    }

    public class GeralConfig
    {
        public string tema { get; set; }
        public string Impressora { get; set; }
        public string DataBase { get; set; }
    }
    public class SalvarConfig
    {
        public string salvarFornecimento { get; set; }
        public string SalvarFisico { get; set; }
        public string SalvarTimbrado { get; set; }
        public string SalvarCapas { get; set; }
        public string SalvarConsolidado { get; set; }
        public string SalvarTemplates { get; set; }

    }

    

    public class Configuracao
    {
        public PDFConfig PDF { get; set; } = new PDFConfig();
        public GeralConfig Geral { get; set; } = new GeralConfig();
        public SalvarConfig Salvar { get; set; } = new SalvarConfig();
    }
}
