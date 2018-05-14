using System;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new Auto( new DateTime(2017,1,1) );
            a.Transferir();
            Console.WriteLine("");

            
            if( a.HaceFaltaPresentarVTV() )
            {
                Console.WriteLine("A ver la VTV?");
            }
            else Console.WriteLine("siga, siga");

            var b = new Bicicleta(new DateTime(2013,10,10));
            b.Transferir();

            Hacer(a); //es lo mismo que a.Transferir()
            Hacer(b); //es lo mismo que b.Transferir()

        }

        static void Hacer(Vehiculo v)
        {
            v.Transferir();
        }
    }


    //Todo lo que herede la clase cosa (y sus derivados) debe establecer como agarrar y como patear.
    //Es una clase abstracta pura.
    interface Cosa
    {
        void Agarrar();
        void Patear();
    }



    abstract class Vehiculo : Cosa
    {

        public Vehiculo(DateTime fecha)
        {
            this.fechaCompra = fecha;
            
            Console.WriteLine("Nuevo Vehiculo");
        }


        //protected sirve para que sea publico solamente para mi clase y las heredadas

        protected int velocidad = 0;
        DateTime fechaCompra;

        
        //Esto es una propiedad. Es como una funcion sin parametros
        //es para acceder a un valor sin tener que ponerlo publico.
        // se llama sin parentesis y se declara entre llaves
        public int Velocidad
        {
            get{ return this.velocidad; }
            set{ this.velocidad = value; }
        }

        //Es un destructor, funciona cuando se deja de utilizar el objeto
        //se lo "llama" dandole un valor null a x por ejemplo
        ~Vehiculo()
        {
            Console.WriteLine("nos vimo");
        }

        public DateTime FechaCompra
        {
            get{ return this.fechaCompra; }
            set{ this.fechaCompra = value; }
        }

        public int Modelo
        {
            get { return this.fechaCompra.Year; }
        }

        public void Acelerar(int accel)
        {
            this.velocidad += accel;
        }

        public abstract void Transferir();

    }

    class Auto : Vehiculo
    {

        int color = 0;

        public Auto(DateTime fechaCompra) : base(fechaCompra)
        {
        }

        public override void Transferir()
        {
            Console.WriteLine("Se hizo la transferencia de un auto");
        }

        public bool HaceFaltaPresentarVTV()
        {
            var hoy = DateTime.Now;
            return (hoy.Year - this.Modelo) > 2;
        }
    }

    class Bicicleta : Vehiculo
    {

        public Bicicleta(DateTime fechaCompra) : base(fechaCompra)
        {
        }

        public override void Transferir()
        {
            Console.WriteLine("Se hizo la transferencia de una bicicleta");
        }



    }

}
