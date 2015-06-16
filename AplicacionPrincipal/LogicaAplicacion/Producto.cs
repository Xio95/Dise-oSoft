using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion
{
    public class Producto
    {
          public int Identificador;
          public string Nombre;
          public string FechaDeEmision;

     public Producto(int Identificador, string Nombre,string FechaDeEmision){

            this.Identificador= Identificador;
            this.Nombre= Nombre;
            this.FechaDeEmision= FechaDeEmision;
        }
        
        }
    }

