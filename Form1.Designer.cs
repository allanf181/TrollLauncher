namespace TrollLauncher
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCriar = new System.Windows.Forms.Button();
            this.listImg = new System.Windows.Forms.ListBox();
            this.labelImg = new System.Windows.Forms.Label();
            this.labelImgBox = new System.Windows.Forms.Label();
            this.labelTxt = new System.Windows.Forms.Label();
            this.txtLinha1 = new System.Windows.Forms.TextBox();
            this.txtLinha2 = new System.Windows.Forms.TextBox();
            this.txtLinha3 = new System.Windows.Forms.TextBox();
            this.txtLinha4 = new System.Windows.Forms.TextBox();
            this.radioBtn0 = new System.Windows.Forms.RadioButton();
            this.radioBtn1 = new System.Windows.Forms.RadioButton();
            this.radioBtn2 = new System.Windows.Forms.RadioButton();
            this.labelBtnNumber = new System.Windows.Forms.Label();
            this.radioBtn3 = new System.Windows.Forms.RadioButton();
            this.labelBtnTxt = new System.Windows.Forms.Label();
            this.txtBtn1 = new System.Windows.Forms.TextBox();
            this.labelBtnTxt1 = new System.Windows.Forms.Label();
            this.labelBtnTxt2 = new System.Windows.Forms.Label();
            this.labelBtnTxt3 = new System.Windows.Forms.Label();
            this.txtBtn2 = new System.Windows.Forms.TextBox();
            this.txtBtn3 = new System.Windows.Forms.TextBox();
            this.checkBtn1Inativo = new System.Windows.Forms.CheckBox();
            this.checkBtn2Inativo = new System.Windows.Forms.CheckBox();
            this.checkBtn3Inativo = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnExError = new System.Windows.Forms.Button();
            this.btnExUpgrade = new System.Windows.Forms.Button();
            this.btnExKeyboard = new System.Windows.Forms.Button();
            this.btnExLinux = new System.Windows.Forms.Button();
            this.btnExButterfly = new System.Windows.Forms.Button();
            this.btnExVirus = new System.Windows.Forms.Button();
            this.btnExDelete = new System.Windows.Forms.Button();
            this.btnExHardware = new System.Windows.Forms.Button();
            this.labelEx = new System.Windows.Forms.Label();
            this.btnExProceeding = new System.Windows.Forms.Button();
            this.btnExOk = new System.Windows.Forms.Button();
            this.btnExMail = new System.Windows.Forms.Button();
            this.btnExHammer = new System.Windows.Forms.Button();
            this.btnExShit = new System.Windows.Forms.Button();
            this.btnExRun = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSobre = new System.Windows.Forms.Label();
            this.timerFocus = new System.Windows.Forms.Timer(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.menuNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.Enabled = false;
            this.btnCriar.Location = new System.Drawing.Point(12, 373);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(162, 44);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listImg
            // 
            this.listImg.FormattingEnabled = true;
            this.listImg.Items.AddRange(new object[] {
            "Attention",
            "Error",
            "Error2",
            "Error3",
            "Error4",
            "aim_guy",
            "aol_icon",
            "bomb",
            "bomb_dynamite",
            "bomb_grenade",
            "bubble_i",
            "bubble_q",
            "bulb",
            "butterfly",
            "cake",
            "circularsaw",
            "control_panel",
            "cow",
            "defrag",
            "disk_blu",
            "disk_blu_lbl",
            "disk_org",
            "disk_red",
            "disk_red_lbl",
            "disk_skull",
            "disk_yel",
            "dos",
            "e_orbit",
            "file_cabinet",
            "find",
            "fortunecookie",
            "garbage_empty",
            "garbage_full",
            "gun",
            "hammer",
            "heart",
            "help",
            "hub",
            "hwinfo",
            "ic_a",
            "keys",
            "keys2",
            "keys3",
            "labtec",
            "mac",
            "mail",
            "mail_deleted",
            "mailbox",
            "mouth",
            "mycomputer",
            "mycomputer2",
            "mycomputer3",
            "newspaper",
            "peripheral",
            "plant_leaf",
            "radiation",
            "ram",
            "recycle",
            "recycle2",
            "scanner",
            "screw",
            "screw2",
            "setup",
            "sknife",
            "skull",
            "skull2",
            "skull3",
            "tux",
            "tux_config",
            "ups",
            "zipdisk",
            "zipdisks"});
            this.listImg.Location = new System.Drawing.Point(12, 31);
            this.listImg.Name = "listImg";
            this.listImg.Size = new System.Drawing.Size(278, 121);
            this.listImg.TabIndex = 3;
            this.listImg.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // labelImg
            // 
            this.labelImg.AutoSize = true;
            this.labelImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImg.Location = new System.Drawing.Point(13, 12);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(117, 13);
            this.labelImg.TabIndex = 4;
            this.labelImg.Text = "Selecione a imgem:";
            // 
            // labelImgBox
            // 
            this.labelImgBox.AutoSize = true;
            this.labelImgBox.Location = new System.Drawing.Point(746, 155);
            this.labelImgBox.Name = "labelImgBox";
            this.labelImgBox.Size = new System.Drawing.Size(99, 13);
            this.labelImgBox.TabIndex = 5;
            this.labelImgBox.Text = "Preview da imagem";
            // 
            // labelTxt
            // 
            this.labelTxt.AutoSize = true;
            this.labelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxt.Location = new System.Drawing.Point(13, 155);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(87, 13);
            this.labelTxt.TabIndex = 6;
            this.labelTxt.Text = "Digite o texto:";
            // 
            // txtLinha1
            // 
            this.txtLinha1.Location = new System.Drawing.Point(12, 171);
            this.txtLinha1.Name = "txtLinha1";
            this.txtLinha1.Size = new System.Drawing.Size(410, 20);
            this.txtLinha1.TabIndex = 7;
            // 
            // txtLinha2
            // 
            this.txtLinha2.Location = new System.Drawing.Point(12, 198);
            this.txtLinha2.Name = "txtLinha2";
            this.txtLinha2.Size = new System.Drawing.Size(410, 20);
            this.txtLinha2.TabIndex = 8;
            // 
            // txtLinha3
            // 
            this.txtLinha3.Location = new System.Drawing.Point(12, 225);
            this.txtLinha3.Name = "txtLinha3";
            this.txtLinha3.Size = new System.Drawing.Size(410, 20);
            this.txtLinha3.TabIndex = 9;
            // 
            // txtLinha4
            // 
            this.txtLinha4.Location = new System.Drawing.Point(12, 252);
            this.txtLinha4.Name = "txtLinha4";
            this.txtLinha4.Size = new System.Drawing.Size(410, 20);
            this.txtLinha4.TabIndex = 10;
            // 
            // radioBtn0
            // 
            this.radioBtn0.AutoSize = true;
            this.radioBtn0.Checked = true;
            this.radioBtn0.Location = new System.Drawing.Point(327, 31);
            this.radioBtn0.Name = "radioBtn0";
            this.radioBtn0.Size = new System.Drawing.Size(31, 17);
            this.radioBtn0.TabIndex = 11;
            this.radioBtn0.TabStop = true;
            this.radioBtn0.Text = "0";
            this.radioBtn0.UseVisualStyleBackColor = true;
            this.radioBtn0.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBtn1
            // 
            this.radioBtn1.AutoSize = true;
            this.radioBtn1.Location = new System.Drawing.Point(327, 55);
            this.radioBtn1.Name = "radioBtn1";
            this.radioBtn1.Size = new System.Drawing.Size(31, 17);
            this.radioBtn1.TabIndex = 12;
            this.radioBtn1.Text = "1";
            this.radioBtn1.UseVisualStyleBackColor = true;
            this.radioBtn1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioBtn2
            // 
            this.radioBtn2.AutoSize = true;
            this.radioBtn2.Location = new System.Drawing.Point(327, 79);
            this.radioBtn2.Name = "radioBtn2";
            this.radioBtn2.Size = new System.Drawing.Size(31, 17);
            this.radioBtn2.TabIndex = 13;
            this.radioBtn2.Text = "2";
            this.radioBtn2.UseVisualStyleBackColor = true;
            this.radioBtn2.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // labelBtnNumber
            // 
            this.labelBtnNumber.AutoSize = true;
            this.labelBtnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBtnNumber.Location = new System.Drawing.Point(324, 12);
            this.labelBtnNumber.Name = "labelBtnNumber";
            this.labelBtnNumber.Size = new System.Drawing.Size(114, 13);
            this.labelBtnNumber.TabIndex = 14;
            this.labelBtnNumber.Text = "Número de botões:";
            // 
            // radioBtn3
            // 
            this.radioBtn3.AutoSize = true;
            this.radioBtn3.Location = new System.Drawing.Point(327, 103);
            this.radioBtn3.Name = "radioBtn3";
            this.radioBtn3.Size = new System.Drawing.Size(31, 17);
            this.radioBtn3.TabIndex = 15;
            this.radioBtn3.Text = "3";
            this.radioBtn3.UseVisualStyleBackColor = true;
            this.radioBtn3.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // labelBtnTxt
            // 
            this.labelBtnTxt.AutoSize = true;
            this.labelBtnTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBtnTxt.Location = new System.Drawing.Point(488, 12);
            this.labelBtnTxt.Name = "labelBtnTxt";
            this.labelBtnTxt.Size = new System.Drawing.Size(109, 13);
            this.labelBtnTxt.TabIndex = 16;
            this.labelBtnTxt.Text = "Texto dos botões:";
            this.labelBtnTxt.Visible = false;
            // 
            // txtBtn1
            // 
            this.txtBtn1.Location = new System.Drawing.Point(513, 28);
            this.txtBtn1.Name = "txtBtn1";
            this.txtBtn1.Size = new System.Drawing.Size(126, 20);
            this.txtBtn1.TabIndex = 17;
            this.txtBtn1.Visible = false;
            // 
            // labelBtnTxt1
            // 
            this.labelBtnTxt1.AutoSize = true;
            this.labelBtnTxt1.Location = new System.Drawing.Point(491, 31);
            this.labelBtnTxt1.Name = "labelBtnTxt1";
            this.labelBtnTxt1.Size = new System.Drawing.Size(16, 13);
            this.labelBtnTxt1.TabIndex = 18;
            this.labelBtnTxt1.Text = "1.";
            this.labelBtnTxt1.Visible = false;
            // 
            // labelBtnTxt2
            // 
            this.labelBtnTxt2.AutoSize = true;
            this.labelBtnTxt2.Location = new System.Drawing.Point(491, 55);
            this.labelBtnTxt2.Name = "labelBtnTxt2";
            this.labelBtnTxt2.Size = new System.Drawing.Size(16, 13);
            this.labelBtnTxt2.TabIndex = 19;
            this.labelBtnTxt2.Text = "2.";
            this.labelBtnTxt2.Visible = false;
            // 
            // labelBtnTxt3
            // 
            this.labelBtnTxt3.AutoSize = true;
            this.labelBtnTxt3.Location = new System.Drawing.Point(491, 79);
            this.labelBtnTxt3.Name = "labelBtnTxt3";
            this.labelBtnTxt3.Size = new System.Drawing.Size(16, 13);
            this.labelBtnTxt3.TabIndex = 20;
            this.labelBtnTxt3.Text = "3.";
            this.labelBtnTxt3.Visible = false;
            // 
            // txtBtn2
            // 
            this.txtBtn2.Location = new System.Drawing.Point(513, 52);
            this.txtBtn2.Name = "txtBtn2";
            this.txtBtn2.Size = new System.Drawing.Size(126, 20);
            this.txtBtn2.TabIndex = 21;
            this.txtBtn2.Visible = false;
            // 
            // txtBtn3
            // 
            this.txtBtn3.Location = new System.Drawing.Point(513, 76);
            this.txtBtn3.Name = "txtBtn3";
            this.txtBtn3.Size = new System.Drawing.Size(126, 20);
            this.txtBtn3.TabIndex = 22;
            this.txtBtn3.Visible = false;
            // 
            // checkBtn1Inativo
            // 
            this.checkBtn1Inativo.AutoSize = true;
            this.checkBtn1Inativo.Location = new System.Drawing.Point(645, 30);
            this.checkBtn1Inativo.Name = "checkBtn1Inativo";
            this.checkBtn1Inativo.Size = new System.Drawing.Size(58, 17);
            this.checkBtn1Inativo.TabIndex = 23;
            this.checkBtn1Inativo.Text = "Inativo";
            this.checkBtn1Inativo.UseVisualStyleBackColor = true;
            this.checkBtn1Inativo.Visible = false;
            // 
            // checkBtn2Inativo
            // 
            this.checkBtn2Inativo.AutoSize = true;
            this.checkBtn2Inativo.Location = new System.Drawing.Point(645, 54);
            this.checkBtn2Inativo.Name = "checkBtn2Inativo";
            this.checkBtn2Inativo.Size = new System.Drawing.Size(58, 17);
            this.checkBtn2Inativo.TabIndex = 24;
            this.checkBtn2Inativo.Text = "Inativo";
            this.checkBtn2Inativo.UseVisualStyleBackColor = true;
            this.checkBtn2Inativo.Visible = false;
            // 
            // checkBtn3Inativo
            // 
            this.checkBtn3Inativo.AutoSize = true;
            this.checkBtn3Inativo.Location = new System.Drawing.Point(645, 78);
            this.checkBtn3Inativo.Name = "checkBtn3Inativo";
            this.checkBtn3Inativo.Size = new System.Drawing.Size(58, 17);
            this.checkBtn3Inativo.TabIndex = 25;
            this.checkBtn3Inativo.Text = "Inativo";
            this.checkBtn3Inativo.UseVisualStyleBackColor = true;
            this.checkBtn3Inativo.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(13, 275);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 13);
            this.labelTitle.TabIndex = 26;
            this.labelTitle.Text = "Digite o título:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 292);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(205, 20);
            this.txtTitle.TabIndex = 27;
            // 
            // btnExError
            // 
            this.btnExError.Location = new System.Drawing.Point(695, 404);
            this.btnExError.Name = "btnExError";
            this.btnExError.Size = new System.Drawing.Size(164, 26);
            this.btnExError.TabIndex = 28;
            this.btnExError.Text = "error repair";
            this.btnExError.UseVisualStyleBackColor = true;
            this.btnExError.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExUpgrade
            // 
            this.btnExUpgrade.Location = new System.Drawing.Point(513, 404);
            this.btnExUpgrade.Name = "btnExUpgrade";
            this.btnExUpgrade.Size = new System.Drawing.Size(164, 26);
            this.btnExUpgrade.TabIndex = 29;
            this.btnExUpgrade.Text = "upgrade";
            this.btnExUpgrade.UseVisualStyleBackColor = true;
            this.btnExUpgrade.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExKeyboard
            // 
            this.btnExKeyboard.Location = new System.Drawing.Point(513, 373);
            this.btnExKeyboard.Name = "btnExKeyboard";
            this.btnExKeyboard.Size = new System.Drawing.Size(164, 26);
            this.btnExKeyboard.TabIndex = 31;
            this.btnExKeyboard.Text = "keyboard error";
            this.btnExKeyboard.UseVisualStyleBackColor = true;
            this.btnExKeyboard.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExLinux
            // 
            this.btnExLinux.Location = new System.Drawing.Point(695, 373);
            this.btnExLinux.Name = "btnExLinux";
            this.btnExLinux.Size = new System.Drawing.Size(164, 26);
            this.btnExLinux.TabIndex = 30;
            this.btnExLinux.Text = "linux";
            this.btnExLinux.UseVisualStyleBackColor = true;
            this.btnExLinux.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnExButterfly
            // 
            this.btnExButterfly.Location = new System.Drawing.Point(513, 341);
            this.btnExButterfly.Name = "btnExButterfly";
            this.btnExButterfly.Size = new System.Drawing.Size(164, 26);
            this.btnExButterfly.TabIndex = 33;
            this.btnExButterfly.Text = "butterfly bug";
            this.btnExButterfly.UseVisualStyleBackColor = true;
            this.btnExButterfly.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnExVirus
            // 
            this.btnExVirus.Location = new System.Drawing.Point(695, 341);
            this.btnExVirus.Name = "btnExVirus";
            this.btnExVirus.Size = new System.Drawing.Size(164, 26);
            this.btnExVirus.TabIndex = 32;
            this.btnExVirus.Text = "virus scan";
            this.btnExVirus.UseVisualStyleBackColor = true;
            this.btnExVirus.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnExDelete
            // 
            this.btnExDelete.Location = new System.Drawing.Point(513, 309);
            this.btnExDelete.Name = "btnExDelete";
            this.btnExDelete.Size = new System.Drawing.Size(164, 26);
            this.btnExDelete.TabIndex = 35;
            this.btnExDelete.Text = "delete hard drive";
            this.btnExDelete.UseVisualStyleBackColor = true;
            this.btnExDelete.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnExHardware
            // 
            this.btnExHardware.Location = new System.Drawing.Point(695, 309);
            this.btnExHardware.Name = "btnExHardware";
            this.btnExHardware.Size = new System.Drawing.Size(164, 26);
            this.btnExHardware.TabIndex = 34;
            this.btnExHardware.Text = "hardware upgrade";
            this.btnExHardware.UseVisualStyleBackColor = true;
            this.btnExHardware.Click += new System.EventHandler(this.button9_Click);
            // 
            // labelEx
            // 
            this.labelEx.AutoSize = true;
            this.labelEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEx.Location = new System.Drawing.Point(510, 198);
            this.labelEx.Name = "labelEx";
            this.labelEx.Size = new System.Drawing.Size(64, 13);
            this.labelEx.TabIndex = 36;
            this.labelEx.Text = "Exemplos:";
            // 
            // btnExProceeding
            // 
            this.btnExProceeding.Location = new System.Drawing.Point(513, 277);
            this.btnExProceeding.Name = "btnExProceeding";
            this.btnExProceeding.Size = new System.Drawing.Size(164, 26);
            this.btnExProceeding.TabIndex = 38;
            this.btnExProceeding.Text = "proceeding";
            this.btnExProceeding.UseVisualStyleBackColor = true;
            this.btnExProceeding.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnExOk
            // 
            this.btnExOk.Location = new System.Drawing.Point(695, 277);
            this.btnExOk.Name = "btnExOk";
            this.btnExOk.Size = new System.Drawing.Size(164, 26);
            this.btnExOk.TabIndex = 37;
            this.btnExOk.Text = "ok";
            this.btnExOk.UseVisualStyleBackColor = true;
            this.btnExOk.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnExMail
            // 
            this.btnExMail.Location = new System.Drawing.Point(513, 246);
            this.btnExMail.Name = "btnExMail";
            this.btnExMail.Size = new System.Drawing.Size(164, 26);
            this.btnExMail.TabIndex = 40;
            this.btnExMail.Text = "mail folder";
            this.btnExMail.UseVisualStyleBackColor = true;
            this.btnExMail.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnExHammer
            // 
            this.btnExHammer.Location = new System.Drawing.Point(695, 246);
            this.btnExHammer.Name = "btnExHammer";
            this.btnExHammer.Size = new System.Drawing.Size(164, 26);
            this.btnExHammer.TabIndex = 39;
            this.btnExHammer.Text = "hammer";
            this.btnExHammer.UseVisualStyleBackColor = true;
            this.btnExHammer.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnExShit
            // 
            this.btnExShit.Location = new System.Drawing.Point(513, 214);
            this.btnExShit.Name = "btnExShit";
            this.btnExShit.Size = new System.Drawing.Size(164, 26);
            this.btnExShit.TabIndex = 42;
            this.btnExShit.Text = "shit";
            this.btnExShit.UseVisualStyleBackColor = true;
            this.btnExShit.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnExRun
            // 
            this.btnExRun.Location = new System.Drawing.Point(695, 214);
            this.btnExRun.Name = "btnExRun";
            this.btnExRun.Size = new System.Drawing.Size(164, 26);
            this.btnExRun.TabIndex = 41;
            this.btnExRun.Text = "run";
            this.btnExRun.UseVisualStyleBackColor = true;
            this.btnExRun.Click += new System.EventHandler(this.button15_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(345, 373);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(162, 44);
            this.btnLimpar.TabIndex = 43;
            this.btnLimpar.Text = "Limpar Textos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button16_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.menuNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Windows Defender - Escaneando";
            // 
            // menuNotify
            // 
            this.menuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuNotify.Name = "contextMenuStrip1";
            this.menuNotify.Size = new System.Drawing.Size(182, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "Parar escaneamento";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // labelSobre
            // 
            this.labelSobre.AutoSize = true;
            this.labelSobre.Location = new System.Drawing.Point(9, 420);
            this.labelSobre.Name = "labelSobre";
            this.labelSobre.Size = new System.Drawing.Size(305, 13);
            this.labelSobre.TabIndex = 44;
            this.labelSobre.Text = "Desenvolvido por allanf181. Clique aqui para mais informações.";
            this.labelSobre.Click += new System.EventHandler(this.label11_Click);
            // 
            // timerFocus
            // 
            this.timerFocus.Interval = 4000;
            this.timerFocus.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(177, 373);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(162, 44);
            this.btnEditar.TabIndex = 45;
            this.btnEditar.Text = "Editar botão de fechar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button17_Click);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(731, 24);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(128, 128);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBox.TabIndex = 2;
            this.imgBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 442);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.labelSobre);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExShit);
            this.Controls.Add(this.btnExRun);
            this.Controls.Add(this.btnExMail);
            this.Controls.Add(this.btnExHammer);
            this.Controls.Add(this.btnExProceeding);
            this.Controls.Add(this.btnExOk);
            this.Controls.Add(this.labelEx);
            this.Controls.Add(this.btnExDelete);
            this.Controls.Add(this.btnExHardware);
            this.Controls.Add(this.btnExButterfly);
            this.Controls.Add(this.btnExVirus);
            this.Controls.Add(this.btnExKeyboard);
            this.Controls.Add(this.btnExLinux);
            this.Controls.Add(this.btnExUpgrade);
            this.Controls.Add(this.btnExError);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.checkBtn3Inativo);
            this.Controls.Add(this.checkBtn2Inativo);
            this.Controls.Add(this.checkBtn1Inativo);
            this.Controls.Add(this.txtBtn3);
            this.Controls.Add(this.txtBtn2);
            this.Controls.Add(this.labelBtnTxt3);
            this.Controls.Add(this.labelBtnTxt2);
            this.Controls.Add(this.labelBtnTxt1);
            this.Controls.Add(this.txtBtn1);
            this.Controls.Add(this.labelBtnTxt);
            this.Controls.Add(this.radioBtn3);
            this.Controls.Add(this.labelBtnNumber);
            this.Controls.Add(this.radioBtn2);
            this.Controls.Add(this.radioBtn1);
            this.Controls.Add(this.radioBtn0);
            this.Controls.Add(this.txtLinha4);
            this.Controls.Add(this.txtLinha3);
            this.Controls.Add(this.txtLinha2);
            this.Controls.Add(this.txtLinha1);
            this.Controls.Add(this.labelTxt);
            this.Controls.Add(this.labelImgBox);
            this.Controls.Add(this.labelImg);
            this.Controls.Add(this.listImg);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.btnCriar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Troll Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuNotify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.ListBox listImg;
        private System.Windows.Forms.Label labelImg;
        private System.Windows.Forms.Label labelImgBox;
        private System.Windows.Forms.Label labelTxt;
        private System.Windows.Forms.TextBox txtLinha1;
        private System.Windows.Forms.TextBox txtLinha2;
        private System.Windows.Forms.TextBox txtLinha3;
        private System.Windows.Forms.TextBox txtLinha4;
        private System.Windows.Forms.RadioButton radioBtn0;
        private System.Windows.Forms.RadioButton radioBtn1;
        private System.Windows.Forms.RadioButton radioBtn2;
        private System.Windows.Forms.Label labelBtnNumber;
        private System.Windows.Forms.RadioButton radioBtn3;
        private System.Windows.Forms.Label labelBtnTxt;
        private System.Windows.Forms.TextBox txtBtn1;
        private System.Windows.Forms.Label labelBtnTxt1;
        private System.Windows.Forms.Label labelBtnTxt2;
        private System.Windows.Forms.Label labelBtnTxt3;
        private System.Windows.Forms.TextBox txtBtn2;
        private System.Windows.Forms.TextBox txtBtn3;
        private System.Windows.Forms.CheckBox checkBtn1Inativo;
        private System.Windows.Forms.CheckBox checkBtn2Inativo;
        private System.Windows.Forms.CheckBox checkBtn3Inativo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnExError;
        private System.Windows.Forms.Button btnExUpgrade;
        private System.Windows.Forms.Button btnExKeyboard;
        private System.Windows.Forms.Button btnExLinux;
        private System.Windows.Forms.Button btnExButterfly;
        private System.Windows.Forms.Button btnExVirus;
        private System.Windows.Forms.Button btnExDelete;
        private System.Windows.Forms.Button btnExHardware;
        private System.Windows.Forms.Label labelEx;
        private System.Windows.Forms.Button btnExProceeding;
        private System.Windows.Forms.Button btnExOk;
        private System.Windows.Forms.Button btnExMail;
        private System.Windows.Forms.Button btnExHammer;
        private System.Windows.Forms.Button btnExShit;
        private System.Windows.Forms.Button btnExRun;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip menuNotify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label labelSobre;
        private System.Windows.Forms.Timer timerFocus;
        private System.Windows.Forms.Button btnEditar;
    }
}

