using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17nov2
{
    class Program
    {
       public const int i= 9;
        public  readonly int j;
        public void abc(out int x)
        {

            x = 10;
            Console.WriteLine("x value is:"+x);
           
            

        }
        public void test(ref int z)
        {
            System.Console.WriteLine(z);
            z = 10;
            System.Console.WriteLine(z);

        }


        Program()
        {
            Console.WriteLine("i value is:" + i);
            Console.WriteLine("enter j value:");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("j value is:" + j);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int x;
            int z = 0;

            
            Program p = new Program();
            p.abc(out x);
            p.test(ref z);
            Console.ReadLine();


        }
    }
}
