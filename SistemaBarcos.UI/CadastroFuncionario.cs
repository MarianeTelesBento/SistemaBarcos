using SistemaBarcos.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBarcos.UI
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            TXTNomeFuncionario.Clear();
            TXTCargoFuncionario.Clear();
            TXTAdmissaoFuncionario.Clear();
        }

        private void TXTNomeFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTCargoFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTAdmissaoFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            int dadoCadastrado = 0;

            bool validacao = cadastro.ValidarCampoVazio(TXTNomeFuncionario.Text, TXTCargoFuncionario.Text, TXTAdmissaoFuncionario.Text);
            bool validarData = cadastro.ValidarData(TXTAdmissaoFuncionario.Text);

            if (validacao)
            {
                if (validarData)
                {
                    dadoCadastrado = cadastro.CadastrarDados("Funcionario", TXTNomeFuncionario.Text, TXTCargoFuncionario.Text, TXTAdmissaoFuncionario.Text);
                }
                else
                {
                    MessageBox.Show("Data inválida");
                    TXTAdmissaoFuncionario.Clear();
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
