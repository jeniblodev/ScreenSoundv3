using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL
    {
        public void ListarArtistas()
        {
            var connection = new Connection().ObterConexao();
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

        public void AdicionarArtista(string nome, string bio)
        {
            var connection = new Connection().ObterConexao();
            connection.Open();

            var fotoPerfilPadrao = "https://img.freepik.com/vetores-gratis/silhueta-feminina_23-2147524227.jpg";

            string sql = $"INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES ('{nome}', '{fotoPerfilPadrao}', '{bio}')";
            SqlCommand command = new SqlCommand(sql, connection);
            
            int retorno = command.ExecuteNonQuery();

            Console.WriteLine($"Linhas afetadas: {retorno}");
        }

        public void AtualizarArtista(int id, string nome, string bio)
        {
            var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = $"UPDATE Artistas SET Nome = '{nome}', Bio = '{bio}' WHERE Id = {id}";               
            SqlCommand command = new SqlCommand(sql, connection);

            int retorno = command.ExecuteNonQuery();

            Console.WriteLine($"Linhas afetadas: {retorno}");
        }

        public void DeletarArtista(int id)
        {
            var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = $"DELETE FROM Artistas WHERE Id = {id}";
            SqlCommand command = new SqlCommand(sql, connection);

            int retorno = command.ExecuteNonQuery();

            Console.WriteLine($"Linhas afetadas: {retorno}");
        }
    }
}
