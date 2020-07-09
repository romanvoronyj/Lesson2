using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = -6;
            int x = 5;
            int add = z + x;
            int diff = z - x;
            int multi = z * x;
            double div = z / (double)x;
            int perDiv = z % x;
            Console.WriteLine("a+b={0}", add);
            Console.WriteLine("a-b={0}", diff);
            Console.WriteLine("a*b={0}", multi);
            Console.WriteLine("a/b={0}", div);
            Console.WriteLine("a%b={0}", perDiv);
            
            Console.ReadLine();
        }
    }
}
