using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ch05.Sub3;

/*
 * 날짜 : 2022/07/18
 * 이름 : 박은총
 * 내용 : 클래스 변수, 클래스 메서드 실습하기 교재 p225
 * 
 * 클래스 변수, 클래스 메서드
 *  - 클래스 변수와 클래스 메서드는 static을 선언한 변수와 메서드로 Data 영역 메모리 공간에 하나의 클래스로 관리
 *  - 클래스 이름으로 직접 참조하거나 호출한다.
 *  
 *  싱글톤(Singleton)
 *  - static을 활용한 가장 대표적인 객체 생성 방법
 *  - 싱글톤 패턴이 적용된 객체는 메모리에 하나의 인스턴스만 생성하고 공유한다.
 *  - 싱글톤 객체를 활용해서 메모리 절약과 성능 향상을 도모한다/
 */

namespace ch05
{
    class Increment
    {
        public int num1;

        // Data 영역에 따로 관리되는 클래스 변수(정적 변수)
        public static int num2;

        public Increment()
        {
            num1++;
            num2++;
            Console.WriteLine("num1 : {0}, num2 : {1}", num1, num2);
        }

        // Data 영역에 따로 관리되는 클래스 메서드(정적 메서드)
        public static void Add()
        {
            // 클래스 메서드(static 메서드)는 non-static 변수를 참조할 수 없다.
            //num1++;
            num2++;
            Console.WriteLine("num2 : {0}", num2);
        }
    }

    internal class _3_클래스_변수와_메서드
    {
        static void Main(string[] args)
        {
            Increment Inc1 = new Increment();
            Increment Inc2 = new Increment();
            Increment Inc3 = new Increment();

            // 클래스 변수 참조
            Increment.num2 = 10;

            // 클래스 메서드 실행
            Increment.Add();

            Car c1 = new Car("소나타", "검정", 0);
            c1.Show();

            Car c2 = new Car("아반테", "검정", 0);
            c2.Show();

            Car c3 = new Car("산타페", "검정", 0);
            c3.Show();

            // 싱글톤 객체
            Calc cal = Calc.Instance;
            Calc cal2 = Calc.Instance;

            cal.Plus(1, 2);

            int r1 = cal.Plus(1, 2);
            int r2 = cal.Minus(1, 2);
            int r3 = cal2.Multi(1, 2);
            int r4 = cal2.Div(1, 2);

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);
            Console.WriteLine("r4 : " + r4);
        }
    }
}
