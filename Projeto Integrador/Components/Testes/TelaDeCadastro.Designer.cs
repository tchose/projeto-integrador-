namespace Projeto_Integrador
{
    partial class TelaDeCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeCadastro));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            textBox3 = new TextBox();
            lbl_senha = new Label();
            lbl_email = new Label();
            lbl_endereço = new Label();
            btn_Cadastrar = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txt_DigiteNome = new TextBox();
            lbl_nome = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(101, 56, 25);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(lbl_senha);
            panel1.Controls.Add(lbl_email);
            panel1.Controls.Add(lbl_endereço);
            panel1.Controls.Add(btn_Cadastrar);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txt_DigiteNome);
            panel1.Controls.Add(lbl_nome);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 681);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 42);
            pictureBox2.Margin = new Padding(8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(471, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(66, 418);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(353, 23);
            textBox3.TabIndex = 16;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Poor Richard", 25F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_senha.Location = new Point(197, 387);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(70, 28);
            lbl_senha.TabIndex = 15;
            lbl_senha.Text = "Senha";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Poor Richard", 25F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_email.Location = new Point(197, 266);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(67, 28);
            lbl_email.TabIndex = 14;
            lbl_email.Text = "Email";
            // 
            // lbl_endereço
            // 
            lbl_endereço.AutoSize = true;
            lbl_endereço.Font = new Font("Poor Richard", 25F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_endereço.Location = new Point(184, 327);
            lbl_endereço.Name = "lbl_endereço";
            lbl_endereço.Size = new Size(100, 28);
            lbl_endereço.TabIndex = 13;
            lbl_endereço.Text = "Endereço";
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = Color.FromArgb(101, 56, 25);
            btn_Cadastrar.FlatStyle = FlatStyle.Flat;
            btn_Cadastrar.Font = new Font("Poor Richard", 25F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_Cadastrar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cadastrar.Location = new Point(143, 484);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(177, 56);
            btn_Cadastrar.TabIndex = 11;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 358);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(353, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 297);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 23);
            textBox1.TabIndex = 7;
            // 
            // txt_DigiteNome
            // 
            txt_DigiteNome.Location = new Point(66, 240);
            txt_DigiteNome.Name = "txt_DigiteNome";
            txt_DigiteNome.Size = new Size(353, 23);
            txt_DigiteNome.TabIndex = 6;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Poor Richard", 25F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_nome.ForeColor = SystemColors.ButtonFace;
            lbl_nome.Location = new Point(199, 209);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(68, 28);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(494, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(730, 681);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form_loginexemplo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 681);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form_loginexemplo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_nome;
        private TextBox txt_DigiteNome;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btn_Cadastrar;
        private TextBox textBox3;
        private Label lbl_senha;
        private Label lbl_email;
        private Label lbl_endereço;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}