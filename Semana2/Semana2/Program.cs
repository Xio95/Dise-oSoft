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
            MaximoFibonacci();
        }
            //hago referencia con respeto al projecto BaseDeDatosCorrect    
         
        private static void MaximoFibonacci(){
            Fibonacci c= new Fibonacci();
            Calculos.RespuestaDeMaximoFibonacci respuesta= c.ObtengaElMaxFibonacci();

            Impresora LaImpresora = new Impresora();
            LaImpresora.Imprima (respuesta);
        }
        
        private static void BaseDeDatosSimulacion(){
            
            BaseDeDatosCorrect.Numeros db = new BaseDeDatosCorrect.Numeros();
            db.Agregar(1);
            db.Agregar(211);
            db.Agregar(45);
            db.Agregar(458);
            db.Agregar(11);

            int cantidad = db.ObtenerCantidadC();

            //imprime cantidad de valores de la Base
            Console.WriteLine("La cantidad de numeros es: " + cantidad);
            Console.ReadLine();


            //int cantidad = db.ObtenerCantidadC();
            //Console.WriteLine("La cantidad de numeros es: " + cantidad);



            //Console.WriteLine("\nHola Mundo! :)");
            //    //Console.WriteLine("Nice to meet you");
            //    //Console.ReadKey();

            //    Fibonacci prueba1 = new Calculos.Fibonacci();
            //    Calculos.Fibonacci
            //    //Console.WriteLine(prueba1.Calcular(5));

            //    ArrayList Fibona02 = new ArrayList();
            //    ArrayList Resultados = new ArrayList();
            //    Fibona02.Add(4);
            //    Fibona02.Add(6);
            //    Fibona02.Add(20);
            //    Fibona02.Add(1);
            //    Fibona02.Add(11);
            //    Fibona02.Add(25);

            //    Resultados = prueba1.recibe(Fibona02);

            //    imprimirResultados(Resultados);
            //}

            //    public static void imprimirResultados (ArrayList Resultados){

            //        foreach(int obj in Resultados) 
            //        {
            //                Console.WriteLine(obj);
            //        }
            //          Console.ReadKey();
            //    }



        }

    }
}

