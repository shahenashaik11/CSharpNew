using System;

namespace _15novinterface
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //using class object
            Person p1 = new Person();
            p1.details();
            p1.printteacherdetails();
            p1.printstudentdetails();
            //creating object using  interface reference
            ITeacher it = new Person();
            it.printteacherdetails();
            IStudent s = new Person();
            s.printstudentdetails();
            Console.ReadLine();

        }
    }
}
