using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Fibonacci
    {
       ArrayList x = new ArrayList();

       public ArrayList recibe(IEnumerable Fibona02)
       {
           ArrayList f = new ArrayList();
           foreach (int obj in Fibona02)
           {
               f.Add(Calcular(obj));



           } return f;
           
       }

        public int Calcular(int n)
        {
           
            if (n == 1)
            {
                return 1;
            }
            if (n==2){
                return 1;
            } 
             
                return Calcular(n-1)+ Calcular(n-2);
            } 
        }

    public void PnewArray (){

}
    }


            
           

        
    
      

