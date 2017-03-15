using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsole.Patrones.Composite.Ejemplo1
{
    class PuntoMenu : Opcion
    {
        public PuntoMenu(string pNombre) : base(pNombre)
        {
        }

        public override void Add(Opcion pOp)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Opcion pOp)
        {
            throw new NotImplementedException();
        }

        public override void Mostrar(int pNivel)
        {
            Console.WriteLine(new string('>', pNivel++) + " " + this.nombre);
        }
    }
}
