namespace Lab1_ClassLibrary
{
    partial class frmCarDetails
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
            lbCarID = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbManufacturer = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            lbReleasedYear = new System.Windows.Forms.Label();
            txtCarID = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.MaskedTextBox();
            txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            cboManufacturer = new System.Windows.Forms.ComboBox();
            buttonCancel = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(55, 38);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(39, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(61, 73);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(60, 15);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(64, 112);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(79, 15);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(68, 153);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(33, 15);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleasedYear
            // 
            lbReleasedYear.AutoSize = true;
            lbReleasedYear.Location = new System.Drawing.Point(67, 183);
            lbReleasedYear.Name = "lbReleasedYear";
            lbReleasedYear.Size = new System.Drawing.Size(78, 15);
            lbReleasedYear.TabIndex = 4;
            lbReleasedYear.Text = "Released Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(133, 38);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(100, 23);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(148, 77);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(100, 23);
            txtCarName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(159, 156);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(100, 23);
            txtPrice.TabIndex = 7;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(156, 183);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(100, 23);
            txtReleaseYear.TabIndex = 8;
            txtReleaseYear.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new System.Drawing.Point(163, 112);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new System.Drawing.Size(121, 23);
            cboManufacturer.TabIndex = 9;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(474, 96);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(468, 49);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(75, 23);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(cboManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleasedYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleasedYear;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtReleaseYear;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}