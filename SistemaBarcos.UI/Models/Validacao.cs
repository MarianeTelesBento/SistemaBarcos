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
        int anoAtual = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
        string dataAtual = DateTime.Now.ToString("dd/MM/yyyy");

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
        public bool ValidarNumero(string d1)
        {
            bool sucesso = Int32.TryParse(d1, out int result);

            if (sucesso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Verifica se o ano está entre 1200 e 2024
        public bool ValidarAno(string ano)
        {
            bool valido = ValidarNumero(ano);

            if (valido)
            {
                var anoConvert = int.Parse(ano);

                if (anoConvert >= anoMinino && anoConvert <= anoAtual)
                {
                    return true;
                }
            }
            return false;
        }

        //Verifica se o ano está abaixo de 2024
        public bool ValidarData(string data)
        {
            bool valido = ValidarNumero(data);

            if (valido)
            {
                var anoConvert = int.Parse(data);

                if (anoConvert <= anoAtual)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
