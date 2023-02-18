using System;
using System.Drawing;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;
        public string size;
        public string gender;

        // constructor
        public Animal()
        {
            name = "";
            size = "";
            gender = "";

        }
        //parameterized constructor
        public Animal(string name, string size, string gender)
        {
            this.name = name;
            this.size = size;
            this.gender = gender;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    class Zebra : Animal
    {
        public double age;
        public double legs;

        // constructor
        public Zebra()
            : base()  // calls the Animal class constructor
        {
            age = 0;
            legs = 0;
        }
        //parameterized constructor
        public Zebra(string name, string size, string gender, double age, double legs)
            : base(name, size, gender)
        {
            this.age = age;
            this.legs = legs;
        }
        public void getName()
        {
            Console.WriteLine($"My name is {name}");
        }
        public void stripes()
        {
            Console.WriteLine($"I have many stripes");
        }
        public void getAge()
        {
            Console.WriteLine($"I am {age} years old");
        }
        public void getLegs()
        {
            Console.WriteLine($"I have {legs} legs");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Kulu";
            myPet.display();
            

            // derived class object using default constructor
            Console.WriteLine("Zebra Information.....");
            Zebra foal = new Zebra();
            foal.name = "Telula";
            foal.size = "Small";
            foal.gender = "Female";
            foal.display();

            foal.age = 2;
            foal.legs = 4;
            foal.getName();
            foal.stripes();
            foal.getAge();
            foal.getLegs();
           


            //derived class object using parameterized constructor
            Console.WriteLine("Zebra Information.....");
            Zebra joe = new Zebra("Joe","large","stripes",8,4); 
            joe.display();
            joe.getName();
            joe.stripes();
            joe.getAge();
            joe.getLegs();
            
            Console.ReadLine();
        }

    }
}

