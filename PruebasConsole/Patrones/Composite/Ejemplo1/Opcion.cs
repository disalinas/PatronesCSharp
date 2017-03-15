using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsole.Patrones.Composite.Ejemplo1
{
    abstract class Opcion
    {
        protected string nombre;

        public Opcion(string pNombre)
        {
            this.nombre = pNombre;
        }

        public abstract void Add(Opcion pOp);
        public abstract void Remove(Opcion pOp);
        public abstract void Mostrar(int pNivel);
    }
}
