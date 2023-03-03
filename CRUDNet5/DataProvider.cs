using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDNet5
{
   public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get 
            { 
                if(instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            //set { instance = value; }
        }
        private DataProvider() { }

        string connectionString = @"Data Source=DESKTOP-CLB5LQN;Initial Catalog=PE_Demo_S2019;Integrated Security=True";
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            // sqlcommand -> insert,delete,...
            //sqladapter -> select
            // datatable -> 1 table
            // dataset -> many table like 1 complete database

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString)) // tự hủy data, bộ nhớ khi dùng using
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                string[] temp = query.Split(' ');
                List<string> listParameter = new List<string>();
                foreach (string item in temp)
                {
                    if (item[0] == '@') listParameter.Add(item);
                }
                for (int i = 0; i < parameter.Length; i++)
                {
                    command.Parameters.AddWithValue(listParameter[i], parameter[i]);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
    }
}
