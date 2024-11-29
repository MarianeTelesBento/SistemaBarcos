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

        private void BTNCadastrarCliente_Click_1(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }

        private void BTNExcluirCliente_Click_1(object sender, EventArgs e)
        {
            ExluirCliente excluirCliente = new ExluirCliente();
            excluirCliente.Show();
        }

        private void BTNCadastrarFuncionario_Click_1(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.Show();
        }

        private void BTNExcluirFuncionario_Click_1(object sender, EventArgs e)
        {
            ExcluirFuncionario excluirFuncionario = new ExcluirFuncionario();
            excluirFuncionario.Show();
        }

        private void BTNExcluirBarco_Click_1(object sender, EventArgs e)
        {
            ExcluirBarco excluirBarco = new ExcluirBarco();
            excluirBarco.Show();
        }

        private void BTNCadastroBarco_Click_1(object sender, EventArgs e)
        {
            CadastroBarco cadastroBarco = new CadastroBarco();
            cadastroBarco.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarBarco buscarBarco = new BuscarBarco();
            buscarBarco.Show();
        }
    }
}
