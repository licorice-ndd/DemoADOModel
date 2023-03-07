using Lab2_ClassLibrary.BusinessObjet;
using Lab2_ClassLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_WinForm
{
    public partial class frmCarManagement : Form
    {
        ICarRepository carRepository = new CarRepository();
        // create a data source
        BindingSource source;
        public frmCarManagement()
        {
            InitializeComponent();
        }

        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            buttonDelete.Enabled = false;
            dgvCarList.CellDoubleClick += DgvCarList_CellDoubleClick;
        }
        private void DgvCarList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            Form1 frmCarDetails = new Form1
            {
                Text = "Update car",
                InsertOrUpdate = true,
                CarInfo = GetCarObject(),
                CarRepository = carRepository
            };
            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                //set focus car updated
                source.Position = source.Count - 1;
            }
        }
        private void ClearText()
        {
            textBoxCarID.Text = string.Empty;
            textBoxCarName.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxReleaseYear.Text = string.Empty;
            textBoxManufacturer.Text = string.Empty;
        }

        private Car GetCarObject()
        {
            Car car = null;
            try
            {
                car = new Car
                {
                    CarID = int.Parse(textBoxCarID.Text),
                    CarName = textBoxCarName.Text,
                    Manufacturer = textBoxManufacturer.Text,
                    Price = decimal.Parse(textBoxPrice.Text),
                    ReleaseYear = int.Parse(textBoxReleaseYear.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get some car");
            }
            return car;
        }
        public void LoadCarList()
        {
            var cars = carRepository.GetCars();
            try
            {
                //The BindingSource component is designed to simplify
                //the process of binding controls to an underlying data source 
                source = new BindingSource();
                source.DataSource = cars;

                textBoxCarID.DataBindings.Clear();
                textBoxCarName.DataBindings.Clear();
                textBoxManufacturer.DataBindings.Clear();
                textBoxPrice.DataBindings.Clear();
                textBoxReleaseYear.DataBindings.Clear();

                textBoxCarID.DataBindings.Add("Text", source, "CarID");
                textBoxCarName.DataBindings.Add("Text", source, "CarName");
                textBoxManufacturer.DataBindings.Add("Text", source, "Manufacturer");
                textBoxPrice.DataBindings.Add("Text", source, "Price");
                textBoxReleaseYear.DataBindings.Add("Text", source, "ReleaseYear");

                dgvCarList.DataSource = null;
                dgvCarList.DataSource = source;

                if (cars.Count() == 0)
                {
                    ClearText();
                    buttonDelete.Enabled = false;
                }
                else
                {
                    buttonDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car list");
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadCarList();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Form1 frmCarDetails = new Form1
            {
                Text = "Add a car",
                InsertOrUpdate = false,
                CarRepository = carRepository
            };
            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                //set focus car inserted
                source.Position = source.Count - 1;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var car = GetCarObject();
                carRepository.DeleteCar(car.CarID);
                LoadCarList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a car");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
