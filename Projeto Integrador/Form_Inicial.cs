using Projeto_Integrador.Utils;

namespace Projeto_Integrador
{
    public partial class projeto_integrador : System.Windows.Forms.Form
    {
        public projeto_integrador()
        {
            InitializeComponent();
            Rounded.setRoundedController(btn_cadastro, 16);
            Rounded.setRoundedController(btn_login, 16);
        }
            
        private void btn_login_Click(object sender, EventArgs e)
        {
            TelaDeLogin login = new TelaDeLogin();
            login.Show(this);

            this.Hide();
            login.FormClosing += delegate { this.Show(); };
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            TelaDeCadastro Cadastro = new TelaDeCadastro();
            Cadastro.Show();


            this.Hide();
            Cadastro.FormClosing += delegate { this.Show(); };
        }
    }
}
