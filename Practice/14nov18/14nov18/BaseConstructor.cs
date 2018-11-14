using System;
using System.Collections.Generic;
using System.Text;

namespace _14nov18
{
    class BaseConstructor
    {
        public int id;
        public string name;
        public BaseConstructor()
        {
            Console.WriteLine("default constructor of base");
        }
        public BaseConstructor(int id)
        {
            this.id = id;
            Console.WriteLine(this.id);
        }
        public BaseConstructor(string name)
        {
            this.name  = name;
            Console.WriteLine(this.name);
        }
    }
    class Child: BaseConstructor
    {
        public Child():base()
        {
            
            Console.WriteLine("default constructor of child");
        }

        public Child(int id) : base(10)
        {
            Console.WriteLine(this.id);
            Console.WriteLine(id);
        }
        public Child(String name) : base(11)
        {
            this.name = name;
            Console.WriteLine(this.name);
            Console.WriteLine(id);
            Console.ReadLine();
        }
    }
}
