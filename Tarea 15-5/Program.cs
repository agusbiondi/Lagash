using System;

namespace Tarea_15_5
{
    enum gender {Man, Woman};


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Persona
    {

//
//Constructores
//
        public Persona()
        {
            this.dni = 0;
            this.name = "";
            this.gender = gender.Woman;
            this.age = 0;
            this.weight = 0;
            this.height = 0;
        }

        public Persona(string name, int age, gender gender)
        {
            this.dni = 0;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.weight = 0;
            this.height = 0;
        }

        public Persona(int dni, string name, gender gender, int age, int weight, int height)
        {
            this.dni = 0;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.weight = 0;
            this.height = 0;
        }

//
//Parametros y definiciones
//
        int dni;
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }


        string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        int age;
        public int Age
        {
            get {return this.age; }
            set { this.age = value; }
        }


        gender gender;
        public gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        

        double weight;
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
      
      
        double height;
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

//
//Metodos
//

    public int CalcularIMC()
    {
        double aux = Math.Pow(this.height, 2);
        
        if ( this.weight / aux < 20 )
        {
            return -1;

        } else if ( this.weight / aux >= 20 && this.weight / aux <= 20 )
        {
            return 0;
        }
        else return 1;
        
    }

    public bool EsMayorDeEdad()
    {
        if (this.age > 18)
        {
            return true;
        }
        else return false;
    }

    private bool ComprobarSexo(gender gender)
    {
        if (this.gender == gender.Woman && this.gender == gender.Man)
        {
            return true;
        }
        else return false;
    }

    void ToString()
    {
        
    }





    }

}
