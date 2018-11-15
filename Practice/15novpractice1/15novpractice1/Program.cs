using System;

namespace _15novpractice1
{   
    abstract class Person
    {
        public int _id;
        public abstract int id { get; set; }
        public string name = "shonu"; 
        public abstract void details();

    }
    class Doctor:Person
    {
        public override  int id { get { return _id; }set { _id = value; } }
        public override void details()
        {
            Console.WriteLine("name of doctor is:" +name);
            Console.WriteLine("doctor id is:" + id);
            Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Doctor d = new Doctor();
            d.id = 11;
            d.details();

            
            Console.ReadLine();

        }
    }
}
