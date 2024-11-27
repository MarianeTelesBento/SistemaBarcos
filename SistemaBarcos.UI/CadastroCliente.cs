using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SistemaBarcos.UI.Models;

namespace SistemaBarcos.UI
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            TXTNomeCliente.Clear();
            TXTEmailCliente.Clear();
            TXTTelefoneCliente.Clear();
        }

        private void TXTNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void TXTEmailCliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void TXTTelefoneCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            int dadoCadastrado = 0;

            bool validacao = cadastro.ValidarCampoVazio(TXTNomeCliente.Text, TXTEmailCliente.Text, TXTTelefoneCliente.Text);
            bool validarNumero = cadastro.ValidarAno(TXTTelefoneCliente.Text);

            if (validacao)
            {
                if (validarNumero)
                {
                    dadoCadastrado = cadastro.CadastrarDados("Cliente", TXTNomeCliente.Text, TXTEmailCliente.Text, TXTTelefoneCliente.Text);
                }
                else
                {
                    MessageBox.Show("Numero de telefone inválido");
                    TXTTelefoneCliente.Clear();
                }
            }
            else
            {
                MessageBox.Show("O Campo não pode ser vazio");
            }

            if (dadoCadastrado > 0)
            {
                MessageBox.Show("Dados cadastrados com sucesso.");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Nenhum dado foi cadastrado");
            }
        }


    }
}
