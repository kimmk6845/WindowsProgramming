using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kmk_가위바위보
{
    public partial class kmk_가위바위보 : Form
    {
        public kmk_가위바위보()
        {
            InitializeComponent();
        }
        bool result_view;  // 결과 보기 플래그
        int Total_count = 0;
        int User_count = 0, Com_count = 0, Draw_count = 0;
        // 내가 승,              컴승                비김 수 
        int User_S = 0, User_R = 0, User_P = 0;  // 나의 가위 바위 보 수
        int Com_S = 0, Com_R = 0, Com_P = 0;

        private void Timer_View_Result_Tick(object sender, EventArgs e)
        {
            int size = 20;
            if (!result_view)
            {
                if (Width >= MaximumSize.Width)
                {
                    Width = MaximumSize.Width;
                    result_view = true;
                    btn_View_Result.Text = "결과 접기 ◀";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width += size;
                }
            }
            else
            {
                if (Width <= MinimumSize.Width)
                {
                    Width = MinimumSize.Width;
                    result_view = false;
                    btn_View_Result.Text = "결과 보기 ▶";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width -= size;
                }
            }
        }

        private void Btn_View_Result_Click(object sender, EventArgs e)
        {
            Timer_View_Result.Start();

            lb_Me_Score.Text = "내가 이긴 횟수 : " + Convert.ToString(User_count) + "번";
            lb_Com_Score.Text = "컴이 이긴 횟수 : " + Convert.ToString(Com_count) + "번";
            lb_Draw_Score.Text = "비긴 횟수 : " + Convert.ToString(Draw_count) + "번";
            lb_Total_Count.Text = "총 " + Convert.ToString(Total_count) + "번의 게임을 진행하였습니다.";

            lb_Me_S.Text = "가위횟수 : " + Convert.ToString(User_S);
            lb_Me_R.Text = "바위횟수 : " + Convert.ToString(User_R);
            lb_Me_P.Text = "보 횟수 : " + Convert.ToString(User_P);

            lb_Com_S.Text = "가위횟수 : " + Convert.ToString(Com_S);
            lb_Com_R.Text = "바위횟수 : " + Convert.ToString(Com_R);
            lb_Com_P.Text = "보 횟수 : " + Convert.ToString(Com_P);
        }

        private void Scissor_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "Images/gawei.jpg";
            User_S++;
            Total_count++;
            Random r = new Random();
            int com_num = r.Next(1, 4);
            switch (com_num)
            {
                case 1:
                    {
                        pictureBox1.ImageLocation = "Images/gawei.jpg";
                        lbResult.Text = "서로 비김";
                        Com_S++;
                        Draw_count++;
                        break;
                    }
                case 2:
                    {
                        pictureBox1.ImageLocation = "Images/bawei.jpg";
                        lbResult.Text = "내가 짐";
                        Com_R++;
                        Com_count++;
                        break;
                    }
                default:
                    {
                        pictureBox1.ImageLocation = "Images/bo.jpg";
                        lbResult.Text = "내가 이김";
                        Com_P++;
                        User_count++;
                        break;
                    }
            }
        }
        private void Rock_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "Images/bawei.jpg";
            User_R++;
            Total_count++;
            Random r = new Random();
            int com_num = r.Next(1, 4);
            switch (com_num)
            {
                case 1:
                    {
                        pictureBox1.ImageLocation = "Images/gawei.jpg";
                        lbResult.Text = "내가 이김";
                        Com_S++;
                        User_count++;
                        break;
                    }
                case 2:
                    {
                        pictureBox1.ImageLocation = "Images/bawei.jpg";
                        lbResult.Text = "서로 비김";
                        Com_R++;
                        Draw_count++;
                        break;
                    }
                default:
                    {
                        pictureBox1.ImageLocation = "Images/bo.jpg";
                        lbResult.Text = "내가 짐";
                        Com_P++;
                        Com_count++;
                        break;
                    }
            }
        }
        private void Papper_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "Images/bo.jpg";
            User_P++;
            Total_count++;
            Random r = new Random();
            int com_num = r.Next(1, 4);
            switch (com_num)
            {
                case 1:
                    {
                        pictureBox1.ImageLocation = "Images/gawei.jpg";
                        lbResult.Text = "내가 짐";
                        Com_S++;
                        Com_count++;
                        break;
                    }
                case 2:
                    {
                        pictureBox1.ImageLocation = "Images/bawei.jpg";
                        lbResult.Text = "내가 이김";
                        Com_R++;
                        User_count++;
                        break;
                    }
                default:
                    {
                        pictureBox1.ImageLocation = "Images/bo.jpg";
                        lbResult.Text = "서로 비김";
                        Com_P++;
                        Draw_count++;
                        break;
                    }
            }
        }
    }
}