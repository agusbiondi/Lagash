using System;

namespace Lagash_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] lista = new int[4];
            lista[0] = 10;
            lista[1] = 23;
            lista[2] = 27;
            lista[3] = 89;

            int i = lista.Length;

            Console.WriteLine("El promedio es: " + Suma(lista, i) / i);

        }

        static int Suma(int[] lista, int i) {

            if (i <= 0) {
                
                return 0;

            }

            return (Suma(lista, i - 1) + lista [i - 1]);
        
        }

    }
}
