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
        // Main!
        static void Main(string[] args)
        {

        }

       /*
        static int Main(string[] args)
        {
            return 0;
        }
        */
    }
}
