using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADOModel.DAL
{
    class DAO
    {
        public static SqlConnection GetConnection()
        {
            string ConnectionStr = "server=DESKTOP-CLB5LQN;database=MyStock;user=sa;password=123456";
            return new SqlConnection(ConnectionStr);
        }
/*        public static DataTable GetDataBySql(string sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(); // lấy về cả 1 khối data sử dụng adapter 
            adapter.SelectCommand = command; 
            DataTable dt = new DataTable(); // fill data vào data table
            adapter.Fill(dt);
            return dt;
        }*/

        public static DataTable GetDataBySql(string sql, params SqlParameter[] parameters) // or SqlParameter[] parameters = null tham số param luôn đứng sau cùng các tham số trong hàm
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null || parameters.Length == 0) command.Parameters.AddRange(parameters); // add range (nhiều item) trước đó sẽ kiểm tra parameter khác null tức có data thì add, vậy nên chỉ cần sử dụng hàm này là đủ k cần đến GetDataBySQL ở trên
            SqlDataAdapter adapter = new SqlDataAdapter(); // lấy về cả 1 khối data sử dụng adapter 
            adapter.SelectCommand = command;
            DataTable dt = new DataTable(); // fill data vào data table
            adapter.Fill(dt);
            return dt;
        }
    }
}
