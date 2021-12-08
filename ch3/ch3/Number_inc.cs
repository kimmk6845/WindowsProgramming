using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class Number_inc
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;

            for (i = 1; i < 10; i++)
            {
                for (j = i; j < 9; j++)
                    Console.Write(" ");         //앞쪽 공백
                for (j = i; j >= 1; j--)
                    Console.Write("{0}", j);     //뒤쪽 감소하는 수
                for (j = 2; j <= i; j++)
                    Console.Write("{0}", j);     //앞쪽 증가하는 수
                Console.WriteLine();
            }
        }
    }
}
