using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSalao
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            pnl_login.Visible = false;
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            pnl_login.Location = new Point((this.Width/2) - 166, (this.Height/2) - 170);
            pnl_login.Visible = Visible;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            chamar_login();
        }

        private void frm_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chamar_login();
            }
        }

        private void chamar_login()
        {
            if (txt_usuario.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Informe o usuário", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_usuario.Text = "";
                txt_usuario.Focus();
                return;
            }
            if (txt_senha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Entre com a senha", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_senha.Text = "";
                txt_usuario.Focus();
                return;
            }


            frm_menu form1 = new frm_menu();
            limpar();
            form1.Show();
            this.Visible = false;

        }

        private void limpar()
        {
            txt_usuario.Text = "";
            txt_senha.Text = "";
            txt_usuario.Focus();
        }

        private void frm_login_Resize(object sender, EventArgs e)
        {
            pnl_login.Location = new Point((this.Width / 2) - 166, (this.Height / 2) - 170);
        }





    }
}
