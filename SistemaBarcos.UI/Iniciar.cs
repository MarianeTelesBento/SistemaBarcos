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
    public partial class Iniciar : Form
    {
        public Iniciar()
        {
            InitializeComponent();
        }

        //Barco
        private void BTNCadastroBarco_Click(object sender, EventArgs e)
        {
            CadastroBarco cadastroBarco = new CadastroBarco();
            cadastroBarco.Show();
        }

        private void BTNExcluirBarco_Click(object sender, EventArgs e)
        {
            ExcluirBarco excluirBarco = new ExcluirBarco();
            excluirBarco.Show();
        }

        //Cliente
        private void BTNCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }

        private void BTNExcluirCliente_Click(object sender, EventArgs e)
        {
            ExcluirBarco excluirBarco = new ExcluirBarco();
            excluirBarco.Show();
        }

        //Funcionário
        private void BTNCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.Show();
        }

        private void BTNExcluirFuncionario_Click(object sender, EventArgs e)
        {
            ExcluirFuncionario excluirFuncionario = new ExcluirFuncionario();
            excluirFuncionario.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
