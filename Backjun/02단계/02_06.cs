using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_06
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(Console.ReadLine());

            int d = (a * 60 + b + c) % 1440;

            Console.WriteLine(d / 60 + " " + d % 60);
        }
    }
}
