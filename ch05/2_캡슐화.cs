using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ch05.Sub2;

/*
 * 날짜 : 2022/07/18
 * 이름 : 박은총
 * 내용 : 캡슐화 실습하기 교재 p203
 * 
 * 캡슐화(Encapsulation)
 *  - 캡슐화는 객체의 내용(필드)를 외부에서 참조하지 못하도록 객체의정보(속성)를 은닉하는 특성
 *  - 캡슐화를 위한 접근 제한자 public,private,protected를 사용한다
 *  - 은닉된 정보의 안전한 제공을 위해 Getter, Setter 를 사용(프로퍼티)
 */

namespace ch05
{
    internal class _2_캡슐화
    {
        static void Main2(string[] args)
        {
            // 객체 생성 및 초기화
            Account kb = new Account("국민은행", "101-12-1010", "김유신", 10000);

            // Acount 객체 활용
            kb.Deposit(40000);
            kb.Withdraw(5000);
            kb.Show();

            // 객체 생성 및 초기화
            Car sonata = new Car("소나타", "흰색", 0);

            // 객체 기능 활용
            sonata.SpeedUp(80);
            sonata.SpeedDown(20);
            sonata.Show();

            // Getter, Setter 활용한 객체
            Car bmw = new Car();

            bmw.Name = "BMW 520";
            bmw.Color = "검은색";
            bmw.Speed = -10;

            Console.WriteLine("sonata name : " + bmw.Name);
            Console.WriteLine("sonata color : " + bmw.Color);
            Console.WriteLine("sonata speed : " + bmw.Speed);
        }
    }
}
