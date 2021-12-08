using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class Hap_Min_Max_Aver
    {
        static void Main(string[] args)
        {
            int MAX = 0;
            int MIN = 10;
            int HAP = 0;
            int AVER = 0;
            int[] su = new int[7] { 1, 3, 5, 7, 2, 4, 6 };

            for(int i=0;i<su.Length;i++)        //합
            {
                HAP += su[i];
            }

            for(int i=0;i<su.Length;i++)        //최대
            {
                if (MAX < su[i])
                    MAX = su[i];
            }

            for(int i=0;i<su.Length;i++)        //최소
            {
                if (MIN > su[i])
                    MIN = su[i];
            }

            AVER = HAP / su.Length;             //평균

            Console.WriteLine("합계 = {0}, 최댓값 = {1}, 최솟값 = {2}, 평균 = {3}",HAP,MAX,MIN,AVER);

            Console.ReadKey();
        }
    }
}
