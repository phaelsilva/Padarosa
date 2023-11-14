using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa.Views
{
    public partial class GerenciamentoUsuarios : Form
    {
        //Atributos globais:
        int idSelecionado = 0;
        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario = new Classes.Usuario();

            //Atribuir a tabela(resultado do SELECT) no DGV:
            dgvUsuario.DataSource = usuario.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciar o usuário:
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.NomeCompleto = txbNomecad.Text;
            usuario.Email = txbEmailcad.Text;
            usuario.Senha = txbSenhacad.Text;

            if(usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                //Limpar os campos:
                txbNomecad.Clear();
                txbEmailcad.Clear();
                txbSenhacad.Clear();
                //Atualizar o dgv:
                dgvUsuario.DataSource = usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o usuário!");
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ativar os grbs:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;
            
            //Obter a linha clicada:
            int linhaSelecionada = dgvUsuario.CurrentCell.RowIndex;

            //Armazenar os dados da linha selecionada em "linha" (tipo um vetor):
            var linha = dgvUsuario.Rows[linhaSelecionada];

            txbNomecompletoedi.Text = linha.Cells[1].Value.ToString();
            txbEmailedi.Text = linha.Cells[2].Value.ToString();

            //Juntar o ID e o nome para exibir no apagar:
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            //Salvar o id selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = idSelecionado;
            //Apagar:

        }
    }
}
