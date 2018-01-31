using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsole.Patrones.Visitor.Ejemplo1
{
    interface Visitor
    {
        double visit(ProductoNormal normal);
        double visit(ProductoDescuento reducido);
    }
}
