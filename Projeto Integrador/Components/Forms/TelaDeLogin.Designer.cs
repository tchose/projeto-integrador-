namespace Projeto_Integrador
{
    partial class TelaDeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeLogin));
            pictureBox1 = new PictureBox();
            lbl_Nome = new Label();
            txt_DigiteNome = new TextBox();
            lbl_Senha = new Label();
            txt_DigiteSenha = new TextBox();
            btn_Login = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(762, 686);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_Nome
            // 
            lbl_Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Nome.AutoSize = true;
            lbl_Nome.BackColor = Color.FromArgb(101, 56, 25);
            lbl_Nome.FlatStyle = FlatStyle.Flat;
            lbl_Nome.Font = new Font("Poor Richard", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Nome.ForeColor = Color.White;
            lbl_Nome.Location = new Point(949, 258);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(83, 31);
            lbl_Nome.TabIndex = 2;
            lbl_Nome.Text = "Nome:";
            // 
            // txt_DigiteNome
            // 
            txt_DigiteNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_DigiteNome.BackColor = SystemColors.ButtonFace;
            txt_DigiteNome.BorderStyle = BorderStyle.FixedSingle;
            txt_DigiteNome.Location = new Point(851, 292);
            txt_DigiteNome.Name = "txt_DigiteNome";
            txt_DigiteNome.Size = new Size(292, 23);
            txt_DigiteNome.TabIndex = 6;
            // 
            // lbl_Senha
            // 
            lbl_Senha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Senha.AutoSize = true;
            lbl_Senha.BackColor = Color.FromArgb(101, 56, 25);
            lbl_Senha.Font = new Font("Poor Richard", 20.25F, FontStyle.Bold);
            lbl_Senha.ForeColor = SystemColors.ButtonHighlight;
            lbl_Senha.Location = new Point(947, 344);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(85, 31);
            lbl_Senha.TabIndex = 7;
            lbl_Senha.Text = "Senha:";
            // 
            // txt_DigiteSenha
            // 
            txt_DigiteSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_DigiteSenha.BorderStyle = BorderStyle.FixedSingle;
            txt_DigiteSenha.Location = new Point(851, 378);
            txt_DigiteSenha.Name = "txt_DigiteSenha";
            txt_DigiteSenha.Size = new Size(292, 23);
            txt_DigiteSenha.TabIndex = 9;
            // 
            // btn_Login
            // 
            btn_Login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_Login.BackColor = Color.FromArgb(101, 56, 25);
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Poor Richard", 20.25F, FontStyle.Bold);
            btn_Login.ForeColor = SystemColors.ControlLightLight;
            btn_Login.Location = new Point(910, 460);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(167, 44);
            btn_Login.TabIndex = 10;
            btn_Login.Text = "login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(762, 17);
            pictureBox2.Margin = new Padding(8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(445, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // TelaDeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 56, 25);
            ClientSize = new Size(1212, 686);
            Controls.Add(pictureBox2);
            Controls.Add(btn_Login);
            Controls.Add(txt_DigiteSenha);
            Controls.Add(lbl_Senha);
            Controls.Add(txt_DigiteNome);
            Controls.Add(lbl_Nome);
            Controls.Add(pictureBox1);
            Name = "TelaDeLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "teladelogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_Nome;
        private TextBox txt_DigiteNome;
        private Label lbl_Senha;
        private TextBox txt_DigiteSenha;
        private Button btn_Login;
        private PictureBox pictureBox2;
    }
}