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
    internal class ArtistaDAL: EntityDAL<Artista> 
    {

        public ArtistaDAL(ScreenSoundContext context) : base(context) { }

        public Artista? RecuperarPeloNome(string nome)
        {
            var artista = context.Artistas.FirstOrDefault(a => a.Nome == nome);
            if (artista != null)
            {
                return artista;
            }
            else
            {
                Console.WriteLine("Artista não encontrado, tente outro Id.");
                return null;
            }

        }


    }
}
