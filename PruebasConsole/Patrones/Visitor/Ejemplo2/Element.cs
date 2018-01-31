using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsole.Patrones.Visitor.Ejemplo2
{
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
