using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarcos.UI.Models
{
    public class Validacao
    {
        public bool ValidarCampo(string d1)
        {
            if (d1 == string.Empty)
            {
                return false;
            }
            return true;
        }

        public bool ValidarCampo(string d1, string d2, string d3)
        {
            if (d1 == string.Empty && d2 == string.Empty && d3 == string.Empty)
            {
                return false;
            }
            return true;
        }
    }
}
