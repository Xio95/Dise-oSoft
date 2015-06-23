using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class CalculadoraController
    {
        public string CoordineLaDivision(double dividendo, double divisor)
        {
            CalculadoraEntity laCalculadora = new CalculadoraEntity();

            double resultado = laCalculadora.Dividir(dividendo, divisor);

            //de letras a string=retorna
            string resultadoString = resultado.ToString();

            return resultadoString;
        }
    }
}
    