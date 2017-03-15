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
            Patrones.Composite.Ejemplo1.EjemploImpl compositeEj1 = new Patrones.Composite.Ejemplo1.EjemploImpl();
            compositeEj1.MostrarNombre();
            compositeEj1.Ejecutar();

            // Wait for user 
            Console.Read();
        }
    }
}
