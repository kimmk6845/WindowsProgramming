using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMK_JuminDLL
{
    public class Jumin
    {
        private string _jumin1;
        private string _jumin2;

        private int _year;
        private int _month;
        private int _day;
        private string _type;
        private int _age;

        public Jumin(string j1, string j2)
        {
            _jumin1 = j1;
            _jumin2 = j2;

            _year = GetYear(Jumin1, Jumin2);
            _month = GetMonth(Jumin1);
            _day = GetDay(Jumin1);
            _type = GetType(Jumin2);
            _age = GetAge(Jumin1, Jumin2);
        }

        public string Jumin1
        {
            get { return _jumin1; }
            set { _jumin1 = value; }
        }
        public string Jumin2
        {
            get { return _jumin2; }
            set { _jumin2 = value; }
        }
        public int Year { get { return _year; } }
        public int Month { get { return _month; } }
        public int Day { get { return _day; } }
        public string Type { get { return _type; } }
        public int Age { get { return _age; } }

        public int GetYear(string j1, string j2)
        {
            int year = Convert.ToInt32(j1.Substring(0, 2));
            int check = Convert.ToInt32(j2.Substring(0, 1));
            if (check == 1 || check == 2)
                year = 1900 + year;
            else
                year = 2000 + year;

            return year;
        }
        public int GetMonth(string j1)
        {
            int month = Convert.ToInt32(j1.Substring(2, 2));
            return month;
        }
        public int GetDay(string j1)
        {
            int day = Convert.ToInt32(j1.Substring(4, 2));
            return day;
        }
        public string GetType(string j2)
        {
            string type = "";
            int gender = Convert.ToInt32(j2.Substring(0, 1));
            if (gender == 1 || gender == 3)
                type = "남자";
            else
                type = "여자";

            return type;
        }
        public int GetAge(string j1, string j2)
        {
            int year = _year; //태어난 년도 구함
            string this_year = Convert.ToString(DateTime.Now);
            int c_year = Convert.ToInt32(this_year.Substring(0, 4));

            int age;
            age = c_year - year + 1;

            return age;
        }
    }
}
