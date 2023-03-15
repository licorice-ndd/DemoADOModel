using DemoADOModel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADOModel.DAL
{
     class StudentDAO
    {
        public static List<Student> GetAllStudent()
        {
            string sql = "select * from Student";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Student> students = new List<Student>();
            foreach (DataRow dr in dt.Rows)
                students.Add(new Student(
                    Convert.ToInt32(dr["StudentId"]),
                    dr["RollNumber"].ToString(),
                    dr["FirstName"].ToString(),
                    dr["LastName"].ToString(),
                    dr["MidName"].ToString()
                    ));
                return students;
        }

        public static Student GetStudentById(int StudentId)
        {
            string sql = "select * from Students where StudentID = @sid";
            /*
                        SqlParameter[] parameters = new SqlParameter[1];
                        parameters[0] = new SqlParameter("@sid", DbType.Int32);
                        parameters[0].Value = StudentId;
            DataTable dt = DAO.GetDataBySql(sql, parameter); */

            SqlParameter parameter1 = new SqlParameter("@sid", DbType.Int32);
            parameter1.Value = StudentId;
            SqlParameter parameter2 = null;
            DataTable dt = DAO.GetDataBySql(sql, parameter1,parameter2);
            if (dt.Rows.Count == 0) return null;
            DataRow dr = dt.Rows[0];

            return new Student(
                    Convert.ToInt32(dr["StudentId"]),
                    dr["RollNumber"].ToString(),
                    dr["FirstName"].ToString(),
                    dr["LastName"].ToString(),
                    dr["MidName"].ToString()
                    );
        }
        string sql = "insert from student value(name = @name, ... where id = @id)";
    }
}
