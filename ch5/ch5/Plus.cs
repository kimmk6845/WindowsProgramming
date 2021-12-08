using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class Plus
    {
        public static int plus(int a,int b)
        {
            int hap;
            hap = a + b;
            return hap;
        }

        static void Main(string[] args)
        {
            int tot;
            tot = plus(2, 3);
            Console.WriteLine("a+ b = {0}",tot);
        }
    }
}
