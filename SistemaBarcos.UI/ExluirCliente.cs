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
    public partial class ExluirCliente : Form
    {
        public ExluirCliente()
        {
            InitializeComponent();
        }

        private void TXTIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNExcluirCliente_Click(object sender, EventArgs e)
        {
            Exclusao exclusao = new Exclusao();

            bool validacao = exclusao.ValidarCampoVazio(TXTIdCliente.Text);
            int DadoExcluido = 0;

            if (validacao)
            {
                DadoExcluido = exclusao.ExcluirDados("Cliente", TXTIdCliente.Text);

                if (DadoExcluido > 0)
                {
                    MessageBox.Show("Dados excluidos com sucesso.");
                }
                else
                {
                    MessageBox.Show("ID não encontrado");
                    MessageBox.Show("Nenhum dado foi excluido.");
                    TXTIdCliente.Clear();
                }
            }
            else
            {
                MessageBox.Show("Os Campos não podem ser vazio");
            }
        }
    }
}
