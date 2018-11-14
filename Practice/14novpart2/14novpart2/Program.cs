using System;

namespace _14novpart2
{   class Person
    {
         public string name = "abc";
        int _id;
        

        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
            //method overriding
             public virtual void details()
             {
                 Console.WriteLine("person name is:" + name);
             }
             public virtual void getdetails()
             {
                 Console.WriteLine("person id is: " + _id);
             }
    }
    class Student:Person
    {

        int marks = 20;
        public override void details()
        {
            Console.WriteLine("student name is " + name);   
        }
        
        public  override void getdetails()
        {
            Console.WriteLine("student marks are: " + marks);
        }

    }
    class Teacher:Person
    {
        int salary = 1000;
        
        public override void details()
        {
            
            Console.WriteLine("Teacher  name is " + name);
        }
        //using new 

        public new void getdetails()
        {
            Console.WriteLine("Teacher salary is "+salary);
        }
       

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.details();
       
           
            int i = p.id= 100;
            p.getdetails();
            Student s = new Student();
            s.details();
            s.getdetails();
            
            
            Person p1 = new Teacher();
            p1.details();

            p1.getdetails();


            Console.ReadLine();
        }
    }
}
