using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_07
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            if(a == b && b == c)
            {
                Console.WriteLine(10000 + a * 1000);
            }
            else if(a == b || b == c)
            {
                Console.WriteLine(1000 + b * 100);
            }
            else if(c == a)
            {
                Console.WriteLine(1000 + a * 100);
            }
            else
            {
                if (a > b)
                    b = a;
                if(b > c)
                    c = b;
                Console.WriteLine(c * 100);
            }
        }
    }
}
