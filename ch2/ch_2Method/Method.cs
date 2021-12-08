using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch_2Method
{
    class Method
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 13;
            int hap = Plus.Sum(a, b);
            Console.WriteLine("a + b = {0}",hap);
        }
        // 리턴값이 없게 프로그래밍 하지 않기!!!!
        /*
        private static void Sum(int a, int b)
        {
            int tot;
            tot = a + b;
            Console.WriteLine("a + b = {0}", tot);
        }
        */

    }
    //public class Plus
    //{
    //    public static int Sum(int a, int b)
    //    {
    //        int tot;
    //        tot = a + b;
    //        return tot;
    //    }
    //}
}
