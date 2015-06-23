using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{//cosas del mundo de afuera y pasarselo a la clase que opera
    class CalculadoraBoundary
    {
        public double ObtenerDivisor()
        {
            Console.WriteLine("Deme el divisor");

            string divisor = Console.ReadLine();
            double respuesta = double.Parse(divisor);
            return respuesta;
        }

       public double ObtenerDividendo()
        {
            Console.WriteLine("Deme el dividendo");

            string dividendo = Console.ReadLine();
            double respuesta = double.Parse(dividendo);
            return respuesta;
        }
        //solo para este componente
       internal void MostrarResultado(string resultado)
       {
           Console.Write("El resultado es: ");
          Console.WriteLine(resultado);
          Console.ReadLine();
       }
    }
}
