using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/13
 * 이름 : 박은총
 * 내용 : 반복문 for 실습하기 교재 p157
 */

namespace ch03
{
    internal class _3_for문
    {
        static void Main(string[] args)
        {
            int sum = 0;

            // for
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}회 반복...", i);
            }

            // 1부터 10까지 합
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
            sum = 0;

            // 1부터 10까지 짝수합
            for (int i = 1; i <= 10; i++)
            {
                if(i%2 == 0)
                    sum += i;
            }

            Console.WriteLine(sum);

            // 중첩 for문
            for(int i = 1; i <= 3; i++)
            {
                for(int n = 1; n <=4; n++)
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine();

            // 구구단
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine("{0}단",i);
                for (int n = 2; n <= 9; n++)
                {
                    Console.WriteLine("{0} X {1} = {2}",i,n,i*n);
                }
            }

            // 별삼각형
            for (int i = 1; i <= 18; i++)
            {
                for (int n = 1; n <= 18-i; n++)
                {
                    Console.Write(" ");
                }
                for (int n = 1; n <= i; n++)
                {
                    Console.Write("★");
                }
                Console.WriteLine();
            }


        }
    }
}
