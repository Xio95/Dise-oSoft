using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasDeNegocio
{
    public class EjemplosReglasDeNegocio
    {
        //EJEMPLO 2
        public bool CuandoSeDebeInactivarUnCliente(DateTime fechaDeUltimaTransaccion, DateTime fechaActual)
        {
            bool esValido = false;
            int diferencia = DateTime.Compare(fechaDeUltimaTransaccion, fechaActual);
            if (diferencia >= 30)
            {
                esValido = true;
            }
            else
            {
                esValido = false;
            }
            return esValido;
        }
        
        //EJEMPLO 3
        public bool EmisionValidaComoGarantia(int diasDeVencimiento)
        {

            bool esValido = false;
            if (diasDeVencimiento > 7)
            {
                esValido = true;
            }
            else
            {
                esValido = false;
            }
            return esValido;
        }

        //EJEMPLO 4
        public bool ValidarLosMultiplosDelMonto(double multiplosDelMonto) 
        {
            bool sonValidos = false;
           double montoMinimo = 100.5;
            if (multiplosDelMonto > montoMinimo)
            {
                sonValidos = false;
            }
            if (multiplosDelMonto == montoMinimo)
            {
                sonValidos = true;
            }
            if (multiplosDelMonto < montoMinimo)
            {
                sonValidos = true;
            }
            if (multiplosDelMonto == 0.01)
            {
                sonValidos = true;
            }
            
            if (multiplosDelMonto< 0.001)
            {
                sonValidos = false;
            }

            return sonValidos;
        }
        
    }
}

