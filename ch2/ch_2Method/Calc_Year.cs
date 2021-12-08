public class Calc_Year
{
    public static int Hae(int year, int gender)         //출생년도 계산
    {
        if (gender == 1 || gender == 2)
            year = year + 1900;         //2000년도 이전 출생자
        else
            year = year + 2000;         //2000년도 이후 출생자
        return year;
    }
}

