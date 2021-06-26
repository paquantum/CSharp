using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuteCat
{
    public partial class Form1 : Form
    {
        private Cat MyCat = new Cat("Lucas", 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            MyCat.Play();
            CatScreen.Text = MyCat.Express();
        }

        private void Feed_Click(object sender, EventArgs e)
        {
            MyCat.Eat();
            CatScreen.Text = MyCat.Express();
        }

        private void CatTimer_Tick(object sender, EventArgs e)
        {
            // 5000 으로 설정해놔서 5초마다 이 함수가 실행 됨
            MyCat.GetBored();
            CatScreen.Text = MyCat.Express();
        }
    }
}
