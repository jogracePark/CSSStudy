using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/13
 * 이름 : 박은총
 * 내용 : 조건문 Switch 실습하기 교재 p127
 */

namespace ch03
{
    internal class _2_switch문
    {
        static void Main2(string[] args)
        {
            Console.Write("숫자 입력 : ");
            string strNum = Console.ReadLine();
            int num = int.Parse(strNum);

            switch (num % 2) 
            {
                case 0:
                    Console.WriteLine("입력하신 숫자는 짝수입니다");
                    break;
                case 1:
                    Console.WriteLine("입력하신 숫자는 홀수입니다");
                    break;
            }
        }
    }
}
