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
            this.BTCapa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClPropTecnica = new System.Windows.Forms.CheckBox();
            this.ClPropComercial = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TB_Descri = new System.Windows.Forms.TextBox();
            this.TB_Area = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TBPropTecnica = new System.Windows.Forms.TextBox();
            this.CBOnlySub = new System.Windows.Forms.CheckBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TBPropComercial = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.botUnificar = new System.Windows.Forms.Button();
            this.PB_buscar_1 = new System.Windows.Forms.PictureBox();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.boxModeloPDF = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboTim = new System.Windows.Forms.ComboBox();
            this.checkTimbrado = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBranco = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBranco = new System.Windows.Forms.CheckBox();
            this.radioArquivo = new System.Windows.Forms.RadioButton();
            this.radioPasta = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastaDistinoPDFsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelETimbradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unificarPDFsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarPDFsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesclarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPPQ = new System.Windows.Forms.TabControl();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.PB_buscar_1)).BeginInit();
            this.panel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPPQ.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel12.Controls.Add(this.label18);
            this.panel12.Controls.Add(this.boxPathOrg);
            this.panel12.Controls.Add(this.radioButton2);
            this.panel12.Controls.Add(this.radioButton1);
            this.panel12.Controls.Add(this.Bt_Organizar);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Location = new System.Drawing.Point(232, 315);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(232, 156);
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
            this.panel9.Location = new System.Drawing.Point(232, 3);
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
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1092, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PDF";
            // 
            // BTCapa
            // 
            this.BTCapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.BTCapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.BTCapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTCapa.Location = new System.Drawing.Point(143, 344);
            this.BTCapa.Name = "BTCapa";
            this.BTCapa.Size = new System.Drawing.Size(128, 32);
            this.BTCapa.TabIndex = 10;
            this.BTCapa.Text = "GERAR CAPA";
            this.BTCapa.UseVisualStyleBackColor = false;
            this.BTCapa.Click += new System.EventHandler(this.BTCapa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.BTCapa);
            this.panel2.Controls.Add(this.ClPropTecnica);
            this.panel2.Controls.Add(this.ClPropComercial);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.TB_Descri);
            this.panel2.Controls.Add(this.TB_Area);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.TBPropTecnica);
            this.panel2.Controls.Add(this.CBOnlySub);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.TBPropComercial);
            this.panel2.Location = new System.Drawing.Point(606, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 392);
            this.panel2.TabIndex = 9;
            // 
            // ClPropTecnica
            // 
            this.ClPropTecnica.AutoSize = true;
            this.ClPropTecnica.Location = new System.Drawing.Point(29, 287);
            this.ClPropTecnica.Name = "ClPropTecnica";
            this.ClPropTecnica.Size = new System.Drawing.Size(15, 14);
            this.ClPropTecnica.TabIndex = 18;
            this.ClPropTecnica.UseVisualStyleBackColor = true;
            this.ClPropTecnica.CheckedChanged += new System.EventHandler(this.CBPropTecnica_CheckedChanged);
            // 
            // ClPropComercial
            // 
            this.ClPropComercial.AutoSize = true;
            this.ClPropComercial.Location = new System.Drawing.Point(29, 224);
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
            this.label24.Location = new System.Drawing.Point(243, 82);
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
            this.label23.Location = new System.Drawing.Point(77, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 16);
            this.label23.TabIndex = 15;
            this.label23.Text = "ÁREA";
            // 
            // TB_Descri
            // 
            this.TB_Descri.Location = new System.Drawing.Point(217, 104);
            this.TB_Descri.Name = "TB_Descri";
            this.TB_Descri.Size = new System.Drawing.Size(149, 20);
            this.TB_Descri.TabIndex = 14;
            // 
            // TB_Area
            // 
            this.TB_Area.Location = new System.Drawing.Point(29, 104);
            this.TB_Area.Name = "TB_Area";
            this.TB_Area.Size = new System.Drawing.Size(149, 20);
            this.TB_Area.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(142, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 25);
            this.label22.TabIndex = 12;
            this.label22.Text = "CRIAR CAPAS";
            // 
            // TBPropTecnica
            // 
            this.TBPropTecnica.Location = new System.Drawing.Point(53, 284);
            this.TBPropTecnica.Name = "TBPropTecnica";
            this.TBPropTecnica.ReadOnly = true;
            this.TBPropTecnica.Size = new System.Drawing.Size(106, 20);
            this.TBPropTecnica.TabIndex = 11;
            this.TBPropTecnica.Text = "Proposta Técnica";
            // 
            // CBOnlySub
            // 
            this.CBOnlySub.AutoSize = true;
            this.CBOnlySub.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOnlySub.Location = new System.Drawing.Point(29, 156);
            this.CBOnlySub.Name = "CBOnlySub";
            this.CBOnlySub.Size = new System.Drawing.Size(185, 26);
            this.CBOnlySub.TabIndex = 10;
            this.CBOnlySub.Text = "Apenas subcategorias";
            this.CBOnlySub.UseVisualStyleBackColor = true;
            this.CBOnlySub.CheckedChanged += new System.EventHandler(this.CBOnlySub_CheckedChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(179, 271);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(187, 46);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(179, 207);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(187, 46);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // TBPropComercial
            // 
            this.TBPropComercial.Location = new System.Drawing.Point(53, 221);
            this.TBPropComercial.Name = "TBPropComercial";
            this.TBPropComercial.ReadOnly = true;
            this.TBPropComercial.Size = new System.Drawing.Size(106, 20);
            this.TBPropComercial.TabIndex = 7;
            this.TBPropComercial.Text = "Proposta Comercial";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(300, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 136);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(192, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 24);
            this.button3.TabIndex = 17;
            this.button3.Text = "INICIAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(24, 96);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 20);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ARQUIVO";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(112, 96);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 20);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "PASTA";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(24, 56);
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
            this.label6.Location = new System.Drawing.Point(40, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "EXCEL COM TIMBRADO";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel7.Controls.Add(this.botUnificar);
            this.panel7.Controls.Add(this.PB_buscar_1);
            this.panel7.Controls.Add(this.PathBox);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(300, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(288, 96);
            this.panel7.TabIndex = 5;
            // 
            // botUnificar
            // 
            this.botUnificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.botUnificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botUnificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.botUnificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botUnificar.Location = new System.Drawing.Point(200, 54);
            this.botUnificar.Name = "botUnificar";
            this.botUnificar.Size = new System.Drawing.Size(72, 24);
            this.botUnificar.TabIndex = 14;
            this.botUnificar.Text = "INICIAR";
            this.botUnificar.UseVisualStyleBackColor = false;
            this.botUnificar.Click += new System.EventHandler(this.botUnificar_Click);
            // 
            // PB_buscar_1
            // 
            this.PB_buscar_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_buscar_1.Image = ((System.Drawing.Image)(resources.GetObject("PB_buscar_1.Image")));
            this.PB_buscar_1.Location = new System.Drawing.Point(232, 8);
            this.PB_buscar_1.Name = "PB_buscar_1";
            this.PB_buscar_1.Size = new System.Drawing.Size(38, 32);
            this.PB_buscar_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_buscar_1.TabIndex = 10;
            this.PB_buscar_1.TabStop = false;
            this.PB_buscar_1.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(24, 56);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(168, 20);
            this.PathBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(40, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "UNIFICAR PDF\'s";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.boxModeloPDF);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.comboTim);
            this.panel6.Controls.Add(this.checkTimbrado);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.comboBranco);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.checkBranco);
            this.panel6.Controls.Add(this.radioArquivo);
            this.panel6.Controls.Add(this.radioPasta);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Location = new System.Drawing.Point(82, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 392);
            this.panel6.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(40, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "MESCLAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // boxModeloPDF
            // 
            this.boxModeloPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxModeloPDF.FormattingEnabled = true;
            this.boxModeloPDF.Location = new System.Drawing.Point(40, 104);
            this.boxModeloPDF.Name = "boxModeloPDF";
            this.boxModeloPDF.Size = new System.Drawing.Size(113, 21);
            this.boxModeloPDF.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(8, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "EXCEL E TIMBRADO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(40, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 16);
            this.label16.TabIndex = 11;
            this.label16.Text = "MODELO";
            // 
            // comboTim
            // 
            this.comboTim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboTim.FormattingEnabled = true;
            this.comboTim.Location = new System.Drawing.Point(40, 168);
            this.comboTim.Name = "comboTim";
            this.comboTim.Size = new System.Drawing.Size(113, 21);
            this.comboTim.TabIndex = 10;
            // 
            // checkTimbrado
            // 
            this.checkTimbrado.AutoSize = true;
            this.checkTimbrado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkTimbrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTimbrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTimbrado.Location = new System.Drawing.Point(152, 145);
            this.checkTimbrado.Name = "checkTimbrado";
            this.checkTimbrado.Size = new System.Drawing.Size(13, 12);
            this.checkTimbrado.TabIndex = 6;
            this.checkTimbrado.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(40, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "TIMBRADO";
            // 
            // comboBranco
            // 
            this.comboBranco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBranco.FormattingEnabled = true;
            this.comboBranco.Location = new System.Drawing.Point(40, 232);
            this.comboBranco.Name = "comboBranco";
            this.comboBranco.Size = new System.Drawing.Size(113, 21);
            this.comboBranco.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(40, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "EM BRANCO";
            // 
            // checkBranco
            // 
            this.checkBranco.AutoSize = true;
            this.checkBranco.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBranco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBranco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBranco.Location = new System.Drawing.Point(152, 209);
            this.checkBranco.Name = "checkBranco";
            this.checkBranco.Size = new System.Drawing.Size(13, 12);
            this.checkBranco.TabIndex = 5;
            this.checkBranco.UseVisualStyleBackColor = true;
            // 
            // radioArquivo
            // 
            this.radioArquivo.AutoSize = true;
            this.radioArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioArquivo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioArquivo.Location = new System.Drawing.Point(32, 270);
            this.radioArquivo.Name = "radioArquivo";
            this.radioArquivo.Size = new System.Drawing.Size(74, 20);
            this.radioArquivo.TabIndex = 6;
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
            this.radioPasta.Location = new System.Drawing.Point(120, 270);
            this.radioPasta.Name = "radioPasta";
            this.radioPasta.Size = new System.Drawing.Size(59, 20);
            this.radioPasta.TabIndex = 5;
            this.radioPasta.TabStop = true;
            this.radioPasta.Text = "PASTA";
            this.radioPasta.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(40, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "GERAR PDF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // tabPPQ
            // 
            this.tabPPQ.Controls.Add(this.tabPage1);
            this.tabPPQ.Controls.Add(this.tabPage2);
            this.tabPPQ.Controls.Add(this.tabPage4);
            this.tabPPQ.Controls.Add(this.tabPage3);
            this.tabPPQ.Location = new System.Drawing.Point(40, 144);
            this.tabPPQ.Name = "tabPPQ";
            this.tabPPQ.SelectedIndex = 0;
            this.tabPPQ.Size = new System.Drawing.Size(1100, 500);
            this.tabPPQ.TabIndex = 0;
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
            this.butImpTemplate.Text = "Importar Template";
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
            this.Controls.Add(this.tabPPQ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1200, 740);
            this.MinimumSize = new System.Drawing.Size(1200, 740);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versão 2.3.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.PB_buscar_1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPPQ.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.PictureBox PB_buscar_1;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox boxModeloPDF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboTim;
        private System.Windows.Forms.CheckBox checkTimbrado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBranco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBranco;
        private System.Windows.Forms.RadioButton radioArquivo;
        private System.Windows.Forms.RadioButton radioPasta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastaDistinoPDFsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelETimbradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unificarPDFsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarPDFsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesclarToolStripMenuItem;
        private System.Windows.Forms.TabControl tabPPQ;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.CheckBox CBOnlySub;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TBPropTecnica;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TB_Descri;
        private System.Windows.Forms.TextBox TB_Area;
        private System.Windows.Forms.Button BTCapa;
        private System.Windows.Forms.CheckBox ClPropTecnica;
        private System.Windows.Forms.CheckBox ClPropComercial;
    }
}

