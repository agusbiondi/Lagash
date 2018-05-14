using System;

namespace Lagash
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Hacer (1, "");
            } catch (Exception e) {

                Console.WriteLine(e.Message);
            }
        }

        static void Hacer(int param, string par) {
            HacerMas(param);
        }

        static void HacerMas(int i) {
            if( i % 2 == 0) {

//El throw interrumpe el programa, y crea una nueva exception. Los errores se "reportan" con el try y el catch sirve para hacer algo en base a ese error
                throw new Exception("No me gustan los numeros pares");
            }
            int t = 0;
            t++;
        }
    }
}
