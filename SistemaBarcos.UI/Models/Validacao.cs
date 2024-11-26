using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarcos.UI.Models
{
    public class Validacao
    {
        const int anoMinino = 1200;
        const int anoAtual = 2024;

        //Verifica de há dados no campo
        public bool ValidarCampoVazio(string d1)
        {
            if (d1 == string.Empty)
            {
                return false;
            }
            return true;
        }
        public bool ValidarCampoVazio(string d1, string d2, string d3)
        {
            if (d1 == string.Empty && d2 == string.Empty && d3 == string.Empty)
            {
                return false;
            }
            return true;
        }


        //Verifica se é um número
        public bool ValidarNumeros(string d1)
        {
            bool Int32.TryParse(d1, out int result);
            if (try())
            {
                return false;
            }
            return true;
        }


        //Verifica se o ano está entre 1200 e 2024
        public bool ValidarAno(string ano)
        {
            var anoConvert = int.Parse(ano);

            if (anoConvert >= anoMinino && anoConvert <= anoAtual)
            {
                return true;
            }
            return false;
        }


    }
}
