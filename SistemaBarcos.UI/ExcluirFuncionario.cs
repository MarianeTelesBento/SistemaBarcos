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
    public partial class ExcluirFuncionario : Form
    {
        public ExcluirFuncionario()
        {
            InitializeComponent();
        }

        private void TXTIdFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNExcluirFuncionario_Click(object sender, EventArgs e)
        {
            Exclusao exclusao = new Exclusao();

            bool validacao = exclusao.ValidarCampoVazio(TXTIdFuncionario.Text);
            int DadoExcluido = 0;

            if (validacao)
            {
                DadoExcluido = exclusao.ExcluirDados("Funcionario", TXTIdFuncionario.Text);

                if (DadoExcluido > 0)
                {
                    MessageBox.Show("Dados excluidos com sucesso.");
                }
                else
                {
                    MessageBox.Show("ID não encontrado");
                    MessageBox.Show("Nenhum dado foi excluido.");
                    TXTIdFuncionario.Clear();
                }
            }
            else
            {
                MessageBox.Show("Os Campos não podem ser vazio");
            }
        }

    }
}
