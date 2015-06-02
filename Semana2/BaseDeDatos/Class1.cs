using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public class Class1

    { List<int> Numeros = new List<int>();
        int i;

        public void Agregar(int Numero)
        {
            Numeros.Add(Numero);
            i++;
                     
             }
        public int ObtenerCantidad()
        {
            return i;

        }
    }
}

    

