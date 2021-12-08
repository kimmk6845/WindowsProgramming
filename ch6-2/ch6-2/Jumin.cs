using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuminDLL;

namespace ch6_2
{
    class Jumin
    {
        static void Main(string[] args)
        {
            string jumin = "";

            Console.Write("주민번호 입력 : ");
            jumin = Console.ReadLine();
            Console.WriteLine("당신이 태어난 년도는 {0}",JuminDLL.Calculator.YEAR(jumin));
            Console.WriteLine("당신이 태어난 월은 {0}", JuminDLL.Calculator.MONTH(jumin));
            Console.WriteLine("당신이 태어난 날은 {0}", JuminDLL.Calculator.DAY(jumin));
            Console.WriteLine("당신의 나이는 {0}", JuminDLL.Calculator.NAI(jumin));
            Console.WriteLine("당신의 성별은 {0}", JuminDLL.Calculator.TYPE(jumin));

        }
    }
}
