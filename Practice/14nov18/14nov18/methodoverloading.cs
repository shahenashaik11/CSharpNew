using System;
using System.Collections.Generic;
using System.Text;

namespace _14nov18
{
    class Methodoverloading
    {
        public int id, age;
       
       public string name;
        public  void details()
        {
            Console.WriteLine("no details ");
            details("shonu");
        }
        public void details(string name)
        {
            this.name = name;
            Console.WriteLine(this.name);
            details(1);
        }
        

        public void details(int id)
        {
            
            this.id = new Random().Next(2, 6);
            Console.WriteLine(this.id);
            this.id = new Random().Next(5, 10);
            Console.WriteLine(this.id);
            int x=details(7, 77);
            Console.WriteLine(x);
        }
        public int details(int id,int age)
        {
            
           return age;
        }

    }
}
