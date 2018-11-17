using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 10, 20, 30, 40, 50 };

            
            for (int i = 0; i < intList.Count; i++)
                Console.WriteLine(intList[i]);
            List<string> name = new List<string>(){"shon","shivleela","gittu"};
            for (int i = 0; i < name.Count; i++)
                Console.WriteLine(name[i]);

            Console.ReadLine();
        }
    }
}
