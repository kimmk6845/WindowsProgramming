using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch11_Event
{
    public partial class FrmKeyDown : Form
    {
        private Point p;
        private Point c1;        //추락 원들의 객체
        private Point c2;
        private Point c3;
        int jumsu = 0;

        public FrmKeyDown()
        {
            InitializeComponent();

            p.X = 100; p.Y = 400;

            Random r = new Random();
            int a = r.Next(280);
            int b = r.Next(100);     //떨어지는 원들의 생성 위치
            c1.X = a; c1.Y = b;
            a = r.Next(280);
            b = r.Next(100);
            c2.X = a; c2.Y = b;
            a = r.Next(280);
            b = r.Next(100);
            c3.X = a; c3.Y = b;

            timer_CircleDown.Start();       //게임 시작
        }

        private void FrmKeyDown_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Black, p.X, p.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Red, c1.X, c1.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Blue, c2.X, c2.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Yellow, c3.X, c3.Y, 40, 40);
        }

        private void FrmKeyDown_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    {
                        if (p.X >= 0)
                            p.X -= 20;
                        else
                            p.X -= 0;
                        Invalidate(); break;
                    }
                case Keys.Right:
                    {
                        if (p.X < 260)  //원이 만들어질 때 좌측 상단을 기준으로 만들어져 오른쪽 화면을 나가게 되어 260으로 조정
                            p.X += 20;
                        else
                            p.X += 0;
                        Invalidate(); break;
                    }
                //case Keys.Up:
                //    {
                //        if (p.Y > 300)
                //            p.Y -= 20;
                //        else
                //            p.Y -= 0;
                //        Invalidate(); break;
                //    }
                //case Keys.Down:
                //    {
                //        if (p.Y < 440) // 화면 아래로 나가므로 440으로 조정 (원 크기 40)
                //            p.Y += 20;
                //        else
                //            p.Y += 0;
                //        Invalidate(); break;
                //    }
                default:
                    break;
            }
        }

        private void CircleMove()
        {
            Random r = new Random();
            int move = r.Next(20);      //0~30사이 랜덤값으로 추락
            c1.Y = c1.Y + move;
            move = r.Next(20);
            c2.Y += move;
            move = r.Next(20);
            c3.Y += move;

            
            if(((p.X - c1.X) > -30 && (p.X - c1.X) < 30) && ((p.Y - c1.Y) > -30 && (p.Y - c1.Y) < 30))   //충돌하면 원 재생성하고 점수 증가
            {
                jumsu += 1;
                int a = r.Next(280);
                int b = r.Next(100);
                c1.X = a; c1.Y = b;
            }
            else if (((p.X - c2.X) > -30 && (p.X - c2.X) < 30) && ((p.Y - c2.Y) > -30 && (p.Y - c2.Y) < 30))
            {
                jumsu += 1;
                int a = r.Next(280);
                int b = r.Next(100);
                c2.X = a; c2.Y = b;
            }
            else if (((p.X - c3.X) > -30 && (p.X - c3.X) < 30) && ((p.Y - c3.Y) > -30 && (p.Y - c3.Y) < 30))
            {
                jumsu += 1;
                int a = r.Next(280);
                int b = r.Next(100);
                c3.X = a; c3.Y = b;
            }
            if(c1.Y > 500)      //점수 원들이 바닥으로 떨어지면 위에 재생성
            {
                int a = r.Next(280);
                int b = r.Next(100);
                c1.X = a; c1.Y = b;
            }else if(c2.Y > 500)
            {
                int a = r.Next(280);
                int b = r.Next(100);
                c2.X = a; c2.Y = b;
            }else if(c3.Y > 500)
            {
                int a = r.Next(280);
                int b = r.Next(100);
                c3.X = a; c3.Y = b;
            }
            lbJumsu.Text = "현재 상태 : 점수" + Convert.ToString(jumsu) + "점";
            if(jumsu >= 5)
            {
                timer_CircleDown.Stop();
                MessageBox.Show("게임종료");
                Application.Exit();
            }
        }

        private void Timer_CircleDown_Tick(object sender, EventArgs e)
        {
            CircleMove();
            Invalidate();
        }
    }
}
