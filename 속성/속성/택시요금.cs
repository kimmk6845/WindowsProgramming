using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 속성
{
    public class taxi
    {
        private int _distance;

        private int _pay;
        private int _buga;
        private int _tot;

        public taxi(int d)  //생성자
        {                   //메인에서 거리만 입력받으므로 나머지는 메소드 처리
            _distance = d;

            _pay = Pay1(_distance);
            _buga = Buga1(_pay);
            _tot = Tot1(_pay, _buga);
        }

        public int Distance { get { return _distance; } set { _distance = value; } }
        public int Pay { get { return _pay; } }
        public int Buga { get { return _buga; } }
        public int Tot { get { return _tot; } }

        public int Pay1(int d)
        {
            return d * 2000;
        }
        public int Buga1(int p)
        {
            return p / 10;
        }
        public int Tot1(int p, int b)
        {
            return p + b;
        }
    }
    class 속성_택시요금
    {
        static void Main(string[] args)
        {
            int distance = 0;
            Console.Write("택시로 이동할 거리(KM)를 정수로 입력하세요 : ");
            distance = Convert.ToInt16(Console.ReadLine());

            taxi t = new taxi(distance);

            Print_Out(t.Distance, t.Pay, t.Buga, t.Tot);
        }

        private static void Print_Out(int d, int p, int b, int t)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("이동거리  택시 요금  부가세  요금 합계");
            Console.WriteLine("{0}KM      {1}원    {2}원  {3}원", d, p, b, t);
        }
    }

}
