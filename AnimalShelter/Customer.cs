using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        /*
         * Age에 따라 입양 가능여부를 따져야 하는데 public일 경우
         * 나이를 10살 넣고 IsQulified도 true로 주면 원치 않는 객체가 생성됨
         * 따라서 클래스는 완벽에 가깝게 해야하기 때문에 private으로 바꿔 줌
         */
        //public int Age;
        //public bool IsQualified;
        //private int _Age; // private 경우 _ 추가해주는 개인적 습관
        // int _Age는 시간이 지나도 그대로이기 때문에 DateTime 사용
        private DateTime _Birthday;
        private bool _IsQualified;
        public string Address;
        public string Description;

        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

            //this._IsQualified = age >= 18;
            //this._IsQualified = DateTime.Now.Year - birthday.Year >= 18;
            this._IsQualified = Age >= 18; // 중복사용을 Age 속성으로 대체
        }

        public DateTime Birthday
        {
            get
            {
                return _Birthday;
            }
            set
            {
                _Birthday = value;
                //_IsQualified = DateTime.Now.Year - value.Year >= 18;
                _IsQualified = Age >= 18;
            }
        }
        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
        }
        //public int GetAge()
        //{
        //    return _Age;
        //}
        //public void SetAge(int age)
        //{
        //    _Age = age;
        //    _IsQualified = age >= 18;
        //}

        /* 
         * Age 라는 속성으느 필드처럼 생기긴 했음 사용에 제약이 있음
         * Get으로 매개변수를 받을 수 없음
         * set은 value라는 키워드로 속성 데이터타입과 같은 값이 넘어옴
         */
        //public int Age // Age라는 속성을 정의
        //{
        //    get { return _Age; }
        //    set { // set접근자에는 매개변수 하나가 들어옴
        //        // 그 속성의 데이터타입과(int) 같다 이름은 : value
        //        _Age = value; // value 키워드와 같음
        //        _IsQualified = value >= 18;
        //    }
        //}

        //public bool GetIsQualified()
        //{
        //    return _IsQualified;
        //}
        public bool IsQualified
        {
            get
            {
                return _IsQualified;
            }
            // set을 해도 되지만 안써서 읽기 전용 됨
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        //public string GetFullName() // 이것도 속성으로
        //{
        //    return FirstName + " " + LastName;
        //}
    }
}
