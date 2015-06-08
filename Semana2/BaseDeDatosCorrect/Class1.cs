using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosCorrect
{
    public class Numeros
     {
        //porque se debe hacer private??
        private List<int> ListaNumeros = new List<int>();
        //int i;

        public void Agregar(int Numero)
        {
            ListaNumeros.Add(Numero);
            //i++;
        }

        public int ObtenerCantidadC()
        {
            return ListaNumeros.Count;
            //return i;
        }
    }
}
