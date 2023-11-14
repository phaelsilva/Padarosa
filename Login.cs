﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Instanciar um usuario:
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Email = txbEmail.Text;
            usuario.Senha = txbSenha.Text;

            //Obter o resultado do SELECT no banco:
            var resultado = usuario.Logar();

            if(resultado.Rows.Count == 1)
            {
                //Senha correta: Prosseguir..
                usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                usuario.Id = (int)resultado.Rows[0]["id"];
                //Proximo passo abrir a janela menu:
                MenuPrincipal janela = new MenuPrincipal(usuario);
                //Esconder a janela atual:
                Hide();
                //Mostrar o menu:
                janela.ShowDialog();
                //Mostrar o login quando o menu fechar:
                Show();
            }
            else
            {
                //Senha incorreta:
                MessageBox.Show("Email ou senha incorretas.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
