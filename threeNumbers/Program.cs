using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = Convert.ToInt32(Console.ReadLine());
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            int numberThree = Convert.ToInt32(Console.ReadLine());

            int sum = numberOne + numberTwo + numberThree;
            int product = numberOne * numberTwo * numberThree;

            Console.WriteLine(sum + " " + product);
            Console.ReadKey();
        }
    }
}