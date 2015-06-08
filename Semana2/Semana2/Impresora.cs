using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Impresora
    {
        internal void Imprima(Calculos.RespuestaDeMaximoFibonacci respuesta)
        {
            Console.WriteLine("Maximo Fibonacci: ");
            Console.WriteLine("n = {0}", respuesta.Numero);
            Console.WriteLine("Fibonacci (n)= {0}", respuesta.Fibonacci);

        }
    }
}
