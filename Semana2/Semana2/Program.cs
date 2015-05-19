using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nHola Mundo! :)");
            //Console.WriteLine("Nice to meet you");
            //Console.ReadKey();

            Fibonacci prueba1 = new Fibonacci();
            Console.WriteLine(prueba1.Calcular(5));
            Console.ReadKey();
        }
    }
}
