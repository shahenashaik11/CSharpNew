using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16nov2018
{
    class Employee:Person
    {
        public void EmployeeDetails()
        {

            PersonDetails();
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Person e = new Person();
            
            Console.WriteLine("i value is:" + e.i);
            Console.WriteLine("firstname is:" + e.firstname);
            Console.WriteLine("lastname is:" + e.lastname);
            Console.WriteLine("agee is:" + e.age);


            Console.ReadLine();
        }

    }

}
