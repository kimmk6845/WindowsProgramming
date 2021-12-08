using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 속성
{
    class 성적처리
    {
        public class seongjuk
        {
            private string _hakbun;
            private string _name;
            private int _kor;
            private int _mat;

            private int _tot;
            private int _aver;

            public seongjuk(string h, string n, int k, int m)
            {
                _hakbun = h;
                _name = n;
                _kor = k;
                _mat = m;

                _tot = sum(_kor, _mat);
                _aver = average(_kor, _mat);
            }


            public string Hakbun
            {
                get { return _hakbun; }
                set { _hakbun = value; }
            }
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public int Kor
            {
                get { return _kor; }
                set { _kor = value; }
            }
            public int Mat
            {
                get { return _mat; }
                set { _mat = value; }
            }
            public int Tot { get { return _tot; } }
            public int Aver { get { return _aver; } }

            public int sum(int k, int m)
            {
                return (k + m);
            }
            public int average(int k, int m)
            {
                int a = sum(k, m);
                return a / 2;
            }
        }

        class 속성_성적처리
        {
            static void Main(string[] args)
            {
                string hakbun = "";
                string name = "";
                int kor = 0, mat = 0;

                Console.Write("학번 입력 : ");
                hakbun = Console.ReadLine();
                Console.Write("이름 입력 : ");
                name = Console.ReadLine();
                Console.Write("국어 입력 : ");
                kor = Convert.ToInt32(Console.ReadLine());
                Console.Write("수학 입력 : ");
                mat = Convert.ToInt32(Console.ReadLine());

                seongjuk jumsu = new seongjuk(hakbun, name, kor, mat);

                Print_Out(jumsu.Hakbun, jumsu.Name, jumsu.Kor, jumsu.Mat, jumsu.Tot, jumsu.Aver);
            }

            private static void Print_Out(string h, string n, int k, int m, int t, int a)
            {
                Console.WriteLine("===============================================");
                Console.WriteLine("학번\t이름\t국어\t수학\t총점\t평균");
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", h, n, k, m, t, a);
                Console.WriteLine();
            }
        }
    }
}
