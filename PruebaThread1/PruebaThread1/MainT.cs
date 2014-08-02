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

           // creaT();
           //creaMT();
            creaMT2();
        }


        // metodo que solo crea un hilo para el trabajo
        private void creaT()
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            System.Console.WriteLine("creaT: " + unixTimestamp);

            for (int i = 0; i < tam; i++)
            {
                CTrabajo ct = new CTrabajo(i, dato_n[i]);
                ct.hasTrabajo();
            }

            unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            System.Console.WriteLine("creaT: " + unixTimestamp);
        }

        // metodo que crea todos los posibles multihilos para el trabajo
        private void creaMT()
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            System.Console.WriteLine("creaMT: " + unixTimestamp);

            for (int i = 0; i < tam; i++)
            {
                CTrabajo ct = new CTrabajo(i, dato_n[i]);
                System.Threading.Thread Thread = new System.Threading.Thread(ct.hasTrabajo);
                Thread.Start();
            }

            unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            System.Console.WriteLine("creaMT: " + unixTimestamp);
        }

        private void creaMT2()
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            System.Console.WriteLine("creaMT2: " + unixTimestamp);

            CTrabajo ct = new CTrabajo(dato_n, tam);
            System.Threading.Thread Thread = new System.Threading.Thread(ct.hasTrabajo2);
            Thread.Start();

            unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            System.Console.WriteLine("creaMT2: " + unixTimestamp);
        }

        //metodo principal
        static void Main(string[] args)
        {
            new MainT();
        }
    }
}
