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
            exclusao.ExcluirDados("Barco", TXTIdBarco.Text);
        }
    }
}
