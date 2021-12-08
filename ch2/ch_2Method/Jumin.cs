using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch_2Method
{
    class Jumin
    {
        static void Main(string[] args)
        {
            string jumin = "";
            string gender1 = "", this_year = "";
            int year = 0, month = 0, day = 0, gender = 0, age = 0;
            int c_year = 0;

            Console.Write("주민번호 13자리를 입력하세요 : ");
            jumin = Console.ReadLine();

            year = Convert.ToInt32(jumin.Substring(0, 2));
            month = Convert.ToInt32(jumin.Substring(2, 2));
            day = Convert.ToInt32(jumin.Substring(4, 2));
            gender = Convert.ToInt32(jumin.Substring(6, 1));

            this_year = Convert.ToString(DateTime.Now);     //시스템 날짜를 이용한 현재시간
            c_year = Convert.ToInt32(this_year.Substring(0, 4));    //시스템 날짜를 이용한 현재년도
            year = Calc_Year.Hae(year, gender);         //출생년도 계산
            age = Calc_Age.Na(year, age, c_year);       //나이 계산
            gender1 = Calc_Gender.Sung(gender, gender1);    //성별 구분

            Console.WriteLine("년도는 : {0}",year);
            Console.WriteLine("월은 : {0}", month);
            Console.WriteLine("일은 : {0}", day);
            Console.WriteLine("올해의 나이는 : {0}", age);
            Console.WriteLine("성별은 : {0}", gender1);

        }
    }
}
