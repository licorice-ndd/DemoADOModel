using PE_PRN211_FA22_Q1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_PRN211_FA22_Q1
{
    public partial class Form1 : Form
    {
        //var db = new PePrnFall22B1Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGernes();
            LoadProducer();
        }
        public void LoadGernes()
        {
            using (var db = new PePrnFall22B1Context())
            {
                listBox1.DataSource = db.Genres.Select(x => x.Title).ToList();
            }
        }
        public void LoadProducer()
        {
            using (var db = new PePrnFall22B1Context())
            {
                comboBoxProducer.DataSource = db.Producers.Select(x => x.Name).ToList();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var db = new PePrnFall22B1Context())
            {
                Movie movie = new Movie();
                movie.Title = textBoxTitle.Text;
                movie.ReleaseDate = DateTime.Parse(dateTimePicker1.Value.ToString());
                movie.Description = textBoxDesciption.Text;
                movie.Language = textBoxLanguage.Text;
                Producer producer = db.Producers.Where(x => x.Name == comboBoxProducer.Text).FirstOrDefault();
                movie.ProducerId = producer.Id;
                db.Add(movie);
                db.SaveChanges();
                MessageBox.Show("add new sucessfully");
            }
        }
    }
}
