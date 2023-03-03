namespace CRUDNet5
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnView = new System.Windows.Forms.Button();
            btbAdd = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(-9, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(908, 456);
            dataGridView1.TabIndex = 0;
            // 
            // btnView
            // 
            btnView.Location = new System.Drawing.Point(920, 166);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(75, 23);
            btnView.TabIndex = 1;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btbAdd
            // 
            btbAdd.Location = new System.Drawing.Point(1036, 166);
            btbAdd.Name = "btbAdd";
            btbAdd.Size = new System.Drawing.Size(75, 23);
            btbAdd.TabIndex = 2;
            btbAdd.Text = "Add";
            btbAdd.UseVisualStyleBackColor = true;
            btbAdd.Click += btbAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(1036, 222);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(75, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(920, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(191, 23);
            textBox1.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(977, 83);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(920, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1153, 493);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(btnEdit);
            Controls.Add(btbAdd);
            Controls.Add(btnView);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btbAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
    }
}
