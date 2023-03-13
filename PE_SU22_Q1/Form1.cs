namespace PE_SU22_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numericUpDown1.Value);
            for (int i = 1; i <= num; i++)
            {
                Label label = new()
                {
                    Text = $"Text of button {i}",
                    Size = new Size(90, 15),
                    Location = new Point(13, i * 41),
                };
                TextBox textBox = new()
                {
                    Size = new Size(156, 23),
                    Location = new Point(120, i * 41),
                    Name = $"TextBoxValue{i}",
                };
                Button button = new()
                {
                    Size = new Size(75, 23),
                    Location = new Point(309, i * 41),
                    Text = $"Button {i}",
                    Name = $"{i}",
                };
                button.Click += button_Click; 
                groupBox1.Controls.Add(label);
                groupBox1.Controls.Add(textBox);
                groupBox1.Controls.Add(button);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            string index = ((Button)sender).Name;
            string textBoxValue = ((TextBox)groupBox1.Controls[$"TextBoxValue{index}"]).Text;
            MessageBox.Show(textBoxValue);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}