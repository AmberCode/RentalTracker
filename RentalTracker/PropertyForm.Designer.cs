namespace RentalTracker
{
    partial class PropertyForm
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
            this.SavePropertyButton = new System.Windows.Forms.Button();
            this.PropertyIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PropertyNameTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.Address2TextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.OwnerNameTextBox = new System.Windows.Forms.TextBox();
            this.ZipCodeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // SavePropertyButton
            // 
            this.SavePropertyButton.Location = new System.Drawing.Point(339, 299);
            this.SavePropertyButton.Name = "SavePropertyButton";
            this.SavePropertyButton.Size = new System.Drawing.Size(75, 23);
            this.SavePropertyButton.TabIndex = 0;
            this.SavePropertyButton.Text = "Save";
            this.SavePropertyButton.UseVisualStyleBackColor = true;
            this.SavePropertyButton.Click += new System.EventHandler(this.SavePropertyButton_Click);
            // 
            // PropertyIdTextBox
            // 
            this.PropertyIdTextBox.Location = new System.Drawing.Point(106, 37);
            this.PropertyIdTextBox.Name = "PropertyIdTextBox";
            this.PropertyIdTextBox.ReadOnly = true;
            this.PropertyIdTextBox.Size = new System.Drawing.Size(89, 20);
            this.PropertyIdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Property Name:";
            // 
            // PropertyNameTextBox
            // 
            this.PropertyNameTextBox.Location = new System.Drawing.Point(106, 64);
            this.PropertyNameTextBox.MaxLength = 50;
            this.PropertyNameTextBox.Name = "PropertyNameTextBox";
            this.PropertyNameTextBox.Size = new System.Drawing.Size(308, 20);
            this.PropertyNameTextBox.TabIndex = 4;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(106, 299);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "State:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Zip Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Owner Name:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(106, 93);
            this.AddressTextBox.MaxLength = 255;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(308, 20);
            this.AddressTextBox.TabIndex = 12;
            // 
            // Address2TextBox
            // 
            this.Address2TextBox.Location = new System.Drawing.Point(106, 124);
            this.Address2TextBox.MaxLength = 50;
            this.Address2TextBox.Name = "Address2TextBox";
            this.Address2TextBox.Size = new System.Drawing.Size(308, 20);
            this.Address2TextBox.TabIndex = 13;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(106, 156);
            this.CityTextBox.MaxLength = 50;
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(168, 20);
            this.CityTextBox.TabIndex = 14;
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(106, 185);
            this.StateTextBox.MaxLength = 50;
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(168, 20);
            this.StateTextBox.TabIndex = 15;
            // 
            // OwnerNameTextBox
            // 
            this.OwnerNameTextBox.Location = new System.Drawing.Point(106, 244);
            this.OwnerNameTextBox.MaxLength = 50;
            this.OwnerNameTextBox.Name = "OwnerNameTextBox";
            this.OwnerNameTextBox.Size = new System.Drawing.Size(308, 20);
            this.OwnerNameTextBox.TabIndex = 17;
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Location = new System.Drawing.Point(106, 215);
            this.ZipCodeTextBox.Mask = "00000";
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(89, 20);
            this.ZipCodeTextBox.TabIndex = 18;
            this.ZipCodeTextBox.ValidatingType = typeof(int);
            // 
            // PropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 343);
            this.Controls.Add(this.ZipCodeTextBox);
            this.Controls.Add(this.OwnerNameTextBox);
            this.Controls.Add(this.StateTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.Address2TextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PropertyNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PropertyIdTextBox);
            this.Controls.Add(this.SavePropertyButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PropertyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SavePropertyButton;
        private System.Windows.Forms.TextBox PropertyIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PropertyNameTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox Address2TextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.TextBox OwnerNameTextBox;
        private System.Windows.Forms.MaskedTextBox ZipCodeTextBox;
    }
}