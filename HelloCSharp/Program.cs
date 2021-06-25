using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write는 한 줄로 작성, WriteLine는 엔터키 역할 추가 '\n'
            Console.WriteLine("Hello C#");
            // cmd에서 HelloCSharp test1 test2 하면 2의 값이 나옴
            Console.WriteLine(args.Length);
            // 키 입력 받을 때까지 기다려라
            Console.ReadKey();
            
        }
    }
}
