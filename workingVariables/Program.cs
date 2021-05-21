using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            int b = (x * x) * (x * x) * (x * x);

            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}