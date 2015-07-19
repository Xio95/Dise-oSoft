using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasDeCalculos
{
    public class EjemplosReglasDeCalculos
    {
        //EJEMPLO 5
        public int CalcularLosDiasAlVencimiento(DateTime fechaDeVencimiento, DateTime fecha)
        {
            int diferencia = DateTime.Compare(fechaDeVencimiento, fecha);
            if (diferencia <= 0)
            {
                return 0;
            }
            else
            {
                return diferencia;
            }
        }

        //EJEMPLO 6
        public double CalcularTasaDeInteresNeta (double tasaBruta, double tasaImpuesto)
        {
            double tasaDeInteresNeta = tasaBruta *(1 - tasaImpuesto);
            return Math.Round(tasaDeInteresNeta, 4);
        }

        // EJEMPLO 7
        public double CalcularValorMercadoDeUnaEmision (double montoNominal, double precioMercado)
        {
            double valorDeMercado = montoNominal * precioMercado;
            return Math.Round(valorDeMercado, 4);
        }
    }
}
