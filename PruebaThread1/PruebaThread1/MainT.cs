using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaThread1
{
    class MainT
    {
        Random r = new Random();

        static int tam = 100;

        int[] dato_n = new int[tam];

        public MainT()
        {
            for (int i = 0; i < tam; i++)
            {
                dato_n[i] = r.Next(1, 100000000);
            }

            creaT();
            creaMT();
        }


        // metodo que solo crea un hilo para el trabajo
        private void creaT()
        {
            for (int i = 0; i < tam; i++)
            {
                CTrabajo ct = new CTrabajo(i, dato_n[i]);
                ct.hasTrabajo();
            }
        }

        // metodo que crea todos los posibles multihilos para el trabajo
        private void creaMT()
        {

            for (int i = 0; i < tam; i++)
            {
                CTrabajo ct = new CTrabajo(i, dato_n[i]);
                System.Threading.Thread Thread = new System.Threading.Thread(ct.hasTrabajo);
                Thread.Start();
            }
        }

        //metodo principal
        static void Main(string[] args)
        {
            new MainT();
        }
    }
}
