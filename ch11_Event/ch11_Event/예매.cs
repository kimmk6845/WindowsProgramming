using System;
using System.Drawing;
using System.Windows.Forms;

namespace ch11_Event
{
    public partial class 예매 : Form
    {
        public 예매()
        {
            InitializeComponent();
        }

        private void Seat7_Click(object sender, EventArgs e)
        {
            if (seat7.BackColor == Color.Magenta)
            {
                MessageBox.Show("예매된 자리입니다.\n다른자리 선택하세요.");
            }
            else
            {
                seat7.Text = "예매완료됨";
                seat7.BackColor = Color.Magenta;
            }
        }

        private void Seat2_Click(object sender, EventArgs e)
        {
            if (seat2.BackColor == Color.Magenta)
            {
                MessageBox.Show("예매된 자리입니다.\n다른자리 선택하세요.");
            }
            else
            {
                seat2.Text = "예매완료됨";
                seat2.BackColor = Color.Magenta;
            }
        }

        private void Seat3_Click(object sender, EventArgs e)
        {
            if (seat3.BackColor == Color.Magenta)
            {
                MessageBox.Show("예매된 자리입니다.\n다른자리 선택하세요.");
            }
            else
            {
                seat3.Text = "예매완료됨";
                seat3.BackColor = Color.Magenta;
            }
        }

        private void Seat4_Click(object sender, EventArgs e)
        {
            if (seat4.BackColor == Color.Magenta)
            {
                MessageBox.Show("예매된 자리입니다.\n다른자리 선택하세요.");
            }
            else
            {
                seat4.Text = "예매완료됨";
                seat4.BackColor = Color.Magenta;
            }
        }

        private void Seat8_Click(object sender, EventArgs e)
        {
            if (seat8.BackColor == Color.Magenta)
            {
                MessageBox.Show("예매된 자리입니다.\n다른자리 선택하세요.");
            }
            else
            {
                seat8.Text = "예매완료됨";
                seat8.BackColor = Color.Magenta;
            }
        }

        private void Seat1_Click(object sender, EventArgs e)
        {
            if (seat1.BackColor == Color.Magenta)
            {
                MessageBox.Show("예매된 자리입니다.\n다른자리 선택하세요.");
            }
            else
            {
                seat1.Text = "예매완료됨";
                seat1.BackColor = Color.Magenta;
            }
        }

        private void Seat6_Click(object sender, EventArgs e)
        {
            if (seat6.BackColor == Color.Magenta)
            {
                MessageBox.Show("예매된 자리입니다.\n다른자리 선택하세요.");
            }
            else
            {
                seat6.Text = "예매완료됨";
                seat6.BackColor = Color.Magenta;
            }
        }

        private void Seat5_Click(object sender, EventArgs e)
        {
            if (seat5.BackColor == Color.Magenta)
            {
                MessageBox.Show("예매된 자리입니다.\n다른자리 선택하세요.");
            }
            else
            {
                seat5.Text = "예매완료됨";
                seat5.BackColor = Color.Magenta;
            }
        }

        private void Seat9_Click(object sender, EventArgs e)
        {
            if (seat9.BackColor == Color.Magenta)
            {
                MessageBox.Show("예매된 자리입니다.\n다른자리 선택하세요.");
            }
            else
            {
                seat9.Text = "예매완료됨";
                seat9.BackColor = Color.Magenta;
            }
        }

        private void Seat10_Click(object sender, EventArgs e)
        {
            if (seat10.BackColor == Color.Magenta)
            {
                MessageBox.Show("예매된 자리입니다.\n다른자리 선택하세요.");
            }
            else
            {
                seat10.Text = "예매완료됨";
                seat10.BackColor = Color.Magenta;
            }
        }

        private void Seat11_Click(object sender, EventArgs e)
        {
            if (seat11.BackColor == Color.Magenta)
            {
                MessageBox.Show("예매된 자리입니다.\n다른자리 선택하세요.");
            }
            else
            {
                seat11.Text = "예매완료됨";
                seat11.BackColor = Color.Magenta;
            }
        }

        private void Seat12_Click(object sender, EventArgs e)
        {
            if (seat12.BackColor == Color.Magenta)
            {
                MessageBox.Show("예매된 자리입니다.\n다른자리 선택하세요.");
            }
            else
            {
                seat12.Text = "예매완료됨";
                seat12.BackColor = Color.Magenta;
            }
        }
    }
}
