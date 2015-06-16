using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaAplicacion;

namespace AplicacionPrincipal
{
  public class Program
    {
        static void Main(string[] args)
        {
           CarritodeCompras c = new CarritodeCompras();
        //agrego los productos a la lista
           c.Agregar (new Producto (10199, "iPod Touch 64GB", "2015-06-06"));
           c.Agregar(new Producto(13100, "ChromeCast", "2015-03-06"));
           c.Agregar(new Producto(10299, "Laptop HB 256GB", "2015-07-06"));

    //llamo al metodo imprimir
           Console.WriteLine("Contenido del carrito de compras: ");
           c.ImprimirCarrito();
           Console.WriteLine("\n");
           Console.ReadLine();

           
         

        }
    }
}
