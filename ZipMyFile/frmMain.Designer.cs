namespace ZipMyFile
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblProgresso = new Label();
            lblDiretorioEntrada = new Label();
            ctrTextoDiretorioEntrada = new TextBox();
            btnDiretorioEntrada = new Button();
            btnCancel = new Button();
            btnOk = new Button();
            lblNomeArquivoSaida = new Label();
            ctrTextoNomeArquivo = new TextBox();
            lblNomeCompletoArquivo = new Label();
            btnDiretorioSaida = new Button();
            label1 = new Label();
            ctrTextoDiretorioSaida = new TextBox();
            groupBox1 = new GroupBox();
            groupBoxDiretorios = new GroupBox();
            pgbZip = new ProgressBar();
            btnClose = new Button();
            btnMinimize = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBoxDiretorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblProgresso
            // 
            lblProgresso.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProgresso.ForeColor = SystemColors.Control;
            lblProgresso.Location = new Point(278, 230);
            lblProgresso.Name = "lblProgresso";
            lblProgresso.Size = new Size(36, 23);
            lblProgresso.TabIndex = 16;
            lblProgresso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiretorioEntrada
            // 
            lblDiretorioEntrada.AutoSize = true;
            lblDiretorioEntrada.Location = new Point(6, 23);
            lblDiretorioEntrada.Name = "lblDiretorioEntrada";
            lblDiretorioEntrada.Size = new Size(96, 15);
            lblDiretorioEntrada.TabIndex = 0;
            lblDiretorioEntrada.Text = "Diretório Entrada";
            // 
            // ctrTextoDiretorioEntrada
            // 
            ctrTextoDiretorioEntrada.Location = new Point(108, 20);
            ctrTextoDiretorioEntrada.Name = "ctrTextoDiretorioEntrada";
            ctrTextoDiretorioEntrada.Size = new Size(292, 23);
            ctrTextoDiretorioEntrada.TabIndex = 1;
            // 
            // btnDiretorioEntrada
            // 
            btnDiretorioEntrada.ForeColor = SystemColors.ControlText;
            btnDiretorioEntrada.Location = new Point(406, 19);
            btnDiretorioEntrada.Name = "btnDiretorioEntrada";
            btnDiretorioEntrada.Size = new Size(28, 23);
            btnDiretorioEntrada.TabIndex = 2;
            btnDiretorioEntrada.Text = "...";
            btnDiretorioEntrada.UseVisualStyleBackColor = true;
            btnDiretorioEntrada.Click += BtnDiretorioEntrada_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.ForeColor = SystemColors.ControlText;
            btnCancel.Location = new Point(401, 230);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "&Cancela";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.ForeColor = SystemColors.ControlText;
            btnOk.Location = new Point(320, 230);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 14;
            btnOk.Text = "&Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += BtnOk_Click;
            // 
            // lblNomeArquivoSaida
            // 
            lblNomeArquivoSaida.AutoSize = true;
            lblNomeArquivoSaida.Location = new Point(6, 19);
            lblNomeArquivoSaida.Name = "lblNomeArquivoSaida";
            lblNomeArquivoSaida.Size = new Size(102, 15);
            lblNomeArquivoSaida.TabIndex = 6;
            lblNomeArquivoSaida.Text = "Nome do Arquivo";
            // 
            // ctrTextoNomeArquivo
            // 
            ctrTextoNomeArquivo.Location = new Point(114, 16);
            ctrTextoNomeArquivo.Name = "ctrTextoNomeArquivo";
            ctrTextoNomeArquivo.Size = new Size(286, 23);
            ctrTextoNomeArquivo.TabIndex = 7;
            ctrTextoNomeArquivo.KeyDown += CtrTextoNomeArquivo_KeyDown;
            ctrTextoNomeArquivo.Validating += CtrTextoNomeArquivo_Validating;
            // 
            // lblNomeCompletoArquivo
            // 
            lblNomeCompletoArquivo.ForeColor = SystemColors.Control;
            lblNomeCompletoArquivo.Location = new Point(6, 53);
            lblNomeCompletoArquivo.Name = "lblNomeCompletoArquivo";
            lblNomeCompletoArquivo.Size = new Size(394, 23);
            lblNomeCompletoArquivo.TabIndex = 8;
            // 
            // btnDiretorioSaida
            // 
            btnDiretorioSaida.ForeColor = SystemColors.ControlText;
            btnDiretorioSaida.Location = new Point(406, 53);
            btnDiretorioSaida.Name = "btnDiretorioSaida";
            btnDiretorioSaida.Size = new Size(28, 23);
            btnDiretorioSaida.TabIndex = 11;
            btnDiretorioSaida.Text = "...";
            btnDiretorioSaida.UseVisualStyleBackColor = true;
            btnDiretorioSaida.Click += BtnDiretorioSaida_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 57);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 9;
            label1.Text = "Diretório Saída";
            // 
            // ctrTextoDiretorioSaida
            // 
            ctrTextoDiretorioSaida.Location = new Point(108, 54);
            ctrTextoDiretorioSaida.Name = "ctrTextoDiretorioSaida";
            ctrTextoDiretorioSaida.Size = new Size(292, 23);
            ctrTextoDiretorioSaida.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblNomeArquivoSaida);
            groupBox1.Controls.Add(ctrTextoNomeArquivo);
            groupBox1.Controls.Add(lblNomeCompletoArquivo);
            groupBox1.Location = new Point(12, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 92);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // groupBoxDiretorios
            // 
            groupBoxDiretorios.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDiretorios.Controls.Add(lblDiretorioEntrada);
            groupBoxDiretorios.Controls.Add(btnDiretorioSaida);
            groupBoxDiretorios.Controls.Add(label1);
            groupBoxDiretorios.Controls.Add(ctrTextoDiretorioSaida);
            groupBoxDiretorios.Controls.Add(ctrTextoDiretorioEntrada);
            groupBoxDiretorios.Controls.Add(btnDiretorioEntrada);
            groupBoxDiretorios.Location = new Point(12, 37);
            groupBoxDiretorios.Name = "groupBoxDiretorios";
            groupBoxDiretorios.Size = new Size(464, 88);
            groupBoxDiretorios.TabIndex = 17;
            groupBoxDiretorios.TabStop = false;
            // 
            // pgbZip
            // 
            pgbZip.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pgbZip.Location = new Point(12, 230);
            pgbZip.Name = "pgbZip";
            pgbZip.Size = new Size(260, 23);
            pgbZip.TabIndex = 19;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = SystemColors.ControlText;
            btnClose.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = SystemColors.Control;
            btnClose.Location = new Point(443, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimize.ForeColor = SystemColors.Control;
            btnMinimize.Location = new Point(401, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(27, 23);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "-";
            btnMinimize.TextAlign = ContentAlignment.BottomCenter;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += BtnMinimize_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ZipMyFile;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 19);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 20;
            label2.Text = " | ZipMyfile";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(488, 263);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(btnMinimize);
            Controls.Add(pgbZip);
            Controls.Add(lblProgresso);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxDiretorios);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(488, 286);
            Name = "frmMain";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Zip My File";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            MouseDown += FrmMain_MouseDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxDiretorios.ResumeLayout(false);
            groupBoxDiretorios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProgresso;
        private Label lblDiretorioEntrada;
        private TextBox ctrTextoDiretorioEntrada;
        private Button btnDiretorioEntrada;
        private Button btnCancel;
        private Button btnOk;
        private Label lblNomeArquivoSaida;
        private TextBox ctrTextoNomeArquivo;
        private Label lblNomeCompletoArquivo;
        private Button btnDiretorioSaida;
        private Label label1;
        private TextBox ctrTextoDiretorioSaida;
        private GroupBox groupBox1;
        private GroupBox groupBoxDiretorios;
        private ProgressBar pgbZip;
        private Button btnMinimize;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Label label2;
    }
}