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
            int DadoCadastrado = 0;

            Cadastro cadastro = new Cadastro();

            bool validacao = cadastro.ValidarCampoVazio(TXTNomeCliente.Text, TXTEmailCliente.Text, TXTTelefoneCliente.Text);
            bool validarAno = cadastro.ValidarAno(TXTEmailCliente.Text);


            if (validacao)
            {
                if (validarAno)
                {
                    DadoCadastrado = cadastro.CadastrarDados("Barco", TXTNomeCliente.Text, TXTEmailCliente.Text, TXTTelefoneCliente.Text);
                }
                else
                {
                    MessageBox.Show("O ano inválido");
                }
            }
            else
            {
                MessageBox.Show("O Campo não pode ser vazio");//Arrumar a verificação do ano
            }

            if (DadoCadastrado > 0)
            {
                MessageBox.Show("Dados cadastrados com sucesso.");
                TXTNomeCliente.Clear();
                TXTEmailCliente.Clear();
                TXTTelefoneCliente.Clear();
            }
            else
            {
                MessageBox.Show("Nenhum dado foi cadastrado");
            }
        }


    }
}
