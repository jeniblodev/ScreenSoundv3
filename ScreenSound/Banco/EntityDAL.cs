using ScreenSound.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal abstract class EntityDAL<T> 
    {

        public abstract IEnumerable<T> Listar();
        public abstract void Adicionar(T objeto);

    }
}
