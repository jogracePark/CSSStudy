using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/12
 * 이름 : 박은총
 * 내용 : 연산자 실습하기 교제 p90
 * 
 * 연산자(Operator)
 * - 변수에 저장된 데이터를 가공하기위해 연산자를 사용
 * - 연산자는 크게 진중, 증감. 복합대입, 비교. 논리연산자 등이 있다
 */

namespace ch02
{
    internal class _3_연산자
    {
        static void Main3(string[] args)
        {
            // 산술 연산자
            int num1 = 1;
            int num2 = 2;

            int t1 = num1 + num2;
            int t2 = num1 - num2;
            int t3 = num1 * num2;
            int t4 = num1 / num2;
            int t5 = num1 % num2;

            Console.WriteLine("t1 : {0}", t1);
            Console.WriteLine("t2 : {0}", t2);
            Console.WriteLine("t3 : {0}", t3);
            Console.WriteLine("t4 : {0}", t4);

            // 증감 연산자
            int num = 0;
            num++;
            ++num;

            Console.WriteLine($"num : {num}"); // 문자열 보간

            num--;
            --num;

            Console.WriteLine($"num : {num} ");

            // 복합대입 연산자
            int n1 = 1, n2 = 2, n3 = 3, n4 = 4;

            n1 += 1;
            n2 -= 2;
            n3 *= 3;
            n4 /= 4;


            // 비교 연산자
            int var1 = 1;
            int var2 = 2;

            bool rs1 = var1 > var2;
            bool rs2 = var1 < var2;
            bool rs3 = var1 >= var2;
            bool rs4 = var1 <= var2;
            bool rs5 = var1 == var2;
            bool rs6 = var1 != var2;

            Console.WriteLine("rs1 : " + rs1);
            Console.WriteLine("rs2 : " + rs2);
            Console.WriteLine("rs3 : " + rs3);
            Console.WriteLine("rs4 : " + rs4);
            Console.WriteLine("rs5 : " + rs5);
            Console.WriteLine("rs6 : " + rs6);

            // 논리 연산자
            bool res1 = var1 > 1 && var2 > 2;
            bool res2 = var1 > 0 && var2 > 1;
            bool res3 = var1 > 1 || var2 > 2;
            bool res4 = var1 > 0 || var2 > 2;
            bool res5 = !(var1 > var2);

            Console.WriteLine("res1 : " + res1);
            Console.WriteLine("res2 : " + res2);
            Console.WriteLine("res3 : " + res3);
            Console.WriteLine("res4 : " + res4);
            Console.WriteLine("res5 : " + res5);

            // whrjs udstkswk
            int number = 1;

            string result = (number > 1) ? "number 가 1보다 크다" : "number가 1보다 작거나 같다";

            Console.WriteLine("result : " + result);
        }
    }
}
