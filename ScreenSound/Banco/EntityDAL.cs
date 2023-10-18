using Microsoft.EntityFrameworkCore.Infrastructure;
using ScreenSound.Context;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal abstract class EntityDAL<T> where T : class
    {
        protected readonly ScreenSoundContext context;

        protected EntityDAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public virtual IEnumerable<T> Listar()
        {
            return context.Set<T>().ToList();
        }
        public virtual void Adicionar(T objeto)
        {
            context.Set<T>().Add(objeto);
            context.SaveChanges();
        }

        public virtual void Deletar(T objeto)
        {
            context.Set<T>().Remove(objeto);
            context.SaveChanges();
            Console.WriteLine($"{typeof(T)} removido com sucesso.");
            
        }

        public virtual void Atualizar(T objeto)
        {

            context.Set<T>().Update(objeto);
            context.SaveChanges();
            Console.WriteLine($"{typeof(T)} atualizado com sucesso.");

        }

    }
}
