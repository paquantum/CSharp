using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Hellolabel1_Click(object sender, EventArgs e)
        {
            HelloLabel1.Text = "Hello C#";
        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;
            // String.IsNullOrWhiteSpace();
            //if (Sum1.Text == "") // 아무 값도 없을 때 에러 방지를 위해
            //{
            //    MessageBox.Show("Sum1에 숫자를 입력해주세요.");
            //    return;
            //}
            // 공백이거나 한개 이상의 공백을 감지해서 알려줌
            if (String.IsNullOrWhiteSpace(Sum1.Text))
            {
                MessageBox.Show("Sum1에 숫자를 입력해주세요.");
                // 잘못 입력된 곳에 커서가 가 있음
                Sum1.Focus();
                return;
            }
            // Sum1.Text에 숫자형 문자가 들어오면 int형 number1에 값을 넣고 true를 반환
            if (int.TryParse(Sum1.Text, out number1) == false)
            {
                MessageBox.Show("Sum1에 문자가 들어왔습니다. 숫자를 입력해주세요.");
                // 잘못 입력한 문자들을 다 선택하고 있음
                Sum1.SelectAll();
                // 잘못 입력된 곳에 커서가 가 있음
                Sum1.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(Sum2.Text))
            {
                MessageBox.Show("Sum2에 숫자를 입력해주세요.");
                return;
            }
            if (int.TryParse(Sum2.Text, out number2) == false)
            {
                MessageBox.Show("Sum1에 문자가 들어왔습니다. 숫자를 입력해주세요.");
                return;
            }

            // text에 string 값을 Convert를 통해 INT 형으로 변환
            //int number1 = Convert.ToInt32(Sum1.Text);
            //int number2 = Convert.ToInt32(Sum2.Text);
            // 숫자 아닌 문자가 들어왔을 때 문제가 생길 수 있어 TryParse를 이용해서 변환

            int sum = Add(number1, number2);
            // Convert를 사용해도 됨
            SumResult.Text = sum.ToString();
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public float Add(float number1, float number2)
        {// 함수 오버로딩으로 이름은 같아도 됨 매개변수가 다름
            float sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }
    }
}
