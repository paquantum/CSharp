﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer("Ian", "Na", new DateTime(2000, 1, 1));
            cus.Address = "123 Wilshire Blvd";
            CusFullName.Text = cus.FullName;
            //CusLastName.Text = cus.LastName;
            //CusAge.Text = cus.Age.ToString();
            //CusAge.Text = cus.GetAge().ToString();
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();

            bool test = cus.IsQualified; // 속성은 필드처럼 사용
        }
    }
}
