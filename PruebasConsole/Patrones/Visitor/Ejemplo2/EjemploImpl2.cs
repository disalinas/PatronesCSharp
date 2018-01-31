using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsole.Patrones.Visitor.Ejemplo2
{
    class EjemploImpl2 : Ejemplo
    {
        public void Ejecutar()
        {
            // Setup structure
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            // Create visitor objects
            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            // Structure accepting visitors
            o.Accept(v1);
            o.Accept(v2);
        }

        public void MostrarNombre()
        {
            Console.WriteLine("");
            Console.WriteLine("PATRÓN VISITOR - EJEMPLO 2");
            Console.WriteLine("");
        }
    }
}
