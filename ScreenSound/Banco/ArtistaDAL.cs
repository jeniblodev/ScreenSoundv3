using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Context;
using Microsoft.EntityFrameworkCore;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL
    {
        private readonly ScreenSoundContext context;

        public ArtistaDAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public IEnumerable<Artista> ListarArtistas() 
        {
            return context.Artistas.ToList();
        }

        public void AdicionarArtista(string nome, string bio)
        {
            var artista = new Artista(nome, bio)
            {
                Nome = nome,
                Bio = bio
            };

            context.Artistas.Add(artista);
            context.SaveChanges();
           
        }

        public void DeletarArtista(int id)
        {
            var artista = context.Artistas.Find(id);
            if(artista != null)
            {
                context.Artistas.Remove(artista);
                context.SaveChanges();
                Console.WriteLine("Artista removido com sucesso.");
            } else
            {
                Console.WriteLine("Artista não encontrado, tente outro Id.");
            }
        }

        public void AtualizarArtista(int id,  string nome, string bio)
        {
            if (context.Artistas.Any(a => a.Id == id))
            {
                var artistaEditado = new Artista(nome, bio, id);
                context.Artistas.Update(artistaEditado);
                context.SaveChanges();
                Console.WriteLine("Artista atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Artista não encontrado, tente outro Id.");
            }

        }
    }
}
