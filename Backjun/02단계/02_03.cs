using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_03
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if(year % 400 == 0 || year % 100 != 0 && year % 4 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
