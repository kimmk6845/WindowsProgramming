using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class Gugudan
    {
        static void Main(string[] args)
        {
            int i = 2;
            int j = 0;
            for (j = 1; j < 10; j++)    //2단 옆으로 완성(1단계)
            {
                Console.Write("{0}*{1}={2}  ", i, j, i * j);
            }

            Console.WriteLine("\n");

            for (j = 1; j < 10; j++)       //2단 아래로 완성(2단계)
            {
                Console.WriteLine("{0}*{1}={2:D2}  ", i, j, i * j);
            }

            Console.WriteLine("\n");

            for (i = 1; i < 10; i++)           //구구단 세로(3단계)
            {
                for (j = 2; j < 10; j++)
                {
                    Console.Write("{0}*{1}={2:D2}  ", j, i, j * i);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            for (i = 2; i < 10; i++)       //구구단 가로(3단계)
            {
                for (j = 1; j < 10; j++)
                {
                    Console.Write("{0}*{1}={2:D2}  ", i, j, i * j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            for (i = 1; i < 10; i++)       //구구단 4단계
            {
                for (j = 1; j < i + 1; j++)
                {
                    Console.Write("{0}*{1}={2:D2}  ", i, j, i * j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            for (i = 1; i < 10; i=i+3)      //구구단 5단계
            {
                for (j = 1; j < 10; j++)
                {
                    Console.Write("{0}*{1}={2:D2}  ", i, j, i * j);
                    Console.Write("{0}*{1}={2:D2}  ", i+1, j, i * j);
                    Console.WriteLine("{0}*{1}={2:D2}  ", i+2, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
