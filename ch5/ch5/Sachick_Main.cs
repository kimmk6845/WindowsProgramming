using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M_D;

namespace ch5
{
    class Sachick_Main
    {
        static void Main(string[] args)
        {
            Console.Write("하나의 정수 입력 : ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("하나의 정수 입력 : ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            ADDSUB_OP AS = new ADDSUB_OP();
            int a = AS.ADD(num1, num2);
            int b = AS.SUB(num1, num2);
            M_D.MD_OP k = new M_D.MD_OP();
            int c = k.Mult(num1, num2);
            int d = k.Divide(num1, num2);


            Console.WriteLine("{0}과 {1}의 합은 {2}", num1, num2, a);
            Console.WriteLine("{0}과 {1}의 차은 {2}", num1, num2, b);
            Console.WriteLine("{0}과 {1}의 곱은 {2}", num1, num2, c);
            Console.WriteLine("{0}과 {1}의 제는 {2}", num1, num2, d);
        }
    }
}
