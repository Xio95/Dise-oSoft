using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CalculadorEntity
    {
         /*
        *4/2=2
        *4/2,5=1,6
        *-4/2,5=-1,6
        *4/0=Error
          */

       double Dividir(double dividiendo, double divisor)
        {


           if (divisor == 0)
           {
               throw new Exception("El divisor no debe ser 0.");
           }

            return dividiendo / divisor;

        }




    }
}
