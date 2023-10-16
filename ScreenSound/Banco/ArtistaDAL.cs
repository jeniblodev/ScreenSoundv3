using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Context;
namespace ScreenSound.Banco
{
    internal class ArtistaDAL
    {
        public IEnumerable<Artista> ListarArtistas() 
        {
            using ScreenSoundContext context = new ScreenSoundContext();
            return context.Artistas.ToList();
        }



        /*public void AdicionarArtista(string nome, string bio)
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
        }*/
    }
}
