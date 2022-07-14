using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 박은총
 * 내용 : 메서드 타입 실습하기 교재 p265
 */

namespace ch03
{
    internal class _2_메서드_형태
    {
        static void Main2(string[] args)
        {
            // 메서드 호출
            double y1 = Type1(0.12); // 인자값 0.12 전달
            double y2 = Type1(1.13);

            Console.WriteLine("y1 : " + y1);
            Console.WriteLine("y2 : " + y2);

            Type2(true);
            Type2(false);

            string rs1 = Type3();
            Console.WriteLine(rs1);

            Type4();

        } // end of Main

        // Type1 : 매개변수 o, 리턴값 o
        public static double Type1(double x) 
        {
            double y = x + Math.PI;
            return y;
        }

        // Type1 : 매개변수 x, 리턴값 o
        public static void Type2(bool status) 
        {
            if (status)
            {
                Console.WriteLine("참 입니다.");
            }
            else
            {
                Console.WriteLine("거짓 입니다");
            }
        }

        // Type1 : 매개변수 o, 리턴값 x
        public static string Type3()
        {
            int n1 = 1;
            int n2 = 2;

            if (n1 > n2)
            {
                return "n1은 n2보다 크다";
            }
            else
            {
                return "n1은 n2보다 작다";
            }

        }

        // Type1 : 매개변수 x, 리턴값 x
        public static void Type4()
        {
            Console.WriteLine("Type4 result : " + Type1(0.12));
        }

    }
}
