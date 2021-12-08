class Calc_Gender
{
    public static string Sung(int gender, string gender1)       //성별 구분
    {
        if (gender % 2 == 0)        //2,4 여자
            gender1 = "여자";
        else                        //1,3 남자
            gender1 = "남자";
        return gender1;
    }
}
