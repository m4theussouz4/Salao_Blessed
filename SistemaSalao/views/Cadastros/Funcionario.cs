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
    public partial class frm_funcionario : Form
    {
        public frm_funcionario()
        {
            InitializeComponent();
        }

        private void habilitar_campos()
        {
            txt_nome.Enabled = true;
            txt_email.Enabled = true;
            txt_telefone.Enabled = true;
            txt_cpf.Enabled = true;
            txt_cargo.Enabled = true;
            txt_nome.Focus();

        }

        private void desabilitar_campos()
        {
            txt_nome.Enabled = false;
            txt_email.Enabled = false;
            txt_telefone.Enabled = false;
            txt_cpf.Enabled = false;
            txt_cargo.Enabled = false;
        }

        private void limpar_campos()
        {
            txt_nome.Text = "";
            txt_email.Text = "";
            txt_telefone.Text = "";
            txt_cpf.Text = "";
        }

        private void frm_funcionario_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            habilitar_campos();
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
                MessageBox.Show("Preencha o nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nome.Text = "";
                txt_nome.Focus();
                return;
            }

            if (txt_cpf.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_cpf.Text = "";
                txt_cpf.Focus();
                return;
            }

            if (txt_telefone.Text == "     -")
            {
                MessageBox.Show("Preencha o telefone", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_telefone.Text = "";
                txt_telefone.Focus();
                return;
            }

            MessageBox.Show("Salvo com sucesso!", "Dados salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_add.Enabled = true;
            btn_salvar.Enabled = false;
            limpar_campos();
            desabilitar_campos();


        }

        private void grid_Click(object sender, EventArgs e)
        {
            btn_editar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_salvar.Enabled = false;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            habilitar_campos();
            if (txt_nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nome.Text = "";
                txt_nome.Focus();
                return;
            }

            if (txt_cpf.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_cpf.Text = "";
                txt_cpf.Focus();
                return;
            }

            if (txt_telefone.Text == "     -")
            {
                MessageBox.Show("Preencha o telefone", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_telefone.Text = "";
                txt_telefone.Focus();
                return;
            }

            MessageBox.Show("Editado com sucesso!", "Dados salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_add.Enabled = true;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            limpar_campos();
            desabilitar_campos();

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
