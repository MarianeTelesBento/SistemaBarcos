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
    public partial class BuscarBarco : Form
    {
        public BuscarBarco()
        {
            InitializeComponent();
        }

        private void TXTIDBuscaBarco_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTNomeBuscaBarco_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTDescricaoBuscaBarco_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();

            editar.EditarDados("Barco", TXTIDBuscaBarco.Text);
        }

        private void BTNBuscarSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
