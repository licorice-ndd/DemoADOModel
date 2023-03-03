using CRUDNet5.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDNet5.Business
{
     class StudentBUS
    {
        private static StudentBUS instance;
        public static StudentBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentBUS();
                }
                return instance;
            }
            //set { instance = value; }
        }
        private StudentBUS() { }
        public void View(DataGridView data)
        {
            data.DataSource = StudentDAO.Instance.View();
        }
        public void SearchByOrderDate(DataGridView data, DateTimePicker datetimepicker)
        {
            data.DataSource = StudentDAO.Instance.SearchByOrderDate(datetimepicker);
        }
        public bool DeleteBySelected(DataGridView dataGridView)
        {
            string id = dataGridView.SelectedCells[0].OwningRow.Cells["id"].Value.ToString();
            return StudentDAO.Instance.DeleteFields(id);
        }
    }
}
