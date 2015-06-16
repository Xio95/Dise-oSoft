using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion
{
    public class CarritodeCompras
    {
        List<Producto> ListaProductos = new List<Producto>();


        public void Agregar(Producto ProductosLista)
        {
            //List<Producto> ListaProductos = new List<Producto>();

            ListaProductos.Add(ProductosLista);

        }

        public void ImprimirCarrito()
        {
            foreach (Producto i in ListaProductos)

                Console.WriteLine("\nIdentidicador: " + i.Identificador + "\nNombre: "+i.Nombre  + "\nFecha de registo: "+ i.FechaDeEmision);
                
        }

    }
}

