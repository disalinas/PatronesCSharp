using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsole
{
    class Program
    {
        static void Main()
        {
            ejemplosComposite();
            ejemplosVisitor();
            Console.Read();
        }

        static void ejemplosComposite()
        {
            Patrones.Composite.Ejemplo1.EjemploImpl compositeEj1 = new Patrones.Composite.Ejemplo1.EjemploImpl();
            compositeEj1.MostrarNombre();
            compositeEj1.Ejecutar();
            
        }

        static void ejemplosVisitor()
        {
            Patrones.Visitor.Ejemplo1.EjemploImpl1 visitorEj1 = new Patrones.Visitor.Ejemplo1.EjemploImpl1();
            visitorEj1.MostrarNombre();
            visitorEj1.Ejecutar();

            Patrones.Visitor.Ejemplo2.EjemploImpl2 visitorEj2 = new Patrones.Visitor.Ejemplo2.EjemploImpl2();
            visitorEj2.MostrarNombre();
            visitorEj2.Ejecutar();
        }
    }
}
