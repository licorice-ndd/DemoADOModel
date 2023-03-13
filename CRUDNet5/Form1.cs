using CRUDNet5.Business;
using CRUDNet5.DAO;
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
            StudentBUS.Instance.View(dataGridView1);
        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Category(CategoryName) VALUES(N'CategoryName number 1 or 2')" + textBox1.Text;
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = StudentDAO.Instance.View();
            comboBox1.DisplayMember = "id";

            if (StudentBUS.Instance.Edit(dataGridView1))
            {
                MessageBox.Show("success");
                btnView_Click(sender, e);
            }
            else MessageBox.Show("not success");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DataProvider.Instance.ExcuteNonQuery("Delete Student where ID like " + textBox1.Text).ToString());
            if (StudentBUS.Instance.DeleteBySelected(dataGridView1))
            {
                MessageBox.Show("success");
                btnView_Click(sender, e);
            }
            else MessageBox.Show("not success");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string sql = "Select * from SubCategory Where ID like " + textBox1.Text; // 1 or ID like 2
            //string sql = "Select * from SubCategory Where ID like @ID"; //way 2 step 1
            //command.Parameters.AddWithValue("@ID", textBox1.Text); //way 2 step 2 truyen tham so

            StudentBUS.Instance.SearchByOrderDate(dataGridView1, dateTimePicker1);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // select e.name, d.name from employee e, department d where e.department = d.id
    }
}
