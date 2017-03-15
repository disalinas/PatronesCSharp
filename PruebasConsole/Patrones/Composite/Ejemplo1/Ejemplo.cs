using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsole.Patrones.Composite.Ejemplo1
{
    class EjemploImpl : Ejemplo
    {
        public void MostrarNombre()
        {
            Console.WriteLine("PATRÓN COMPOSITE - EJEMPLO 1");
            Console.WriteLine("");
        }
        public void Ejecutar()
        {
            Menu archivo = new Menu("Archivo");
            archivo.Add(new PuntoMenu("Abrir"));
            archivo.Add(new PuntoMenu("Guardar"));

            Menu exportar = new Menu("Exportar");
            exportar.Add(new PuntoMenu("XML"));
            exportar.Add(new PuntoMenu("PDF"));
            exportar.Add(new PuntoMenu("PNG"));
            archivo.Add(exportar);

            Menu notacion = new Menu("Notación");
            notacion.Add(new PuntoMenu("UML 1.4"));
            notacion.Add(new PuntoMenu("Java"));
            notacion.Add(new PuntoMenu("C++"));
            archivo.Add(notacion);

            archivo.Add(new PuntoMenu("Salir"));

            archivo.Mostrar(1);
        }
    }
}
