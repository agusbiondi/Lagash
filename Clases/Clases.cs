using System;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {

            var v = new Vehiculo( new DateTime(2013, 10, 10) );
            Console.WriteLine(v.Modelo);
            v.Acelerar(10);
        
            var x = new Vehiculo( new DateTime(2018, 4, 4) );
            x.Acelerar(20);
            x = null;

            Console.WriteLine(v.Velocidad);


        }
    }

    class Vehiculo
    {

        public Vehiculo(DateTime fecha)
        {
            this.fechaCompra = fecha;
            
            Console.WriteLine("Nuevo Vehiculo");
        }

        int velocidad = 0;
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

    }

    class Auto
    {

    }



}
