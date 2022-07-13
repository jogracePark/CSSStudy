using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
날짜 : 2022/07/12
이름 : 박은총
내용 : 변수 실습하기 교재 p79

변수(Variable)
 - 데이터를 처리하기 위한 데이터 그릇
 - 변수는 메모리상에 생성되는 공간

상수(Constant)
 - 데이터를 변경할 수 없는 변수
 - 최초 저장(초기화)된 데이터를 고정

 */
namespace ch02
{
    internal class _1_변수
    {
        static void Main1(string[] args)
        {
            // 변수
            int num1; // 선언
            num1 = 10; // 값 할당

            int num2 = 20; // 선언과 초기화

            int num3 = num1 + num2; // 데이터 처리(연산)

            Console.WriteLine("num3 : " + num3); ;

            const double PI = 3.14;
            const int NUM = 10; // 상수, 즉 대입하지 못하는 변수. 암묵적으로 대문자를 사용한다
            // NUM = 20;(X)

            Console.WriteLine("PI : " + PI);
            Console.WriteLine("NUM : " + NUM);
        }
    }
}
