using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 박은총
 * 내용 : 메서드 실습하기 교제 p275
 * 
 * 전역변수(Global Variable)
 * 모든 메서드에서 참조할 수 있는 변수
 * 객체지향프로그래밍에서 젼역변수는 멤버변수(속성) 이다.
 * 
 * 지역변수(Local variable)
 * 측정 메서드에서 선언된 변수로 해당 메서드에서만 참조한다.
 * 해당 메서드가 끝나면Stack에서 사라진다 (Pop)
 */

namespace ch04
{
    internal class _4_메서드_지역변수
    {
    static int result = 0;


        static void Main4(string[] args)
        {
            int n1 = 1;
            int n2 = 10;

            result = Sum(n1, n2);

            Console.WriteLine(result);

        } // end of Main

        public static int Sum(int start, int end)
        {
            int total = 0;

            for(int k = start; k <=end; k++)
            {
                total += k;
            }
            return total;
        }
    }
}
