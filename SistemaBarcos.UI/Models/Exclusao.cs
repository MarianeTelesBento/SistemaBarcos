﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SistemaBarcos.UI.Models
{
    public class Exclusao : Validacao
    {

        public int ExcluirDados(string table, string id)
        {
            string connectionString = "Data Source=FAC0539673W10-1;Initial Catalog=M34Db;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand($"DELETE {table} WHERE Id{table} = {id}; ", connection);
            
            return command.ExecuteNonQuery();
        }
    }
}
