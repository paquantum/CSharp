using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        // @배열을 컬렉션으로 교체
        public List<Customer> Customers = new List<Customer>();
        //public Customer[] CustomerArray = new Customer[10];
        //public int CustomerArrayIndex = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            /* 배열 선언 방법들
             * int[] numberArray = new int[5];
             * numberArray[0] = 1;
             * numberArray[1] = 2;
             * int[] numberArray2 = new int[] {1, 2, 3, 4, 5};
             * int[] numberArray3 = {1, 2, 3, 4, 5};
            */
            // @ 컬렉션 방식으로 교체
            //CustomerArray[CustomerArrayIndex] = new Customer(CusNewFirstName.Text,
            //    CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            //CustomerArray[CustomerArrayIndex].Address = CusNewAddress.Text;
            //CustomerArray[CustomerArrayIndex].Description = CusNewDescription.Text;
            //CustomerList.Items.Add(CustomerArray[CustomerArrayIndex].FirstName);
            //CustomerArrayIndex += 1;
            Customer cus = new Customer(CusNewFirstName.Text, 
                CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            cus.Address = CusNewAddress.Text;
            cus.Description = CusNewDescription.Text;
            CustomerList.Items.Add(cus.FirstName);
            Customers.Add(cus);
        }
        public void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            string firstName = CustomerList.SelectedItem.ToString();

            // foreach로 교체
            foreach (Customer cus in Customers)
            {
                if (cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }
            /*
            for (int index = 0; index < CustomerArrayIndex; index++)
            {
                if (CustomerArray[index].FirstName == firstName)
                {
                    ShowDetails(CustomerArray[index]);
                    break;
                }
            }*/
        }

        public void test()
        {
            // object를 받기 때문에 어떤 데이터 타입도 바을 수 있다
            // 하지만 num 처럼 값을 받아올 때 형 변환이 필요하며
            // 이는 데이터 양이 많아질수록 프로그램에 좋지 않다
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("HI");
            arrayList.Insert(2, 2);
            arrayList.Remove(2);
            arrayList.RemoveAt(1);
            int num = (int)arrayList[0];

            // List의 경우 데이터 타입을 지정해줌으로써 형변환이 생기지 않음
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            int sum2 = 0;
            for (int index = 0; index < intList.Count; index++)
            {
                int value = intList[index];
                sum2 += value;
            }
            // 위 아래 for foreach는 똑같은 역할을 함
            // in 뒤에 컬렉션, 배열이 옴 foreach가 깔끔하고 효율적임
            foreach (int value in intList)
            {
                sum2 += value;
            }
        }
    }
}
