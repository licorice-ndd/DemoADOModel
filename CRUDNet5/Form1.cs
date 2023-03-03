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

        string connectionString = @"Data Source=DESKTOP-CLB5LQN;Initial Catalog=PE_Demo_S2019;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string sql = "Select * from Category";
            //            string sql = "Select top 10 * from SubCategory";
            dataGridView1.DataSource = ExcuteQuery(sql);
        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Category(CategoryName) VALUES(N'CategoryName number 1 or 2')" + textBox1.Text;
            dataGridView1.DataSource = ExcuteQuery(sql);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "Delete Category where ID like " + textBox1.Text;
            dataGridView1.DataSource = ExcuteQuery(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

/*            string sql = "Select * from SubCategory Where ID like " + textBox1.Text; // 1 or ID like 2
            // string sql = "Select * from SubCategory Where ID like @ID"; way 2 step 1
            SqlCommand command = new SqlCommand(sql, connection);
            // command.Parameters.AddWithValue("@ID", textBox1.Text); way 2 step 2 truyen tham so
*/

            string querydatetime = "select * from Orders where OrderDate > @OrderDate";
            SqlCommand command = new SqlCommand(querydatetime, connection);
            command.Parameters.AddWithValue("@OrderDate",dateTimePicker1.Value);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        DataTable ExcuteQuery(string query)
        {
            // sqlcommand -> insert,delete,...
            //sqladapter -> select
            // datatable -> 1 table
            // dataset -> many table like 1 complete database
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection); 
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}
