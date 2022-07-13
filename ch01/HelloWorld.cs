using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2022 07월 12일
이름 : 박은총
내용 : C# 개발환경 설정, Hello World 출력 교재 p44
 */

namespace ch01
{
    internal class HelloWorld
    {
        static void Main(string[] args) // svm탭탭
        {
            Console.WriteLine("Hello World"); // cw탭탭
            Console.WriteLine("Hello C#1");

            // 서식출력
            Console.Write("Hello\t"); // ctrl + d = 한줄 복사
            Console.Write("Hello\n");

            // 포맷출력
            Console.WriteLine("{0}, {1}", "Hello", "Busan");
        }
    }
}
