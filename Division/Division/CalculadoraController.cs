using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class CalculadoraController
    {
        public void  CoordineLaDivision()
        {
            CalculadoraBoundary elLimite = new CalculadoraBoundary();
           
            string resultadoString;
            try
            {
                string dividendo = elLimite.ObtenerDividendo();
                if (dividendo.Contains("."))
                {

                }
                else
                {
                    
                }
                string divisor = elLimite.ObtenerDivisor();

                CalculadoraEntity laCalculadora = new CalculadoraEntity();
                double resultado = laCalculadora.Dividir(dividendo, divisor);
                //de letras a string=retorna
                resultadoString = resultado.ToString();

            }
            catch (Exception)
            {
                
               resultadoString= "Error";
            }

            elLimite.MostrarResultado(resultadoString);
                 
                   }
    }
}
    