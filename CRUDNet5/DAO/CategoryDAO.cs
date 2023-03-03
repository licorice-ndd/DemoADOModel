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
    class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                return instance;
            }
            //set { instance = value; }
        }
        private CategoryDAO() { }
        public DataTable View()
        {
            string sql = "Select * from Category";
            //            string sql = "Select top 10 * from SubCategory";
            return DataProvider.Instance.ExcuteQuery(sql);
        }
    }
}
