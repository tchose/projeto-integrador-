using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace Projeto_Integrador
{
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seja bem vindo - {txt_DigiteNome.Text}");
            //lbl_Nome.Text = "Ola " + txt_DigiteNome.Text;
        }
    }
}
