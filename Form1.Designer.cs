using System.Drawing.Drawing2D;


namespace windowsFormOI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel26 = new System.Windows.Forms.Panel();
            this.RecarregarTab = new System.Windows.Forms.PictureBox();
            this.DeletarTabelaBox = new System.Windows.Forms.ComboBox();
            this.DeletarTabelabt = new System.Windows.Forms.RadioButton();
            this.DB_BT = new System.Windows.Forms.Button();
            this.NewTabelaBox = new System.Windows.Forms.TextBox();
            this.ATTabelaBox = new System.Windows.Forms.ComboBox();
            this.NewTabelaBt = new System.Windows.Forms.RadioButton();
            this.ATTabelaBt = new System.Windows.Forms.RadioButton();
            this.label45 = new System.Windows.Forms.Label();
            this.CaminhoVarredura = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.ModeloVarredura = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.boxPathOrg = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Bt_Organizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.RB_RA_Nao = new System.Windows.Forms.RadioButton();
            this.RB_RA_Sim = new System.Windows.Forms.RadioButton();
            this.label_Renomear = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.RB_MT_Copiar = new System.Windows.Forms.RadioButton();
            this.BT_MT_Mover = new System.Windows.Forms.RadioButton();
            this.label_MT = new System.Windows.Forms.Label();
            this.Ck_Cm_All = new System.Windows.Forms.CheckBox();
            this.Ck_Cm_Word = new System.Windows.Forms.CheckBox();
            this.Ck_Cm_Excel = new System.Windows.Forms.CheckBox();
            this.Ck_Cm_PDF = new System.Windows.Forms.CheckBox();
            this.IniciarCM = new System.Windows.Forms.Button();
            this.PB_BT_Stop_1 = new System.Windows.Forms.PictureBox();
            this.PDestinoBox = new System.Windows.Forms.TextBox();
            this.PRaizBox = new System.Windows.Forms.TextBox();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelRaiz = new System.Windows.Forms.Label();
            this.LBCataMilho = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkFiltrar = new System.Windows.Forms.CheckBox();
            this.PanelBuscar = new System.Windows.Forms.Panel();
            this.BtArquivos = new System.Windows.Forms.RadioButton();
            this.BtArquivoUnico = new System.Windows.Forms.RadioButton();
            this.bArquivo = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.PanelConsolidar = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bConsolidado = new System.Windows.Forms.Button();
            this.textFim = new System.Windows.Forms.TextBox();
            this.textInicio = new System.Windows.Forms.TextBox();
            this.labelCabeçalho2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCabeçalho1 = new System.Windows.Forms.Label();
            this.BoxModelo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtFis = new System.Windows.Forms.Panel();
            this.BtGerarConsolidado = new System.Windows.Forms.Button();
            this.BtFisico = new System.Windows.Forms.Button();
            this.BtFornecimento = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxArea = new System.Windows.Forms.ComboBox();
            this.BoxTA2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxTA1 = new System.Windows.Forms.ComboBox();
            this.bAplicarInfo = new System.Windows.Forms.Button();
            this.bDerrubar = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.PanelFiltrar = new System.Windows.Forms.Panel();
            this.bMulti = new System.Windows.Forms.Button();
            this.bSupTub = new System.Windows.Forms.Button();
            this.bTub = new System.Windows.Forms.Button();
            this.bInst = new System.Windows.Forms.Button();
            this.bMentos = new System.Windows.Forms.Button();
            this.bCBINC = new System.Windows.Forms.Button();
            this.bElet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirDiretórioRaizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoUsarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesSuplementaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarDisciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarunicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linhasDeCabeçalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClSubCat = new System.Windows.Forms.CheckBox();
            this.TxSubCat = new System.Windows.Forms.TextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.checkFornecedor = new System.Windows.Forms.CheckBox();
            this.Capa_fornecedores = new System.Windows.Forms.TextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.BTCapa = new System.Windows.Forms.Button();
            this.ClPropTecnica = new System.Windows.Forms.CheckBox();
            this.ClPropComercial = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TB_Descri = new System.Windows.Forms.TextBox();
            this.TB_Area = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TBPropTecnica = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TBPropComercial = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PathSalvar = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.genPDF = new System.Windows.Forms.Button();
            this.btTimbrado = new System.Windows.Forms.Button();
            this.Pathpdfs = new System.Windows.Forms.TextBox();
            this.btBranco = new System.Windows.Forms.Button();
            this.radioArquivo = new System.Windows.Forms.RadioButton();
            this.radioPasta = new System.Windows.Forms.RadioButton();
            this.BoxTimbrado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.botUnificar = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastaDistinoPDFsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelETimbradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unificarPDFsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarPDFsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesclarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Config_Save = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.valorDeIndice = new System.Windows.Forms.TextBox();
            this.textBoxEntrega = new System.Windows.Forms.TextBox();
            this.butImpTemplate = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.butExpTemplate = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PDF_Config = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.label47 = new System.Windows.Forms.Label();
            this.CaminhoDB = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.Geral_Sav_Bot = new System.Windows.Forms.PictureBox();
            this.Geral_Reset_Bot = new System.Windows.Forms.PictureBox();
            this.TemaBox = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ImpressoraBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.Capas_Reset_Bot = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Capas_Sav_Bot = new System.Windows.Forms.PictureBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.TamL_Fornecedor = new System.Windows.Forms.TextBox();
            this.Espa_sub2 = new System.Windows.Forms.TextBox();
            this.TamL_Cat = new System.Windows.Forms.TextBox();
            this.Espa_sub1 = new System.Windows.Forms.TextBox();
            this.TamL_Sub = new System.Windows.Forms.TextBox();
            this.Espa_Cat = new System.Windows.Forms.TextBox();
            this.Salvar_Config = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.bot_reset = new System.Windows.Forms.PictureBox();
            this.bot_sav = new System.Windows.Forms.PictureBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.Sav_PPQ_1 = new System.Windows.Forms.TextBox();
            this.Sav_PPQ_01 = new System.Windows.Forms.CheckBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Sav_PDF_02 = new System.Windows.Forms.CheckBox();
            this.Sav_PDF_2 = new System.Windows.Forms.TextBox();
            this.Sav_PDF_1 = new System.Windows.Forms.TextBox();
            this.Sav_PDF_01 = new System.Windows.Forms.CheckBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.Sav_Excel_03 = new System.Windows.Forms.CheckBox();
            this.Sav_Excel_02 = new System.Windows.Forms.CheckBox();
            this.Sav_Excel_3 = new System.Windows.Forms.TextBox();
            this.Sav_Excel_2 = new System.Windows.Forms.TextBox();
            this.Sav_Excel_1 = new System.Windows.Forms.TextBox();
            this.Sav_Excel_01 = new System.Windows.Forms.CheckBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecarregarTab)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BT_Stop_1)).BeginInit();
            this.panel8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PanelBuscar.SuspendLayout();
            this.PanelConsolidar.SuspendLayout();
            this.BtFis.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PanelFiltrar.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Config_Save.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.PDF_Config.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Geral_Sav_Bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geral_Reset_Bot)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Capas_Reset_Bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Capas_Sav_Bot)).BeginInit();
            this.Salvar_Config.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bot_reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot_sav)).BeginInit();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(968, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 679);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1028, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tabPage4.Controls.Add(this.panel26);
            this.tabPage4.Controls.Add(this.panel12);
            this.tabPage4.Controls.Add(this.panel9);
            this.tabPage4.Controls.Add(this.panel8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1092, 474);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ferramentas";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel26.Controls.Add(this.RecarregarTab);
            this.panel26.Controls.Add(this.DeletarTabelaBox);
            this.panel26.Controls.Add(this.DeletarTabelabt);
            this.panel26.Controls.Add(this.DB_BT);
            this.panel26.Controls.Add(this.NewTabelaBox);
            this.panel26.Controls.Add(this.ATTabelaBox);
            this.panel26.Controls.Add(this.NewTabelaBt);
            this.panel26.Controls.Add(this.ATTabelaBt);
            this.panel26.Controls.Add(this.label45);
            this.panel26.Controls.Add(this.CaminhoVarredura);
            this.panel26.Controls.Add(this.label43);
            this.panel26.Controls.Add(this.ModeloVarredura);
            this.panel26.Controls.Add(this.label32);
            this.panel26.Location = new System.Drawing.Point(755, 4);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(332, 300);
            this.panel26.TabIndex = 5;
            // 
            // RecarregarTab
            // 
            this.RecarregarTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecarregarTab.Image = ((System.Drawing.Image)(resources.GetObject("RecarregarTab.Image")));
            this.RecarregarTab.Location = new System.Drawing.Point(288, 8);
            this.RecarregarTab.Name = "RecarregarTab";
            this.RecarregarTab.Size = new System.Drawing.Size(30, 31);
            this.RecarregarTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RecarregarTab.TabIndex = 29;
            this.RecarregarTab.TabStop = false;
            this.RecarregarTab.Click += new System.EventHandler(this.RecarregarTab_Click);
            // 
            // DeletarTabelaBox
            // 
            this.DeletarTabelaBox.BackColor = System.Drawing.Color.Crimson;
            this.DeletarTabelaBox.ForeColor = System.Drawing.SystemColors.Window;
            this.DeletarTabelaBox.FormattingEnabled = true;
            this.DeletarTabelaBox.Location = new System.Drawing.Point(157, 185);
            this.DeletarTabelaBox.Name = "DeletarTabelaBox";
            this.DeletarTabelaBox.Size = new System.Drawing.Size(161, 21);
            this.DeletarTabelaBox.TabIndex = 28;
            // 
            // DeletarTabelabt
            // 
            this.DeletarTabelabt.AutoSize = true;
            this.DeletarTabelabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletarTabelabt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeletarTabelabt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletarTabelabt.ForeColor = System.Drawing.Color.Black;
            this.DeletarTabelabt.Location = new System.Drawing.Point(18, 185);
            this.DeletarTabelabt.Name = "DeletarTabelabt";
            this.DeletarTabelabt.Size = new System.Drawing.Size(98, 20);
            this.DeletarTabelabt.TabIndex = 27;
            this.DeletarTabelabt.TabStop = true;
            this.DeletarTabelabt.Text = "Deletar Tabela";
            this.DeletarTabelabt.UseVisualStyleBackColor = true;
            this.DeletarTabelabt.CheckedChanged += new System.EventHandler(this.DeletarTabelabt_CheckedChanged);
            // 
            // DB_BT
            // 
            this.DB_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.DB_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DB_BT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.DB_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DB_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_BT.Location = new System.Drawing.Point(117, 260);
            this.DB_BT.Name = "DB_BT";
            this.DB_BT.Size = new System.Drawing.Size(104, 24);
            this.DB_BT.TabIndex = 26;
            this.DB_BT.Text = "Iniciar";
            this.DB_BT.UseVisualStyleBackColor = false;
            this.DB_BT.Click += new System.EventHandler(this.DB_BT_Click);
            // 
            // NewTabelaBox
            // 
            this.NewTabelaBox.Location = new System.Drawing.Point(157, 150);
            this.NewTabelaBox.Name = "NewTabelaBox";
            this.NewTabelaBox.Size = new System.Drawing.Size(161, 20);
            this.NewTabelaBox.TabIndex = 25;
            // 
            // ATTabelaBox
            // 
            this.ATTabelaBox.FormattingEnabled = true;
            this.ATTabelaBox.Location = new System.Drawing.Point(157, 117);
            this.ATTabelaBox.Name = "ATTabelaBox";
            this.ATTabelaBox.Size = new System.Drawing.Size(161, 21);
            this.ATTabelaBox.TabIndex = 24;
            // 
            // NewTabelaBt
            // 
            this.NewTabelaBt.AutoSize = true;
            this.NewTabelaBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewTabelaBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewTabelaBt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTabelaBt.ForeColor = System.Drawing.Color.Black;
            this.NewTabelaBt.Location = new System.Drawing.Point(18, 150);
            this.NewTabelaBt.Name = "NewTabelaBt";
            this.NewTabelaBt.Size = new System.Drawing.Size(88, 20);
            this.NewTabelaBt.TabIndex = 23;
            this.NewTabelaBt.TabStop = true;
            this.NewTabelaBt.Text = "Nova Tabela";
            this.NewTabelaBt.UseVisualStyleBackColor = true;
            // 
            // ATTabelaBt
            // 
            this.ATTabelaBt.AutoSize = true;
            this.ATTabelaBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ATTabelaBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ATTabelaBt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATTabelaBt.ForeColor = System.Drawing.Color.Black;
            this.ATTabelaBt.Location = new System.Drawing.Point(18, 117);
            this.ATTabelaBt.Name = "ATTabelaBt";
            this.ATTabelaBt.Size = new System.Drawing.Size(106, 20);
            this.ATTabelaBt.TabIndex = 22;
            this.ATTabelaBt.TabStop = true;
            this.ATTabelaBt.Text = "Atualizar Tabela";
            this.ATTabelaBt.UseVisualStyleBackColor = true;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label45.Location = new System.Drawing.Point(15, 224);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(77, 18);
            this.label45.TabIndex = 21;
            this.label45.Text = "Caminho";
            this.label45.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label45, "Este é um label informativo.");
            // 
            // CaminhoVarredura
            // 
            this.CaminhoVarredura.Location = new System.Drawing.Point(102, 223);
            this.CaminhoVarredura.Name = "CaminhoVarredura";
            this.CaminhoVarredura.Size = new System.Drawing.Size(216, 20);
            this.CaminhoVarredura.TabIndex = 20;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label43.Location = new System.Drawing.Point(15, 72);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(164, 18);
            this.label43.TabIndex = 19;
            this.label43.Text = "Modelo de Varredura";
            this.label43.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModeloVarredura
            // 
            this.ModeloVarredura.FormattingEnabled = true;
            this.ModeloVarredura.Location = new System.Drawing.Point(197, 71);
            this.ModeloVarredura.Name = "ModeloVarredura";
            this.ModeloVarredura.Size = new System.Drawing.Size(121, 21);
            this.ModeloVarredura.TabIndex = 9;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label32.Location = new System.Drawing.Point(77, 7);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(191, 29);
            this.label32.TabIndex = 8;
            this.label32.Text = "BANCO DE DADOS";
            this.label32.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label32, "Ferramenta para transferir arquivos de um diretório para outro");
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel12.Controls.Add(this.label18);
            this.panel12.Controls.Add(this.boxPathOrg);
            this.panel12.Controls.Add(this.radioButton2);
            this.panel12.Controls.Add(this.radioButton1);
            this.panel12.Controls.Add(this.Bt_Organizar);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Location = new System.Drawing.Point(227, 310);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(232, 161);
            this.panel12.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(8, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 18);
            this.label18.TabIndex = 25;
            this.label18.Text = "Path";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // boxPathOrg
            // 
            this.boxPathOrg.Location = new System.Drawing.Point(72, 86);
            this.boxPathOrg.Name = "boxPathOrg";
            this.boxPathOrg.Size = new System.Drawing.Size(152, 20);
            this.boxPathOrg.TabIndex = 24;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(112, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Personalizado";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(24, 56);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 20);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Padrão";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Bt_Organizar
            // 
            this.Bt_Organizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.Bt_Organizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Organizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.Bt_Organizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Organizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Organizar.Location = new System.Drawing.Point(64, 120);
            this.Bt_Organizar.Name = "Bt_Organizar";
            this.Bt_Organizar.Size = new System.Drawing.Size(96, 24);
            this.Bt_Organizar.TabIndex = 7;
            this.Bt_Organizar.Text = "Organizar";
            this.Bt_Organizar.UseVisualStyleBackColor = false;
            this.Bt_Organizar.Click += new System.EventHandler(this.Bt_Organizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(24, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ordenar Pastas TA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label7, "Ferramenta para transferir arquivos de um diretório para outro");
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel9.Controls.Add(this.textBox1);
            this.panel9.Controls.Add(this.checkBox1);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.label_Renomear);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.label_MT);
            this.panel9.Controls.Add(this.Ck_Cm_All);
            this.panel9.Controls.Add(this.Ck_Cm_Word);
            this.panel9.Controls.Add(this.Ck_Cm_Excel);
            this.panel9.Controls.Add(this.Ck_Cm_PDF);
            this.panel9.Controls.Add(this.IniciarCM);
            this.panel9.Controls.Add(this.PB_BT_Stop_1);
            this.panel9.Controls.Add(this.PDestinoBox);
            this.panel9.Controls.Add(this.PRaizBox);
            this.panel9.Controls.Add(this.labelDestino);
            this.panel9.Controls.Add(this.labelRaiz);
            this.panel9.Controls.Add(this.LBCataMilho);
            this.panel9.Location = new System.Drawing.Point(227, 3);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel9.Size = new System.Drawing.Size(520, 301);
            this.panel9.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(24, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(187, 24);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Buscar Por Palavra Chave";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.RB_RA_Nao);
            this.panel11.Controls.Add(this.RB_RA_Sim);
            this.panel11.ForeColor = System.Drawing.Color.Transparent;
            this.panel11.Location = new System.Drawing.Point(224, 88);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(184, 32);
            this.panel11.TabIndex = 21;
            // 
            // RB_RA_Nao
            // 
            this.RB_RA_Nao.AutoSize = true;
            this.RB_RA_Nao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_RA_Nao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RB_RA_Nao.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_RA_Nao.ForeColor = System.Drawing.Color.Black;
            this.RB_RA_Nao.Location = new System.Drawing.Point(104, 8);
            this.RB_RA_Nao.Name = "RB_RA_Nao";
            this.RB_RA_Nao.Size = new System.Drawing.Size(45, 20);
            this.RB_RA_Nao.TabIndex = 1;
            this.RB_RA_Nao.TabStop = true;
            this.RB_RA_Nao.Text = "Não";
            this.RB_RA_Nao.UseVisualStyleBackColor = true;
            // 
            // RB_RA_Sim
            // 
            this.RB_RA_Sim.AutoSize = true;
            this.RB_RA_Sim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_RA_Sim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RB_RA_Sim.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_RA_Sim.ForeColor = System.Drawing.Color.Black;
            this.RB_RA_Sim.Location = new System.Drawing.Point(16, 8);
            this.RB_RA_Sim.Name = "RB_RA_Sim";
            this.RB_RA_Sim.Size = new System.Drawing.Size(44, 20);
            this.RB_RA_Sim.TabIndex = 0;
            this.RB_RA_Sim.TabStop = true;
            this.RB_RA_Sim.Text = "Sim";
            this.RB_RA_Sim.UseVisualStyleBackColor = true;
            // 
            // label_Renomear
            // 
            this.label_Renomear.AutoSize = true;
            this.label_Renomear.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Renomear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Renomear.Location = new System.Drawing.Point(24, 96);
            this.label_Renomear.Name = "label_Renomear";
            this.label_Renomear.Size = new System.Drawing.Size(173, 18);
            this.label_Renomear.TabIndex = 20;
            this.label_Renomear.Text = "Renomear Arquivos ?";
            this.label_Renomear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.RB_MT_Copiar);
            this.panel10.Controls.Add(this.BT_MT_Mover);
            this.panel10.ForeColor = System.Drawing.Color.Transparent;
            this.panel10.Location = new System.Drawing.Point(224, 48);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(184, 32);
            this.panel10.TabIndex = 19;
            // 
            // RB_MT_Copiar
            // 
            this.RB_MT_Copiar.AutoSize = true;
            this.RB_MT_Copiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_MT_Copiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RB_MT_Copiar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_MT_Copiar.ForeColor = System.Drawing.Color.Black;
            this.RB_MT_Copiar.Location = new System.Drawing.Point(104, 8);
            this.RB_MT_Copiar.Name = "RB_MT_Copiar";
            this.RB_MT_Copiar.Size = new System.Drawing.Size(59, 20);
            this.RB_MT_Copiar.TabIndex = 1;
            this.RB_MT_Copiar.TabStop = true;
            this.RB_MT_Copiar.Text = "Copiar";
            this.RB_MT_Copiar.UseVisualStyleBackColor = true;
            // 
            // BT_MT_Mover
            // 
            this.BT_MT_Mover.AutoSize = true;
            this.BT_MT_Mover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_MT_Mover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_MT_Mover.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_MT_Mover.ForeColor = System.Drawing.Color.Black;
            this.BT_MT_Mover.Location = new System.Drawing.Point(16, 8);
            this.BT_MT_Mover.Name = "BT_MT_Mover";
            this.BT_MT_Mover.Size = new System.Drawing.Size(56, 20);
            this.BT_MT_Mover.TabIndex = 0;
            this.BT_MT_Mover.TabStop = true;
            this.BT_MT_Mover.Text = "Mover";
            this.BT_MT_Mover.UseVisualStyleBackColor = true;
            // 
            // label_MT
            // 
            this.label_MT.AutoSize = true;
            this.label_MT.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_MT.Location = new System.Drawing.Point(24, 56);
            this.label_MT.Name = "label_MT";
            this.label_MT.Size = new System.Drawing.Size(176, 18);
            this.label_MT.TabIndex = 18;
            this.label_MT.Text = "Modo de transferência";
            this.label_MT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ck_Cm_All
            // 
            this.Ck_Cm_All.AutoSize = true;
            this.Ck_Cm_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ck_Cm_All.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ck_Cm_All.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Cm_All.Location = new System.Drawing.Point(328, 184);
            this.Ck_Cm_All.Name = "Ck_Cm_All";
            this.Ck_Cm_All.Size = new System.Drawing.Size(123, 20);
            this.Ck_Cm_All.TabIndex = 17;
            this.Ck_Cm_All.Text = "Todos os Arquivos";
            this.Ck_Cm_All.UseVisualStyleBackColor = true;
            // 
            // Ck_Cm_Word
            // 
            this.Ck_Cm_Word.AutoSize = true;
            this.Ck_Cm_Word.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ck_Cm_Word.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ck_Cm_Word.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Cm_Word.Location = new System.Drawing.Point(240, 184);
            this.Ck_Cm_Word.Name = "Ck_Cm_Word";
            this.Ck_Cm_Word.Size = new System.Drawing.Size(53, 20);
            this.Ck_Cm_Word.TabIndex = 16;
            this.Ck_Cm_Word.Text = "Word";
            this.Ck_Cm_Word.UseVisualStyleBackColor = true;
            // 
            // Ck_Cm_Excel
            // 
            this.Ck_Cm_Excel.AutoSize = true;
            this.Ck_Cm_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ck_Cm_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ck_Cm_Excel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Cm_Excel.Location = new System.Drawing.Point(152, 184);
            this.Ck_Cm_Excel.Name = "Ck_Cm_Excel";
            this.Ck_Cm_Excel.Size = new System.Drawing.Size(52, 20);
            this.Ck_Cm_Excel.TabIndex = 15;
            this.Ck_Cm_Excel.Text = "Excel";
            this.Ck_Cm_Excel.UseVisualStyleBackColor = true;
            // 
            // Ck_Cm_PDF
            // 
            this.Ck_Cm_PDF.AutoSize = true;
            this.Ck_Cm_PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ck_Cm_PDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ck_Cm_PDF.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Cm_PDF.Location = new System.Drawing.Point(72, 184);
            this.Ck_Cm_PDF.Name = "Ck_Cm_PDF";
            this.Ck_Cm_PDF.Size = new System.Drawing.Size(46, 20);
            this.Ck_Cm_PDF.TabIndex = 14;
            this.Ck_Cm_PDF.Text = "PDF";
            this.Ck_Cm_PDF.UseVisualStyleBackColor = true;
            // 
            // IniciarCM
            // 
            this.IniciarCM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.IniciarCM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarCM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.IniciarCM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IniciarCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarCM.Location = new System.Drawing.Point(408, 240);
            this.IniciarCM.Name = "IniciarCM";
            this.IniciarCM.Size = new System.Drawing.Size(104, 24);
            this.IniciarCM.TabIndex = 13;
            this.IniciarCM.Text = "Iniciar";
            this.IniciarCM.UseVisualStyleBackColor = false;
            // 
            // PB_BT_Stop_1
            // 
            this.PB_BT_Stop_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_BT_Stop_1.Image = ((System.Drawing.Image)(resources.GetObject("PB_BT_Stop_1.Image")));
            this.PB_BT_Stop_1.Location = new System.Drawing.Point(448, 8);
            this.PB_BT_Stop_1.Name = "PB_BT_Stop_1";
            this.PB_BT_Stop_1.Size = new System.Drawing.Size(48, 32);
            this.PB_BT_Stop_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_BT_Stop_1.TabIndex = 12;
            this.PB_BT_Stop_1.TabStop = false;
            // 
            // PDestinoBox
            // 
            this.PDestinoBox.Location = new System.Drawing.Point(152, 264);
            this.PDestinoBox.Name = "PDestinoBox";
            this.PDestinoBox.Size = new System.Drawing.Size(248, 20);
            this.PDestinoBox.TabIndex = 11;
            // 
            // PRaizBox
            // 
            this.PRaizBox.Location = new System.Drawing.Point(152, 224);
            this.PRaizBox.Name = "PRaizBox";
            this.PRaizBox.Size = new System.Drawing.Size(248, 20);
            this.PRaizBox.TabIndex = 10;
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDestino.Location = new System.Drawing.Point(24, 264);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(114, 18);
            this.labelDestino.TabIndex = 9;
            this.labelDestino.Text = "Pasta Destino";
            this.labelDestino.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.labelDestino, "Este é um label informativo.");
            // 
            // labelRaiz
            // 
            this.labelRaiz.AutoSize = true;
            this.labelRaiz.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRaiz.Location = new System.Drawing.Point(24, 224);
            this.labelRaiz.Name = "labelRaiz";
            this.labelRaiz.Size = new System.Drawing.Size(87, 18);
            this.labelRaiz.TabIndex = 8;
            this.labelRaiz.Text = "Pasta Raiz";
            this.labelRaiz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.labelRaiz, "Este é um label informativo.");
            // 
            // LBCataMilho
            // 
            this.LBCataMilho.AutoSize = true;
            this.LBCataMilho.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCataMilho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBCataMilho.Location = new System.Drawing.Point(192, 8);
            this.LBCataMilho.Name = "LBCataMilho";
            this.LBCataMilho.Size = new System.Drawing.Size(134, 29);
            this.LBCataMilho.TabIndex = 7;
            this.LBCataMilho.Text = "CATA MILHO";
            this.LBCataMilho.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.LBCataMilho, "Ferramenta para transferir arquivos de um diretório para outro");
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(216, 468);
            this.panel8.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(24, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(173, 60);
            this.label17.TabIndex = 6;
            this.label17.Text = "FERRAMENTAS\r\n AUXILIARES";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Converter Numeros";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tabPage2.Controls.Add(this.checkFiltrar);
            this.tabPage2.Controls.Add(this.PanelBuscar);
            this.tabPage2.Controls.Add(this.checkBox4);
            this.tabPage2.Controls.Add(this.PanelConsolidar);
            this.tabPage2.Controls.Add(this.BtFis);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.PanelFiltrar);
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Excel";
            // 
            // checkFiltrar
            // 
            this.checkFiltrar.AutoSize = true;
            this.checkFiltrar.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFiltrar.Location = new System.Drawing.Point(8, 160);
            this.checkFiltrar.Name = "checkFiltrar";
            this.checkFiltrar.Size = new System.Drawing.Size(15, 14);
            this.checkFiltrar.TabIndex = 18;
            this.checkFiltrar.UseVisualStyleBackColor = true;
            // 
            // PanelBuscar
            // 
            this.PanelBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.PanelBuscar.Controls.Add(this.BtArquivos);
            this.PanelBuscar.Controls.Add(this.BtArquivoUnico);
            this.PanelBuscar.Controls.Add(this.bArquivo);
            this.PanelBuscar.Location = new System.Drawing.Point(496, 112);
            this.PanelBuscar.Name = "PanelBuscar";
            this.PanelBuscar.Size = new System.Drawing.Size(452, 72);
            this.PanelBuscar.TabIndex = 17;
            // 
            // BtArquivos
            // 
            this.BtArquivos.AutoSize = true;
            this.BtArquivos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtArquivos.Location = new System.Drawing.Point(184, 26);
            this.BtArquivos.Name = "BtArquivos";
            this.BtArquivos.Size = new System.Drawing.Size(120, 24);
            this.BtArquivos.TabIndex = 11;
            this.BtArquivos.TabStop = true;
            this.BtArquivos.Text = "Entre Arquivos";
            this.BtArquivos.UseVisualStyleBackColor = true;
            // 
            // BtArquivoUnico
            // 
            this.BtArquivoUnico.AutoSize = true;
            this.BtArquivoUnico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtArquivoUnico.Location = new System.Drawing.Point(32, 26);
            this.BtArquivoUnico.Name = "BtArquivoUnico";
            this.BtArquivoUnico.Size = new System.Drawing.Size(138, 24);
            this.BtArquivoUnico.TabIndex = 10;
            this.BtArquivoUnico.TabStop = true;
            this.BtArquivoUnico.Text = "Sem Comparativo";
            this.BtArquivoUnico.UseVisualStyleBackColor = true;
            // 
            // bArquivo
            // 
            this.bArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArquivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bArquivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bArquivo.Location = new System.Drawing.Point(312, 20);
            this.bArquivo.Name = "bArquivo";
            this.bArquivo.Size = new System.Drawing.Size(118, 34);
            this.bArquivo.TabIndex = 2;
            this.bArquivo.Text = "BUSCAR";
            this.bArquivo.UseVisualStyleBackColor = false;
            this.bArquivo.Click += new System.EventHandler(this.bArquivo_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(8, 144);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // PanelConsolidar
            // 
            this.PanelConsolidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.PanelConsolidar.Controls.Add(this.textBox2);
            this.PanelConsolidar.Controls.Add(this.bConsolidado);
            this.PanelConsolidar.Controls.Add(this.textFim);
            this.PanelConsolidar.Controls.Add(this.textInicio);
            this.PanelConsolidar.Controls.Add(this.labelCabeçalho2);
            this.PanelConsolidar.Controls.Add(this.label9);
            this.PanelConsolidar.Controls.Add(this.labelCabeçalho1);
            this.PanelConsolidar.Controls.Add(this.BoxModelo);
            this.PanelConsolidar.Controls.Add(this.label8);
            this.PanelConsolidar.Location = new System.Drawing.Point(144, 312);
            this.PanelConsolidar.Name = "PanelConsolidar";
            this.PanelConsolidar.Size = new System.Drawing.Size(344, 144);
            this.PanelConsolidar.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 20);
            this.textBox2.TabIndex = 16;
            // 
            // bConsolidado
            // 
            this.bConsolidado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bConsolidado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bConsolidado.FlatAppearance.BorderSize = 0;
            this.bConsolidado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bConsolidado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bConsolidado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsolidado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bConsolidado.Location = new System.Drawing.Point(224, 40);
            this.bConsolidado.Name = "bConsolidado";
            this.bConsolidado.Size = new System.Drawing.Size(96, 32);
            this.bConsolidado.TabIndex = 15;
            this.bConsolidado.Text = "CONSOLIDAR";
            this.bConsolidado.UseVisualStyleBackColor = false;
            this.bConsolidado.Click += new System.EventHandler(this.bConsolidado_Click);
            // 
            // textFim
            // 
            this.textFim.Location = new System.Drawing.Point(168, 104);
            this.textFim.Name = "textFim";
            this.textFim.Size = new System.Drawing.Size(40, 20);
            this.textFim.TabIndex = 13;
            // 
            // textInicio
            // 
            this.textInicio.Location = new System.Drawing.Point(168, 72);
            this.textInicio.Name = "textInicio";
            this.textInicio.Size = new System.Drawing.Size(40, 20);
            this.textInicio.TabIndex = 12;
            // 
            // labelCabeçalho2
            // 
            this.labelCabeçalho2.AutoSize = true;
            this.labelCabeçalho2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCabeçalho2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCabeçalho2.Location = new System.Drawing.Point(24, 104);
            this.labelCabeçalho2.Name = "labelCabeçalho2";
            this.labelCabeçalho2.Size = new System.Drawing.Size(128, 20);
            this.labelCabeçalho2.TabIndex = 11;
            this.labelCabeçalho2.Text = "Nos Demais Copiar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(104, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "COPIAR CABEÇALHO";
            // 
            // labelCabeçalho1
            // 
            this.labelCabeçalho1.AutoSize = true;
            this.labelCabeçalho1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCabeçalho1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCabeçalho1.Location = new System.Drawing.Point(24, 72);
            this.labelCabeçalho1.Name = "labelCabeçalho1";
            this.labelCabeçalho1.Size = new System.Drawing.Size(111, 20);
            this.labelCabeçalho1.TabIndex = 10;
            this.labelCabeçalho1.Text = "Cabeçalho no 1°";
            // 
            // BoxModelo
            // 
            this.BoxModelo.FormattingEnabled = true;
            this.BoxModelo.Location = new System.Drawing.Point(88, 40);
            this.BoxModelo.Name = "BoxModelo";
            this.BoxModelo.Size = new System.Drawing.Size(122, 21);
            this.BoxModelo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(24, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Modelo";
            // 
            // BtFis
            // 
            this.BtFis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.BtFis.Controls.Add(this.BtGerarConsolidado);
            this.BtFis.Controls.Add(this.BtFisico);
            this.BtFis.Controls.Add(this.BtFornecimento);
            this.BtFis.Location = new System.Drawing.Point(248, 24);
            this.BtFis.Name = "BtFis";
            this.BtFis.Size = new System.Drawing.Size(600, 64);
            this.BtFis.TabIndex = 10;
            // 
            // BtGerarConsolidado
            // 
            this.BtGerarConsolidado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.BtGerarConsolidado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtGerarConsolidado.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtGerarConsolidado.FlatAppearance.BorderSize = 0;
            this.BtGerarConsolidado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.BtGerarConsolidado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtGerarConsolidado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtGerarConsolidado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtGerarConsolidado.Location = new System.Drawing.Point(416, 12);
            this.BtGerarConsolidado.Name = "BtGerarConsolidado";
            this.BtGerarConsolidado.Size = new System.Drawing.Size(152, 40);
            this.BtGerarConsolidado.TabIndex = 21;
            this.BtGerarConsolidado.Text = "Gerar Consolidado";
            this.BtGerarConsolidado.UseVisualStyleBackColor = false;
            this.BtGerarConsolidado.Click += new System.EventHandler(this.BtGerarConsolidado_Click);
            // 
            // BtFisico
            // 
            this.BtFisico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.BtFisico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtFisico.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtFisico.FlatAppearance.BorderSize = 0;
            this.BtFisico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.BtFisico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtFisico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtFisico.Location = new System.Drawing.Point(224, 12);
            this.BtFisico.Name = "BtFisico";
            this.BtFisico.Size = new System.Drawing.Size(152, 40);
            this.BtFisico.TabIndex = 20;
            this.BtFisico.Text = "Físico - Financeiro";
            this.BtFisico.UseVisualStyleBackColor = false;
            this.BtFisico.Click += new System.EventHandler(this.BtFisico_Click);
            // 
            // BtFornecimento
            // 
            this.BtFornecimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.BtFornecimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtFornecimento.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtFornecimento.FlatAppearance.BorderSize = 0;
            this.BtFornecimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.BtFornecimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtFornecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtFornecimento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtFornecimento.Location = new System.Drawing.Point(32, 12);
            this.BtFornecimento.Name = "BtFornecimento";
            this.BtFornecimento.Size = new System.Drawing.Size(152, 40);
            this.BtFornecimento.TabIndex = 19;
            this.BtFornecimento.Text = "Comparativo de Fornecimento";
            this.BtFornecimento.UseVisualStyleBackColor = false;
            this.BtFornecimento.Click += new System.EventHandler(this.BtFornecimento_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(8, 128);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.BoxArea);
            this.panel4.Controls.Add(this.BoxTA2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.BoxTA1);
            this.panel4.Controls.Add(this.bAplicarInfo);
            this.panel4.Controls.Add(this.bDerrubar);
            this.panel4.Location = new System.Drawing.Point(144, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(344, 192);
            this.panel4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(24, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Área";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(40, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "INFORMAÇÕES SUPLEMENTARES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "1° TA";
            // 
            // BoxArea
            // 
            this.BoxArea.FormattingEnabled = true;
            this.BoxArea.Location = new System.Drawing.Point(80, 144);
            this.BoxArea.Name = "BoxArea";
            this.BoxArea.Size = new System.Drawing.Size(121, 21);
            this.BoxArea.TabIndex = 6;
            // 
            // BoxTA2
            // 
            this.BoxTA2.FormattingEnabled = true;
            this.BoxTA2.Location = new System.Drawing.Point(77, 104);
            this.BoxTA2.Name = "BoxTA2";
            this.BoxTA2.Size = new System.Drawing.Size(72, 21);
            this.BoxTA2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(21, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "2° TA";
            // 
            // BoxTA1
            // 
            this.BoxTA1.FormattingEnabled = true;
            this.BoxTA1.Location = new System.Drawing.Point(77, 64);
            this.BoxTA1.Name = "BoxTA1";
            this.BoxTA1.Size = new System.Drawing.Size(72, 21);
            this.BoxTA1.TabIndex = 4;
            // 
            // bAplicarInfo
            // 
            this.bAplicarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bAplicarInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAplicarInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bAplicarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAplicarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAplicarInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAplicarInfo.Location = new System.Drawing.Point(232, 104);
            this.bAplicarInfo.Name = "bAplicarInfo";
            this.bAplicarInfo.Size = new System.Drawing.Size(96, 24);
            this.bAplicarInfo.TabIndex = 8;
            this.bAplicarInfo.Text = "INSTANCIAR";
            this.bAplicarInfo.UseVisualStyleBackColor = false;
            this.bAplicarInfo.Click += new System.EventHandler(this.bAplicarInfo_Click);
            // 
            // bDerrubar
            // 
            this.bDerrubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bDerrubar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDerrubar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bDerrubar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDerrubar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDerrubar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bDerrubar.Location = new System.Drawing.Point(232, 144);
            this.bDerrubar.Name = "bDerrubar";
            this.bDerrubar.Size = new System.Drawing.Size(96, 24);
            this.bDerrubar.TabIndex = 9;
            this.bDerrubar.Text = "DERRUBAR";
            this.bDerrubar.UseVisualStyleBackColor = false;
            this.bDerrubar.Click += new System.EventHandler(this.bDerrubar_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(8, 112);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // PanelFiltrar
            // 
            this.PanelFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.PanelFiltrar.Controls.Add(this.bMulti);
            this.PanelFiltrar.Controls.Add(this.bSupTub);
            this.PanelFiltrar.Controls.Add(this.bTub);
            this.PanelFiltrar.Controls.Add(this.bInst);
            this.PanelFiltrar.Controls.Add(this.bMentos);
            this.PanelFiltrar.Controls.Add(this.bCBINC);
            this.PanelFiltrar.Controls.Add(this.bElet);
            this.PanelFiltrar.Controls.Add(this.label1);
            this.PanelFiltrar.Location = new System.Drawing.Point(496, 192);
            this.PanelFiltrar.Name = "PanelFiltrar";
            this.PanelFiltrar.Size = new System.Drawing.Size(452, 266);
            this.PanelFiltrar.TabIndex = 0;
            // 
            // bMulti
            // 
            this.bMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bMulti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMulti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bMulti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bMulti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bMulti.Location = new System.Drawing.Point(141, 217);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(172, 34);
            this.bMulti.TabIndex = 10;
            this.bMulti.Text = "MULTI-DISCIPLINAR";
            this.bMulti.UseVisualStyleBackColor = false;
            this.bMulti.Click += new System.EventHandler(this.bMulti_Click);
            // 
            // bSupTub
            // 
            this.bSupTub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bSupTub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSupTub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bSupTub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSupTub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSupTub.Location = new System.Drawing.Point(245, 168);
            this.bSupTub.Name = "bSupTub";
            this.bSupTub.Size = new System.Drawing.Size(172, 34);
            this.bSupTub.TabIndex = 9;
            this.bSupTub.Text = "SUPORTE A TUBULAÇÃO";
            this.bSupTub.UseVisualStyleBackColor = false;
            this.bSupTub.Click += new System.EventHandler(this.bSupTub_Click);
            // 
            // bTub
            // 
            this.bTub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bTub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bTub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bTub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bTub.Location = new System.Drawing.Point(36, 168);
            this.bTub.Name = "bTub";
            this.bTub.Size = new System.Drawing.Size(172, 34);
            this.bTub.TabIndex = 8;
            this.bTub.Text = "TUBULAÇÃO";
            this.bTub.UseVisualStyleBackColor = false;
            this.bTub.Click += new System.EventHandler(this.bTub_Click);
            // 
            // bInst
            // 
            this.bInst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bInst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bInst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bInst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bInst.Location = new System.Drawing.Point(245, 118);
            this.bInst.Name = "bInst";
            this.bInst.Size = new System.Drawing.Size(172, 34);
            this.bInst.TabIndex = 7;
            this.bInst.Text = "INSTRUMENTAÇÃO";
            this.bInst.UseVisualStyleBackColor = false;
            this.bInst.Click += new System.EventHandler(this.bInst_Click);
            // 
            // bMentos
            // 
            this.bMentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bMentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bMentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bMentos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bMentos.Location = new System.Drawing.Point(36, 118);
            this.bMentos.Name = "bMentos";
            this.bMentos.Size = new System.Drawing.Size(172, 34);
            this.bMentos.TabIndex = 6;
            this.bMentos.Text = "INSTRUMENTOS";
            this.bMentos.UseVisualStyleBackColor = false;
            this.bMentos.Click += new System.EventHandler(this.bMentos_Click);
            // 
            // bCBINC
            // 
            this.bCBINC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bCBINC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCBINC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bCBINC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCBINC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bCBINC.Location = new System.Drawing.Point(245, 69);
            this.bCBINC.Name = "bCBINC";
            this.bCBINC.Size = new System.Drawing.Size(172, 34);
            this.bCBINC.TabIndex = 5;
            this.bCBINC.Text = "COMBATE A INCÊNDIO";
            this.bCBINC.UseVisualStyleBackColor = false;
            this.bCBINC.Click += new System.EventHandler(this.bCBINC_Click);
            // 
            // bElet
            // 
            this.bElet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bElet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bElet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bElet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bElet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bElet.Location = new System.Drawing.Point(36, 69);
            this.bElet.Name = "bElet";
            this.bElet.Size = new System.Drawing.Size(172, 34);
            this.bElet.TabIndex = 4;
            this.bElet.Text = "ELÉTRICA";
            this.bElet.UseVisualStyleBackColor = false;
            this.bElet.Click += new System.EventHandler(this.bElet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(104, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILTRAR DISCIPLINAS";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(4, 4);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(52, 24);
            this.menuStrip2.TabIndex = 15;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirDiretórioRaizToolStripMenuItem,
            this.visualizarExcelToolStripMenuItem,
            this.comoUsarToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // abrirDiretórioRaizToolStripMenuItem
            // 
            this.abrirDiretórioRaizToolStripMenuItem.Name = "abrirDiretórioRaizToolStripMenuItem";
            this.abrirDiretórioRaizToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.abrirDiretórioRaizToolStripMenuItem.Text = "Abrir Diretório Raiz";
            this.abrirDiretórioRaizToolStripMenuItem.Click += new System.EventHandler(this.abrirDiretórioRaizToolStripMenuItem_Click);
            // 
            // visualizarExcelToolStripMenuItem
            // 
            this.visualizarExcelToolStripMenuItem.Name = "visualizarExcelToolStripMenuItem";
            this.visualizarExcelToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.visualizarExcelToolStripMenuItem.Text = "Visualizar Excel";
            this.visualizarExcelToolStripMenuItem.Click += new System.EventHandler(this.visualizarExcelToolStripMenuItem_Click);
            // 
            // comoUsarToolStripMenuItem
            // 
            this.comoUsarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçõesSuplementaresToolStripMenuItem,
            this.filtrarDisciplinasToolStripMenuItem,
            this.buscarunicoToolStripMenuItem,
            this.linhasDeCabeçalhoToolStripMenuItem});
            this.comoUsarToolStripMenuItem.Name = "comoUsarToolStripMenuItem";
            this.comoUsarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.comoUsarToolStripMenuItem.Text = "Como Usar?";
            // 
            // informaçõesSuplementaresToolStripMenuItem
            // 
            this.informaçõesSuplementaresToolStripMenuItem.Name = "informaçõesSuplementaresToolStripMenuItem";
            this.informaçõesSuplementaresToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.informaçõesSuplementaresToolStripMenuItem.Text = "Informações Suplementares";
            this.informaçõesSuplementaresToolStripMenuItem.Click += new System.EventHandler(this.informaçõesSuplementaresToolStripMenuItem_Click);
            // 
            // filtrarDisciplinasToolStripMenuItem
            // 
            this.filtrarDisciplinasToolStripMenuItem.Name = "filtrarDisciplinasToolStripMenuItem";
            this.filtrarDisciplinasToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.filtrarDisciplinasToolStripMenuItem.Text = "Filtrar Disciplinas";
            this.filtrarDisciplinasToolStripMenuItem.Click += new System.EventHandler(this.filtrarDisciplinasToolStripMenuItem_Click);
            // 
            // buscarunicoToolStripMenuItem
            // 
            this.buscarunicoToolStripMenuItem.Name = "buscarunicoToolStripMenuItem";
            this.buscarunicoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.buscarunicoToolStripMenuItem.Text = "Buscar/unico";
            this.buscarunicoToolStripMenuItem.Click += new System.EventHandler(this.buscarunicoToolStripMenuItem_Click);
            // 
            // linhasDeCabeçalhoToolStripMenuItem
            // 
            this.linhasDeCabeçalhoToolStripMenuItem.Name = "linhasDeCabeçalhoToolStripMenuItem";
            this.linhasDeCabeçalhoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.linhasDeCabeçalhoToolStripMenuItem.Text = "Linhas de Cabeçalho";
            this.linhasDeCabeçalhoToolStripMenuItem.Click += new System.EventHandler(this.linhasDeCabeçalhoToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1092, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PDF";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.ClSubCat);
            this.panel2.Controls.Add(this.TxSubCat);
            this.panel2.Controls.Add(this.richTextBox4);
            this.panel2.Controls.Add(this.panel25);
            this.panel2.Controls.Add(this.checkFornecedor);
            this.panel2.Controls.Add(this.Capa_fornecedores);
            this.panel2.Controls.Add(this.richTextBox3);
            this.panel2.Controls.Add(this.BTCapa);
            this.panel2.Controls.Add(this.ClPropTecnica);
            this.panel2.Controls.Add(this.ClPropComercial);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.TB_Descri);
            this.panel2.Controls.Add(this.TB_Area);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.TBPropTecnica);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.TBPropComercial);
            this.panel2.Location = new System.Drawing.Point(547, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 363);
            this.panel2.TabIndex = 9;
            // 
            // ClSubCat
            // 
            this.ClSubCat.AutoSize = true;
            this.ClSubCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClSubCat.Location = new System.Drawing.Point(29, 351);
            this.ClSubCat.Name = "ClSubCat";
            this.ClSubCat.Size = new System.Drawing.Size(15, 14);
            this.ClSubCat.TabIndex = 25;
            this.ClSubCat.UseVisualStyleBackColor = true;
            this.ClSubCat.CheckedChanged += new System.EventHandler(this.ClSubCat_CheckedChanged);
            // 
            // TxSubCat
            // 
            this.TxSubCat.Location = new System.Drawing.Point(53, 348);
            this.TxSubCat.Name = "TxSubCat";
            this.TxSubCat.ReadOnly = true;
            this.TxSubCat.Size = new System.Drawing.Size(106, 20);
            this.TxSubCat.TabIndex = 24;
            this.TxSubCat.Text = "Apenas SubCat";
            this.TxSubCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(179, 335);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(187, 46);
            this.richTextBox4.TabIndex = 23;
            this.richTextBox4.Text = "";
            // 
            // panel25
            // 
            this.panel25.Location = new System.Drawing.Point(3, 430);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(43, 28);
            this.panel25.TabIndex = 22;
            // 
            // checkFornecedor
            // 
            this.checkFornecedor.AutoSize = true;
            this.checkFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkFornecedor.Location = new System.Drawing.Point(29, 289);
            this.checkFornecedor.Name = "checkFornecedor";
            this.checkFornecedor.Size = new System.Drawing.Size(15, 14);
            this.checkFornecedor.TabIndex = 21;
            this.checkFornecedor.UseVisualStyleBackColor = true;
            this.checkFornecedor.CheckedChanged += new System.EventHandler(this.checkFornecedor_CheckedChanged);
            // 
            // Capa_fornecedores
            // 
            this.Capa_fornecedores.Location = new System.Drawing.Point(53, 286);
            this.Capa_fornecedores.Name = "Capa_fornecedores";
            this.Capa_fornecedores.ReadOnly = true;
            this.Capa_fornecedores.Size = new System.Drawing.Size(106, 20);
            this.Capa_fornecedores.TabIndex = 20;
            this.Capa_fornecedores.Text = "Fornecedores";
            this.Capa_fornecedores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(179, 273);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(187, 46);
            this.richTextBox3.TabIndex = 19;
            this.richTextBox3.Text = "";
            // 
            // BTCapa
            // 
            this.BTCapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.BTCapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.BTCapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTCapa.Location = new System.Drawing.Point(122, 404);
            this.BTCapa.Name = "BTCapa";
            this.BTCapa.Size = new System.Drawing.Size(128, 32);
            this.BTCapa.TabIndex = 10;
            this.BTCapa.Text = "GERAR CAPA";
            this.BTCapa.UseVisualStyleBackColor = false;
            this.BTCapa.Click += new System.EventHandler(this.BTCapa_Click);
            // 
            // ClPropTecnica
            // 
            this.ClPropTecnica.AutoSize = true;
            this.ClPropTecnica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClPropTecnica.Location = new System.Drawing.Point(29, 226);
            this.ClPropTecnica.Name = "ClPropTecnica";
            this.ClPropTecnica.Size = new System.Drawing.Size(15, 14);
            this.ClPropTecnica.TabIndex = 18;
            this.ClPropTecnica.UseVisualStyleBackColor = true;
            this.ClPropTecnica.CheckedChanged += new System.EventHandler(this.CBPropTecnica_CheckedChanged);
            // 
            // ClPropComercial
            // 
            this.ClPropComercial.AutoSize = true;
            this.ClPropComercial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClPropComercial.Location = new System.Drawing.Point(29, 165);
            this.ClPropComercial.Name = "ClPropComercial";
            this.ClPropComercial.Size = new System.Drawing.Size(15, 14);
            this.ClPropComercial.TabIndex = 17;
            this.ClPropComercial.UseVisualStyleBackColor = true;
            this.ClPropComercial.CheckedChanged += new System.EventHandler(this.CBPropComercial_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(245, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 16);
            this.label24.TabIndex = 16;
            this.label24.Text = "DESCRITIVO";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(79, 74);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 16);
            this.label23.TabIndex = 15;
            this.label23.Text = "ÁREA";
            // 
            // TB_Descri
            // 
            this.TB_Descri.Location = new System.Drawing.Point(219, 96);
            this.TB_Descri.Name = "TB_Descri";
            this.TB_Descri.Size = new System.Drawing.Size(149, 20);
            this.TB_Descri.TabIndex = 14;
            // 
            // TB_Area
            // 
            this.TB_Area.Location = new System.Drawing.Point(31, 96);
            this.TB_Area.Name = "TB_Area";
            this.TB_Area.Size = new System.Drawing.Size(149, 20);
            this.TB_Area.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(132, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 25);
            this.label22.TabIndex = 12;
            this.label22.Text = "CRIAR CAPAS";
            // 
            // TBPropTecnica
            // 
            this.TBPropTecnica.Location = new System.Drawing.Point(53, 223);
            this.TBPropTecnica.Name = "TBPropTecnica";
            this.TBPropTecnica.ReadOnly = true;
            this.TBPropTecnica.Size = new System.Drawing.Size(106, 20);
            this.TBPropTecnica.TabIndex = 11;
            this.TBPropTecnica.Text = "Proposta Técnica";
            this.TBPropTecnica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(179, 210);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(187, 46);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(179, 148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(187, 46);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // TBPropComercial
            // 
            this.TBPropComercial.Location = new System.Drawing.Point(53, 162);
            this.TBPropComercial.Name = "TBPropComercial";
            this.TBPropComercial.ReadOnly = true;
            this.TBPropComercial.Size = new System.Drawing.Size(106, 20);
            this.TBPropComercial.TabIndex = 7;
            this.TBPropComercial.Text = "Proposta Comercial";
            this.TBPropComercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.PathSalvar);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.genPDF);
            this.panel1.Controls.Add(this.btTimbrado);
            this.panel1.Controls.Add(this.Pathpdfs);
            this.panel1.Controls.Add(this.btBranco);
            this.panel1.Controls.Add(this.radioArquivo);
            this.panel1.Controls.Add(this.radioPasta);
            this.panel1.Controls.Add(this.BoxTimbrado);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(178, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 210);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PathSalvar
            // 
            this.PathSalvar.Enabled = false;
            this.PathSalvar.Location = new System.Drawing.Point(180, 98);
            this.PathSalvar.Name = "PathSalvar";
            this.PathSalvar.Size = new System.Drawing.Size(149, 20);
            this.PathSalvar.TabIndex = 22;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(27, 97);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(138, 21);
            this.checkBox5.TabIndex = 21;
            this.checkBox5.Text = "Salvar Personalizado";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // genPDF
            // 
            this.genPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.genPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.genPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genPDF.Location = new System.Drawing.Point(27, 168);
            this.genPDF.Name = "genPDF";
            this.genPDF.Size = new System.Drawing.Size(81, 24);
            this.genPDF.TabIndex = 20;
            this.genPDF.Text = "GERAR PDF";
            this.genPDF.UseVisualStyleBackColor = false;
            this.genPDF.Click += new System.EventHandler(this.genPDF_Click);
            // 
            // btTimbrado
            // 
            this.btTimbrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.btTimbrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTimbrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.btTimbrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTimbrado.Location = new System.Drawing.Point(137, 168);
            this.btTimbrado.Name = "btTimbrado";
            this.btTimbrado.Size = new System.Drawing.Size(81, 24);
            this.btTimbrado.TabIndex = 19;
            this.btTimbrado.Text = "TIMBRADO";
            this.btTimbrado.UseVisualStyleBackColor = false;
            this.btTimbrado.Click += new System.EventHandler(this.btTimbrado_Click);
            // 
            // Pathpdfs
            // 
            this.Pathpdfs.Location = new System.Drawing.Point(180, 133);
            this.Pathpdfs.Name = "Pathpdfs";
            this.Pathpdfs.Size = new System.Drawing.Size(149, 20);
            this.Pathpdfs.TabIndex = 18;
            // 
            // btBranco
            // 
            this.btBranco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.btBranco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBranco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.btBranco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBranco.Location = new System.Drawing.Point(247, 168);
            this.btBranco.Name = "btBranco";
            this.btBranco.Size = new System.Drawing.Size(81, 24);
            this.btBranco.TabIndex = 17;
            this.btBranco.Text = "BRANCO";
            this.btBranco.UseVisualStyleBackColor = false;
            this.btBranco.Click += new System.EventHandler(this.btBranco_Click);
            // 
            // radioArquivo
            // 
            this.radioArquivo.AutoSize = true;
            this.radioArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioArquivo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioArquivo.Location = new System.Drawing.Point(27, 133);
            this.radioArquivo.Name = "radioArquivo";
            this.radioArquivo.Size = new System.Drawing.Size(74, 20);
            this.radioArquivo.TabIndex = 16;
            this.radioArquivo.TabStop = true;
            this.radioArquivo.Text = "ARQUIVO";
            this.radioArquivo.UseVisualStyleBackColor = true;
            // 
            // radioPasta
            // 
            this.radioPasta.AutoSize = true;
            this.radioPasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPasta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioPasta.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPasta.Location = new System.Drawing.Point(115, 133);
            this.radioPasta.Name = "radioPasta";
            this.radioPasta.Size = new System.Drawing.Size(59, 20);
            this.radioPasta.TabIndex = 15;
            this.radioPasta.TabStop = true;
            this.radioPasta.Text = "PASTA";
            this.radioPasta.UseVisualStyleBackColor = true;
            // 
            // BoxTimbrado
            // 
            this.BoxTimbrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoxTimbrado.FormattingEnabled = true;
            this.BoxTimbrado.Location = new System.Drawing.Point(180, 62);
            this.BoxTimbrado.Name = "BoxTimbrado";
            this.BoxTimbrado.Size = new System.Drawing.Size(113, 21);
            this.BoxTimbrado.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(92, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "MODELO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(74, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "EXCEL COM TIMBRADO";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel7.Controls.Add(this.botUnificar);
            this.panel7.Controls.Add(this.PathBox);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(178, 333);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(351, 86);
            this.panel7.TabIndex = 5;
            // 
            // botUnificar
            // 
            this.botUnificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.botUnificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botUnificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.botUnificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botUnificar.Location = new System.Drawing.Point(256, 47);
            this.botUnificar.Name = "botUnificar";
            this.botUnificar.Size = new System.Drawing.Size(72, 24);
            this.botUnificar.TabIndex = 14;
            this.botUnificar.Text = "INICIAR";
            this.botUnificar.UseVisualStyleBackColor = false;
            this.botUnificar.Click += new System.EventHandler(this.botUnificar_Click);
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(27, 50);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(202, 20);
            this.PathBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(101, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "UNIFICAR PDF\'s";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarPDFToolStripMenuItem,
            this.pastaDistinoPDFsToolStripMenuItem});
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // visualizarPDFToolStripMenuItem
            // 
            this.visualizarPDFToolStripMenuItem.Name = "visualizarPDFToolStripMenuItem";
            this.visualizarPDFToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.visualizarPDFToolStripMenuItem.Text = "Visualizar PDF";
            this.visualizarPDFToolStripMenuItem.Click += new System.EventHandler(this.visualizarPDF_Click);
            // 
            // pastaDistinoPDFsToolStripMenuItem
            // 
            this.pastaDistinoPDFsToolStripMenuItem.Name = "pastaDistinoPDFsToolStripMenuItem";
            this.pastaDistinoPDFsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pastaDistinoPDFsToolStripMenuItem.Text = "Pasta Distino PDF\'s";
            this.pastaDistinoPDFsToolStripMenuItem.Click += new System.EventHandler(this.caminhoPDFs_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelETimbradoToolStripMenuItem,
            this.unificarPDFsToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // excelETimbradoToolStripMenuItem
            // 
            this.excelETimbradoToolStripMenuItem.Name = "excelETimbradoToolStripMenuItem";
            this.excelETimbradoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.excelETimbradoToolStripMenuItem.Text = "Unificar PDF\'s";
            this.excelETimbradoToolStripMenuItem.Click += new System.EventHandler(this.excelTimHelp_Click);
            // 
            // unificarPDFsToolStripMenuItem
            // 
            this.unificarPDFsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarPDFsToolStripMenuItem,
            this.mesclarToolStripMenuItem});
            this.unificarPDFsToolStripMenuItem.Name = "unificarPDFsToolStripMenuItem";
            this.unificarPDFsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.unificarPDFsToolStripMenuItem.Text = "Excel e Timbrado";
            // 
            // gerarPDFsToolStripMenuItem
            // 
            this.gerarPDFsToolStripMenuItem.Name = "gerarPDFsToolStripMenuItem";
            this.gerarPDFsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.gerarPDFsToolStripMenuItem.Text = "Gerar PDF\'s";
            this.gerarPDFsToolStripMenuItem.Click += new System.EventHandler(this.gerarPDFHelp_Click);
            // 
            // mesclarToolStripMenuItem
            // 
            this.mesclarToolStripMenuItem.Name = "mesclarToolStripMenuItem";
            this.mesclarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.mesclarToolStripMenuItem.Text = "Mesclar";
            this.mesclarToolStripMenuItem.Click += new System.EventHandler(this.mesclarHelp_Click);
            // 
            // Config_Save
            // 
            this.Config_Save.Controls.Add(this.tabPage1);
            this.Config_Save.Controls.Add(this.tabPage2);
            this.Config_Save.Controls.Add(this.tabPage4);
            this.Config_Save.Controls.Add(this.tabPage3);
            this.Config_Save.Controls.Add(this.tabPage5);
            this.Config_Save.Location = new System.Drawing.Point(40, 144);
            this.Config_Save.Name = "Config_Save";
            this.Config_Save.SelectedIndex = 0;
            this.Config_Save.Size = new System.Drawing.Size(1100, 500);
            this.Config_Save.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.valorDeIndice);
            this.tabPage3.Controls.Add(this.textBoxEntrega);
            this.tabPage3.Controls.Add(this.butImpTemplate);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.butExpTemplate);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1092, 474);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "PPQ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label21.Location = new System.Drawing.Point(931, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 20);
            this.label21.TabIndex = 11;
            this.label21.Text = "1° Índice";
            // 
            // valorDeIndice
            // 
            this.valorDeIndice.Location = new System.Drawing.Point(914, 58);
            this.valorDeIndice.Name = "valorDeIndice";
            this.valorDeIndice.ReadOnly = true;
            this.valorDeIndice.Size = new System.Drawing.Size(121, 20);
            this.valorDeIndice.TabIndex = 10;
            // 
            // textBoxEntrega
            // 
            this.textBoxEntrega.Location = new System.Drawing.Point(213, 58);
            this.textBoxEntrega.Name = "textBoxEntrega";
            this.textBoxEntrega.Size = new System.Drawing.Size(121, 20);
            this.textBoxEntrega.TabIndex = 9;
            this.textBoxEntrega.TextChanged += new System.EventHandler(this.textBoxEntrega_TextChanged);
            // 
            // butImpTemplate
            // 
            this.butImpTemplate.Location = new System.Drawing.Point(615, 57);
            this.butImpTemplate.Name = "butImpTemplate";
            this.butImpTemplate.Size = new System.Drawing.Size(120, 23);
            this.butImpTemplate.TabIndex = 8;
            this.butImpTemplate.Text = "Exibir Template";
            this.butImpTemplate.UseVisualStyleBackColor = true;
            this.butImpTemplate.Click += new System.EventHandler(this.butImpTemplate_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label20.Location = new System.Drawing.Point(99, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 20);
            this.label20.TabIndex = 7;
            this.label20.Text = "Área";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label19.Location = new System.Drawing.Point(240, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 20);
            this.label19.TabIndex = 6;
            this.label19.Text = "Entrega";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(461, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "RM";
            // 
            // butExpTemplate
            // 
            this.butExpTemplate.Location = new System.Drawing.Point(763, 57);
            this.butExpTemplate.Name = "butExpTemplate";
            this.butExpTemplate.Size = new System.Drawing.Size(120, 23);
            this.butExpTemplate.TabIndex = 4;
            this.butExpTemplate.Text = "Exportar Templates";
            this.butExpTemplate.UseVisualStyleBackColor = true;
            this.butExpTemplate.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(368, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(60, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1048, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tabPage5.Controls.Add(this.tabControl1);
            this.tabPage5.Controls.Add(this.menuStrip3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1092, 474);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Configurações";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.PDF_Config);
            this.tabControl1.Controls.Add(this.Salvar_Config);
            this.tabControl1.Location = new System.Drawing.Point(179, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 406);
            this.tabControl1.TabIndex = 1;
            // 
            // PDF_Config
            // 
            this.PDF_Config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.PDF_Config.Controls.Add(this.panel5);
            this.PDF_Config.Controls.Add(this.panel3);
            this.PDF_Config.Location = new System.Drawing.Point(4, 25);
            this.PDF_Config.Name = "PDF_Config";
            this.PDF_Config.Padding = new System.Windows.Forms.Padding(3);
            this.PDF_Config.Size = new System.Drawing.Size(734, 377);
            this.PDF_Config.TabIndex = 1;
            this.PDF_Config.Text = "PDF";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.panel27);
            this.panel5.Controls.Add(this.panel21);
            this.panel5.Controls.Add(this.TemaBox);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.ImpressoraBox);
            this.panel5.Location = new System.Drawing.Point(24, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(441, 315);
            this.panel5.TabIndex = 16;
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.LightGray;
            this.panel27.Controls.Add(this.label47);
            this.panel27.Controls.Add(this.CaminhoDB);
            this.panel27.Controls.Add(this.button3);
            this.panel27.Controls.Add(this.label46);
            this.panel27.Location = new System.Drawing.Point(213, 66);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(217, 150);
            this.panel27.TabIndex = 25;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(63, 55);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(87, 15);
            this.label47.TabIndex = 18;
            this.label47.Text = "Caminho DB";
            // 
            // CaminhoDB
            // 
            this.CaminhoDB.Location = new System.Drawing.Point(11, 77);
            this.CaminhoDB.Name = "CaminhoDB";
            this.CaminhoDB.Size = new System.Drawing.Size(196, 20);
            this.CaminhoDB.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(61, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(26, 6);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(168, 20);
            this.label46.TabIndex = 11;
            this.label46.Text = "BANCO DE DADOS";
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Gray;
            this.panel21.Controls.Add(this.label31);
            this.panel21.Controls.Add(this.Geral_Sav_Bot);
            this.panel21.Controls.Add(this.Geral_Reset_Bot);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(441, 44);
            this.panel21.TabIndex = 22;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(75, 10);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(258, 25);
            this.label31.TabIndex = 10;
            this.label31.Text = "INFORMAÇÕES GERAIS";
            // 
            // Geral_Sav_Bot
            // 
            this.Geral_Sav_Bot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geral_Sav_Bot.Image = ((System.Drawing.Image)(resources.GetObject("Geral_Sav_Bot.Image")));
            this.Geral_Sav_Bot.Location = new System.Drawing.Point(351, 7);
            this.Geral_Sav_Bot.Name = "Geral_Sav_Bot";
            this.Geral_Sav_Bot.Size = new System.Drawing.Size(30, 31);
            this.Geral_Sav_Bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Geral_Sav_Bot.TabIndex = 18;
            this.Geral_Sav_Bot.TabStop = false;
            this.Geral_Sav_Bot.Click += new System.EventHandler(this.Geral_Sav_Bot_Click);
            // 
            // Geral_Reset_Bot
            // 
            this.Geral_Reset_Bot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geral_Reset_Bot.Image = ((System.Drawing.Image)(resources.GetObject("Geral_Reset_Bot.Image")));
            this.Geral_Reset_Bot.Location = new System.Drawing.Point(392, 7);
            this.Geral_Reset_Bot.Name = "Geral_Reset_Bot";
            this.Geral_Reset_Bot.Size = new System.Drawing.Size(30, 31);
            this.Geral_Reset_Bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Geral_Reset_Bot.TabIndex = 19;
            this.Geral_Reset_Bot.TabStop = false;
            this.Geral_Reset_Bot.Click += new System.EventHandler(this.Geral_Reset_Bot_Click);
            // 
            // TemaBox
            // 
            this.TemaBox.FormattingEnabled = true;
            this.TemaBox.Location = new System.Drawing.Point(53, 176);
            this.TemaBox.Name = "TemaBox";
            this.TemaBox.Size = new System.Drawing.Size(102, 21);
            this.TemaBox.TabIndex = 21;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(76, 143);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(57, 20);
            this.label30.TabIndex = 20;
            this.label30.Text = "TEMA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(38, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "IMPRESSORA";
            // 
            // ImpressoraBox
            // 
            this.ImpressoraBox.FormattingEnabled = true;
            this.ImpressoraBox.Location = new System.Drawing.Point(34, 104);
            this.ImpressoraBox.Name = "ImpressoraBox";
            this.ImpressoraBox.Size = new System.Drawing.Size(135, 21);
            this.ImpressoraBox.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panel23);
            this.panel3.Controls.Add(this.panel22);
            this.panel3.Controls.Add(this.panel20);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.TamL_Fornecedor);
            this.panel3.Controls.Add(this.Espa_sub2);
            this.panel3.Controls.Add(this.TamL_Cat);
            this.panel3.Controls.Add(this.Espa_sub1);
            this.panel3.Controls.Add(this.TamL_Sub);
            this.panel3.Controls.Add(this.Espa_Cat);
            this.panel3.Location = new System.Drawing.Point(471, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 315);
            this.panel3.TabIndex = 15;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.LightGray;
            this.panel23.Controls.Add(this.label16);
            this.panel23.Location = new System.Drawing.Point(0, 184);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(236, 32);
            this.panel23.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(210, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "ESPAÇAMENTO ENTRE:";
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.LightGray;
            this.panel22.Controls.Add(this.label14);
            this.panel22.Location = new System.Drawing.Point(0, 66);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(236, 32);
            this.panel22.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "TAMANHO DA LETRA:";
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Gray;
            this.panel20.Controls.Add(this.Capas_Reset_Bot);
            this.panel20.Controls.Add(this.label13);
            this.panel20.Controls.Add(this.Capas_Sav_Bot);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(236, 44);
            this.panel20.TabIndex = 22;
            // 
            // Capas_Reset_Bot
            // 
            this.Capas_Reset_Bot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Capas_Reset_Bot.Image = ((System.Drawing.Image)(resources.GetObject("Capas_Reset_Bot.Image")));
            this.Capas_Reset_Bot.Location = new System.Drawing.Point(191, 5);
            this.Capas_Reset_Bot.Name = "Capas_Reset_Bot";
            this.Capas_Reset_Bot.Size = new System.Drawing.Size(30, 31);
            this.Capas_Reset_Bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Capas_Reset_Bot.TabIndex = 19;
            this.Capas_Reset_Bot.TabStop = false;
            this.Capas_Reset_Bot.Click += new System.EventHandler(this.Capas_Reset_Bot_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(49, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 29);
            this.label13.TabIndex = 10;
            this.label13.Text = "CAPAS";
            // 
            // Capas_Sav_Bot
            // 
            this.Capas_Sav_Bot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Capas_Sav_Bot.Image = ((System.Drawing.Image)(resources.GetObject("Capas_Sav_Bot.Image")));
            this.Capas_Sav_Bot.Location = new System.Drawing.Point(150, 5);
            this.Capas_Sav_Bot.Name = "Capas_Sav_Bot";
            this.Capas_Sav_Bot.Size = new System.Drawing.Size(30, 31);
            this.Capas_Sav_Bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Capas_Sav_Bot.TabIndex = 18;
            this.Capas_Sav_Bot.TabStop = false;
            this.Capas_Sav_Bot.Click += new System.EventHandler(this.Capas_Sav_Bot_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(19, 276);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(139, 15);
            this.label28.TabIndex = 21;
            this.label28.Text = "Entre SubCategorias";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(19, 250);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(132, 15);
            this.label29.TabIndex = 20;
            this.label29.Text = "Categoria X SubCat";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(19, 224);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(148, 15);
            this.label33.TabIndex = 19;
            this.label33.Text = "Categoria X Categoria";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(19, 155);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(117, 15);
            this.label27.TabIndex = 18;
            this.label27.Text = "Capa Fornecedor";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(19, 129);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(105, 15);
            this.label26.TabIndex = 17;
            this.label26.Text = "Sub Categorias";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(19, 103);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 15);
            this.label25.TabIndex = 16;
            this.label25.Text = "Categorias";
            // 
            // TamL_Fornecedor
            // 
            this.TamL_Fornecedor.Location = new System.Drawing.Point(179, 153);
            this.TamL_Fornecedor.Name = "TamL_Fornecedor";
            this.TamL_Fornecedor.Size = new System.Drawing.Size(36, 20);
            this.TamL_Fornecedor.TabIndex = 15;
            // 
            // Espa_sub2
            // 
            this.Espa_sub2.Location = new System.Drawing.Point(179, 274);
            this.Espa_sub2.Name = "Espa_sub2";
            this.Espa_sub2.Size = new System.Drawing.Size(36, 20);
            this.Espa_sub2.TabIndex = 14;
            // 
            // TamL_Cat
            // 
            this.TamL_Cat.Location = new System.Drawing.Point(179, 101);
            this.TamL_Cat.Name = "TamL_Cat";
            this.TamL_Cat.Size = new System.Drawing.Size(36, 20);
            this.TamL_Cat.TabIndex = 5;
            // 
            // Espa_sub1
            // 
            this.Espa_sub1.Location = new System.Drawing.Point(179, 248);
            this.Espa_sub1.Name = "Espa_sub1";
            this.Espa_sub1.Size = new System.Drawing.Size(36, 20);
            this.Espa_sub1.TabIndex = 13;
            // 
            // TamL_Sub
            // 
            this.TamL_Sub.Location = new System.Drawing.Point(179, 127);
            this.TamL_Sub.Name = "TamL_Sub";
            this.TamL_Sub.Size = new System.Drawing.Size(36, 20);
            this.TamL_Sub.TabIndex = 6;
            // 
            // Espa_Cat
            // 
            this.Espa_Cat.Location = new System.Drawing.Point(179, 222);
            this.Espa_Cat.Name = "Espa_Cat";
            this.Espa_Cat.Size = new System.Drawing.Size(36, 20);
            this.Espa_Cat.TabIndex = 12;
            // 
            // Salvar_Config
            // 
            this.Salvar_Config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.Salvar_Config.Controls.Add(this.panel6);
            this.Salvar_Config.Location = new System.Drawing.Point(4, 25);
            this.Salvar_Config.Name = "Salvar_Config";
            this.Salvar_Config.Size = new System.Drawing.Size(734, 377);
            this.Salvar_Config.TabIndex = 2;
            this.Salvar_Config.Text = "Salvar";
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel6.Controls.Add(this.panel24);
            this.panel6.Controls.Add(this.panel18);
            this.panel6.Controls.Add(this.panel16);
            this.panel6.Controls.Add(this.panel14);
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(734, 377);
            this.panel6.TabIndex = 0;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.Gray;
            this.panel24.Controls.Add(this.label34);
            this.panel24.Controls.Add(this.bot_reset);
            this.panel24.Controls.Add(this.bot_sav);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(717, 41);
            this.panel24.TabIndex = 25;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(163, 7);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(385, 25);
            this.label34.TabIndex = 11;
            this.label34.Text = "OS ARQUIVOS SERÃO SALVOS EM:";
            // 
            // bot_reset
            // 
            this.bot_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bot_reset.Image = ((System.Drawing.Image)(resources.GetObject("bot_reset.Image")));
            this.bot_reset.Location = new System.Drawing.Point(624, 4);
            this.bot_reset.Name = "bot_reset";
            this.bot_reset.Size = new System.Drawing.Size(30, 31);
            this.bot_reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bot_reset.TabIndex = 17;
            this.bot_reset.TabStop = false;
            this.bot_reset.Click += new System.EventHandler(this.bot_reset_Click);
            // 
            // bot_sav
            // 
            this.bot_sav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bot_sav.Image = ((System.Drawing.Image)(resources.GetObject("bot_sav.Image")));
            this.bot_sav.Location = new System.Drawing.Point(583, 4);
            this.bot_sav.Name = "bot_sav";
            this.bot_sav.Size = new System.Drawing.Size(30, 31);
            this.bot_sav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bot_sav.TabIndex = 16;
            this.bot_sav.TabStop = false;
            this.bot_sav.Click += new System.EventHandler(this.bot_sav_Click_1);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel18.Controls.Add(this.Sav_PPQ_1);
            this.panel18.Controls.Add(this.Sav_PPQ_01);
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Controls.Add(this.label44);
            this.panel18.Location = new System.Drawing.Point(53, 432);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(610, 88);
            this.panel18.TabIndex = 15;
            // 
            // Sav_PPQ_1
            // 
            this.Sav_PPQ_1.Location = new System.Drawing.Point(306, 49);
            this.Sav_PPQ_1.Name = "Sav_PPQ_1";
            this.Sav_PPQ_1.Size = new System.Drawing.Size(297, 20);
            this.Sav_PPQ_1.TabIndex = 18;
            // 
            // Sav_PPQ_01
            // 
            this.Sav_PPQ_01.AutoSize = true;
            this.Sav_PPQ_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sav_PPQ_01.Location = new System.Drawing.Point(11, 53);
            this.Sav_PPQ_01.Name = "Sav_PPQ_01";
            this.Sav_PPQ_01.Size = new System.Drawing.Size(15, 14);
            this.Sav_PPQ_01.TabIndex = 17;
            this.Sav_PPQ_01.UseVisualStyleBackColor = true;
            this.Sav_PPQ_01.CheckedChanged += new System.EventHandler(this.Sav_PPQ_01_CheckedChanged);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Silver;
            this.panel19.Controls.Add(this.label40);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(610, 32);
            this.panel19.TabIndex = 16;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(277, 4);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(57, 25);
            this.label40.TabIndex = 12;
            this.label40.Text = "PPQ";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(37, 49);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(132, 20);
            this.label44.TabIndex = 13;
            this.label44.Text = "Templates PPQ";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel16.Controls.Add(this.Sav_PDF_02);
            this.panel16.Controls.Add(this.Sav_PDF_2);
            this.panel16.Controls.Add(this.Sav_PDF_1);
            this.panel16.Controls.Add(this.Sav_PDF_01);
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Controls.Add(this.label41);
            this.panel16.Controls.Add(this.label42);
            this.panel16.Location = new System.Drawing.Point(53, 277);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(610, 133);
            this.panel16.TabIndex = 14;
            // 
            // Sav_PDF_02
            // 
            this.Sav_PDF_02.AutoSize = true;
            this.Sav_PDF_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sav_PDF_02.Location = new System.Drawing.Point(11, 95);
            this.Sav_PDF_02.Name = "Sav_PDF_02";
            this.Sav_PDF_02.Size = new System.Drawing.Size(15, 14);
            this.Sav_PDF_02.TabIndex = 21;
            this.Sav_PDF_02.UseVisualStyleBackColor = true;
            this.Sav_PDF_02.CheckedChanged += new System.EventHandler(this.Sav_PDF_02_CheckedChanged);
            // 
            // Sav_PDF_2
            // 
            this.Sav_PDF_2.Location = new System.Drawing.Point(306, 91);
            this.Sav_PDF_2.Name = "Sav_PDF_2";
            this.Sav_PDF_2.Size = new System.Drawing.Size(297, 20);
            this.Sav_PDF_2.TabIndex = 19;
            // 
            // Sav_PDF_1
            // 
            this.Sav_PDF_1.Location = new System.Drawing.Point(306, 49);
            this.Sav_PDF_1.Name = "Sav_PDF_1";
            this.Sav_PDF_1.Size = new System.Drawing.Size(297, 20);
            this.Sav_PDF_1.TabIndex = 18;
            // 
            // Sav_PDF_01
            // 
            this.Sav_PDF_01.AutoSize = true;
            this.Sav_PDF_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sav_PDF_01.Location = new System.Drawing.Point(11, 53);
            this.Sav_PDF_01.Name = "Sav_PDF_01";
            this.Sav_PDF_01.Size = new System.Drawing.Size(15, 14);
            this.Sav_PDF_01.TabIndex = 17;
            this.Sav_PDF_01.UseVisualStyleBackColor = true;
            this.Sav_PDF_01.CheckedChanged += new System.EventHandler(this.Sav_PDF_01_CheckedChanged);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Silver;
            this.panel17.Controls.Add(this.label39);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(610, 32);
            this.panel17.TabIndex = 16;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(277, 4);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(54, 25);
            this.label39.TabIndex = 12;
            this.label39.Text = "PDF";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(37, 91);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(147, 20);
            this.label41.TabIndex = 14;
            this.label41.Text = "PDF\'s das Capas";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(37, 49);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(227, 20);
            this.label42.TabIndex = 13;
            this.label42.Text = "Planilhas do Timbrado / Etc";
            // 
            // panel14
            // 
            this.panel14.Location = new System.Drawing.Point(53, 541);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(610, 31);
            this.panel14.TabIndex = 13;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel13.Controls.Add(this.Sav_Excel_03);
            this.panel13.Controls.Add(this.Sav_Excel_02);
            this.panel13.Controls.Add(this.Sav_Excel_3);
            this.panel13.Controls.Add(this.Sav_Excel_2);
            this.panel13.Controls.Add(this.Sav_Excel_1);
            this.panel13.Controls.Add(this.Sav_Excel_01);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.label38);
            this.panel13.Controls.Add(this.label37);
            this.panel13.Controls.Add(this.label36);
            this.panel13.Location = new System.Drawing.Point(53, 87);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(610, 172);
            this.panel13.TabIndex = 12;
            // 
            // Sav_Excel_03
            // 
            this.Sav_Excel_03.AutoSize = true;
            this.Sav_Excel_03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sav_Excel_03.Location = new System.Drawing.Point(11, 135);
            this.Sav_Excel_03.Name = "Sav_Excel_03";
            this.Sav_Excel_03.Size = new System.Drawing.Size(15, 14);
            this.Sav_Excel_03.TabIndex = 22;
            this.Sav_Excel_03.UseVisualStyleBackColor = true;
            this.Sav_Excel_03.CheckedChanged += new System.EventHandler(this.Sav_Excel_03_CheckedChanged);
            // 
            // Sav_Excel_02
            // 
            this.Sav_Excel_02.AutoSize = true;
            this.Sav_Excel_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sav_Excel_02.Location = new System.Drawing.Point(11, 95);
            this.Sav_Excel_02.Name = "Sav_Excel_02";
            this.Sav_Excel_02.Size = new System.Drawing.Size(15, 14);
            this.Sav_Excel_02.TabIndex = 21;
            this.Sav_Excel_02.UseVisualStyleBackColor = true;
            this.Sav_Excel_02.CheckedChanged += new System.EventHandler(this.Sav_Excel_02_CheckedChanged);
            // 
            // Sav_Excel_3
            // 
            this.Sav_Excel_3.Location = new System.Drawing.Point(306, 132);
            this.Sav_Excel_3.Name = "Sav_Excel_3";
            this.Sav_Excel_3.Size = new System.Drawing.Size(297, 20);
            this.Sav_Excel_3.TabIndex = 20;
            // 
            // Sav_Excel_2
            // 
            this.Sav_Excel_2.Location = new System.Drawing.Point(306, 91);
            this.Sav_Excel_2.Name = "Sav_Excel_2";
            this.Sav_Excel_2.Size = new System.Drawing.Size(297, 20);
            this.Sav_Excel_2.TabIndex = 19;
            // 
            // Sav_Excel_1
            // 
            this.Sav_Excel_1.Location = new System.Drawing.Point(306, 49);
            this.Sav_Excel_1.Name = "Sav_Excel_1";
            this.Sav_Excel_1.Size = new System.Drawing.Size(297, 20);
            this.Sav_Excel_1.TabIndex = 18;
            // 
            // Sav_Excel_01
            // 
            this.Sav_Excel_01.AutoSize = true;
            this.Sav_Excel_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sav_Excel_01.Location = new System.Drawing.Point(11, 53);
            this.Sav_Excel_01.Name = "Sav_Excel_01";
            this.Sav_Excel_01.Size = new System.Drawing.Size(15, 14);
            this.Sav_Excel_01.TabIndex = 17;
            this.Sav_Excel_01.UseVisualStyleBackColor = true;
            this.Sav_Excel_01.CheckedChanged += new System.EventHandler(this.Sav_Excel_01_CheckedChanged);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Silver;
            this.panel15.Controls.Add(this.label35);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(610, 32);
            this.panel15.TabIndex = 16;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(264, 4);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(83, 25);
            this.label35.TabIndex = 12;
            this.label35.Text = "EXCEL";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(37, 130);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(117, 20);
            this.label38.TabIndex = 15;
            this.label38.Text = "Consolidados";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(37, 91);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(251, 20);
            this.label37.TabIndex = 14;
            this.label37.Text = "Comparativo Físico-Financeiro";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(37, 49);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(249, 20);
            this.label36.TabIndex = 13;
            this.label36.Text = "Comparativo de Fornecimento";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem,
            this.salvarToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(3, 3);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(104, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.pDFToolStripMenuItem.Text = "Geral";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Config_Save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1200, 740);
            this.MinimumSize = new System.Drawing.Size(1200, 740);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versão 4.3.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecarregarTab)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BT_Stop_1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.PanelBuscar.ResumeLayout(false);
            this.PanelBuscar.PerformLayout();
            this.PanelConsolidar.ResumeLayout(false);
            this.PanelConsolidar.PerformLayout();
            this.BtFis.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.PanelFiltrar.ResumeLayout(false);
            this.PanelFiltrar.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Config_Save.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.PDF_Config.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Geral_Sav_Bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geral_Reset_Bot)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Capas_Reset_Bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Capas_Sav_Bot)).EndInit();
            this.Salvar_Config.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bot_reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot_sav)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel BtFis;
        private System.Windows.Forms.Button bConsolidado;
        private System.Windows.Forms.Button bArquivo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BoxArea;
        private System.Windows.Forms.Button bDerrubar;
        private System.Windows.Forms.TextBox textFim;
        private System.Windows.Forms.ComboBox BoxTA2;
        private System.Windows.Forms.Button bAplicarInfo;
        private System.Windows.Forms.Label labelCabeçalho2;
        private System.Windows.Forms.TextBox textInicio;
        private System.Windows.Forms.ComboBox BoxTA1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCabeçalho1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox BoxModelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelFiltrar;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bSupTub;
        private System.Windows.Forms.Button bTub;
        private System.Windows.Forms.Button bInst;
        private System.Windows.Forms.Button bMentos;
        private System.Windows.Forms.Button bCBINC;
        private System.Windows.Forms.Button bElet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button botUnificar;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastaDistinoPDFsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelETimbradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unificarPDFsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarPDFsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesclarToolStripMenuItem;
        private System.Windows.Forms.TabControl Config_Save;
        private System.Windows.Forms.Button Bt_Organizar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label LBCataMilho;
        private System.Windows.Forms.Label labelRaiz;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.TextBox PDestinoBox;
        private System.Windows.Forms.TextBox PRaizBox;
        private System.Windows.Forms.PictureBox PB_BT_Stop_1;
        private System.Windows.Forms.Button IniciarCM;
        private System.Windows.Forms.CheckBox Ck_Cm_All;
        private System.Windows.Forms.CheckBox Ck_Cm_Word;
        private System.Windows.Forms.CheckBox Ck_Cm_Excel;
        private System.Windows.Forms.CheckBox Ck_Cm_PDF;
        private System.Windows.Forms.Label label_MT;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton BT_MT_Mover;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RadioButton RB_RA_Nao;
        private System.Windows.Forms.RadioButton RB_RA_Sim;
        private System.Windows.Forms.Label label_Renomear;
        private System.Windows.Forms.RadioButton RB_MT_Copiar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox boxPathOrg;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirDiretórioRaizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoUsarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesSuplementaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarDisciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarunicoToolStripMenuItem;
        private System.Windows.Forms.Panel PanelConsolidar;
        private System.Windows.Forms.ToolStripMenuItem linhasDeCabeçalhoToolStripMenuItem;
        private System.Windows.Forms.Panel PanelBuscar;
        private System.Windows.Forms.RadioButton BtArquivoUnico;
        private System.Windows.Forms.RadioButton BtArquivos;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button BtFornecimento;
        private System.Windows.Forms.Button BtGerarConsolidado;
        private System.Windows.Forms.Button BtFisico;
        private System.Windows.Forms.CheckBox checkFiltrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btBranco;
        private System.Windows.Forms.RadioButton radioArquivo;
        private System.Windows.Forms.RadioButton radioPasta;
        private System.Windows.Forms.ComboBox BoxTimbrado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butExpTemplate;
        private System.Windows.Forms.Button butImpTemplate;
        private System.Windows.Forms.TextBox textBoxEntrega;
        private System.Windows.Forms.TextBox valorDeIndice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBPropComercial;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TBPropTecnica;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TB_Descri;
        private System.Windows.Forms.TextBox TB_Area;
        private System.Windows.Forms.Button BTCapa;
        private System.Windows.Forms.CheckBox ClPropTecnica;
        private System.Windows.Forms.CheckBox ClPropComercial;
        private System.Windows.Forms.TextBox Pathpdfs;
        private System.Windows.Forms.Button genPDF;
        private System.Windows.Forms.Button btTimbrado;
        private System.Windows.Forms.TextBox PathSalvar;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PDF_Config;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ImpressoraBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox TamL_Fornecedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Espa_sub2;
        private System.Windows.Forms.TextBox TamL_Cat;
        private System.Windows.Forms.TextBox Espa_sub1;
        private System.Windows.Forms.TextBox TamL_Sub;
        private System.Windows.Forms.TextBox Espa_Cat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage Salvar_Config;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox bot_reset;
        private System.Windows.Forms.PictureBox bot_sav;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox Sav_PPQ_1;
        private System.Windows.Forms.CheckBox Sav_PPQ_01;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.CheckBox Sav_PDF_02;
        private System.Windows.Forms.TextBox Sav_PDF_2;
        private System.Windows.Forms.TextBox Sav_PDF_1;
        private System.Windows.Forms.CheckBox Sav_PDF_01;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.CheckBox Sav_Excel_03;
        private System.Windows.Forms.CheckBox Sav_Excel_02;
        private System.Windows.Forms.TextBox Sav_Excel_3;
        private System.Windows.Forms.TextBox Sav_Excel_2;
        private System.Windows.Forms.TextBox Sav_Excel_1;
        private System.Windows.Forms.CheckBox Sav_Excel_01;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.PictureBox Geral_Reset_Bot;
        private System.Windows.Forms.PictureBox Geral_Sav_Bot;
        private System.Windows.Forms.PictureBox Capas_Reset_Bot;
        private System.Windows.Forms.PictureBox Capas_Sav_Bot;
        private System.Windows.Forms.ComboBox TemaBox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.CheckBox checkFornecedor;
        private System.Windows.Forms.TextBox Capa_fornecedores;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.CheckBox ClSubCat;
        private System.Windows.Forms.TextBox TxSubCat;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox ModeloVarredura;
        private System.Windows.Forms.RadioButton NewTabelaBt;
        private System.Windows.Forms.RadioButton ATTabelaBt;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox CaminhoVarredura;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox NewTabelaBox;
        private System.Windows.Forms.ComboBox ATTabelaBox;
        private System.Windows.Forms.Button DB_BT;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox DeletarTabelaBox;
        private System.Windows.Forms.RadioButton DeletarTabelabt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox RecarregarTab;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox CaminhoDB;
    }
}

