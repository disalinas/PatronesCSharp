using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsole.Patrones.Visitor.Ejemplo1
{
    class EjemploImpl1 : Ejemplo
    {
        public void Ejecutar()
        {
            ProductoDescuento prodDescuento = new ProductoDescuento();
            prodDescuento.setPrecio(100);

            ProductoNormal prodNormal = new ProductoNormal();
            prodNormal.setPrecio(100);

            IVA iva = new IVA();
            double precio1 = prodDescuento.accept(iva);
            double precio2 = prodNormal.accept(iva);

            Console.WriteLine("Precio producto descuento: " + precio1.ToString());
            Console.WriteLine("Precio producto normal: " + precio2.ToString());
        }

        public void MostrarNombre()
        {
            Console.WriteLine("");
            Console.WriteLine("PATRÓN VISITOR - EJEMPLO 1");
            Console.WriteLine("");
        }
    }
}
