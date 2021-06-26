using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
    public class Cat // 접근제한자가 없는경우 default = internal -> 이는 CuteCat 네임스페이스 툴박스에서만 사용 가능
    {
        public string Name;
        public int Age;
        private int Happiness = 50;

        public Cat(string name, int age) // 외부에서 생성자 이용 못하면 의미가 없어 public로
        {
            this.Name = name;
            this.Age = age;
        }

        public void GetBored()
        {
            Happiness -= 10;
            if (Happiness < 0)
                Happiness = 0;
        }

        public void Play()
        {
            Happiness += 10;
            if (Happiness > 100)
                Happiness = 100;
        }

        public void Eat()
        {
            Happiness += 20;
            if (Happiness > 100)
                Happiness = 100;
        }

        public string Express()
        {
            string message = "";
            if (Happiness >= 80)
                message = "I`m very happy";
            else if (Happiness >= 60)
                message = "I`m happy";
            else if (Happiness >= 40)
                message = "I`m so so";
            else if (Happiness >= 20)
                message = "I`m gloomy";
            else
                message = "I`m sad";

            return this.Name + ": " + message;
        }
    }
}
