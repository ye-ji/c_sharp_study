// using. 프롤로그(prolog). 클래스의 네임스페이스 선언
// 네임스페이스 명시 없이 클래스 사용!

// ex) Console.Write()
// -> System.Console.Write()
// 원래는 네임스페이스명.클래스명을 써야하지만, System이라는 namespace를 명시함으로, 위와같이 Console.Write()를 쓸 수 있는것이다.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// namespace. 프로그램 몸체
namespace ConsoleApplication1
{
    // 하나 이상의 Class 정의는 필수! 왜냐면 Main은 하나의 Class 안에 있어야 하므로!
    // class
    class Program
    {


        static void Main(String[] args)
        {
            string filePath = @"C:\Users\scoleridge\Documents\";
            Console.WriteLine(filePath);
            //Output: C:\Users\scoleridge\Documents\

            string text = @"My pensive SARA ! thy soft cheek reclined
            Thus on mine arm, most soothing sweet it is
            To sit beside our Cot,...";
            Console.WriteLine(text);
            /* Output:
            My pensive SARA ! thy soft cheek reclined
               Thus on mine arm, most soothing sweet it is
               To sit beside our Cot,... 
            */

            string quote = @"Her name was ""Sara.""";
            Console.WriteLine(quote);
            //Output: Her name was "Sara."
        }


        // Main! Ctrl + F5 to excute Main
        /*
        static void Main(string[] args)
        {
            Console.Write("write\n");
            Console.WriteLine("Hello World!");
            Console.WriteLine("{0} {1} {2}", true, false, 3.14f);
            Console.WriteLine("{0} + {1} = {2}", 1, 2, 1 + 2);

            // C - 통화($, W 등) 표시
            // N - 콤마 출력
            // P - % 단위로 출력
            // X - 16진수 출력
            Console.WriteLine("{0:C} {1:P} {0:X}", 123, 123.45);


        }
        */
        /*
         static int Main(string[] args)
         {
             return 0;
         }
         */
    }
}
