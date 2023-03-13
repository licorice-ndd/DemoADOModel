namespace PE_PRN211_FA22_Q1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxTitle = new TextBox();
            textBoxLanguage = new TextBox();
            textBoxDesciption = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBoxProducer = new ComboBox();
            listBox1 = new ListBox();
            label6 = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 31);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 69);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "ReleaseDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 110);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Desciption";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 150);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Language";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 187);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Producer";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(131, 29);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(100, 23);
            textBoxTitle.TabIndex = 5;
            // 
            // textBoxLanguage
            // 
            textBoxLanguage.Location = new Point(131, 150);
            textBoxLanguage.Name = "textBoxLanguage";
            textBoxLanguage.Size = new Size(100, 23);
            textBoxLanguage.TabIndex = 6;
            // 
            // textBoxDesciption
            // 
            textBoxDesciption.Location = new Point(131, 107);
            textBoxDesciption.Name = "textBoxDesciption";
            textBoxDesciption.Size = new Size(100, 23);
            textBoxDesciption.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(131, 69);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // comboBoxProducer
            // 
            comboBoxProducer.FormattingEnabled = true;
            comboBoxProducer.Location = new Point(130, 187);
            comboBoxProducer.Name = "comboBoxProducer";
            comboBoxProducer.Size = new Size(121, 23);
            comboBoxProducer.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(529, 99);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(149, 319);
            listBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(529, 69);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "Gernes";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(224, 344);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(comboBoxProducer);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxDesciption);
            Controls.Add(textBoxLanguage);
            Controls.Add(textBoxTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxTitle;
        private TextBox textBoxLanguage;
        private TextBox textBoxDesciption;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxProducer;
        private ListBox listBox1;
        private Label label6;
        private Button buttonSave;
    }
}