using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SistemaBarcos.UI.Models
{
    public class Editar : Validacao
    {
        
        public void EditarDados(string table, string d1)
        {
            string connectionString = "Data Source=FAC0539673W10-1;Initial Catalog=M34Db;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand pesquisaCommand = new SqlCommand($"SELECT * FROM {table} WHERE id = @d1; ", connection);

            pesquisaCommand.Parameters.AddWithValue("@d1", d1);

            SqlDataReader reader = pesquisaCommand.ExecuteReader();

            if (reader.HasRows)//Preenche os TEXTS se ouver linha
            {
                d1 = reader["CapacidadePassageirosBarco"].ToString();
            }
            else
            {
                MessageBox.Show("ID, não encontrado");
            }

            connection.Close();

        }
        
    }
}
