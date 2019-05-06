using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Enter the desired width:");
            int width = int.Parse(Console.ReadLine());

            for (int a = 1; a <= height; a++)
            {
                for (int b = a; b <= width; b++)
                {
                    Console.Write("");
                }
                for (int k = a; k <= width; k++)
                {
                    Console.Write(width);
                }
                Console.WriteLine();

            }
        }
    }
}
