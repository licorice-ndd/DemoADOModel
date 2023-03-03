using CRUDNet5.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDNet5.Business
{
     class CategoryBUS
    {
        private static CategoryBUS instance;
        public static CategoryBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryBUS();
                }
                return instance;
            }
            //set { instance = value; }
        }
        private CategoryBUS() { }
        public void View(DataGridView data)
        {
            data.DataSource = CategoryDAO.Instance.View();
        }
    }
}
