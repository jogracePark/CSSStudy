using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._01단계
{
    internal class _01_12
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();

            Console.WriteLine(int.Parse(input) * (int.Parse(input2) % 10));
            Console.WriteLine(int.Parse(input) * (int.Parse(input2)%100/10));
            Console.WriteLine(int.Parse(input) * (int.Parse(input2) / 100));
            Console.WriteLine(int.Parse(input) * int.Parse(input2));
        }
    }
}
