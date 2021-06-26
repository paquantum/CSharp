using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin_v2
{
    public enum Operators { Add, Sub, Multi, Div }

    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;

        public Calculator()
        {
            InitializeComponent();
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

        private void NumButton1_Click(object sender, EventArgs e)
        {
            //if (NumScreen.Text == "0") // 처음 0이 써져있어서 0111.. 을 방지하기 위해
            //    NumScreen.Text = "1";
            //else
            //    NumScreen.Text += "1";
            // 같은 코드가 1 ~ 9까지 반복 돼서 SetNum 함수를 만들어서 바꿈
            //SetNum("1");
            // 0 ~ 9까지 핸들러를 추가하면 너무 많음 하나의 핸들러를 공유하게 하는 방식으로
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        //private void NumButton2_Click(object sender, EventArgs e)
        //{
        //    SetNum("2");
        //}

        public void SetNum(string num)
        {
            //if (NumScreen.Text == "0")
            //    NumScreen.Text = num;
            //else
            //    NumScreen.Text += num;
            // 전역변수를 두고 새로운 숫자인 경우 아닌 경우
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {

                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                int num = int.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                    Result += num;
                else if (Opt == Operators.Sub)
                    Result -= num;


                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }
    }
}
