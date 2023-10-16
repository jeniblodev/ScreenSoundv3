using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL
    {
        public IEnumerable<Artista> ListarArtistas()
        {
            var lista = new List<Artista>();
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = "SELECT * FROM Artistas";
            SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader dataReader = command.ExecuteReader();


            while (dataReader.Read())
            {
                string nomeArtista = Convert.ToString(dataReader["Nome"]);
                string bioArtista = Convert.ToString(dataReader["Bio"]);
                Artista artista = new(nomeArtista, bioArtista);
                lista.Add(artista);
            }

            return lista;
        }

        public void AdicionarArtista(string nome, string bio)
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();

            var fotoPerfilPadrao = "https://img.freepik.com/vetores-gratis/silhueta-feminina_23-2147524227.jpg";

            string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@perfilPadrao", fotoPerfilPadrao);
            command.Parameters.AddWithValue("@bio", bio);

            int retorno = command.ExecuteNonQuery();

            Console.WriteLine($"Linhas afetadas: {retorno}");
        }

        public void AtualizarArtista(int id, string nome, string bio)
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = $"UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id";               
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@bio", bio);
            command.Parameters.AddWithValue("@id", id);

            int retorno = command.ExecuteNonQuery();

            Console.WriteLine($"Linhas afetadas: {retorno}");
        }

        public void DeletarArtista(int id)
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = $"DELETE FROM Artistas WHERE Id = @id";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id", id);

            int retorno = command.ExecuteNonQuery();

            Console.WriteLine($"Linhas afetadas: {retorno}");
        }
    }
}
