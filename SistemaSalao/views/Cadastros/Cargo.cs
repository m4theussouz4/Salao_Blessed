using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSalao.views.Cadastros
{
    public partial class frm_cargo : Form
    {
        public frm_cargo()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_nome.Enabled = true;
            btn_salvar.Enabled = true;
            btn_add.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            txt_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o cargo", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nome.Text = "";
                txt_nome.Focus();
                return;
            }
            MessageBox.Show("Salvo com sucesso!", "Dados salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_add.Enabled = true;
            btn_salvar.Enabled = false;
            txt_nome.Text = "";
            txt_nome.Enabled = false;
        }

        private void grid_Click(object sender, EventArgs e)
        {
            btn_editar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_salvar.Enabled = false;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            
            if (txt_nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o cargo", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nome.Text = "";
                txt_nome.Focus();
                return;
            }

            MessageBox.Show("Editado com sucesso!", "Dados salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_add.Enabled = true;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            txt_nome.Text = "";
            txt_nome.Enabled = false;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja excluir registro?", "Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Excluido com sucesso!", "Dados excluidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_add.Enabled = true;
                btn_editar.Enabled = false;
                btn_excluir.Enabled = false;
                txt_nome.Text = "";
                txt_nome.Enabled = false;
            }
        }





    }
}
