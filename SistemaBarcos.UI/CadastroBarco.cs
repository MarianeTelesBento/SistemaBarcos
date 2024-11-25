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
    public partial class CadastroBarco : Form
    {
        public CadastroBarco()
        {
            InitializeComponent();
        }



        private void TXTNomeBarco_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTFabricacaoBarco_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTCapacidadeBarco_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCadastrarBarco_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            int DadoCadastrado = cadastro.CadastrarDados("Barco", TXTNomeBarco.Text, TXTFabricacaoBarco.Text, TXTCapacidadeBarco.Text);

            bool validacao = cadastro.ValidarCampo(TXTNomeBarco.Text, TXTFabricacaoBarco.Text, TXTCapacidadeBarco.Text);

            if (validacao && DadoCadastrado > 0)
            {
                MessageBox.Show("Dados cadastrados com sucesso.");
                TXTNomeBarco.Clear();
                TXTFabricacaoBarco.Clear();
                TXTCapacidadeBarco.Clear();
            }
            else
            {
                MessageBox.Show("Nenhum dado foi inserido.");
            }

           

        }
    }
}
