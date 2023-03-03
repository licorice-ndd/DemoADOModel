using CRUDNet5.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDNet5.DAO
{
    class StudentDAO
    {
        private static StudentDAO instance;
        public static StudentDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentDAO();
                }
                return instance;
            }
            //set { instance = value; }
        }
        private StudentDAO() { }
        public DataTable View()
        {
            object[] parameter = new object[] {};
            string sql = "Select id as N'Student ID', name as N'Student Name', address as N'Student Address', gender as N'Male or Female', dateofbirth as N'DOB', country as N'Location', role as N'Position' from Student";
            //            string sql = "Select top 10 * from SubCategory";
            return DataProvider.Instance.ExcuteQuery(sql,parameter);
        }
        public DataTable SearchByOrderDate(DateTimePicker datetimepicker)
        {
            object[] parameter = new object[] { datetimepicker.Value };
            string sql = "select * from Student where dateofbirth > @dateofbirth";
            return DataProvider.Instance.ExcuteQuery(sql, parameter);
        }
        public bool DeleteFields(string id)
        {
            string sql = "Delete Student where id = @id";
            object[] parameter = new object[] { id};
            if (DataProvider.Instance.ExcuteNonQuery(sql,parameter)>0)
            {
                return true;
            }
            return false;
        }
        public bool FixDataByFields(string id)
        {

        }
/*        INSERT INTO[dbo].[Student]
        ([id]
      ,[name]
      ,[address]
      ,[gender]
      ,[dateofbirth]
      ,[country]
      ,[role])
VALUES(6, N'Mr F', N'105 PVD', N'Gay','2009-09-09', N'China', N'Goalkepper');*/
    }
}
