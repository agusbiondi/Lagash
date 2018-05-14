using System;

namespace DivisionSinOperador
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a, b;
            a = 4;
            b = 8;

            if(b==0) {
                
                Console.WriteLine("No es posible dividir por cero");

            } else if (a<0 ^ b<0) {

                Console.WriteLine("Cociente : " + ( - Cociente(ref a, b)));
                Console.WriteLine("Resto: " + a);

            } else if (true) {

                
                Console.WriteLine("Cociente : " + Cociente(ref a, b));
                Console.WriteLine("Resto: " + a);


            }

        }
    


        static decimal Cociente(ref decimal a, decimal b) {
            
            a = Math.Abs(a);
            b = Math.Abs(b);
            decimal cociente = 0;
            
            if(a>=b) {
            
                while(a>=b) {

                    a -= b;
                    cociente ++;               

                }
            }
            return cociente;

        }        
                       
    }


}

