using CRUDNet5.DAO;
using CRUDNet5.Entity;
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
        public bool Edit(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells.OwningRow;

            int newId = Convert.ToInt32(row.Cells["id"].Value);

            string OldID = row.Cells["Student ID"].Value.ToString();
            string Id = row.Cells["Student ID"].Value.ToString();

            string Name = row.Cells["Student Name"].Value.ToString();
            string Address = row.Cells["Student Address"].Value.ToString();
            string Gender = row.Cells["Male or Female"].Value.ToString();
            DateTime Dateofbirth = (DateTime)row.Cells["DOB"].Value;
            string Country = row.Cells["Location"].Value.ToString();
            string Role = row.Cells["Position"].Value.ToString();

            StudentDTO sdto = new StudentDTO() { Id = Id, Name = Name,Address = Address,Gender = Gender,Dateofbirth = Dateofbirth, Country = Country, Role = Role };
            return StudentDAO.Instance.FixDataByFields(OldID, sdto);
        }
    }
}
