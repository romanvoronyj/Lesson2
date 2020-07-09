using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const long year = 1992;
            short beta = (short)year;
            //const long gama = 32768;
            //short alfa = (short)gama;
            //year = 40;

            Console.WriteLine("Birth year:{0}", year);
            Console.WriteLine("Beta:{0}", beta);
            //Console.WriteLine("Gama:{0}, gama);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
