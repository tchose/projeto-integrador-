namespace Projeto_Integrador
{
    partial class projeto_integrador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(projeto_integrador));
            btn_login = new Button();
            btn_cadastro = new Button();
            ptb_teladefundo = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ptb_teladefundo).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Bottom;
            btn_login.BackColor = Color.FromArgb(242, 192, 41);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Poor Richard", 25F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            btn_login.Location = new Point(274, 444);
            btn_login.Margin = new Padding(11, 10, 11, 10);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(209, 51);
            btn_login.TabIndex = 1;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_cadastro
            // 
            btn_cadastro.Anchor = AnchorStyles.Bottom;
            btn_cadastro.BackColor = Color.Red;
            btn_cadastro.FlatAppearance.BorderColor = Color.Black;
            btn_cadastro.FlatAppearance.BorderSize = 0;
            btn_cadastro.FlatStyle = FlatStyle.Flat;
            btn_cadastro.Font = new Font("Poor Richard", 25F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            btn_cadastro.ForeColor = SystemColors.ControlLightLight;
            btn_cadastro.Location = new Point(744, 444);
            btn_cadastro.Margin = new Padding(11, 10, 11, 10);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(209, 58);
            btn_cadastro.TabIndex = 2;
            btn_cadastro.Text = "Cadastrar";
            btn_cadastro.UseVisualStyleBackColor = false;
            btn_cadastro.Click += btn_cadastro_Click;
            // 
            // ptb_teladefundo
            // 
            ptb_teladefundo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ptb_teladefundo.Image = (Image)resources.GetObject("ptb_teladefundo.Image");
            ptb_teladefundo.Location = new Point(1, 0);
            ptb_teladefundo.Margin = new Padding(0);
            ptb_teladefundo.Name = "ptb_teladefundo";
            ptb_teladefundo.Size = new Size(1224, 652);
            ptb_teladefundo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_teladefundo.TabIndex = 0;
            ptb_teladefundo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(67, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 525);
            panel1.TabIndex = 3;
            // 
            // projeto_integrador
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 652);
            Controls.Add(btn_cadastro);
            Controls.Add(btn_login);
            Controls.Add(ptb_teladefundo);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Margin = new Padding(4);
            MinimumSize = new Size(640, 420);
            Name = "projeto_integrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "projeto integrador";
            ((System.ComponentModel.ISupportInitialize)ptb_teladefundo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_login;
        private Button btn_cadastro;
        private PictureBox ptb_teladefundo;
        private Panel panel1;
    }
}
