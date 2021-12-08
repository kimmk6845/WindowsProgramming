using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMK계산기
{
    public partial class KMK계산기 : Form
    {
        // 계산기에서 사용할 변수 선언
        string output = "";      // 임시 출력 할 변수
        char oper;               // 연산자 저장할 변수 + , - , * , /
        double result;          // 결과 값 저장할 변수
        string str = "";        //중위표기식 (사용자 입력)
        string postFix = "";        //후위표기식

        public KMK계산기()
        {
            InitializeComponent();
        }

        private void bt_num_click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            output += btn.Text;
            textBox1.Text = output;
            str += btn.Text;
        }

        private void bt_oper_click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            output += btn.Text;
            textBox1.Text = output;
            oper = btn.Text[0];
            str += oper;
        }

        private void bt_clear_click(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            output = "";
            result = 0.0;
            str = "";
        }

        private void KMK계산기_Load(object sender, EventArgs e)
        {
            textBox1.Text = output;
        }

        private void bt_calc_click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            postFix = InToPost(str);        //중위 표기식 -> 후위 표기식
            result = Cal(postFix);          //후위표기식 계산
            output += btn.Text + result.ToString();         //=과 계산결과를 임시출력 변수에 저장
            textBox1.Text = output;         //결과 출력
            str = "";               //저장되어있던 중위표기식 초기화 시킨 후
            str += result.ToString();       //결과 값을 저장(다음 계산을 위함)
        }
        private double Cal(string postfix)        //스택 이용한 후위표기식 계산
        {
            double op1, op2;        //계산할 피연산자
            Stack s = new Stack(100);       //크기가 100인 스택 생성,후위표기식 계산을 위함

            for (int i = 0; i <= postfix.Length - 1; i++)
            {
                if (postfix[i] != '+' && postfix[i] != '-' &&
                    postfix[i] != '*' && postfix[i] != '/' &&
                    postfix[i] != '%' && postfix[i] != '^' &&
                    postfix[i] != '!' && postfix[i] != '√')
                {       //입력이 피연산자
                    s.push(postfix[i].ToString());      //스택에 값을 넣음
                }
                else
                {       //연산자이면
                    switch (postfix[i])
                    {                           //피연산자를 pop해서 변수에 저장하고 각 연산자에 해당하는 연산
                        case '+':               //결과값을 다시 스택에 넣음(push)
                            op2 = Convert.ToDouble(s.pop());
                            op1 = Convert.ToDouble(s.pop());
                            s.push(Convert.ToString(op1 + op2)); break;
                        case '-':
                            op2 = Convert.ToDouble(s.pop());
                            op1 = Convert.ToDouble(s.pop());
                            s.push(Convert.ToString(op1 - op2)); break;
                        case '*':
                            op2 = Convert.ToDouble(s.pop());
                            op1 = Convert.ToDouble(s.pop());
                            s.push(Convert.ToString(op1 * op2)); break;
                        case '/':
                            op2 = Convert.ToDouble(s.pop());
                            op1 = Convert.ToDouble(s.pop());
                            s.push(Convert.ToString(op1 / op2)); break;
                        case '%':
                            op2 = Convert.ToDouble(s.pop());
                            op1 = Convert.ToDouble(s.pop());
                            s.push(Convert.ToString(op1 % op2)); break;
                        case '^':
                            op2 = Convert.ToDouble(s.pop());
                            op1 = Convert.ToDouble(s.pop());
                            double a = op1;
                            for (int j = 1; j < op2; j++)
                                op1 *= a;
                            op2 = op1;
                            s.push(Convert.ToString(op2)); break;
                        case '!':
                            op2 = Convert.ToDouble(s.pop());
                            int n = 1;
                            for (int j = 1; j <= (int)op2; j++)
                                n *= j;
                            s.push(Convert.ToString(n)); break;
                        case '√':
                            op2 = Convert.ToDouble(s.pop());
                            double num = Math.Sqrt(op2);
                            s.push(Convert.ToString(num)); break;
                    }
                }
            }
            return Convert.ToDouble(s.peek());      //모든 연산이 끝나면 스택의 top값인 연산결과값을 반환함
        }
        private int prec(char op)       //연산자 우선순위
        {
            int pri = 0;
            switch (op)         //우선순위 : +,- < *,/,%,^ < !,√
            {
                case '+': case '-': pri = 1; break;
                case '*': case '/': case '%': case '^': pri = 2; break;
                case '!': case '√': pri = 3; break;
            }
            return pri;
        }

        private string InToPost(string infix)         //중위표기 -> 후위표기
        {
            Stack s = new Stack(100);       //크기가 100인 스택 생성
            string postfix = "";            //후위 표기식을 저장할 변수

            for (int i = 0; i < infix.Length; i++)
            {
                switch (infix[i])
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '%':
                    case '^':
                    case '!':
                        while (!s.is_empty() && (prec(infix[i]) <= prec(Convert.ToChar(s.peek()))))         //스택에 있는 연산자 우선순위가 더 크거나 같으면
                            postfix += s.pop();             //pop해서 변수에 저장
                        s.push(infix[i].ToString());        //스택에 연산자 넣음
                        break;
                    default:        //피연산자
                        postfix += infix[i];        //피연산자일경우 변수에 바로 저장
                        break;
                }
            }
            while (!s.is_empty())       //스택에 저장된 연산자들 pop
                postfix += s.pop();

            return postfix;         //후위표기식 반환
        }
    }

    public class Stack      //스택 클래스
    {
        string[] stack;
        int top;

        public Stack(int size)      //생성자
        {
            stack = new string[size];
            top = -1;
        }
        public bool is_empty()      //스택이 비어있는지 확인하는 메소드
        {
            if (top == -1) return true;
            else return false;
        }

        public string peek()        //스택의 top값 반환 메소드
        {
            string o = stack[top];
            return o;
        }

        public string pop()     //스택의 top이 빠지며 값을 반환하는 메소드
        {
            string o = stack[top];
            stack[top] = null;
            top--;
            return o;
        }

        public void push(string Stack)      //스택에 값을 넣는 메소드
        {
            top++;
            stack[top] = Stack;
        }
    }
}