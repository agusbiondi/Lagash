using System;

namespace Lagash_3
{
    class Program
    {
        enum Operadores { Suma, Resta, Multiplicacion, Division }

        struct Persona {
            public string Nombre;
            public string Apellido;
            public string Club;

        }
        
        static void Main(string[] args)
        {            
            var result = HacerCuentaSwitch(3, 3, Operadores.Suma);
            
            var agus = new Persona();
                agus.Nombre = "Agustin";
                agus.Apellido = "Biondi";
                agus.Club = "Boca";


            Console.WriteLine(result);
            Console.WriteLine(agus.Nombre);
        }


        static int HacerCuentaSwitch(int a, int b, Operadores operador) {

            switch(operador) {

                case Operadores.Suma:
                    return a+b;
                
                case Operadores.Resta:
                    return a-b;
                
                case Operadores.Division:
                    return a/b;
                
                case Operadores.Multiplicacion:
                    return a*b;

                default:
                    throw new Exception ("humo");

            }
        
        }
            
        // static int HacerCuenta(int a, int b, Operadores operador) {

        //     if(operador == Operadores.Suma)
        //     {
        //         return a+b;
        //     }
        //     else if( operador == Operadores.Resta)
        //     {
        //         return a-b;
        //     }
        //     else if( operador == Operadores.Division)
        //     {
        //         return a/b;
        //     }
        //     else if( operador == Operadores.Multiplicacion)
        //     {
        //         return a*b;
        //     }

        //     throw new Exception ("humo");

        // }



    }

}
