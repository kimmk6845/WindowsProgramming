﻿
public class Hakjum_M
{
    public static string Grade(int score, string grade)
    {
        switch (score / 10)
        {
            case 10:
            case 9:
                grade = "A";
                break;
            case 8:
                grade = "B";
                break;
            case 7:
                grade = "C";
                break;
            case 6:
                grade = "D";
                break;
            default:
                grade = "F";
                break;
        }
        return grade;
    }
}

