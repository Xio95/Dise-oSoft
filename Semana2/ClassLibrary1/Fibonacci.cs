using Calculos;//para poder usar todas las clases de este proyecto
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    public class Fibonacci
    {
       //ArrayList x = new ArrayList();

       //public ArrayList recibe(IEnumerable Fibona02)
       //{
       //    ArrayList f = new ArrayList();
       //    foreach (int obj in Fibona02)
       //    {
       //        f.Add(Calcular(obj));



       //    } return f;
           
       //}

        public int Calcular(int n)
        {
           
            if (n == 1)
            {
                return 1;
            }
            if (n==2){
                return 1;
            } 
             
                return Calcular(n-1)+ Calcular(n-2);
            }
        public List<int> CalcuFibonacciLista(List<int> lista)
        {
            List<int> resultado = new List<int>();
            foreach (int i in lista)
            {
                resultado.Add(Calcular(i));
                
            }
            return resultado;
        }

        public RespuestaDeMaximoFibonacci ObtengaElMaxFibonacci()
        {
            //Calculos.RespuestaDeMaximoFibonacci = no es necesario hacerlo porque ya se hizo como "USING CALCULOS;"
            RespuestaDeMaximoFibonacci respuesta = new RespuestaDeMaximoFibonacci();

            int n = 1;
            try
            {
                //ciclo infinito que saca fibonacci
                while (true)
                {
                    int elFibonacci = Calcular(n);
                    //guarda resultado
                    respuesta.Numero = n;
                    respuesta.Fibonacci = elFibonacci;
                
                    //siguente numero
                    n++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se obtuvo una excepcion en el numero: " + n);
                Console.WriteLine("El mensaje de la excepcion es: " + ex.Message);
            }
            return respuesta;
        }
        }

}
    


            
           

        
    
      

