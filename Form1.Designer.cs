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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Ferr_pag = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Aba_Ferr_01 = new System.Windows.Forms.CheckBox();
            this.Aba_Ferr_02 = new System.Windows.Forms.CheckBox();
            this.Aba_Ferr_03 = new System.Windows.Forms.CheckBox();
            this.Conversor_N = new System.Windows.Forms.Button();
            this.BD_Caminhos = new System.Windows.Forms.Button();
            this.FerrAux_Bt = new System.Windows.Forms.Button();
            this.CataMilho_Bt = new System.Windows.Forms.Button();
            this.panel29 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.DB_Aba = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.RecarregarTab = new System.Windows.Forms.PictureBox();
            this.DeletarTabelaBox = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.DeletarTabelabt = new System.Windows.Forms.RadioButton();
            this.ModeloVarredura = new System.Windows.Forms.ComboBox();
            this.DB_BT = new System.Windows.Forms.Button();
            this.CaminhoVarredura = new System.Windows.Forms.TextBox();
            this.NewTabelaBox = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.ATTabelaBox = new System.Windows.Forms.ComboBox();
            this.ATTabelaBt = new System.Windows.Forms.RadioButton();
            this.NewTabelaBt = new System.Windows.Forms.RadioButton();
            this.CM_Aba = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.RB_RA_Nao = new System.Windows.Forms.RadioButton();
            this.RB_RA_Sim = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.Aux_Aba = new System.Windows.Forms.TabPage();
            this.Unificar_Bt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boxPathOrg = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Bt_Organizar = new System.Windows.Forms.Button();
            this.PDF_Pag = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CK_PDF_01 = new System.Windows.Forms.CheckBox();
            this.CK_PDF_02 = new System.Windows.Forms.CheckBox();
            this.Abrir_out_02 = new System.Windows.Forms.PictureBox();
            this.Timbrao_Bt = new System.Windows.Forms.Button();
            this.PDF_QP_bt = new System.Windows.Forms.Button();
            this.Indice_Bt = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.Timbrado_Pag = new System.Windows.Forms.TabPage();
            this.PathSalvar = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.btBranco = new System.Windows.Forms.Button();
            this.genPDF = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btTimbrado = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Pathpdfs = new System.Windows.Forms.TextBox();
            this.BoxTimbrado = new System.Windows.Forms.ComboBox();
            this.radioPasta = new System.Windows.Forms.RadioButton();
            this.radioArquivo = new System.Windows.Forms.RadioButton();
            this.Indice_Pag = new System.Windows.Forms.TabPage();
            this.CK_Fornecedores = new System.Windows.Forms.RadioButton();
            this.CK_SubCat = new System.Windows.Forms.RadioButton();
            this.CK_Comercial = new System.Windows.Forms.RadioButton();
            this.CK_Tecnica = new System.Windows.Forms.RadioButton();
            this.CK_TC = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_Area = new System.Windows.Forms.TextBox();
            this.TB_Descri = new System.Windows.Forms.TextBox();
            this.BTCapa = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.TBPropTecnica = new System.Windows.Forms.TextBox();
            this.TBPropComercial = new System.Windows.Forms.TextBox();
            this.ClPropTecnica = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ClPropComercial = new System.Windows.Forms.CheckBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Container_01 = new System.Windows.Forms.TabControl();
            this.Excel_Pag = new System.Windows.Forms.TabPage();
            this.panel28 = new System.Windows.Forms.Panel();
            this.Container2 = new System.Windows.Forms.TabControl();
            this.Fornecimento_tab = new System.Windows.Forms.TabPage();
            this.Fisico_Bt = new System.Windows.Forms.Button();
            this.Bt_Fornecimento = new System.Windows.Forms.Button();
            this.R_Arquivos = new System.Windows.Forms.RadioButton();
            this.R_Unico = new System.Windows.Forms.RadioButton();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.area_box = new System.Windows.Forms.ComboBox();
            this.TA2_Box = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.TA1_Box = new System.Windows.Forms.ComboBox();
            this.Consolidar_Tab = new System.Windows.Forms.TabPage();
            this.TA2_Box2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TA1_Box2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Delimitador_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Box_Nomear = new System.Windows.Forms.TextBox();
            this.boxAbaCSD = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textFim = new System.Windows.Forms.TextBox();
            this.textInicio = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.BoxModelo = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.Servi_Tab = new System.Windows.Forms.TabPage();
            this.Criar_PPQ_Bt = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.valorDeIndice = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBoxEntrega = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.Comparativos_aba = new System.Windows.Forms.CheckBox();
            this.Consolidar_Aba = new System.Windows.Forms.CheckBox();
            this.Abrir_out_01 = new System.Windows.Forms.PictureBox();
            this.Servi_Aba = new System.Windows.Forms.CheckBox();
            this.Mont_Aba = new System.Windows.Forms.CheckBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Config_pag = new System.Windows.Forms.TabPage();
            this.panel26 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Geral_Aba = new System.Windows.Forms.TabPage();
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
            this.Salvar_Aba = new System.Windows.Forms.TabPage();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Config_Aba_01 = new System.Windows.Forms.CheckBox();
            this.Config_Aba_02 = new System.Windows.Forms.CheckBox();
            this.Geral_Bt = new System.Windows.Forms.Button();
            this.Salvar_Bt = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Aba_Config = new System.Windows.Forms.Button();
            this.Aba_Ferramentas = new System.Windows.Forms.Button();
            this.Aba_Excel = new System.Windows.Forms.Button();
            this.Aba_PDF = new System.Windows.Forms.Button();
            this.PCP_01 = new System.Windows.Forms.CheckBox();
            this.PCP_02 = new System.Windows.Forms.CheckBox();
            this.PCP_04 = new System.Windows.Forms.CheckBox();
            this.PCP_03 = new System.Windows.Forms.CheckBox();
            this.panel25 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.Ferr_pag.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel29.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.DB_Aba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecarregarTab)).BeginInit();
            this.CM_Aba.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BT_Stop_1)).BeginInit();
            this.Aux_Aba.SuspendLayout();
            this.PDF_Pag.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Abrir_out_02)).BeginInit();
            this.panel7.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.Timbrado_Pag.SuspendLayout();
            this.Indice_Pag.SuspendLayout();
            this.Container_01.SuspendLayout();
            this.Excel_Pag.SuspendLayout();
            this.panel28.SuspendLayout();
            this.Container2.SuspendLayout();
            this.Fornecimento_tab.SuspendLayout();
            this.Consolidar_Tab.SuspendLayout();
            this.Criar_PPQ_Bt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Abrir_out_01)).BeginInit();
            this.Config_pag.SuspendLayout();
            this.panel26.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Geral_Aba.SuspendLayout();
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
            this.Salvar_Aba.SuspendLayout();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel25.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(966, 32);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(1028, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Ferr_pag
            // 
            this.Ferr_pag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(99)))));
            this.Ferr_pag.Controls.Add(this.panel8);
            this.Ferr_pag.Controls.Add(this.panel29);
            this.Ferr_pag.Location = new System.Drawing.Point(4, 22);
            this.Ferr_pag.Name = "Ferr_pag";
            this.Ferr_pag.Padding = new System.Windows.Forms.Padding(3);
            this.Ferr_pag.Size = new System.Drawing.Size(1092, 474);
            this.Ferr_pag.TabIndex = 3;
            this.Ferr_pag.Text = "Ferramentas";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.panel8.Controls.Add(this.Aba_Ferr_01);
            this.panel8.Controls.Add(this.Aba_Ferr_02);
            this.panel8.Controls.Add(this.Aba_Ferr_03);
            this.panel8.Controls.Add(this.Conversor_N);
            this.panel8.Controls.Add(this.BD_Caminhos);
            this.panel8.Controls.Add(this.FerrAux_Bt);
            this.panel8.Controls.Add(this.CataMilho_Bt);
            this.panel8.Location = new System.Drawing.Point(19, 16);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(161, 440);
            this.panel8.TabIndex = 11;
            // 
            // Aba_Ferr_01
            // 
            this.Aba_Ferr_01.AutoSize = true;
            this.Aba_Ferr_01.Location = new System.Drawing.Point(5, 36);
            this.Aba_Ferr_01.Name = "Aba_Ferr_01";
            this.Aba_Ferr_01.Size = new System.Drawing.Size(15, 14);
            this.Aba_Ferr_01.TabIndex = 20;
            this.Aba_Ferr_01.UseVisualStyleBackColor = true;
            this.Aba_Ferr_01.Visible = false;
            this.Aba_Ferr_01.CheckedChanged += new System.EventHandler(this.Aba_Ferr_01_CheckedChanged);
            // 
            // Aba_Ferr_02
            // 
            this.Aba_Ferr_02.AutoSize = true;
            this.Aba_Ferr_02.Location = new System.Drawing.Point(5, 84);
            this.Aba_Ferr_02.Name = "Aba_Ferr_02";
            this.Aba_Ferr_02.Size = new System.Drawing.Size(15, 14);
            this.Aba_Ferr_02.TabIndex = 19;
            this.Aba_Ferr_02.UseVisualStyleBackColor = true;
            this.Aba_Ferr_02.Visible = false;
            this.Aba_Ferr_02.CheckedChanged += new System.EventHandler(this.Aba_Ferr_02_CheckedChanged);
            // 
            // Aba_Ferr_03
            // 
            this.Aba_Ferr_03.AutoSize = true;
            this.Aba_Ferr_03.Location = new System.Drawing.Point(5, 133);
            this.Aba_Ferr_03.Name = "Aba_Ferr_03";
            this.Aba_Ferr_03.Size = new System.Drawing.Size(15, 14);
            this.Aba_Ferr_03.TabIndex = 18;
            this.Aba_Ferr_03.UseVisualStyleBackColor = true;
            this.Aba_Ferr_03.Visible = false;
            this.Aba_Ferr_03.CheckedChanged += new System.EventHandler(this.Aba_Ferr_03_CheckedChanged);
            // 
            // Conversor_N
            // 
            this.Conversor_N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Conversor_N.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Conversor_N.FlatAppearance.BorderSize = 0;
            this.Conversor_N.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Conversor_N.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conversor_N.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Conversor_N.Location = new System.Drawing.Point(26, 170);
            this.Conversor_N.Name = "Conversor_N";
            this.Conversor_N.Size = new System.Drawing.Size(108, 38);
            this.Conversor_N.TabIndex = 5;
            this.Conversor_N.Text = "PopUp: Número Por Extenso";
            this.Conversor_N.UseVisualStyleBackColor = false;
            this.Conversor_N.Click += new System.EventHandler(this.Conversor_N_Click);
            // 
            // BD_Caminhos
            // 
            this.BD_Caminhos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.BD_Caminhos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BD_Caminhos.FlatAppearance.BorderSize = 0;
            this.BD_Caminhos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BD_Caminhos.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BD_Caminhos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BD_Caminhos.Location = new System.Drawing.Point(26, 23);
            this.BD_Caminhos.Name = "BD_Caminhos";
            this.BD_Caminhos.Size = new System.Drawing.Size(108, 38);
            this.BD_Caminhos.TabIndex = 4;
            this.BD_Caminhos.Text = "Bancos de Dados Para Caminhos";
            this.BD_Caminhos.UseVisualStyleBackColor = false;
            this.BD_Caminhos.Click += new System.EventHandler(this.BD_Caminhos_Click);
            // 
            // FerrAux_Bt
            // 
            this.FerrAux_Bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.FerrAux_Bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FerrAux_Bt.FlatAppearance.BorderSize = 0;
            this.FerrAux_Bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FerrAux_Bt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FerrAux_Bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FerrAux_Bt.Location = new System.Drawing.Point(26, 120);
            this.FerrAux_Bt.Name = "FerrAux_Bt";
            this.FerrAux_Bt.Size = new System.Drawing.Size(108, 38);
            this.FerrAux_Bt.TabIndex = 2;
            this.FerrAux_Bt.Text = "Ferramentas Auxiliares";
            this.FerrAux_Bt.UseVisualStyleBackColor = false;
            this.FerrAux_Bt.Click += new System.EventHandler(this.FerrAux_Bt_Click);
            // 
            // CataMilho_Bt
            // 
            this.CataMilho_Bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.CataMilho_Bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CataMilho_Bt.Enabled = false;
            this.CataMilho_Bt.FlatAppearance.BorderSize = 0;
            this.CataMilho_Bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CataMilho_Bt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CataMilho_Bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CataMilho_Bt.Location = new System.Drawing.Point(26, 71);
            this.CataMilho_Bt.Name = "CataMilho_Bt";
            this.CataMilho_Bt.Size = new System.Drawing.Size(108, 38);
            this.CataMilho_Bt.TabIndex = 1;
            this.CataMilho_Bt.Text = "Cata Milho";
            this.CataMilho_Bt.UseVisualStyleBackColor = false;
            this.CataMilho_Bt.Click += new System.EventHandler(this.CataMilho_Bt_Click);
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.tabControl2);
            this.panel29.Location = new System.Drawing.Point(270, 46);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(730, 383);
            this.panel29.TabIndex = 12;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.DB_Aba);
            this.tabControl2.Controls.Add(this.CM_Aba);
            this.tabControl2.Controls.Add(this.Aux_Aba);
            this.tabControl2.Location = new System.Drawing.Point(-4, -22);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(738, 409);
            this.tabControl2.TabIndex = 0;
            // 
            // DB_Aba
            // 
            this.DB_Aba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.DB_Aba.Controls.Add(this.label9);
            this.DB_Aba.Controls.Add(this.RecarregarTab);
            this.DB_Aba.Controls.Add(this.DeletarTabelaBox);
            this.DB_Aba.Controls.Add(this.label43);
            this.DB_Aba.Controls.Add(this.DeletarTabelabt);
            this.DB_Aba.Controls.Add(this.ModeloVarredura);
            this.DB_Aba.Controls.Add(this.DB_BT);
            this.DB_Aba.Controls.Add(this.CaminhoVarredura);
            this.DB_Aba.Controls.Add(this.NewTabelaBox);
            this.DB_Aba.Controls.Add(this.label45);
            this.DB_Aba.Controls.Add(this.ATTabelaBox);
            this.DB_Aba.Controls.Add(this.ATTabelaBt);
            this.DB_Aba.Controls.Add(this.NewTabelaBt);
            this.DB_Aba.Location = new System.Drawing.Point(4, 22);
            this.DB_Aba.Name = "DB_Aba";
            this.DB_Aba.Padding = new System.Windows.Forms.Padding(3);
            this.DB_Aba.Size = new System.Drawing.Size(730, 383);
            this.DB_Aba.TabIndex = 0;
            this.DB_Aba.Text = "tabPage1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(224, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(290, 40);
            this.label9.TabIndex = 30;
            this.label9.Text = "BANCOS DE DADOS";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label9, "Ferramenta para transferir arquivos de um diretório para outro");
            // 
            // RecarregarTab
            // 
            this.RecarregarTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecarregarTab.Image = ((System.Drawing.Image)(resources.GetObject("RecarregarTab.Image")));
            this.RecarregarTab.Location = new System.Drawing.Point(652, 25);
            this.RecarregarTab.Name = "RecarregarTab";
            this.RecarregarTab.Size = new System.Drawing.Size(30, 31);
            this.RecarregarTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RecarregarTab.TabIndex = 29;
            this.RecarregarTab.TabStop = false;
            this.RecarregarTab.Click += new System.EventHandler(this.RecarregarTab_Click);
            // 
            // DeletarTabelaBox
            // 
            this.DeletarTabelaBox.BackColor = System.Drawing.Color.White;
            this.DeletarTabelaBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.DeletarTabelaBox.FormattingEnabled = true;
            this.DeletarTabelaBox.Location = new System.Drawing.Point(369, 259);
            this.DeletarTabelaBox.Name = "DeletarTabelaBox";
            this.DeletarTabelaBox.Size = new System.Drawing.Size(161, 21);
            this.DeletarTabelaBox.TabIndex = 28;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label43.Location = new System.Drawing.Point(190, 89);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(194, 25);
            this.label43.TabIndex = 19;
            this.label43.Text = "Modelo de Varredura";
            this.label43.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeletarTabelabt
            // 
            this.DeletarTabelabt.AutoSize = true;
            this.DeletarTabelabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletarTabelabt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletarTabelabt.ForeColor = System.Drawing.Color.White;
            this.DeletarTabelabt.Location = new System.Drawing.Point(189, 255);
            this.DeletarTabelabt.Name = "DeletarTabelabt";
            this.DeletarTabelabt.Size = new System.Drawing.Size(158, 29);
            this.DeletarTabelabt.TabIndex = 27;
            this.DeletarTabelabt.TabStop = true;
            this.DeletarTabelabt.Text = "Deletar Tabela";
            this.DeletarTabelabt.UseVisualStyleBackColor = true;
            this.DeletarTabelabt.CheckedChanged += new System.EventHandler(this.DeletarTabelabt_CheckedChanged);
            // 
            // ModeloVarredura
            // 
            this.ModeloVarredura.FormattingEnabled = true;
            this.ModeloVarredura.Location = new System.Drawing.Point(408, 94);
            this.ModeloVarredura.Name = "ModeloVarredura";
            this.ModeloVarredura.Size = new System.Drawing.Size(121, 21);
            this.ModeloVarredura.TabIndex = 9;
            // 
            // DB_BT
            // 
            this.DB_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.DB_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DB_BT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.DB_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DB_BT.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_BT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DB_BT.Location = new System.Drawing.Point(303, 318);
            this.DB_BT.Name = "DB_BT";
            this.DB_BT.Size = new System.Drawing.Size(133, 34);
            this.DB_BT.TabIndex = 26;
            this.DB_BT.Text = "Iniciar";
            this.DB_BT.UseVisualStyleBackColor = false;
            this.DB_BT.Click += new System.EventHandler(this.DB_BT_Click);
            // 
            // CaminhoVarredura
            // 
            this.CaminhoVarredura.Location = new System.Drawing.Point(313, 134);
            this.CaminhoVarredura.Name = "CaminhoVarredura";
            this.CaminhoVarredura.Size = new System.Drawing.Size(216, 20);
            this.CaminhoVarredura.TabIndex = 20;
            // 
            // NewTabelaBox
            // 
            this.NewTabelaBox.Location = new System.Drawing.Point(369, 217);
            this.NewTabelaBox.Name = "NewTabelaBox";
            this.NewTabelaBox.Size = new System.Drawing.Size(161, 20);
            this.NewTabelaBox.TabIndex = 25;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label45.Location = new System.Drawing.Point(190, 131);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(90, 25);
            this.label45.TabIndex = 21;
            this.label45.Text = "Caminho";
            this.label45.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label45, "Este é um label informativo.");
            // 
            // ATTabelaBox
            // 
            this.ATTabelaBox.FormattingEnabled = true;
            this.ATTabelaBox.Location = new System.Drawing.Point(369, 176);
            this.ATTabelaBox.Name = "ATTabelaBox";
            this.ATTabelaBox.Size = new System.Drawing.Size(161, 21);
            this.ATTabelaBox.TabIndex = 24;
            // 
            // ATTabelaBt
            // 
            this.ATTabelaBt.AutoSize = true;
            this.ATTabelaBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ATTabelaBt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATTabelaBt.ForeColor = System.Drawing.Color.White;
            this.ATTabelaBt.Location = new System.Drawing.Point(189, 170);
            this.ATTabelaBt.Name = "ATTabelaBt";
            this.ATTabelaBt.Size = new System.Drawing.Size(173, 29);
            this.ATTabelaBt.TabIndex = 22;
            this.ATTabelaBt.TabStop = true;
            this.ATTabelaBt.Text = "Atualizar Tabela";
            this.ATTabelaBt.UseVisualStyleBackColor = true;
            // 
            // NewTabelaBt
            // 
            this.NewTabelaBt.AutoSize = true;
            this.NewTabelaBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewTabelaBt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTabelaBt.ForeColor = System.Drawing.Color.White;
            this.NewTabelaBt.Location = new System.Drawing.Point(189, 212);
            this.NewTabelaBt.Name = "NewTabelaBt";
            this.NewTabelaBt.Size = new System.Drawing.Size(141, 29);
            this.NewTabelaBt.TabIndex = 23;
            this.NewTabelaBt.TabStop = true;
            this.NewTabelaBt.Text = "Nova Tabela";
            this.NewTabelaBt.UseVisualStyleBackColor = true;
            // 
            // CM_Aba
            // 
            this.CM_Aba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.CM_Aba.Controls.Add(this.panel11);
            this.CM_Aba.Controls.Add(this.textBox1);
            this.CM_Aba.Controls.Add(this.checkBox1);
            this.CM_Aba.Controls.Add(this.label_Renomear);
            this.CM_Aba.Controls.Add(this.panel10);
            this.CM_Aba.Controls.Add(this.label_MT);
            this.CM_Aba.Controls.Add(this.Ck_Cm_All);
            this.CM_Aba.Controls.Add(this.Ck_Cm_Word);
            this.CM_Aba.Controls.Add(this.Ck_Cm_Excel);
            this.CM_Aba.Controls.Add(this.Ck_Cm_PDF);
            this.CM_Aba.Controls.Add(this.IniciarCM);
            this.CM_Aba.Controls.Add(this.PB_BT_Stop_1);
            this.CM_Aba.Controls.Add(this.PDestinoBox);
            this.CM_Aba.Controls.Add(this.PRaizBox);
            this.CM_Aba.Controls.Add(this.labelDestino);
            this.CM_Aba.Controls.Add(this.labelRaiz);
            this.CM_Aba.Controls.Add(this.LBCataMilho);
            this.CM_Aba.Location = new System.Drawing.Point(4, 22);
            this.CM_Aba.Name = "CM_Aba";
            this.CM_Aba.Padding = new System.Windows.Forms.Padding(3);
            this.CM_Aba.Size = new System.Drawing.Size(730, 383);
            this.CM_Aba.TabIndex = 1;
            this.CM_Aba.Text = "tabPage2";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.RB_RA_Nao);
            this.panel11.Controls.Add(this.RB_RA_Sim);
            this.panel11.ForeColor = System.Drawing.Color.Transparent;
            this.panel11.Location = new System.Drawing.Point(375, 112);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(184, 32);
            this.panel11.TabIndex = 40;
            // 
            // RB_RA_Nao
            // 
            this.RB_RA_Nao.AutoSize = true;
            this.RB_RA_Nao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_RA_Nao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_RA_Nao.ForeColor = System.Drawing.Color.White;
            this.RB_RA_Nao.Location = new System.Drawing.Point(104, 3);
            this.RB_RA_Nao.Name = "RB_RA_Nao";
            this.RB_RA_Nao.Size = new System.Drawing.Size(58, 25);
            this.RB_RA_Nao.TabIndex = 1;
            this.RB_RA_Nao.TabStop = true;
            this.RB_RA_Nao.Text = "Não";
            this.RB_RA_Nao.UseVisualStyleBackColor = true;
            // 
            // RB_RA_Sim
            // 
            this.RB_RA_Sim.AutoSize = true;
            this.RB_RA_Sim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_RA_Sim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_RA_Sim.ForeColor = System.Drawing.Color.White;
            this.RB_RA_Sim.Location = new System.Drawing.Point(16, 3);
            this.RB_RA_Sim.Name = "RB_RA_Sim";
            this.RB_RA_Sim.Size = new System.Drawing.Size(55, 25);
            this.RB_RA_Sim.TabIndex = 0;
            this.RB_RA_Sim.TabStop = true;
            this.RB_RA_Sim.Text = "Sim";
            this.RB_RA_Sim.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(376, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 22);
            this.textBox1.TabIndex = 39;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(175, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(214, 25);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "Buscar Por Palavra Chave";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label_Renomear
            // 
            this.label_Renomear.AutoSize = true;
            this.label_Renomear.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Renomear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Renomear.Location = new System.Drawing.Point(174, 116);
            this.label_Renomear.Name = "label_Renomear";
            this.label_Renomear.Size = new System.Drawing.Size(195, 25);
            this.label_Renomear.TabIndex = 37;
            this.label_Renomear.Text = "Renomear Arquivos ?";
            this.label_Renomear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.RB_MT_Copiar);
            this.panel10.Controls.Add(this.BT_MT_Mover);
            this.panel10.ForeColor = System.Drawing.Color.Transparent;
            this.panel10.Location = new System.Drawing.Point(375, 74);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(184, 32);
            this.panel10.TabIndex = 36;
            // 
            // RB_MT_Copiar
            // 
            this.RB_MT_Copiar.AutoSize = true;
            this.RB_MT_Copiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_MT_Copiar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_MT_Copiar.ForeColor = System.Drawing.Color.White;
            this.RB_MT_Copiar.Location = new System.Drawing.Point(104, 3);
            this.RB_MT_Copiar.Name = "RB_MT_Copiar";
            this.RB_MT_Copiar.Size = new System.Drawing.Size(76, 25);
            this.RB_MT_Copiar.TabIndex = 1;
            this.RB_MT_Copiar.TabStop = true;
            this.RB_MT_Copiar.Text = "Copiar";
            this.RB_MT_Copiar.UseVisualStyleBackColor = true;
            // 
            // BT_MT_Mover
            // 
            this.BT_MT_Mover.AutoSize = true;
            this.BT_MT_Mover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_MT_Mover.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_MT_Mover.ForeColor = System.Drawing.Color.White;
            this.BT_MT_Mover.Location = new System.Drawing.Point(16, 3);
            this.BT_MT_Mover.Name = "BT_MT_Mover";
            this.BT_MT_Mover.Size = new System.Drawing.Size(73, 25);
            this.BT_MT_Mover.TabIndex = 0;
            this.BT_MT_Mover.TabStop = true;
            this.BT_MT_Mover.Text = "Mover";
            this.BT_MT_Mover.UseVisualStyleBackColor = true;
            // 
            // label_MT
            // 
            this.label_MT.AutoSize = true;
            this.label_MT.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_MT.Location = new System.Drawing.Point(174, 76);
            this.label_MT.Name = "label_MT";
            this.label_MT.Size = new System.Drawing.Size(205, 25);
            this.label_MT.TabIndex = 35;
            this.label_MT.Text = "Modo de transferência";
            this.label_MT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ck_Cm_All
            // 
            this.Ck_Cm_All.AutoSize = true;
            this.Ck_Cm_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ck_Cm_All.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Cm_All.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ck_Cm_All.Location = new System.Drawing.Point(419, 205);
            this.Ck_Cm_All.Name = "Ck_Cm_All";
            this.Ck_Cm_All.Size = new System.Drawing.Size(160, 25);
            this.Ck_Cm_All.TabIndex = 34;
            this.Ck_Cm_All.Text = "Todos os Arquivos";
            this.Ck_Cm_All.UseVisualStyleBackColor = true;
            // 
            // Ck_Cm_Word
            // 
            this.Ck_Cm_Word.AutoSize = true;
            this.Ck_Cm_Word.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ck_Cm_Word.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Cm_Word.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ck_Cm_Word.Location = new System.Drawing.Point(331, 205);
            this.Ck_Cm_Word.Name = "Ck_Cm_Word";
            this.Ck_Cm_Word.Size = new System.Drawing.Size(68, 25);
            this.Ck_Cm_Word.TabIndex = 33;
            this.Ck_Cm_Word.Text = "Word";
            this.Ck_Cm_Word.UseVisualStyleBackColor = true;
            // 
            // Ck_Cm_Excel
            // 
            this.Ck_Cm_Excel.AutoSize = true;
            this.Ck_Cm_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ck_Cm_Excel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Cm_Excel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ck_Cm_Excel.Location = new System.Drawing.Point(243, 205);
            this.Ck_Cm_Excel.Name = "Ck_Cm_Excel";
            this.Ck_Cm_Excel.Size = new System.Drawing.Size(65, 25);
            this.Ck_Cm_Excel.TabIndex = 32;
            this.Ck_Cm_Excel.Text = "Excel";
            this.Ck_Cm_Excel.UseVisualStyleBackColor = true;
            // 
            // Ck_Cm_PDF
            // 
            this.Ck_Cm_PDF.AutoSize = true;
            this.Ck_Cm_PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ck_Cm_PDF.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Cm_PDF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ck_Cm_PDF.Location = new System.Drawing.Point(163, 205);
            this.Ck_Cm_PDF.Name = "Ck_Cm_PDF";
            this.Ck_Cm_PDF.Size = new System.Drawing.Size(59, 25);
            this.Ck_Cm_PDF.TabIndex = 31;
            this.Ck_Cm_PDF.Text = "PDF";
            this.Ck_Cm_PDF.UseVisualStyleBackColor = true;
            // 
            // IniciarCM
            // 
            this.IniciarCM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.IniciarCM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarCM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.IniciarCM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IniciarCM.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarCM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IniciarCM.Location = new System.Drawing.Point(303, 332);
            this.IniciarCM.Name = "IniciarCM";
            this.IniciarCM.Size = new System.Drawing.Size(133, 34);
            this.IniciarCM.TabIndex = 30;
            this.IniciarCM.Text = "Iniciar";
            this.IniciarCM.UseVisualStyleBackColor = false;
            // 
            // PB_BT_Stop_1
            // 
            this.PB_BT_Stop_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_BT_Stop_1.Image = ((System.Drawing.Image)(resources.GetObject("PB_BT_Stop_1.Image")));
            this.PB_BT_Stop_1.Location = new System.Drawing.Point(667, 10);
            this.PB_BT_Stop_1.Name = "PB_BT_Stop_1";
            this.PB_BT_Stop_1.Size = new System.Drawing.Size(48, 32);
            this.PB_BT_Stop_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_BT_Stop_1.TabIndex = 29;
            this.PB_BT_Stop_1.TabStop = false;
            // 
            // PDestinoBox
            // 
            this.PDestinoBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDestinoBox.Location = new System.Drawing.Point(304, 290);
            this.PDestinoBox.Name = "PDestinoBox";
            this.PDestinoBox.Size = new System.Drawing.Size(248, 22);
            this.PDestinoBox.TabIndex = 28;
            // 
            // PRaizBox
            // 
            this.PRaizBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRaizBox.Location = new System.Drawing.Point(304, 250);
            this.PRaizBox.Name = "PRaizBox";
            this.PRaizBox.Size = new System.Drawing.Size(248, 22);
            this.PRaizBox.TabIndex = 27;
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDestino.Location = new System.Drawing.Point(175, 286);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(131, 25);
            this.labelDestino.TabIndex = 26;
            this.labelDestino.Text = "Pasta Destino";
            this.labelDestino.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.labelDestino, "Este é um label informativo.");
            // 
            // labelRaiz
            // 
            this.labelRaiz.AutoSize = true;
            this.labelRaiz.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaiz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRaiz.Location = new System.Drawing.Point(175, 246);
            this.labelRaiz.Name = "labelRaiz";
            this.labelRaiz.Size = new System.Drawing.Size(102, 25);
            this.labelRaiz.TabIndex = 25;
            this.labelRaiz.Text = "Pasta Raiz";
            this.labelRaiz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.labelRaiz, "Este é um label informativo.");
            // 
            // LBCataMilho
            // 
            this.LBCataMilho.AutoSize = true;
            this.LBCataMilho.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCataMilho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBCataMilho.Location = new System.Drawing.Point(180, 13);
            this.LBCataMilho.Name = "LBCataMilho";
            this.LBCataMilho.Size = new System.Drawing.Size(379, 40);
            this.LBCataMilho.TabIndex = 24;
            this.LBCataMilho.Text = "TRANSFERÊNCIA DE ITENS";
            this.LBCataMilho.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.LBCataMilho, "Ferramenta para transferir arquivos de um diretório para outro");
            // 
            // Aux_Aba
            // 
            this.Aux_Aba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.Aux_Aba.Controls.Add(this.Unificar_Bt);
            this.Aux_Aba.Controls.Add(this.panel1);
            this.Aux_Aba.Controls.Add(this.panel9);
            this.Aux_Aba.Controls.Add(this.textBox2);
            this.Aux_Aba.Controls.Add(this.label18);
            this.Aux_Aba.Controls.Add(this.label8);
            this.Aux_Aba.Controls.Add(this.boxPathOrg);
            this.Aux_Aba.Controls.Add(this.panel12);
            this.Aux_Aba.Controls.Add(this.radioButton2);
            this.Aux_Aba.Controls.Add(this.radioButton1);
            this.Aux_Aba.Controls.Add(this.label7);
            this.Aux_Aba.Controls.Add(this.Bt_Organizar);
            this.Aux_Aba.Location = new System.Drawing.Point(4, 22);
            this.Aux_Aba.Name = "Aux_Aba";
            this.Aux_Aba.Padding = new System.Windows.Forms.Padding(3);
            this.Aux_Aba.Size = new System.Drawing.Size(730, 383);
            this.Aux_Aba.TabIndex = 2;
            this.Aux_Aba.Text = "tabPage5";
            // 
            // Unificar_Bt
            // 
            this.Unificar_Bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Unificar_Bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Unificar_Bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.Unificar_Bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Unificar_Bt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unificar_Bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Unificar_Bt.Location = new System.Drawing.Point(74, 342);
            this.Unificar_Bt.Name = "Unificar_Bt";
            this.Unificar_Bt.Size = new System.Drawing.Size(108, 26);
            this.Unificar_Bt.TabIndex = 14;
            this.Unificar_Bt.Text = "INICIAR";
            this.Unificar_Bt.UseVisualStyleBackColor = false;
            this.Unificar_Bt.Click += new System.EventHandler(this.Unificar_Bt_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(263, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 155);
            this.panel1.TabIndex = 27;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(0, 219);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(263, 1);
            this.panel9.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 302);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(22, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 30);
            this.label18.TabIndex = 25;
            this.label18.Text = "Path";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(46, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 30);
            this.label8.TabIndex = 5;
            this.label8.Text = "UNIFICAR PDF\'s";
            // 
            // boxPathOrg
            // 
            this.boxPathOrg.Location = new System.Drawing.Point(86, 121);
            this.boxPathOrg.Name = "boxPathOrg";
            this.boxPathOrg.Size = new System.Drawing.Size(152, 20);
            this.boxPathOrg.TabIndex = 24;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(263, 1);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 224);
            this.panel12.TabIndex = 7;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton2.Location = new System.Drawing.Point(120, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(131, 25);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Personalizado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton1.Location = new System.Drawing.Point(24, 79);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 25);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Padrão";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(42, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ordenar Pastas TA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label7, "Ferramenta para transferir arquivos de um diretório para outro");
            // 
            // Bt_Organizar
            // 
            this.Bt_Organizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Bt_Organizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Organizar.FlatAppearance.BorderSize = 0;
            this.Bt_Organizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.Bt_Organizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Organizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Organizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bt_Organizar.Location = new System.Drawing.Point(74, 162);
            this.Bt_Organizar.Name = "Bt_Organizar";
            this.Bt_Organizar.Size = new System.Drawing.Size(108, 26);
            this.Bt_Organizar.TabIndex = 7;
            this.Bt_Organizar.Text = "Organizar";
            this.Bt_Organizar.UseVisualStyleBackColor = false;
            this.Bt_Organizar.Click += new System.EventHandler(this.Bt_Organizar_Click_1);
            // 
            // PDF_Pag
            // 
            this.PDF_Pag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(99)))));
            this.PDF_Pag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PDF_Pag.Controls.Add(this.panel4);
            this.PDF_Pag.Controls.Add(this.panel7);
            this.PDF_Pag.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.PDF_Pag.Location = new System.Drawing.Point(4, 22);
            this.PDF_Pag.Name = "PDF_Pag";
            this.PDF_Pag.Padding = new System.Windows.Forms.Padding(3);
            this.PDF_Pag.Size = new System.Drawing.Size(1092, 474);
            this.PDF_Pag.TabIndex = 0;
            this.PDF_Pag.Text = "PDF";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.CK_PDF_01);
            this.panel4.Controls.Add(this.CK_PDF_02);
            this.panel4.Controls.Add(this.Abrir_out_02);
            this.panel4.Controls.Add(this.Timbrao_Bt);
            this.panel4.Controls.Add(this.PDF_QP_bt);
            this.panel4.Controls.Add(this.Indice_Bt);
            this.panel4.Location = new System.Drawing.Point(19, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 440);
            this.panel4.TabIndex = 10;
            // 
            // CK_PDF_01
            // 
            this.CK_PDF_01.AutoSize = true;
            this.CK_PDF_01.Location = new System.Drawing.Point(5, 36);
            this.CK_PDF_01.Name = "CK_PDF_01";
            this.CK_PDF_01.Size = new System.Drawing.Size(15, 14);
            this.CK_PDF_01.TabIndex = 20;
            this.CK_PDF_01.UseVisualStyleBackColor = true;
            this.CK_PDF_01.Visible = false;
            this.CK_PDF_01.CheckedChanged += new System.EventHandler(this.CK_PDF_01_CheckedChanged);
            // 
            // CK_PDF_02
            // 
            this.CK_PDF_02.AutoSize = true;
            this.CK_PDF_02.Location = new System.Drawing.Point(5, 84);
            this.CK_PDF_02.Name = "CK_PDF_02";
            this.CK_PDF_02.Size = new System.Drawing.Size(15, 14);
            this.CK_PDF_02.TabIndex = 19;
            this.CK_PDF_02.UseVisualStyleBackColor = true;
            this.CK_PDF_02.Visible = false;
            this.CK_PDF_02.CheckedChanged += new System.EventHandler(this.CK_PDF_02_CheckedChanged);
            // 
            // Abrir_out_02
            // 
            this.Abrir_out_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Abrir_out_02.Image = ((System.Drawing.Image)(resources.GetObject("Abrir_out_02.Image")));
            this.Abrir_out_02.Location = new System.Drawing.Point(123, 401);
            this.Abrir_out_02.Name = "Abrir_out_02";
            this.Abrir_out_02.Size = new System.Drawing.Size(30, 31);
            this.Abrir_out_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Abrir_out_02.TabIndex = 21;
            this.Abrir_out_02.TabStop = false;
            this.Abrir_out_02.Click += new System.EventHandler(this.Abrir_out_02_Click);
            // 
            // Timbrao_Bt
            // 
            this.Timbrao_Bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Timbrao_Bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Timbrao_Bt.FlatAppearance.BorderSize = 0;
            this.Timbrao_Bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Timbrao_Bt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timbrao_Bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Timbrao_Bt.Location = new System.Drawing.Point(26, 23);
            this.Timbrao_Bt.Name = "Timbrao_Bt";
            this.Timbrao_Bt.Size = new System.Drawing.Size(108, 38);
            this.Timbrao_Bt.TabIndex = 4;
            this.Timbrao_Bt.Text = "Timbrado";
            this.Timbrao_Bt.UseVisualStyleBackColor = false;
            this.Timbrao_Bt.Click += new System.EventHandler(this.Timbrao_Bt_Click);
            // 
            // PDF_QP_bt
            // 
            this.PDF_QP_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.PDF_QP_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PDF_QP_bt.FlatAppearance.BorderSize = 0;
            this.PDF_QP_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PDF_QP_bt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDF_QP_bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PDF_QP_bt.Location = new System.Drawing.Point(26, 120);
            this.PDF_QP_bt.Name = "PDF_QP_bt";
            this.PDF_QP_bt.Size = new System.Drawing.Size(108, 38);
            this.PDF_QP_bt.TabIndex = 2;
            this.PDF_QP_bt.Text = "PDF Easy";
            this.PDF_QP_bt.UseVisualStyleBackColor = false;
            this.PDF_QP_bt.Click += new System.EventHandler(this.PDF_QP_bt_Click);
            // 
            // Indice_Bt
            // 
            this.Indice_Bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Indice_Bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Indice_Bt.FlatAppearance.BorderSize = 0;
            this.Indice_Bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Indice_Bt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indice_Bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Indice_Bt.Location = new System.Drawing.Point(26, 71);
            this.Indice_Bt.Name = "Indice_Bt";
            this.Indice_Bt.Size = new System.Drawing.Size(108, 38);
            this.Indice_Bt.TabIndex = 1;
            this.Indice_Bt.Text = "Índices Book";
            this.Indice_Bt.UseVisualStyleBackColor = false;
            this.Indice_Bt.Click += new System.EventHandler(this.Indice_Bt_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tabControl3);
            this.panel7.Location = new System.Drawing.Point(270, 46);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(730, 383);
            this.panel7.TabIndex = 11;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.Timbrado_Pag);
            this.tabControl3.Controls.Add(this.Indice_Pag);
            this.tabControl3.Location = new System.Drawing.Point(-4, -22);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(738, 409);
            this.tabControl3.TabIndex = 0;
            // 
            // Timbrado_Pag
            // 
            this.Timbrado_Pag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.Timbrado_Pag.Controls.Add(this.PathSalvar);
            this.Timbrado_Pag.Controls.Add(this.checkBox5);
            this.Timbrado_Pag.Controls.Add(this.btBranco);
            this.Timbrado_Pag.Controls.Add(this.genPDF);
            this.Timbrado_Pag.Controls.Add(this.label6);
            this.Timbrado_Pag.Controls.Add(this.btTimbrado);
            this.Timbrado_Pag.Controls.Add(this.label10);
            this.Timbrado_Pag.Controls.Add(this.Pathpdfs);
            this.Timbrado_Pag.Controls.Add(this.BoxTimbrado);
            this.Timbrado_Pag.Controls.Add(this.radioPasta);
            this.Timbrado_Pag.Controls.Add(this.radioArquivo);
            this.Timbrado_Pag.Location = new System.Drawing.Point(4, 22);
            this.Timbrado_Pag.Name = "Timbrado_Pag";
            this.Timbrado_Pag.Padding = new System.Windows.Forms.Padding(3);
            this.Timbrado_Pag.Size = new System.Drawing.Size(730, 383);
            this.Timbrado_Pag.TabIndex = 0;
            this.Timbrado_Pag.Text = "Timbrado_Pag";
            // 
            // PathSalvar
            // 
            this.PathSalvar.Enabled = false;
            this.PathSalvar.Location = new System.Drawing.Point(401, 178);
            this.PathSalvar.Name = "PathSalvar";
            this.PathSalvar.Size = new System.Drawing.Size(149, 20);
            this.PathSalvar.TabIndex = 22;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox5.Location = new System.Drawing.Point(184, 174);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(211, 29);
            this.checkBox5.TabIndex = 21;
            this.checkBox5.Text = "Salvar Personalizado";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // btBranco
            // 
            this.btBranco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.btBranco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBranco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.btBranco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBranco.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBranco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBranco.Location = new System.Drawing.Point(501, 290);
            this.btBranco.Name = "btBranco";
            this.btBranco.Size = new System.Drawing.Size(130, 30);
            this.btBranco.TabIndex = 17;
            this.btBranco.Text = "BRANCO";
            this.btBranco.UseVisualStyleBackColor = false;
            this.btBranco.Click += new System.EventHandler(this.btBranco_Click);
            // 
            // genPDF
            // 
            this.genPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.genPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.genPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genPDF.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genPDF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genPDF.Location = new System.Drawing.Point(109, 290);
            this.genPDF.Name = "genPDF";
            this.genPDF.Size = new System.Drawing.Size(130, 30);
            this.genPDF.TabIndex = 20;
            this.genPDF.Text = "COMPLETO";
            this.genPDF.UseVisualStyleBackColor = false;
            this.genPDF.Click += new System.EventHandler(this.genPDF_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(218, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "EXCEL COM TIMBRADO";
            // 
            // btTimbrado
            // 
            this.btTimbrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.btTimbrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTimbrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.btTimbrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTimbrado.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimbrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btTimbrado.Location = new System.Drawing.Point(304, 290);
            this.btTimbrado.Name = "btTimbrado";
            this.btTimbrado.Size = new System.Drawing.Size(130, 30);
            this.btTimbrado.TabIndex = 19;
            this.btTimbrado.Text = "TIMBRADO";
            this.btTimbrado.UseVisualStyleBackColor = false;
            this.btTimbrado.Click += new System.EventHandler(this.btTimbrado_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(260, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "MODELO";
            // 
            // Pathpdfs
            // 
            this.Pathpdfs.Location = new System.Drawing.Point(401, 226);
            this.Pathpdfs.Name = "Pathpdfs";
            this.Pathpdfs.Size = new System.Drawing.Size(149, 20);
            this.Pathpdfs.TabIndex = 18;
            // 
            // BoxTimbrado
            // 
            this.BoxTimbrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoxTimbrado.FormattingEnabled = true;
            this.BoxTimbrado.Location = new System.Drawing.Point(354, 124);
            this.BoxTimbrado.Name = "BoxTimbrado";
            this.BoxTimbrado.Size = new System.Drawing.Size(113, 21);
            this.BoxTimbrado.TabIndex = 14;
            // 
            // radioPasta
            // 
            this.radioPasta.AutoSize = true;
            this.radioPasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPasta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPasta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioPasta.Location = new System.Drawing.Point(303, 223);
            this.radioPasta.Name = "radioPasta";
            this.radioPasta.Size = new System.Drawing.Size(77, 25);
            this.radioPasta.TabIndex = 15;
            this.radioPasta.TabStop = true;
            this.radioPasta.Text = "PASTA";
            this.radioPasta.UseVisualStyleBackColor = true;
            // 
            // radioArquivo
            // 
            this.radioArquivo.AutoSize = true;
            this.radioArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioArquivo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioArquivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioArquivo.Location = new System.Drawing.Point(183, 223);
            this.radioArquivo.Name = "radioArquivo";
            this.radioArquivo.Size = new System.Drawing.Size(99, 25);
            this.radioArquivo.TabIndex = 16;
            this.radioArquivo.TabStop = true;
            this.radioArquivo.Text = "ARQUIVO";
            this.radioArquivo.UseVisualStyleBackColor = true;
            // 
            // Indice_Pag
            // 
            this.Indice_Pag.AutoScroll = true;
            this.Indice_Pag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.Indice_Pag.Controls.Add(this.CK_Fornecedores);
            this.Indice_Pag.Controls.Add(this.CK_SubCat);
            this.Indice_Pag.Controls.Add(this.CK_Comercial);
            this.Indice_Pag.Controls.Add(this.CK_Tecnica);
            this.Indice_Pag.Controls.Add(this.CK_TC);
            this.Indice_Pag.Controls.Add(this.label11);
            this.Indice_Pag.Controls.Add(this.TB_Area);
            this.Indice_Pag.Controls.Add(this.TB_Descri);
            this.Indice_Pag.Controls.Add(this.BTCapa);
            this.Indice_Pag.Controls.Add(this.label23);
            this.Indice_Pag.Controls.Add(this.label24);
            this.Indice_Pag.Controls.Add(this.TBPropTecnica);
            this.Indice_Pag.Controls.Add(this.TBPropComercial);
            this.Indice_Pag.Controls.Add(this.ClPropTecnica);
            this.Indice_Pag.Controls.Add(this.richTextBox1);
            this.Indice_Pag.Controls.Add(this.ClPropComercial);
            this.Indice_Pag.Controls.Add(this.richTextBox2);
            this.Indice_Pag.Location = new System.Drawing.Point(4, 22);
            this.Indice_Pag.Name = "Indice_Pag";
            this.Indice_Pag.Padding = new System.Windows.Forms.Padding(3);
            this.Indice_Pag.Size = new System.Drawing.Size(730, 383);
            this.Indice_Pag.TabIndex = 1;
            this.Indice_Pag.Text = "tabPage4";
            // 
            // CK_Fornecedores
            // 
            this.CK_Fornecedores.AutoSize = true;
            this.CK_Fornecedores.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CK_Fornecedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CK_Fornecedores.Location = new System.Drawing.Point(580, 174);
            this.CK_Fornecedores.Name = "CK_Fornecedores";
            this.CK_Fornecedores.Size = new System.Drawing.Size(109, 23);
            this.CK_Fornecedores.TabIndex = 31;
            this.CK_Fornecedores.TabStop = true;
            this.CK_Fornecedores.Text = "Fornecedores";
            this.CK_Fornecedores.UseVisualStyleBackColor = true;
            this.CK_Fornecedores.CheckedChanged += new System.EventHandler(this.CK_Fornecedores_CheckedChanged);
            // 
            // CK_SubCat
            // 
            this.CK_SubCat.AutoSize = true;
            this.CK_SubCat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CK_SubCat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CK_SubCat.Location = new System.Drawing.Point(430, 174);
            this.CK_SubCat.Name = "CK_SubCat";
            this.CK_SubCat.Size = new System.Drawing.Size(124, 23);
            this.CK_SubCat.TabIndex = 30;
            this.CK_SubCat.TabStop = true;
            this.CK_SubCat.Text = "Sub-Categorias";
            this.CK_SubCat.UseVisualStyleBackColor = true;
            this.CK_SubCat.CheckedChanged += new System.EventHandler(this.CK_SubCat_CheckedChanged);
            // 
            // CK_Comercial
            // 
            this.CK_Comercial.AutoSize = true;
            this.CK_Comercial.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CK_Comercial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CK_Comercial.Location = new System.Drawing.Point(314, 174);
            this.CK_Comercial.Name = "CK_Comercial";
            this.CK_Comercial.Size = new System.Drawing.Size(90, 23);
            this.CK_Comercial.TabIndex = 29;
            this.CK_Comercial.TabStop = true;
            this.CK_Comercial.Text = "Comercial";
            this.CK_Comercial.UseVisualStyleBackColor = true;
            this.CK_Comercial.CheckedChanged += new System.EventHandler(this.CK_Comercial_CheckedChanged);
            // 
            // CK_Tecnica
            // 
            this.CK_Tecnica.AutoSize = true;
            this.CK_Tecnica.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CK_Tecnica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CK_Tecnica.Location = new System.Drawing.Point(214, 174);
            this.CK_Tecnica.Name = "CK_Tecnica";
            this.CK_Tecnica.Size = new System.Drawing.Size(74, 23);
            this.CK_Tecnica.TabIndex = 28;
            this.CK_Tecnica.TabStop = true;
            this.CK_Tecnica.Text = "Técnica";
            this.CK_Tecnica.UseVisualStyleBackColor = true;
            this.CK_Tecnica.CheckedChanged += new System.EventHandler(this.CK_Tecnica_CheckedChanged);
            // 
            // CK_TC
            // 
            this.CK_TC.AutoSize = true;
            this.CK_TC.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CK_TC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CK_TC.Location = new System.Drawing.Point(45, 174);
            this.CK_TC.Name = "CK_TC";
            this.CK_TC.Size = new System.Drawing.Size(143, 23);
            this.CK_TC.TabIndex = 27;
            this.CK_TC.TabStop = true;
            this.CK_TC.Text = "Técnica/Comercial";
            this.CK_TC.UseVisualStyleBackColor = true;
            this.CK_TC.CheckedChanged += new System.EventHandler(this.CK_TC_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(247, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 37);
            this.label11.TabIndex = 26;
            this.label11.Text = "ÍNDICES PARA BOOKS";
            // 
            // TB_Area
            // 
            this.TB_Area.Location = new System.Drawing.Point(115, 130);
            this.TB_Area.Name = "TB_Area";
            this.TB_Area.Size = new System.Drawing.Size(90, 20);
            this.TB_Area.TabIndex = 13;
            // 
            // TB_Descri
            // 
            this.TB_Descri.Location = new System.Drawing.Point(243, 130);
            this.TB_Descri.Name = "TB_Descri";
            this.TB_Descri.Size = new System.Drawing.Size(222, 20);
            this.TB_Descri.TabIndex = 14;
            // 
            // BTCapa
            // 
            this.BTCapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.BTCapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.BTCapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTCapa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCapa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTCapa.Location = new System.Drawing.Point(503, 123);
            this.BTCapa.Name = "BTCapa";
            this.BTCapa.Size = new System.Drawing.Size(128, 32);
            this.BTCapa.TabIndex = 10;
            this.BTCapa.Text = "GERAR CAPA";
            this.BTCapa.UseVisualStyleBackColor = false;
            this.BTCapa.Click += new System.EventHandler(this.BTCapa_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(140, 103);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 20);
            this.label23.TabIndex = 15;
            this.label23.Text = "ÁREA";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(305, 105);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 20);
            this.label24.TabIndex = 16;
            this.label24.Text = "DESCRITIVO";
            // 
            // TBPropTecnica
            // 
            this.TBPropTecnica.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPropTecnica.Location = new System.Drawing.Point(163, 307);
            this.TBPropTecnica.Name = "TBPropTecnica";
            this.TBPropTecnica.ReadOnly = true;
            this.TBPropTecnica.Size = new System.Drawing.Size(130, 22);
            this.TBPropTecnica.TabIndex = 11;
            this.TBPropTecnica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBPropTecnica.Visible = false;
            // 
            // TBPropComercial
            // 
            this.TBPropComercial.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPropComercial.Location = new System.Drawing.Point(163, 240);
            this.TBPropComercial.Name = "TBPropComercial";
            this.TBPropComercial.ReadOnly = true;
            this.TBPropComercial.Size = new System.Drawing.Size(130, 22);
            this.TBPropComercial.TabIndex = 7;
            this.TBPropComercial.Text = "Selecione";
            this.TBPropComercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClPropTecnica
            // 
            this.ClPropTecnica.AutoSize = true;
            this.ClPropTecnica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClPropTecnica.Location = new System.Drawing.Point(136, 310);
            this.ClPropTecnica.Name = "ClPropTecnica";
            this.ClPropTecnica.Size = new System.Drawing.Size(15, 14);
            this.ClPropTecnica.TabIndex = 18;
            this.ClPropTecnica.UseVisualStyleBackColor = true;
            this.ClPropTecnica.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(305, 226);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(272, 46);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // ClPropComercial
            // 
            this.ClPropComercial.AutoSize = true;
            this.ClPropComercial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClPropComercial.Location = new System.Drawing.Point(136, 243);
            this.ClPropComercial.Name = "ClPropComercial";
            this.ClPropComercial.Size = new System.Drawing.Size(15, 14);
            this.ClPropComercial.TabIndex = 17;
            this.ClPropComercial.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(306, 294);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(272, 46);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // Container_01
            // 
            this.Container_01.Controls.Add(this.PDF_Pag);
            this.Container_01.Controls.Add(this.Excel_Pag);
            this.Container_01.Controls.Add(this.Ferr_pag);
            this.Container_01.Controls.Add(this.Config_pag);
            this.Container_01.Location = new System.Drawing.Point(-4, -23);
            this.Container_01.Name = "Container_01";
            this.Container_01.SelectedIndex = 0;
            this.Container_01.Size = new System.Drawing.Size(1100, 500);
            this.Container_01.TabIndex = 0;
            // 
            // Excel_Pag
            // 
            this.Excel_Pag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(99)))));
            this.Excel_Pag.Controls.Add(this.panel28);
            this.Excel_Pag.Controls.Add(this.panelSideBar);
            this.Excel_Pag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Excel_Pag.Location = new System.Drawing.Point(4, 22);
            this.Excel_Pag.Name = "Excel_Pag";
            this.Excel_Pag.Padding = new System.Windows.Forms.Padding(3);
            this.Excel_Pag.Size = new System.Drawing.Size(1092, 474);
            this.Excel_Pag.TabIndex = 6;
            this.Excel_Pag.Text = "Excel";
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.panel28.Controls.Add(this.Container2);
            this.panel28.Location = new System.Drawing.Point(270, 46);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(730, 383);
            this.panel28.TabIndex = 4;
            // 
            // Container2
            // 
            this.Container2.Controls.Add(this.Fornecimento_tab);
            this.Container2.Controls.Add(this.Consolidar_Tab);
            this.Container2.Controls.Add(this.Servi_Tab);
            this.Container2.Controls.Add(this.Criar_PPQ_Bt);
            this.Container2.Location = new System.Drawing.Point(-4, -22);
            this.Container2.Name = "Container2";
            this.Container2.SelectedIndex = 0;
            this.Container2.Size = new System.Drawing.Size(738, 409);
            this.Container2.TabIndex = 3;
            // 
            // Fornecimento_tab
            // 
            this.Fornecimento_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.Fornecimento_tab.Controls.Add(this.Fisico_Bt);
            this.Fornecimento_tab.Controls.Add(this.Bt_Fornecimento);
            this.Fornecimento_tab.Controls.Add(this.R_Arquivos);
            this.Fornecimento_tab.Controls.Add(this.R_Unico);
            this.Fornecimento_tab.Controls.Add(this.label48);
            this.Fornecimento_tab.Controls.Add(this.label49);
            this.Fornecimento_tab.Controls.Add(this.label50);
            this.Fornecimento_tab.Controls.Add(this.area_box);
            this.Fornecimento_tab.Controls.Add(this.TA2_Box);
            this.Fornecimento_tab.Controls.Add(this.label51);
            this.Fornecimento_tab.Controls.Add(this.TA1_Box);
            this.Fornecimento_tab.Location = new System.Drawing.Point(4, 22);
            this.Fornecimento_tab.Name = "Fornecimento_tab";
            this.Fornecimento_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Fornecimento_tab.Size = new System.Drawing.Size(730, 383);
            this.Fornecimento_tab.TabIndex = 0;
            this.Fornecimento_tab.Text = "Comparativos";
            // 
            // Fisico_Bt
            // 
            this.Fisico_Bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Fisico_Bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fisico_Bt.FlatAppearance.BorderSize = 0;
            this.Fisico_Bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fisico_Bt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fisico_Bt.Location = new System.Drawing.Point(373, 316);
            this.Fisico_Bt.Name = "Fisico_Bt";
            this.Fisico_Bt.Size = new System.Drawing.Size(176, 33);
            this.Fisico_Bt.TabIndex = 18;
            this.Fisico_Bt.Text = "FÍSICO-FINANC";
            this.Fisico_Bt.UseVisualStyleBackColor = false;
            this.Fisico_Bt.Click += new System.EventHandler(this.button9_Click);
            // 
            // Bt_Fornecimento
            // 
            this.Bt_Fornecimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Bt_Fornecimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Fornecimento.FlatAppearance.BorderSize = 0;
            this.Bt_Fornecimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Fornecimento.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Fornecimento.Location = new System.Drawing.Point(191, 316);
            this.Bt_Fornecimento.Name = "Bt_Fornecimento";
            this.Bt_Fornecimento.Size = new System.Drawing.Size(176, 33);
            this.Bt_Fornecimento.TabIndex = 17;
            this.Bt_Fornecimento.Text = "FORNECIMENTO";
            this.Bt_Fornecimento.UseVisualStyleBackColor = false;
            this.Bt_Fornecimento.Click += new System.EventHandler(this.Bt_Fornecimento_Click);
            // 
            // R_Arquivos
            // 
            this.R_Arquivos.AutoSize = true;
            this.R_Arquivos.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Arquivos.Location = new System.Drawing.Point(395, 252);
            this.R_Arquivos.Name = "R_Arquivos";
            this.R_Arquivos.Size = new System.Drawing.Size(176, 32);
            this.R_Arquivos.TabIndex = 16;
            this.R_Arquivos.TabStop = true;
            this.R_Arquivos.Text = "Entre 2 Arquivos";
            this.R_Arquivos.UseVisualStyleBackColor = true;
            // 
            // R_Unico
            // 
            this.R_Unico.AutoSize = true;
            this.R_Unico.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Unico.Location = new System.Drawing.Point(177, 252);
            this.R_Unico.Name = "R_Unico";
            this.R_Unico.Size = new System.Drawing.Size(184, 32);
            this.R_Unico.TabIndex = 15;
            this.R_Unico.TabStop = true;
            this.R_Unico.Text = "Apenas 1 Arquivo";
            this.R_Unico.UseVisualStyleBackColor = true;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.SystemColors.Control;
            this.label48.Location = new System.Drawing.Point(257, 196);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(54, 28);
            this.label48.TabIndex = 14;
            this.label48.Text = "Área";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.SystemColors.Control;
            this.label49.Location = new System.Drawing.Point(159, 20);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(420, 37);
            this.label49.TabIndex = 8;
            this.label49.Text = "INFORMAÇÕES SUPLEMENTARES";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.SystemColors.Control;
            this.label50.Location = new System.Drawing.Point(259, 103);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(57, 28);
            this.label50.TabIndex = 9;
            this.label50.Text = "1° TA";
            // 
            // area_box
            // 
            this.area_box.FormattingEnabled = true;
            this.area_box.Location = new System.Drawing.Point(336, 203);
            this.area_box.Name = "area_box";
            this.area_box.Size = new System.Drawing.Size(121, 21);
            this.area_box.TabIndex = 13;
            // 
            // TA2_Box
            // 
            this.TA2_Box.FormattingEnabled = true;
            this.TA2_Box.Location = new System.Drawing.Point(338, 155);
            this.TA2_Box.Name = "TA2_Box";
            this.TA2_Box.Size = new System.Drawing.Size(72, 21);
            this.TA2_Box.TabIndex = 12;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.SystemColors.Control;
            this.label51.Location = new System.Drawing.Point(258, 149);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(59, 28);
            this.label51.TabIndex = 10;
            this.label51.Text = "2° TA";
            // 
            // TA1_Box
            // 
            this.TA1_Box.FormattingEnabled = true;
            this.TA1_Box.Location = new System.Drawing.Point(338, 109);
            this.TA1_Box.Name = "TA1_Box";
            this.TA1_Box.Size = new System.Drawing.Size(72, 21);
            this.TA1_Box.TabIndex = 11;
            // 
            // Consolidar_Tab
            // 
            this.Consolidar_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.Consolidar_Tab.Controls.Add(this.TA2_Box2);
            this.Consolidar_Tab.Controls.Add(this.label17);
            this.Consolidar_Tab.Controls.Add(this.TA1_Box2);
            this.Consolidar_Tab.Controls.Add(this.label12);
            this.Consolidar_Tab.Controls.Add(this.Delimitador_Box);
            this.Consolidar_Tab.Controls.Add(this.label5);
            this.Consolidar_Tab.Controls.Add(this.Box_Nomear);
            this.Consolidar_Tab.Controls.Add(this.boxAbaCSD);
            this.Consolidar_Tab.Controls.Add(this.label57);
            this.Consolidar_Tab.Controls.Add(this.label56);
            this.Consolidar_Tab.Controls.Add(this.button6);
            this.Consolidar_Tab.Controls.Add(this.textFim);
            this.Consolidar_Tab.Controls.Add(this.textInicio);
            this.Consolidar_Tab.Controls.Add(this.label52);
            this.Consolidar_Tab.Controls.Add(this.label53);
            this.Consolidar_Tab.Controls.Add(this.label54);
            this.Consolidar_Tab.Controls.Add(this.BoxModelo);
            this.Consolidar_Tab.Controls.Add(this.label55);
            this.Consolidar_Tab.Location = new System.Drawing.Point(4, 22);
            this.Consolidar_Tab.Name = "Consolidar_Tab";
            this.Consolidar_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Consolidar_Tab.Size = new System.Drawing.Size(730, 383);
            this.Consolidar_Tab.TabIndex = 1;
            this.Consolidar_Tab.Text = "Consolidar";
            // 
            // TA2_Box2
            // 
            this.TA2_Box2.FormattingEnabled = true;
            this.TA2_Box2.Location = new System.Drawing.Point(564, 83);
            this.TA2_Box2.Name = "TA2_Box2";
            this.TA2_Box2.Size = new System.Drawing.Size(50, 21);
            this.TA2_Box2.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(501, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 28);
            this.label17.TabIndex = 36;
            this.label17.Text = "TA 2°";
            // 
            // TA1_Box2
            // 
            this.TA1_Box2.FormattingEnabled = true;
            this.TA1_Box2.Location = new System.Drawing.Point(431, 83);
            this.TA1_Box2.Name = "TA1_Box2";
            this.TA1_Box2.Size = new System.Drawing.Size(50, 21);
            this.TA1_Box2.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(368, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 28);
            this.label12.TabIndex = 34;
            this.label12.Text = "TA 1°";
            // 
            // Delimitador_Box
            // 
            this.Delimitador_Box.Location = new System.Drawing.Point(487, 218);
            this.Delimitador_Box.Name = "Delimitador_Box";
            this.Delimitador_Box.Size = new System.Drawing.Size(40, 20);
            this.Delimitador_Box.TabIndex = 32;
            this.Delimitador_Box.Text = "-";
            this.Delimitador_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(344, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "Delimitador :";
            // 
            // Box_Nomear
            // 
            this.Box_Nomear.Location = new System.Drawing.Point(409, 261);
            this.Box_Nomear.Name = "Box_Nomear";
            this.Box_Nomear.Size = new System.Drawing.Size(118, 20);
            this.Box_Nomear.TabIndex = 30;
            this.Box_Nomear.Text = "Genérico";
            // 
            // boxAbaCSD
            // 
            this.boxAbaCSD.Location = new System.Drawing.Point(270, 218);
            this.boxAbaCSD.Name = "boxAbaCSD";
            this.boxAbaCSD.Size = new System.Drawing.Size(40, 20);
            this.boxAbaCSD.TabIndex = 29;
            this.boxAbaCSD.Text = "1";
            this.boxAbaCSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label57.Location = new System.Drawing.Point(210, 254);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(166, 28);
            this.label57.TabIndex = 28;
            this.label57.Text = "Nomear Arquivo:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label56.Location = new System.Drawing.Point(210, 213);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(52, 28);
            this.label56.TabIndex = 27;
            this.label56.Text = "Aba:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(303, 316);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 33);
            this.button6.TabIndex = 26;
            this.button6.Text = "INICIAR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textFim
            // 
            this.textFim.Location = new System.Drawing.Point(487, 176);
            this.textFim.Name = "textFim";
            this.textFim.Size = new System.Drawing.Size(40, 20);
            this.textFim.TabIndex = 23;
            // 
            // textInicio
            // 
            this.textInicio.Location = new System.Drawing.Point(487, 133);
            this.textInicio.Name = "textInicio";
            this.textInicio.Size = new System.Drawing.Size(40, 20);
            this.textInicio.TabIndex = 22;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label52.Location = new System.Drawing.Point(210, 169);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(267, 28);
            this.label52.TabIndex = 21;
            this.label52.Text = "Nos Demais Copiar a Partir :";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label53.Location = new System.Drawing.Point(168, 20);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(403, 37);
            this.label53.TabIndex = 19;
            this.label53.Text = "INFORMAÇÕES DE CABEÇALHO";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label54.Location = new System.Drawing.Point(210, 126);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(269, 28);
            this.label54.TabIndex = 20;
            this.label54.Text = "No 1° Arquivo Copiar Desde :";
            // 
            // BoxModelo
            // 
            this.BoxModelo.FormattingEnabled = true;
            this.BoxModelo.Location = new System.Drawing.Point(223, 83);
            this.BoxModelo.Name = "BoxModelo";
            this.BoxModelo.Size = new System.Drawing.Size(122, 21);
            this.BoxModelo.TabIndex = 17;
            this.BoxModelo.SelectedIndexChanged += new System.EventHandler(this.BoxModelo_SelectedIndexChanged);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label55.Location = new System.Drawing.Point(132, 78);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(78, 28);
            this.label55.TabIndex = 18;
            this.label55.Text = "Modelo";
            // 
            // Servi_Tab
            // 
            this.Servi_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.Servi_Tab.Location = new System.Drawing.Point(4, 22);
            this.Servi_Tab.Name = "Servi_Tab";
            this.Servi_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Servi_Tab.Size = new System.Drawing.Size(730, 383);
            this.Servi_Tab.TabIndex = 3;
            this.Servi_Tab.Text = "Serviços";
            // 
            // Criar_PPQ_Bt
            // 
            this.Criar_PPQ_Bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.Criar_PPQ_Bt.Controls.Add(this.dataGridView1);
            this.Criar_PPQ_Bt.Controls.Add(this.label4);
            this.Criar_PPQ_Bt.Controls.Add(this.valorDeIndice);
            this.Criar_PPQ_Bt.Controls.Add(this.button7);
            this.Criar_PPQ_Bt.Controls.Add(this.button8);
            this.Criar_PPQ_Bt.Controls.Add(this.textBoxEntrega);
            this.Criar_PPQ_Bt.Controls.Add(this.label1);
            this.Criar_PPQ_Bt.Controls.Add(this.label2);
            this.Criar_PPQ_Bt.Controls.Add(this.label3);
            this.Criar_PPQ_Bt.Controls.Add(this.textBox3);
            this.Criar_PPQ_Bt.Controls.Add(this.comboBox2);
            this.Criar_PPQ_Bt.Location = new System.Drawing.Point(4, 22);
            this.Criar_PPQ_Bt.Name = "Criar_PPQ_Bt";
            this.Criar_PPQ_Bt.Padding = new System.Windows.Forms.Padding(3);
            this.Criar_PPQ_Bt.Size = new System.Drawing.Size(730, 383);
            this.Criar_PPQ_Bt.TabIndex = 4;
            this.Criar_PPQ_Bt.Text = "tabPage1";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(6, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 284);
            this.dataGridView1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(426, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "1° Índice";
            // 
            // valorDeIndice
            // 
            this.valorDeIndice.Location = new System.Drawing.Point(411, 44);
            this.valorDeIndice.Name = "valorDeIndice";
            this.valorDeIndice.ReadOnly = true;
            this.valorDeIndice.Size = new System.Drawing.Size(121, 20);
            this.valorDeIndice.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(554, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Exibir Template";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(554, 59);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "Exportar Templates";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBoxEntrega
            // 
            this.textBoxEntrega.Location = new System.Drawing.Point(163, 44);
            this.textBoxEntrega.Name = "textBoxEntrega";
            this.textBoxEntrega.Size = new System.Drawing.Size(58, 20);
            this.textBoxEntrega.TabIndex = 15;
            this.textBoxEntrega.TextChanged += new System.EventHandler(this.textBoxEntrega_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(74, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Área";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(154, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Entrega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(293, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "RM";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(63, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(77, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.panelSideBar.Controls.Add(this.Comparativos_aba);
            this.panelSideBar.Controls.Add(this.Consolidar_Aba);
            this.panelSideBar.Controls.Add(this.Abrir_out_01);
            this.panelSideBar.Controls.Add(this.Servi_Aba);
            this.panelSideBar.Controls.Add(this.Mont_Aba);
            this.panelSideBar.Controls.Add(this.button9);
            this.panelSideBar.Controls.Add(this.button2);
            this.panelSideBar.Controls.Add(this.button5);
            this.panelSideBar.Controls.Add(this.button4);
            this.panelSideBar.Location = new System.Drawing.Point(19, 16);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(161, 440);
            this.panelSideBar.TabIndex = 2;
            // 
            // Comparativos_aba
            // 
            this.Comparativos_aba.AutoSize = true;
            this.Comparativos_aba.Location = new System.Drawing.Point(5, 36);
            this.Comparativos_aba.Name = "Comparativos_aba";
            this.Comparativos_aba.Size = new System.Drawing.Size(15, 14);
            this.Comparativos_aba.TabIndex = 20;
            this.Comparativos_aba.UseVisualStyleBackColor = true;
            this.Comparativos_aba.Visible = false;
            this.Comparativos_aba.CheckedChanged += new System.EventHandler(this.Comparativos_aba_CheckedChanged);
            // 
            // Consolidar_Aba
            // 
            this.Consolidar_Aba.AutoSize = true;
            this.Consolidar_Aba.Location = new System.Drawing.Point(5, 84);
            this.Consolidar_Aba.Name = "Consolidar_Aba";
            this.Consolidar_Aba.Size = new System.Drawing.Size(15, 14);
            this.Consolidar_Aba.TabIndex = 19;
            this.Consolidar_Aba.UseVisualStyleBackColor = true;
            this.Consolidar_Aba.Visible = false;
            this.Consolidar_Aba.CheckedChanged += new System.EventHandler(this.Consolidar_Aba_CheckedChanged);
            // 
            // Abrir_out_01
            // 
            this.Abrir_out_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Abrir_out_01.Image = ((System.Drawing.Image)(resources.GetObject("Abrir_out_01.Image")));
            this.Abrir_out_01.Location = new System.Drawing.Point(123, 401);
            this.Abrir_out_01.Name = "Abrir_out_01";
            this.Abrir_out_01.Size = new System.Drawing.Size(30, 31);
            this.Abrir_out_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Abrir_out_01.TabIndex = 21;
            this.Abrir_out_01.TabStop = false;
            this.Abrir_out_01.Click += new System.EventHandler(this.Abrir_out_01_Click);
            // 
            // Servi_Aba
            // 
            this.Servi_Aba.AutoSize = true;
            this.Servi_Aba.Location = new System.Drawing.Point(5, 133);
            this.Servi_Aba.Name = "Servi_Aba";
            this.Servi_Aba.Size = new System.Drawing.Size(15, 14);
            this.Servi_Aba.TabIndex = 18;
            this.Servi_Aba.UseVisualStyleBackColor = true;
            this.Servi_Aba.Visible = false;
            this.Servi_Aba.CheckedChanged += new System.EventHandler(this.Servi_Aba_CheckedChanged);
            // 
            // Mont_Aba
            // 
            this.Mont_Aba.AutoSize = true;
            this.Mont_Aba.Location = new System.Drawing.Point(5, 183);
            this.Mont_Aba.Name = "Mont_Aba";
            this.Mont_Aba.Size = new System.Drawing.Size(15, 14);
            this.Mont_Aba.TabIndex = 17;
            this.Mont_Aba.UseVisualStyleBackColor = true;
            this.Mont_Aba.Visible = false;
            this.Mont_Aba.CheckedChanged += new System.EventHandler(this.Mont_Aba_CheckedChanged);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(26, 170);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 38);
            this.button9.TabIndex = 5;
            this.button9.Text = "Montar PPQ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Comparativos do TA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(26, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 38);
            this.button5.TabIndex = 2;
            this.button5.Text = "M.C de Serviços";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(26, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "Consolidar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Config_pag
            // 
            this.Config_pag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(99)))));
            this.Config_pag.Controls.Add(this.panel26);
            this.Config_pag.Controls.Add(this.panel2);
            this.Config_pag.Location = new System.Drawing.Point(4, 22);
            this.Config_pag.Name = "Config_pag";
            this.Config_pag.Size = new System.Drawing.Size(1092, 474);
            this.Config_pag.TabIndex = 5;
            this.Config_pag.Text = "Configurações";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.tabControl1);
            this.panel26.Location = new System.Drawing.Point(270, 46);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(730, 383);
            this.panel26.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.Geral_Aba);
            this.tabControl1.Controls.Add(this.Salvar_Aba);
            this.tabControl1.Location = new System.Drawing.Point(-4, -25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 413);
            this.tabControl1.TabIndex = 1;
            // 
            // Geral_Aba
            // 
            this.Geral_Aba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.Geral_Aba.Controls.Add(this.panel5);
            this.Geral_Aba.Controls.Add(this.panel3);
            this.Geral_Aba.Location = new System.Drawing.Point(4, 25);
            this.Geral_Aba.Name = "Geral_Aba";
            this.Geral_Aba.Padding = new System.Windows.Forms.Padding(3);
            this.Geral_Aba.Size = new System.Drawing.Size(730, 384);
            this.Geral_Aba.TabIndex = 1;
            this.Geral_Aba.Text = "PDF";
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
            this.label47.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(63, 55);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(89, 19);
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
            this.label46.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(26, 6);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(167, 25);
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
            this.label31.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label31.Location = new System.Drawing.Point(75, 6);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(274, 32);
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
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(76, 143);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 25);
            this.label30.TabIndex = 20;
            this.label30.Text = "TEMA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(42, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 25);
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
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 25);
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
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 25);
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
            this.Capas_Reset_Bot.Location = new System.Drawing.Point(191, 7);
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
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(49, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 32);
            this.label13.TabIndex = 10;
            this.label13.Text = "CAPAS";
            // 
            // Capas_Sav_Bot
            // 
            this.Capas_Sav_Bot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Capas_Sav_Bot.Image = ((System.Drawing.Image)(resources.GetObject("Capas_Sav_Bot.Image")));
            this.Capas_Sav_Bot.Location = new System.Drawing.Point(150, 7);
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
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(19, 276);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(136, 19);
            this.label28.TabIndex = 21;
            this.label28.Text = "Entre SubCategorias";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(19, 250);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(133, 19);
            this.label29.TabIndex = 20;
            this.label29.Text = "Categoria X SubCat";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(19, 224);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(150, 19);
            this.label33.TabIndex = 19;
            this.label33.Text = "Categoria X Categoria";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(19, 155);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(115, 19);
            this.label27.TabIndex = 18;
            this.label27.Text = "Capa Fornecedor";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(19, 129);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(104, 19);
            this.label26.TabIndex = 17;
            this.label26.Text = "Sub Categorias";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(19, 103);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 19);
            this.label25.TabIndex = 16;
            this.label25.Text = "Categorias";
            // 
            // TamL_Fornecedor
            // 
            this.TamL_Fornecedor.Location = new System.Drawing.Point(179, 155);
            this.TamL_Fornecedor.Name = "TamL_Fornecedor";
            this.TamL_Fornecedor.Size = new System.Drawing.Size(36, 20);
            this.TamL_Fornecedor.TabIndex = 15;
            // 
            // Espa_sub2
            // 
            this.Espa_sub2.Location = new System.Drawing.Point(179, 276);
            this.Espa_sub2.Name = "Espa_sub2";
            this.Espa_sub2.Size = new System.Drawing.Size(36, 20);
            this.Espa_sub2.TabIndex = 14;
            // 
            // TamL_Cat
            // 
            this.TamL_Cat.Location = new System.Drawing.Point(179, 103);
            this.TamL_Cat.Name = "TamL_Cat";
            this.TamL_Cat.Size = new System.Drawing.Size(36, 20);
            this.TamL_Cat.TabIndex = 5;
            // 
            // Espa_sub1
            // 
            this.Espa_sub1.Location = new System.Drawing.Point(179, 250);
            this.Espa_sub1.Name = "Espa_sub1";
            this.Espa_sub1.Size = new System.Drawing.Size(36, 20);
            this.Espa_sub1.TabIndex = 13;
            // 
            // TamL_Sub
            // 
            this.TamL_Sub.Location = new System.Drawing.Point(179, 129);
            this.TamL_Sub.Name = "TamL_Sub";
            this.TamL_Sub.Size = new System.Drawing.Size(36, 20);
            this.TamL_Sub.TabIndex = 6;
            // 
            // Espa_Cat
            // 
            this.Espa_Cat.Location = new System.Drawing.Point(179, 224);
            this.Espa_Cat.Name = "Espa_Cat";
            this.Espa_Cat.Size = new System.Drawing.Size(36, 20);
            this.Espa_Cat.TabIndex = 12;
            // 
            // Salvar_Aba
            // 
            this.Salvar_Aba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.Salvar_Aba.Controls.Add(this.panel6);
            this.Salvar_Aba.Location = new System.Drawing.Point(4, 25);
            this.Salvar_Aba.Name = "Salvar_Aba";
            this.Salvar_Aba.Size = new System.Drawing.Size(730, 384);
            this.Salvar_Aba.TabIndex = 2;
            this.Salvar_Aba.Text = "Salvar";
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.panel24);
            this.panel6.Controls.Add(this.panel18);
            this.panel6.Controls.Add(this.panel16);
            this.panel6.Controls.Add(this.panel14);
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(730, 384);
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
            this.panel24.Size = new System.Drawing.Size(713, 41);
            this.panel24.TabIndex = 25;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label34.Location = new System.Drawing.Point(163, 5);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(369, 31);
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
            this.label40.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(277, 2);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(53, 28);
            this.label40.TabIndex = 12;
            this.label40.Text = "PPQ";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(37, 45);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(141, 25);
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
            this.label39.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(277, 1);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(50, 28);
            this.label39.TabIndex = 12;
            this.label39.Text = "PDF";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(37, 87);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(151, 25);
            this.label41.TabIndex = 14;
            this.label41.Text = "PDF\'s das Capas";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(37, 45);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(250, 25);
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
            this.label35.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(264, 1);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(70, 28);
            this.label35.TabIndex = 12;
            this.label35.Text = "EXCEL";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(37, 127);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(125, 25);
            this.label38.TabIndex = 15;
            this.label38.Text = "Consolidados";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(37, 89);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(269, 25);
            this.label37.TabIndex = 14;
            this.label37.Text = "Comparativo Físico-Financeiro";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(37, 45);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(265, 25);
            this.label36.TabIndex = 13;
            this.label36.Text = "Comparativo de Fornecimento";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Config_Aba_01);
            this.panel2.Controls.Add(this.Config_Aba_02);
            this.panel2.Controls.Add(this.Geral_Bt);
            this.panel2.Controls.Add(this.Salvar_Bt);
            this.panel2.Location = new System.Drawing.Point(19, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 440);
            this.panel2.TabIndex = 12;
            // 
            // Config_Aba_01
            // 
            this.Config_Aba_01.AutoSize = true;
            this.Config_Aba_01.Location = new System.Drawing.Point(5, 36);
            this.Config_Aba_01.Name = "Config_Aba_01";
            this.Config_Aba_01.Size = new System.Drawing.Size(15, 14);
            this.Config_Aba_01.TabIndex = 20;
            this.Config_Aba_01.UseVisualStyleBackColor = true;
            this.Config_Aba_01.Visible = false;
            this.Config_Aba_01.CheckedChanged += new System.EventHandler(this.Config_Aba_01_CheckedChanged);
            // 
            // Config_Aba_02
            // 
            this.Config_Aba_02.AutoSize = true;
            this.Config_Aba_02.Location = new System.Drawing.Point(5, 84);
            this.Config_Aba_02.Name = "Config_Aba_02";
            this.Config_Aba_02.Size = new System.Drawing.Size(15, 14);
            this.Config_Aba_02.TabIndex = 19;
            this.Config_Aba_02.UseVisualStyleBackColor = true;
            this.Config_Aba_02.Visible = false;
            this.Config_Aba_02.CheckedChanged += new System.EventHandler(this.Config_Aba_02_CheckedChanged);
            // 
            // Geral_Bt
            // 
            this.Geral_Bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Geral_Bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geral_Bt.FlatAppearance.BorderSize = 0;
            this.Geral_Bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Geral_Bt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geral_Bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Geral_Bt.Location = new System.Drawing.Point(26, 23);
            this.Geral_Bt.Name = "Geral_Bt";
            this.Geral_Bt.Size = new System.Drawing.Size(108, 38);
            this.Geral_Bt.TabIndex = 4;
            this.Geral_Bt.Text = "Geral";
            this.Geral_Bt.UseVisualStyleBackColor = false;
            this.Geral_Bt.Click += new System.EventHandler(this.Geral_Bt_Click);
            // 
            // Salvar_Bt
            // 
            this.Salvar_Bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Salvar_Bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salvar_Bt.FlatAppearance.BorderSize = 0;
            this.Salvar_Bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Salvar_Bt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvar_Bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Salvar_Bt.Location = new System.Drawing.Point(26, 71);
            this.Salvar_Bt.Name = "Salvar_Bt";
            this.Salvar_Bt.Size = new System.Drawing.Size(108, 38);
            this.Salvar_Bt.TabIndex = 1;
            this.Salvar_Bt.Text = "Salvar";
            this.Salvar_Bt.UseVisualStyleBackColor = false;
            this.Salvar_Bt.Click += new System.EventHandler(this.Salvar_Bt_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(268, -37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(677, 217);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Aba_Config
            // 
            this.Aba_Config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Aba_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aba_Config.FlatAppearance.BorderSize = 0;
            this.Aba_Config.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aba_Config.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aba_Config.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aba_Config.Location = new System.Drawing.Point(741, 142);
            this.Aba_Config.Name = "Aba_Config";
            this.Aba_Config.Size = new System.Drawing.Size(108, 26);
            this.Aba_Config.TabIndex = 12;
            this.Aba_Config.Text = "CONFIGURAÇÕES";
            this.Aba_Config.UseVisualStyleBackColor = false;
            this.Aba_Config.Click += new System.EventHandler(this.Aba_Config_Click);
            // 
            // Aba_Ferramentas
            // 
            this.Aba_Ferramentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Aba_Ferramentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aba_Ferramentas.FlatAppearance.BorderSize = 0;
            this.Aba_Ferramentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aba_Ferramentas.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aba_Ferramentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aba_Ferramentas.Location = new System.Drawing.Point(623, 142);
            this.Aba_Ferramentas.Name = "Aba_Ferramentas";
            this.Aba_Ferramentas.Size = new System.Drawing.Size(108, 26);
            this.Aba_Ferramentas.TabIndex = 13;
            this.Aba_Ferramentas.Text = "FERRAMENTAS";
            this.Aba_Ferramentas.UseVisualStyleBackColor = false;
            this.Aba_Ferramentas.Click += new System.EventHandler(this.Aba_Ferramentas_Click);
            // 
            // Aba_Excel
            // 
            this.Aba_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Aba_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aba_Excel.FlatAppearance.BorderSize = 0;
            this.Aba_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aba_Excel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aba_Excel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aba_Excel.Location = new System.Drawing.Point(505, 142);
            this.Aba_Excel.Name = "Aba_Excel";
            this.Aba_Excel.Size = new System.Drawing.Size(108, 26);
            this.Aba_Excel.TabIndex = 14;
            this.Aba_Excel.Text = "EXCEL";
            this.Aba_Excel.UseVisualStyleBackColor = false;
            this.Aba_Excel.Click += new System.EventHandler(this.Aba_Excel_Click);
            // 
            // Aba_PDF
            // 
            this.Aba_PDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.Aba_PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aba_PDF.FlatAppearance.BorderSize = 0;
            this.Aba_PDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aba_PDF.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aba_PDF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aba_PDF.Location = new System.Drawing.Point(387, 142);
            this.Aba_PDF.Name = "Aba_PDF";
            this.Aba_PDF.Size = new System.Drawing.Size(108, 26);
            this.Aba_PDF.TabIndex = 15;
            this.Aba_PDF.Text = "PDF";
            this.Aba_PDF.UseVisualStyleBackColor = false;
            this.Aba_PDF.Click += new System.EventHandler(this.Aba_PDF_Click);
            // 
            // PCP_01
            // 
            this.PCP_01.AutoSize = true;
            this.PCP_01.Location = new System.Drawing.Point(743, 2);
            this.PCP_01.Name = "PCP_01";
            this.PCP_01.Size = new System.Drawing.Size(15, 14);
            this.PCP_01.TabIndex = 16;
            this.PCP_01.UseVisualStyleBackColor = true;
            this.PCP_01.Visible = false;
            this.PCP_01.CheckedChanged += new System.EventHandler(this.PCP_01_CheckedChanged);
            // 
            // PCP_02
            // 
            this.PCP_02.AutoSize = true;
            this.PCP_02.Location = new System.Drawing.Point(763, 2);
            this.PCP_02.Name = "PCP_02";
            this.PCP_02.Size = new System.Drawing.Size(15, 14);
            this.PCP_02.TabIndex = 17;
            this.PCP_02.UseVisualStyleBackColor = true;
            this.PCP_02.Visible = false;
            this.PCP_02.CheckedChanged += new System.EventHandler(this.PCP_02_CheckedChanged);
            // 
            // PCP_04
            // 
            this.PCP_04.AutoSize = true;
            this.PCP_04.Location = new System.Drawing.Point(805, 2);
            this.PCP_04.Name = "PCP_04";
            this.PCP_04.Size = new System.Drawing.Size(15, 14);
            this.PCP_04.TabIndex = 18;
            this.PCP_04.UseVisualStyleBackColor = true;
            this.PCP_04.Visible = false;
            this.PCP_04.CheckedChanged += new System.EventHandler(this.PCP_04_CheckedChanged);
            // 
            // PCP_03
            // 
            this.PCP_03.AutoSize = true;
            this.PCP_03.Location = new System.Drawing.Point(784, 2);
            this.PCP_03.Name = "PCP_03";
            this.PCP_03.Size = new System.Drawing.Size(15, 14);
            this.PCP_03.TabIndex = 19;
            this.PCP_03.UseVisualStyleBackColor = true;
            this.PCP_03.Visible = false;
            this.PCP_03.CheckedChanged += new System.EventHandler(this.PCP_03_CheckedChanged);
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.Container_01);
            this.panel25.Location = new System.Drawing.Point(44, 174);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(1092, 473);
            this.panel25.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.PCP_03);
            this.Controls.Add(this.PCP_04);
            this.Controls.Add(this.PCP_02);
            this.Controls.Add(this.PCP_01);
            this.Controls.Add(this.Aba_PDF);
            this.Controls.Add(this.Aba_Excel);
            this.Controls.Add(this.Aba_Ferramentas);
            this.Controls.Add(this.Aba_Config);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 740);
            this.MinimumSize = new System.Drawing.Size(1200, 740);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versão 5.0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Ferr_pag.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.DB_Aba.ResumeLayout(false);
            this.DB_Aba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecarregarTab)).EndInit();
            this.CM_Aba.ResumeLayout(false);
            this.CM_Aba.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BT_Stop_1)).EndInit();
            this.Aux_Aba.ResumeLayout(false);
            this.Aux_Aba.PerformLayout();
            this.PDF_Pag.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Abrir_out_02)).EndInit();
            this.panel7.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.Timbrado_Pag.ResumeLayout(false);
            this.Timbrado_Pag.PerformLayout();
            this.Indice_Pag.ResumeLayout(false);
            this.Indice_Pag.PerformLayout();
            this.Container_01.ResumeLayout(false);
            this.Excel_Pag.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.Container2.ResumeLayout(false);
            this.Fornecimento_tab.ResumeLayout(false);
            this.Fornecimento_tab.PerformLayout();
            this.Consolidar_Tab.ResumeLayout(false);
            this.Consolidar_Tab.PerformLayout();
            this.Criar_PPQ_Bt.ResumeLayout(false);
            this.Criar_PPQ_Bt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Abrir_out_01)).EndInit();
            this.Config_pag.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Geral_Aba.ResumeLayout(false);
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
            this.Salvar_Aba.ResumeLayout(false);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel25.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage Ferr_pag;
        private System.Windows.Forms.TabPage PDF_Pag;
        private System.Windows.Forms.TabControl Container_01;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btBranco;
        private System.Windows.Forms.RadioButton radioArquivo;
        private System.Windows.Forms.RadioButton radioPasta;
        private System.Windows.Forms.ComboBox BoxTimbrado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBPropComercial;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
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
        private System.Windows.Forms.TabPage Config_pag;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Geral_Aba;
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
        private System.Windows.Forms.TabPage Salvar_Aba;
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
        private System.Windows.Forms.TabPage Excel_Pag;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.TabControl Container2;
        private System.Windows.Forms.TabPage Fornecimento_tab;
        private System.Windows.Forms.Button Bt_Fornecimento;
        private System.Windows.Forms.RadioButton R_Unico;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TabPage Consolidar_Tab;
        private System.Windows.Forms.TextBox textFim;
        private System.Windows.Forms.TextBox textInicio;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox BoxModelo;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TabPage Servi_Tab;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox Box_Nomear;
        private System.Windows.Forms.TextBox boxAbaCSD;
        public System.Windows.Forms.ComboBox area_box;
        public System.Windows.Forms.ComboBox TA2_Box;
        public System.Windows.Forms.ComboBox TA1_Box;
        private System.Windows.Forms.Button Fisico_Bt;
        public System.Windows.Forms.RadioButton R_Arquivos;
        private System.Windows.Forms.TabPage Criar_PPQ_Bt;
        private System.Windows.Forms.TextBox textBoxEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorDeIndice;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Aba_Config;
        private System.Windows.Forms.Button Aba_Ferramentas;
        private System.Windows.Forms.Button Aba_Excel;
        private System.Windows.Forms.Button Aba_PDF;
        private System.Windows.Forms.CheckBox PCP_01;
        private System.Windows.Forms.CheckBox PCP_02;
        private System.Windows.Forms.CheckBox PCP_04;
        private System.Windows.Forms.CheckBox PCP_03;
        private System.Windows.Forms.TextBox Delimitador_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Comparativos_aba;
        private System.Windows.Forms.CheckBox Consolidar_Aba;
        private System.Windows.Forms.CheckBox Servi_Aba;
        private System.Windows.Forms.CheckBox Mont_Aba;
        private System.Windows.Forms.PictureBox Abrir_out_01;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox CK_PDF_01;
        private System.Windows.Forms.CheckBox CK_PDF_02;
        private System.Windows.Forms.PictureBox Abrir_out_02;
        private System.Windows.Forms.Button Timbrao_Bt;
        private System.Windows.Forms.Button PDF_QP_bt;
        private System.Windows.Forms.Button Indice_Bt;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox Aba_Ferr_01;
        private System.Windows.Forms.CheckBox Aba_Ferr_02;
        private System.Windows.Forms.CheckBox Aba_Ferr_03;
        private System.Windows.Forms.Button Conversor_N;
        private System.Windows.Forms.Button BD_Caminhos;
        private System.Windows.Forms.Button FerrAux_Bt;
        private System.Windows.Forms.Button CataMilho_Bt;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage DB_Aba;
        private System.Windows.Forms.TabPage CM_Aba;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage Timbrado_Pag;
        private System.Windows.Forms.TabPage Indice_Pag;
        private System.Windows.Forms.TabPage Aux_Aba;
        private System.Windows.Forms.Button Unificar_Bt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox boxPathOrg;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Bt_Organizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RadioButton RB_RA_Nao;
        private System.Windows.Forms.RadioButton RB_RA_Sim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_Renomear;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton RB_MT_Copiar;
        private System.Windows.Forms.RadioButton BT_MT_Mover;
        private System.Windows.Forms.Label label_MT;
        private System.Windows.Forms.CheckBox Ck_Cm_All;
        private System.Windows.Forms.CheckBox Ck_Cm_Word;
        private System.Windows.Forms.CheckBox Ck_Cm_Excel;
        private System.Windows.Forms.CheckBox Ck_Cm_PDF;
        private System.Windows.Forms.Button IniciarCM;
        private System.Windows.Forms.PictureBox PB_BT_Stop_1;
        private System.Windows.Forms.TextBox PDestinoBox;
        private System.Windows.Forms.TextBox PRaizBox;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelRaiz;
        private System.Windows.Forms.Label LBCataMilho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox Config_Aba_01;
        private System.Windows.Forms.CheckBox Config_Aba_02;
        private System.Windows.Forms.Button Geral_Bt;
        private System.Windows.Forms.Button Salvar_Bt;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.RadioButton CK_Tecnica;
        private System.Windows.Forms.RadioButton CK_TC;
        private System.Windows.Forms.RadioButton CK_Fornecedores;
        private System.Windows.Forms.RadioButton CK_SubCat;
        private System.Windows.Forms.RadioButton CK_Comercial;
        private System.Windows.Forms.ComboBox TA1_Box2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox TA2_Box2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel25;
    }
}

