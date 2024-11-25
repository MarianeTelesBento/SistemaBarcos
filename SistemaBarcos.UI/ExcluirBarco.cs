using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using SistemaBarcos.UI.Models;

namespace SistemaBarcos.UI
{
    public partial class ExcluirBarco : Form
    {
        public ExcluirBarco()
        {
            InitializeComponent();
        }

        private void TXTIdBarco_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNExcluirBarco_Click(object sender, EventArgs e)
        {
            Exclusao exclusao = new Exclusao();

            bool validacao = exclusao.ValidarCampo(TXTIdBarco.Text);
            int DadoExcluido = 0;

            if (validacao)
            {
                DadoExcluido = exclusao.ExcluirDados("Barco", TXTIdBarco.Text);
            }
            else
            {
                MessageBox.Show("Os Campos não podem ser vazio");
            }

            if (validacao && DadoExcluido > 0)
            {
                MessageBox.Show("Dados excluidos com sucesso.");
            }
            else
            {
                MessageBox.Show("Nenhum dado foi excluido.");
            }

        }
    }
}
