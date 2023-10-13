using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    public class Connection
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        
        public SqlConnection ObterConexao()
        {
            return new SqlConnection(connectionString);
        }

        public void  ListarArtistas()
        {
            var connection = ObterConexao();
            connection.Open();

            string sql = "SELECT * FROM Artistas";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();

            
            while (dataReader.Read())
            {
                Console.WriteLine($"{dataReader["Id"]}, {dataReader["Nome"]}, {dataReader["FotoPerfil"]}, {dataReader["Bio"]}");
            }

            dataReader.Close();
        }
    }

}
