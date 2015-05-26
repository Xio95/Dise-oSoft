using System;
using System.Collections;
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
            //Console.WriteLine(prueba1.Calcular(5));

            ArrayList Fibona02 = new ArrayList();
            Fibona02.Add(4);
            Fibona02.Add(6);
            Fibona02.Add(20);
            Fibona02.Add(1);
            Fibona02.Add(11);
            Fibona02.Add(25);
            Console.WriteLine(prueba1.recibe(Fibona02));
            Console.ReadKey();
        }
    }
}
