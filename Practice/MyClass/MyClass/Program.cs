using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class MyException : ApplicationException
    {
        public MyException(String Msg) : base(Msg)
        {
        }
    }

    class MyClass
    {
        public static void Show()
        {
            throw new MyException("This is My Exception");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
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
