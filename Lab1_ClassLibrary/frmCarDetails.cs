using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_ClassLibrary
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }

        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; } // false : insert, true update
        public Car CarInfo { get; set; }

        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                // update mode
                //show car to perform updating
            }
        }
    }
}
