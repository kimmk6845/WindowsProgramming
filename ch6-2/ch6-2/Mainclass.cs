using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using 다른네임스페이스;           //방법 1

namespace ch6_2
{
    class Mainclass
    {
        public static void Main()
        {
            ClassOne.Insa();

            다른네임스페이스.OtherClass.Insa();         //방법 2
        }
    }

    public class ClassOne
    {
        public static void Insa()
        {
            Console.WriteLine("안녕...");
        }
    }
}
