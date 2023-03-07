namespace Lab2_WinForm
{
    partial class frmCarManagement
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
            buttonClose = new Button();
            dgvCarList = new DataGridView();
            buttonDelete = new Button();
            buttonNew = new Button();
            buttonLoad = new Button();
            textBoxReleaseYear = new TextBox();
            textBoxPrice = new TextBox();
            textBoxManufacturer = new TextBox();
            textBoxCarName = new TextBox();
            textBoxCarID = new TextBox();
            lbReleasedYear = new Label();
            lbPrice = new Label();
            lbManufacturer = new Label();
            lbCarName = new Label();
            lbCarID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(286, 368);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 77;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(547, 90);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.Size = new Size(640, 418);
            dgvCarList.TabIndex = 76;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(286, 327);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 75;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(286, 288);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 23);
            buttonNew.TabIndex = 74;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(286, 247);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 73;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // textBoxReleaseYear
            // 
            textBoxReleaseYear.Location = new Point(325, 194);
            textBoxReleaseYear.Name = "textBoxReleaseYear";
            textBoxReleaseYear.Size = new Size(100, 23);
            textBoxReleaseYear.TabIndex = 72;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(325, 165);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 71;
            // 
            // textBoxManufacturer
            // 
            textBoxManufacturer.Location = new Point(325, 136);
            textBoxManufacturer.Name = "textBoxManufacturer";
            textBoxManufacturer.Size = new Size(100, 23);
            textBoxManufacturer.TabIndex = 70;
            // 
            // textBoxCarName
            // 
            textBoxCarName.Location = new Point(325, 107);
            textBoxCarName.Name = "textBoxCarName";
            textBoxCarName.Size = new Size(100, 23);
            textBoxCarName.TabIndex = 69;
            // 
            // textBoxCarID
            // 
            textBoxCarID.Location = new Point(325, 78);
            textBoxCarID.Name = "textBoxCarID";
            textBoxCarID.Size = new Size(100, 23);
            textBoxCarID.TabIndex = 68;
            // 
            // lbReleasedYear
            // 
            lbReleasedYear.AutoSize = true;
            lbReleasedYear.Location = new Point(241, 202);
            lbReleasedYear.Name = "lbReleasedYear";
            lbReleasedYear.Size = new Size(78, 15);
            lbReleasedYear.TabIndex = 67;
            lbReleasedYear.Text = "Released Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(241, 173);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 66;
            lbPrice.Text = "Price";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(241, 144);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 65;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(241, 115);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 64;
            lbCarName.Text = "Car Name";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(241, 86);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 63;
            lbCarID.Text = "Car ID";
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 586);
            Controls.Add(buttonClose);
            Controls.Add(dgvCarList);
            Controls.Add(buttonDelete);
            Controls.Add(buttonNew);
            Controls.Add(buttonLoad);
            Controls.Add(textBoxReleaseYear);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxManufacturer);
            Controls.Add(textBoxCarName);
            Controls.Add(textBoxCarID);
            Controls.Add(lbReleasedYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private DataGridView dgvCarList;
        private Button buttonDelete;
        private Button buttonNew;
        private Button buttonLoad;
        private TextBox textBoxReleaseYear;
        private TextBox textBoxPrice;
        private TextBox textBoxManufacturer;
        private TextBox textBoxCarName;
        private TextBox textBoxCarID;
        private Label lbReleasedYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbCarID;
    }
}