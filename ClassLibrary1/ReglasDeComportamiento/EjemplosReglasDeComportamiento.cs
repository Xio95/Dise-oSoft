using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasDeComportamiento
{
    public class EjemplosReglasDeComportamiento
    {
        public bool SeDebeReintentarUnPagoMovil( int numeroDeReintentos)
        {
            bool debeReintentar = false;
            if (numeroDeReintentos <= 3)
            {
                debeReintentar = true;
            }
            else
            {
                debeReintentar = false;
            }
            return debeReintentar;

        }
    }
}
