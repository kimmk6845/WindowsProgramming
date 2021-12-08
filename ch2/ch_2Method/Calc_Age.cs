public class Calc_Age
{
    public static int Na(int year,int age, int c_year)      //나이 계산
    {
        age = c_year - year + 1;        //현재년도 - 출생년도 + 1 = 나이
        return age;
    }
}
