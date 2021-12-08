using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class For_Star
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;

            for(i=0;i<5;i++)
                Console.Write("*");
            Console.WriteLine("\n");        //한줄 띄기

            for(j=0;j<5;j++)
                Console.WriteLine("*");
            Console.WriteLine("\n");

            for (j = 0; j < 5; j++)     //열
            {
                for (i = 0; i < 5; i++)     //행
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            for(j=0;j<5;j++)
            {
                for(i=0;i<j+1;i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
