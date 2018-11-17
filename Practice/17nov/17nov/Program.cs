using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17nov
{   class ArithematicOperations : Exception
    {
        public int a, b, c;
        public void Division()
        { 
            try
            {
           
       
                Console.WriteLine("Enter the  a value");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the  b value");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("c value is " +c);
                Console.ReadLine();

        
            }
            catch(Exception e)
            { 
                
                Console.WriteLine("Division by zero cannot be possible");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArithematicOperations a = new ArithematicOperations();
            a.Division();
            try
            {

                MyClass.Show();
            }
            catch (MyException ex)
            {

                Console.WriteLine(ex.Message);
            }

            
            Console.ReadLine();

        }
    }
}
