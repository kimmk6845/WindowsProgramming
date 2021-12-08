using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sachick_1;

namespace ch5
{
    class 네임스페이스연습
    {

        static void Main(string[] args)
        {
           // hap_test h_t = new hap_test();
            hap_test.a = 3;
            hap_test.b = 6;
            int sum = hap_test.hap();
            Console.WriteLine("a + b = {0}",sum);
        }
    }
}
