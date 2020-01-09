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

    public partial class frm_menu : Form
    {


        public frm_menu()
        {
            InitializeComponent();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            chamar_outro_form();
        }

        public void chamar_outro_form()
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is frm_login
                         select frm;

            if(qrForm != null && qrForm.Count() > 0)
            {
                ((frm_login)qrForm.First()).Show();
            }
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(230, 230, 230);
            pnl_right.BackColor = Color.FromArgb(170, 170, 170);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.Cadastros.frm_cliente form = new views.Cadastros.frm_cliente();
            form.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.Cadastros.frm_funcionario form = new views.Cadastros.frm_funcionario();
            form.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.Cadastros.frm_cargo form = new views.Cadastros.frm_cargo();
            form.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.Cadastros.frm_produto form = new views.Cadastros.frm_produto();
            form.Show();
        }


        
    }
}
