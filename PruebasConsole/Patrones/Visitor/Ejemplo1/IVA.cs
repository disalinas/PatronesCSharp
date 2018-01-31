using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsole.Patrones.Visitor.Ejemplo1
{
    class IVA : Visitor
    {
        private double impuestoNormal = 1.21;
        private double impuestoReducido = 1.105;

        public double visit(ProductoDescuento reducido)
        {
            return reducido.getPrecio() * this.impuestoReducido;
        }

        public double visit(ProductoNormal normal)
        {
            return normal.getPrecio() * this.impuestoNormal;
        }
    }
}
