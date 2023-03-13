namespace PE_SU22_Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            dataGridView1 = new DataGridView();
            comboBoxTOC = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxDepartment = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            buttonAdd = new Button();
            buttonInsert = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 76);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(147, 25);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(200, 23);
            textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(147, 68);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(200, 23);
            textBoxLastName.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(436, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(664, 322);
            dataGridView1.TabIndex = 4;
            // 
            // comboBoxTOC
            // 
            comboBoxTOC.FormattingEnabled = true;
            comboBoxTOC.Items.AddRange(new object[] { "Dr.", "Mr.", "Mrs.", "Ms." });
            comboBoxTOC.Location = new Point(147, 119);
            comboBoxTOC.Name = "comboBoxTOC";
            comboBoxTOC.Size = new Size(200, 23);
            comboBoxTOC.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 127);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 6;
            label3.Text = "Title Of Coutesy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 189);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 7;
            label4.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(147, 186);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(200, 23);
            comboBoxDepartment.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(147, 245);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(147, 363);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(172, 23);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Add New";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(929, 386);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(171, 23);
            buttonInsert.TabIndex = 11;
            buttonInsert.Text = "Insert into database";
            buttonInsert.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 251);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 12;
            label5.Text = "Birth Date";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 431);
            Controls.Add(label5);
            Controls.Add(buttonInsert);
            Controls.Add(buttonAdd);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBoxDepartment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxTOC);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SU22";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private DataGridView dataGridView1;
        private ComboBox comboBoxTOC;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxDepartment;
        private DateTimePicker dateTimePicker1;
        private Button buttonAdd;
        private Button buttonInsert;
        private Label label5;
    }
}