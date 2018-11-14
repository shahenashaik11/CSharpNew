using System;

namespace _14nov18
{   class Player
    {
        //constructor overloading
        public Player()
        {
            
            Console.WriteLine("default constructor");
          
        }
        //constructor chaining
        public Player(string name):this()
        {
            
            Console.WriteLine(name);
            
        }
        //constructor chaining
        public Player(int id):this("neha")
        {
            
            Console.WriteLine(id);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(1);
           
            Methodoverloading m = new Methodoverloading();
            m.details();
            Child c = new Child();
            Child c1 = new Child(5);
            GetSet g = new GetSet();
            int i=g.marks = 100;
            Console.WriteLine(i);
            string j = g.name1 = "heena";
            Console.WriteLine(j);
            Console.ReadLine();

        }
    }
}
