public class GBB
{
    public static string check(int fix_su, int input_su)
    {
        if (fix_su > input_su)
            return "너무 작아";
        else if (fix_su < input_su)
            return "너무 커";
        else
            return "정답";
    }
}

