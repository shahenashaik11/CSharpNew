using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16novstatic
{
    
  /*static */ class Interest
    {

        
        static int Rate = 10;
        int SimpleInterest;
        public /*static */int Calculate(int Principle, int Time )
        {
            const int age = 100;
            SimpleInterest = (Principle * Time * Rate) / 100;
            Console.WriteLine("Simple Interest is:" + SimpleInterest);
            return SimpleInterest;

        }
        static Interest()
        {

        }
        /*static Interest(int i,string k)//a static constructor must be parameterless
        {

        }*/
        
    
}
    class Program
    {
        static void Main(string[] args)
        {
            
            Interest i = new Interest();//cannot create instance of static class
            i.Calculate(15000,1) ;
            i.Calculate(70000, 1);//if method is static we cannot call through reference
            Console.ReadLine();
        }
    }
}
