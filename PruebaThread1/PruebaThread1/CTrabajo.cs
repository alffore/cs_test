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

        protected int[] aitarea;
        protected int numt;

        public CTrabajo(int tarea,int v)
        {
            this.v = v;
            this.tarea = tarea;
           
        }

        public CTrabajo(int[] aitarea, int numt)
        {
            this.aitarea = aitarea;
            this.numt = numt;
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



        public void hasTrabajo2()
        {
            for (int j = 0; j < numt; j++)
            {
                String sres;
                int divi = 0;

                v = aitarea[j];
                tarea = j;

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

                System.Console.WriteLine(tarea + ":: " + v + ": " + sres);
            }
        }

    }
}
