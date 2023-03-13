namespace SU22_Q2
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
            label5 = new System.Windows.Forms.Label();
            buttonInsert = new System.Windows.Forms.Button();
            buttonAdd = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            comboBoxDepartment = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            comboBoxTOC = new System.Windows.Forms.ComboBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            textBoxLastName = new System.Windows.Forms.TextBox();
            textBoxFirstName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(114, 259);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 15);
            label5.TabIndex = 38;
            label5.Text = "Birth Date";
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new System.Drawing.Point(1003, 394);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new System.Drawing.Size(171, 23);
            buttonInsert.TabIndex = 37;
            buttonInsert.Text = "Insert into database";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(221, 371);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(172, 23);
            buttonAdd.TabIndex = 36;
            buttonAdd.Text = "Add New";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(221, 253);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            dateTimePicker1.TabIndex = 35;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new System.Drawing.Point(221, 194);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new System.Drawing.Size(200, 23);
            comboBoxDepartment.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(115, 197);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 15);
            label4.TabIndex = 33;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(114, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 15);
            label3.TabIndex = 32;
            label3.Text = "Title Of Coutesy";
            // 
            // comboBoxTOC
            // 
            comboBoxTOC.FormattingEnabled = true;
            comboBoxTOC.Items.AddRange(new object[] { "Dr.", "Mr.", "Mrs.", "Ms." });
            comboBoxTOC.Location = new System.Drawing.Point(221, 127);
            comboBoxTOC.Name = "comboBoxTOC";
            comboBoxTOC.Size = new System.Drawing.Size(200, 23);
            comboBoxTOC.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(510, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(664, 322);
            dataGridView1.TabIndex = 30;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new System.Drawing.Point(221, 76);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new System.Drawing.Size(200, 23);
            textBoxLastName.TabIndex = 29;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new System.Drawing.Point(221, 33);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new System.Drawing.Size(200, 23);
            textBoxFirstName.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(115, 84);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 27;
            label2.Text = "LastName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(114, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 15);
            label1.TabIndex = 26;
            label1.Text = "FirstName";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1288, 450);
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
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTOC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
