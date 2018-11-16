using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assembly;


namespace _16nov2018
{   class Person
    {
        public int i = 10;
        private string firstname = "hi";
        protected string lastname = "Everyone";
        internal int age = 44;


        public void PersonDetails()
        { 
            Console.WriteLine("i value is:" + i);
            Console.WriteLine("firstname is:" + firstname);
            Console.WriteLine("lastname is:" + lastname);
            Console.WriteLine("agee is:" + age);  Console.WriteLine("i value is:" + i);
            Console.WriteLine("firstname is:" + firstname);
            Console.WriteLine("lastname is:" + lastname);
            Console.WriteLine("agee is:" + age);

        }
    }
    
}
