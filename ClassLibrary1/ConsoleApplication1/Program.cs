using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReglasDeCalculos;
using CaracteristicasDeRedencion;
using ReglasCondicionFinanciera;
using ReglasDeComportamiento;
using ReglasDeNegocio;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidorDeCaracteristicasDeRedencion D = new ValidorDeCaracteristicasDeRedencion();
            D.CaracteristicasDeRendencionSonValidas(false, 0, 0);
          



        }
    }
}
