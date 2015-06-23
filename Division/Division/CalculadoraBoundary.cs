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
            string divisor = Console.ReadLine();
            double respuesta = double.Parse(divisor);
            return respuesta;
        }

       public double ObtenerDividendo()
        {
            string dividendo = Console.ReadLine();
            double respuesta = double.Parse(dividendo);
            return respuesta;
        }
    }
}
