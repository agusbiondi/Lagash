using System;

namespace Lagash_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            int [] lista = new int[10];
            lista[i] = 10;
            lista[1] = 23;
            lista[2] = 35;
            lista[3] = 40;

            
            int promedio = 0;
            while (i < 10 && lista[i] != 0) {
                promedio = promedio + lista [i];
                i ++;
            }
            promedio = promedio / i;

            Console.WriteLine(promedio);
            Console.WriteLine(" ");

            decimal prom = 0;
            int nota;
            for (nota = 0; nota < 10 && lista[nota] != 0; nota++) {
                prom += lista[nota];
                
            }

            prom /= nota;
            Console.WriteLine(prom);
            Console.WriteLine(" ");

        }
    }
}
