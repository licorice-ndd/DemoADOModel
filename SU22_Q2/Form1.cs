using Microsoft.EntityFrameworkCore;
using SU22_Q2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU22_Q2
{
    public partial class Form1 : Form
    {
        public List<Employee> Employees = new();

        private readonly PRN_Sum22_B1Context context = new PRN_Sum22_B1Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTOC.SelectedIndex = 0;
            comboBoxDepartment.DataSource = context.Departments.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string fName = textBoxFirstName.Text;
            string lName = textBoxLastName.Text;
            string title = comboBoxTOC.Text;
            Department de = (Department)comboBoxDepartment.SelectedValue;
            DateTime datebirth = dateTimePicker1.Value;

            Employee employee = new()
            {
                TitleOfCourtesy = title,
                FirstName = fName,
                LastName = lName,
                BirthDate = datebirth,
                Departments = de,
            };
            Employees.Add(employee);
            dataGridView1.DataSource = Employees.Select(x => new
            {
                x.FirstName,
                x.LastName,
                DepartmentId = x.Departments.DepartmentId,
                x.TitleOfCourtesy,
                BirthDate = x.BirthDate?.ToString("dd/MM/yyyy"),
            }).ToList();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (Employees.Count > 0)
            {
                context.Employees.AddRange(Employees);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show($"Insert successfully {Employees.Count} employee(s)");
                }
            }
        }
    }
}
