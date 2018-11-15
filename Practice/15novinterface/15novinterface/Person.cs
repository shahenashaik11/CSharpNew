using System;
using System.Collections.Generic;
using System.Text;

namespace _15novinterface
{
    //IMPLEMENTING INTERFACES
    class Person:ITeacher,IStudent
    {
        public int id;
        public string name;
        public void details()
        {
            id = 1;
            name = "person";
            Console.WriteLine("name of person is:" + name);
            Console.WriteLine("Id of person is:" + id);
        }
        public void printteacherdetails()
        {
            id =2;
            name = "teacher";
            Console.WriteLine("name of teacher is:" + name);
            Console.WriteLine("Id of teacher is:" + id);
        }
        public void printstudentdetails()
        {
            id = 3;
            name = "student";
            Console.WriteLine("name of student is:" + name);
            Console.WriteLine("Id of student is:" + id);
        }
    }
}
