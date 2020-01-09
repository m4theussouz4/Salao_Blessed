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
    public partial class frm_produto : Form
    {
        public frm_produto()
        {
            InitializeComponent();
        }

        private void habilitar_campos()
        {
            txt_nome.Enabled = true;
            txt_validade.Enabled = true;
            txt_estoque.Enabled = true;
            txt_fabricante.Enabled = true;
            btn_imagem.Enabled = true;
            txt_nome.Focus();

        }

        private void desabilitar_campos()
        {
            txt_nome.Enabled = false;
            txt_validade.Enabled = false;
            txt_estoque.Enabled = false;
            txt_fabricante.Enabled = false;
            btn_imagem.Enabled = false;
        }

        private void limpar_campos()
        {
            txt_nome.Text = "";
            txt_validade.Text = "";
            txt_estoque.Text = "";
            txt_fabricante.Text = "";
            limpar_foto();
        }

        private void limpar_foto()
        {
            imagem.Image = Properties.Resources.sem_foto;
        }


        private void frm_produto_Load(object sender, EventArgs e)
        {
            limpar_foto();
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

            if (txt_validade.Text == "  /  /")
            {
                MessageBox.Show("Coloque a data de validade", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_validade.Text = "";
                txt_validade.Focus();
                return;
            }

            MessageBox.Show("Salvo com sucesso!", "Dados salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_add.Enabled = true;
            btn_salvar.Enabled = false;
            limpar_campos();
            desabilitar_campos();
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

            if (txt_validade.Text == "   .   .   -")
            {
                MessageBox.Show("Coloque a data de validade", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_validade.Text = "";
                txt_validade.Focus();
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

        private void grid_Click(object sender, EventArgs e)
        {
            btn_editar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_salvar.Enabled = false;
        }

        private void btn_imagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Arquivo de Imagens|*.jpg;*.png;*.jpeg;*.gif" + "|Todos os arquivos|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                imagem.ImageLocation = foto;
            }
        }







    }
}
