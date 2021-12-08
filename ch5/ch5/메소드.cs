using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class Add
    {
        public int plus(int a, int b)
        {
            int hap;
            return hap = a + b;
        }
    }
    class 메소드
    {
        static void Main(string[] args)
        {
            Add Sum = new Add();
            int tot;
            tot = Sum.plus(22, 33);
            Console.WriteLine("a + b = {0}",tot);
        }
    }
}
