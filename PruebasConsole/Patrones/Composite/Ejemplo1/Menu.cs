using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsole.Patrones.Composite.Ejemplo1
{
    class Menu : Opcion
    {
        private List<Opcion> opciones;

        public Menu(string pNombre) : base(pNombre)
        {
            this.opciones = new List<Opcion>();
        }

        public override void Add(Opcion pOp)
        {
            this.opciones.Add(pOp);
        }

        public override void Remove(Opcion pOp)
        {
            this.opciones.Remove(pOp);
        }

        public override void Mostrar(int pNivel)
        {
            Console.WriteLine(new string('>', pNivel++) + " " + this.nombre);
            foreach (Opcion op in this.opciones)
            {
                op.Mostrar(pNivel);
            }
        }
    }
}
