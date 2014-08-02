using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaThread1
{
    class CTrabajo
    {

        protected int v;
        protected int tarea;
       

        public CTrabajo(int tarea,int v)
        {
            this.v = v;
            this.tarea = tarea;
           
        }

        // metodo que checa como trabajo si un número es primo o compuesto por divisibilidad
        public void hasTrabajo()
        {
            String sres;
            int divi = 0;

            for (int i = v; i > 0; i--)
            {
                if (v % i == 0)
                {
                    divi++;
                    if (divi > 2) break;
                }
            }

            if (divi == 2)
            {
                sres = "primo";
            }
            else
            {
                sres = "compuesto";
            }
            
            System.Console.WriteLine(tarea+":: "+v + ": " + sres);
        }


    }
}
