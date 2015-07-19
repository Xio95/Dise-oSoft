using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteristicasDeRedencion
{
    public class ValidorDeCaracteristicasDeRedencion
    {
        //EJEMPLO 1
        public bool CaracteristicasDeRendencionSonValidas(bool permiteRedencion, double comision, int periodoMinimoDeRetencionEnDias)
        {
            bool sonValidas = false;
            if (permiteRedencion == false && comision == 0 && periodoMinimoDeRetencionEnDias == 0)
            {

                sonValidas = true;
            }
            if (permiteRedencion == true && comision == 0.19 && periodoMinimoDeRetencionEnDias == 30)
            {

                sonValidas = true;
            }
            if (permiteRedencion == true && comision == 0.10 && periodoMinimoDeRetencionEnDias == 0)
            {

                sonValidas = false;
            }
            if (permiteRedencion == true && comision == 0 && periodoMinimoDeRetencionEnDias == 30)
            {

                sonValidas = false;
            }
            return sonValidas;

        }

    }
}