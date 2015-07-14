using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasCondicionFinanciera
{
    public class ValidaronDeFechas
    {
        // DateTime FechaDeVigencia;
        //DateTime FechaDeRegistro;
        // bool esValido;

        public bool LaFechaDeVigenciaEsValida(DateTime fechaDeVigencia, DateTime fechaDeRegistro)
        {
            bool esValido = false;

            if (fechaDeVigencia == fechaDeRegistro)
            {
                esValido = true;
            }

            if (fechaDeVigencia <= fechaDeRegistro)
            {
                esValido = false;
            }

            if (fechaDeVigencia >= fechaDeRegistro)
            {
                esValido = true;
            }

            return esValido;
        }

    }
}
