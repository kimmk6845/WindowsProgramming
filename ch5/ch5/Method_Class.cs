using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    public class Top
    {
        public static int a;
        public static int b;

        public static int hap()
        {
            return a + b;
        }
    }
    class Method_Class
    {
        static void Main(string[] args)
        {
            //Top su = new Top();
            Top.a = 3;
            Top.b = 6;
            int sum = Top.hap();
            Console.WriteLine("{0} + {1} = {2}",Top.a,Top.b,sum);
        }
    }
}
