using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
    internal class _03_02
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] input;

            for (int i = 0; i < a; i++)
            {
                input = Console.ReadLine().Split();
                Console.WriteLine(int.Parse(input[0]) + int.Parse(input[1]));
            }
        }
    }
}
