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
    public partial class FrmKeyInput : Form
    {
        public FrmKeyInput()
        {
            InitializeComponent();
        }

        private void FrmKeyInput_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = Convert.ToString(e.KeyCode);
            //  KeyCode는 int 형의 숫자임-그러므로 형 변환이 필요
            // 소스 추가 후 실행 시작 객체 지정 후 실행
            int a = Convert.ToInt16(e.KeyCode);
            label1.Text = Convert.ToString(a);
        }
    }
}
