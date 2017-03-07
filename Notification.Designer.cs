namespace TrollLauncher
{
    partial class Notification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelecionarIcon = new System.Windows.Forms.Button();
            this.labelFixedLocal = new System.Windows.Forms.Label();
            this.labelFixedTitulo = new System.Windows.Forms.Label();
            this.labelFixedBtnNome = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxBtnNome = new System.Windows.Forms.TextBox();
            this.checkBoxUsarPadrao = new System.Windows.Forms.CheckBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Icone";
            this.openFileDialog1.Filter = "Arquivos de icone (*.ico)|*.ico";
            // 
            // btnSelecionarIcon
            // 
            this.btnSelecionarIcon.Location = new System.Drawing.Point(329, 13);
            this.btnSelecionarIcon.Name = "btnSelecionarIcon";
            this.btnSelecionarIcon.Size = new System.Drawing.Size(106, 23);
            this.btnSelecionarIcon.TabIndex = 0;
            this.btnSelecionarIcon.Text = "Selecionar icone";
            this.btnSelecionarIcon.UseVisualStyleBackColor = true;
            this.btnSelecionarIcon.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFixedLocal
            // 
            this.labelFixedLocal.AutoSize = true;
            this.labelFixedLocal.Location = new System.Drawing.Point(12, 18);
            this.labelFixedLocal.Name = "labelFixedLocal";
            this.labelFixedLocal.Size = new System.Drawing.Size(39, 13);
            this.labelFixedLocal.TabIndex = 1;
            this.labelFixedLocal.Text = "Local: ";
            // 
            // labelFixedTitulo
            // 
            this.labelFixedTitulo.AutoSize = true;
            this.labelFixedTitulo.Location = new System.Drawing.Point(65, 46);
            this.labelFixedTitulo.Name = "labelFixedTitulo";
            this.labelFixedTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelFixedTitulo.TabIndex = 3;
            this.labelFixedTitulo.Text = "Titulo";
            // 
            // labelFixedBtnNome
            // 
            this.labelFixedBtnNome.AutoSize = true;
            this.labelFixedBtnNome.Location = new System.Drawing.Point(65, 78);
            this.labelFixedBtnNome.Name = "labelFixedBtnNome";
            this.labelFixedBtnNome.Size = new System.Drawing.Size(35, 13);
            this.labelFixedBtnNome.TabIndex = 4;
            this.labelFixedBtnNome.Text = "Botão";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(106, 43);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(329, 20);
            this.textBoxTitulo.TabIndex = 5;
            this.textBoxTitulo.Text = "Windows Defender - Escaneando";
            // 
            // textBoxBtnNome
            // 
            this.textBoxBtnNome.Location = new System.Drawing.Point(106, 75);
            this.textBoxBtnNome.Name = "textBoxBtnNome";
            this.textBoxBtnNome.Size = new System.Drawing.Size(329, 20);
            this.textBoxBtnNome.TabIndex = 6;
            this.textBoxBtnNome.Text = "Parar Escaneamento";
            // 
            // checkBoxUsarPadrao
            // 
            this.checkBoxUsarPadrao.AutoSize = true;
            this.checkBoxUsarPadrao.Location = new System.Drawing.Point(12, 101);
            this.checkBoxUsarPadrao.Name = "checkBoxUsarPadrao";
            this.checkBoxUsarPadrao.Size = new System.Drawing.Size(87, 17);
            this.checkBoxUsarPadrao.TabIndex = 7;
            this.checkBoxUsarPadrao.Text = "Usar padrão.";
            this.checkBoxUsarPadrao.UseVisualStyleBackColor = true;
            this.checkBoxUsarPadrao.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(58, 18);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(16, 13);
            this.labelLocal.TabIndex = 8;
            this.labelLocal.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(335, 105);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 32);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 142);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.checkBoxUsarPadrao);
            this.Controls.Add(this.textBoxBtnNome);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelFixedBtnNome);
            this.Controls.Add(this.labelFixedTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelFixedLocal);
            this.Controls.Add(this.btnSelecionarIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notification";
            this.ShowIcon = false;
            this.Text = "Notificação aka botão de fechar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Button btnSelecionarIcon;
        public System.Windows.Forms.Label labelFixedLocal;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelFixedTitulo;
        public System.Windows.Forms.Label labelFixedBtnNome;
        public System.Windows.Forms.TextBox textBoxTitulo;
        public System.Windows.Forms.TextBox textBoxBtnNome;
        public System.Windows.Forms.CheckBox checkBoxUsarPadrao;
        public System.Windows.Forms.Label labelLocal;
        public System.Windows.Forms.Button btnFechar;
    }
}