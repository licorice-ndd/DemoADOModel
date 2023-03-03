using CRUDNet5.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDNet5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
/*            string sql = "Select * from Category";
            //            string sql = "Select top 10 * from SubCategory";
            object[] paramete = new object[] {};
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(sql,paramete);*/
            CategoryBUS.Instance.View(dataGridView1);
        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Category(CategoryName) VALUES(N'CategoryName number 1 or 2')" + textBox1.Text;
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "Delete Category where ID like " + textBox1.Text;
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // string sql = "Select * from SubCategory Where ID like " + textBox1.Text; // 1 or ID like 2
            // string sql = "Select * from SubCategory Where ID like @ID"; way 2 step 1
            // command.Parameters.AddWithValue("@ID", textBox1.Text); way 2 step 2 truyen tham so

            string sql = "select * from Orders where OrderDate > @OrderDate";

            object[] paramete = new object[] { dateTimePicker1.Value };
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(sql,paramete);
        }
    }
}
