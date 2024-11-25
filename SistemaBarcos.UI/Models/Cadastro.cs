using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SistemaBarcos.UI.Models
{
    public class Cadastro : Validacao
    {

        public int CadastrarDados(string table, string d1, string d2, string d3)
        {
            string connectionString = "Data Source=FAC0539673W10-1;Initial Catalog=M34Db;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand($"insert into {table} values(@d1, @d2, @d3); ", connection);

            command.Parameters.AddWithValue("@d1", d1);
            command.Parameters.AddWithValue("@d2", d2);
            command.Parameters.AddWithValue("@d3", d3);

            return command.ExecuteNonQuery();
        }
    }
}
