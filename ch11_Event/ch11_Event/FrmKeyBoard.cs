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
    public partial class FrmKeyBoard : Form
    {
        public FrmKeyBoard()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                button1.Focus();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(textBox1.Text);
            float b = Convert.ToSingle(textBox2.Text);

            lb_Tot.Text = Convert.ToString(a + b);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            lb_Tot.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

            textBox1.Focus();
        }
    }
}
