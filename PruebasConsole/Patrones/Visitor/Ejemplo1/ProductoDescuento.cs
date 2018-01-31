using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsole.Patrones.Visitor.Ejemplo1
{
    class ProductoDescuento : Element
    {
        private double precio;

        public double accept(Visitor visitor)
        {
            return visitor.visit(this);
        }

        public double getPrecio()
        {
            return precio;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }
    }
}
