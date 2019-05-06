using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1, num2, num3;
            Console.WriteLine("Enter number 1 :");
            num1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter number 2 :");
            num2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter number 3 :");
            num3 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("{0},{1},{2}", num3, num2, num1);
        }
    }
}
