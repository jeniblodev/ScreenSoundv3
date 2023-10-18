using ScreenSound.Context;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class MusicaDAL
    {
        private readonly ScreenSoundContext context;

        public MusicaDAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public IEnumerable<Musica> Listar()
        {
            return context.Musicas.ToList();
        }

        public void Adicionar(string nome)
        {
            var musica = new Musica(nome)
            {
                Nome = nome
            };

            context.Musicas.Add(musica);
            context.SaveChanges();

        }

        public void Deletar(int id)
        {
            var musica = context.Musicas.Find(id);
            if (musica != null)
            {
                context.Musicas.Remove(musica);
                context.SaveChanges();
                Console.WriteLine("Música removida com sucesso.");
            }
            else
            {
                Console.WriteLine("Música não encontrada, tente outro Id.");
            }
        }

        public void Atualizar(int id, string nome)
        {
            if (context.Musicas.Any(a => a.Id == id))
            {
                var musicaEditada = new Musica(nome);
                context.Musicas.Update(musicaEditada);
                context.SaveChanges();
                Console.WriteLine("Música atualizada com sucesso.");
            }
            else
            {
                Console.WriteLine("Música não encontrada, tente outro Id.");
            }

        }

        public Musica RecuperarPeloNome(string nome)
        {
            var musica = context.Musicas.FirstOrDefault(a => a.Nome == nome);
            if (musica != null)
            {
                return musica;
            }
            else
            {
                Console.WriteLine("Música não encontrada, tente outro Id.");
                return null;
            }

        }
    }
}
