namespace RentalTracker
{
    partial class Main
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
            this.PropertyTenanInfoTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PreviewAgreementButton = new System.Windows.Forms.Button();
            this.DeleteTenantButton = new System.Windows.Forms.Button();
            this.EditTenantButton = new System.Windows.Forms.Button();
            this.NewTenantButton = new System.Windows.Forms.Button();
            this.TenantGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeletePropertyButton = new System.Windows.Forms.Button();
            this.PropertyGridView = new System.Windows.Forms.DataGridView();
            this.EditPropertyButton = new System.Windows.Forms.Button();
            this.NewPropertyButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DownloadAndPreviewButton = new System.Windows.Forms.Button();
            this.UploadDocumentLoadingPictureBox = new System.Windows.Forms.PictureBox();
            this.UploadDocumentButton = new System.Windows.Forms.Button();
            this.GDLoadFilesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GDGridView = new System.Windows.Forms.DataGridView();
            this.LoadingGDFilesPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SqlServerConnectionButton = new System.Windows.Forms.Button();
            this.PropertyTenanInfoTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TenantGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadDocumentLoadingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGDFilesPictureBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PropertyTenanInfoTab
            // 
            this.PropertyTenanInfoTab.Controls.Add(this.tabPage1);
            this.PropertyTenanInfoTab.Controls.Add(this.tabPage2);
            this.PropertyTenanInfoTab.Controls.Add(this.tabPage3);
            this.PropertyTenanInfoTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyTenanInfoTab.Location = new System.Drawing.Point(0, 0);
            this.PropertyTenanInfoTab.Name = "PropertyTenanInfoTab";
            this.PropertyTenanInfoTab.SelectedIndex = 0;
            this.PropertyTenanInfoTab.Size = new System.Drawing.Size(1098, 624);
            this.PropertyTenanInfoTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1090, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Property/Tenant info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PreviewAgreementButton);
            this.groupBox2.Controls.Add(this.DeleteTenantButton);
            this.groupBox2.Controls.Add(this.EditTenantButton);
            this.groupBox2.Controls.Add(this.NewTenantButton);
            this.groupBox2.Controls.Add(this.TenantGridView);
            this.groupBox2.Location = new System.Drawing.Point(20, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1046, 259);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tenants:";
            // 
            // PreviewAgreementButton
            // 
            this.PreviewAgreementButton.Location = new System.Drawing.Point(890, 200);
            this.PreviewAgreementButton.Name = "PreviewAgreementButton";
            this.PreviewAgreementButton.Size = new System.Drawing.Size(126, 23);
            this.PreviewAgreementButton.TabIndex = 8;
            this.PreviewAgreementButton.Text = "Preview Agreement";
            this.PreviewAgreementButton.UseVisualStyleBackColor = true;
            this.PreviewAgreementButton.Click += new System.EventHandler(this.PreviewAgreementButton_Click);
            // 
            // DeleteTenantButton
            // 
            this.DeleteTenantButton.Location = new System.Drawing.Point(890, 121);
            this.DeleteTenantButton.Name = "DeleteTenantButton";
            this.DeleteTenantButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteTenantButton.TabIndex = 7;
            this.DeleteTenantButton.Text = "Delete";
            this.DeleteTenantButton.UseVisualStyleBackColor = true;
            this.DeleteTenantButton.Click += new System.EventHandler(this.DeleteTenantButton_Click);
            // 
            // EditTenantButton
            // 
            this.EditTenantButton.Location = new System.Drawing.Point(890, 76);
            this.EditTenantButton.Name = "EditTenantButton";
            this.EditTenantButton.Size = new System.Drawing.Size(75, 23);
            this.EditTenantButton.TabIndex = 6;
            this.EditTenantButton.Text = "Edit";
            this.EditTenantButton.UseVisualStyleBackColor = true;
            this.EditTenantButton.Click += new System.EventHandler(this.EditTenantButton_Click);
            // 
            // NewTenantButton
            // 
            this.NewTenantButton.Location = new System.Drawing.Point(890, 32);
            this.NewTenantButton.Name = "NewTenantButton";
            this.NewTenantButton.Size = new System.Drawing.Size(75, 23);
            this.NewTenantButton.TabIndex = 5;
            this.NewTenantButton.Text = "New";
            this.NewTenantButton.UseVisualStyleBackColor = true;
            this.NewTenantButton.Click += new System.EventHandler(this.NewTenantButton_Click);
            // 
            // TenantGridView
            // 
            this.TenantGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TenantGridView.Location = new System.Drawing.Point(16, 32);
            this.TenantGridView.MultiSelect = false;
            this.TenantGridView.Name = "TenantGridView";
            this.TenantGridView.ReadOnly = true;
            this.TenantGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TenantGridView.Size = new System.Drawing.Size(845, 191);
            this.TenantGridView.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeletePropertyButton);
            this.groupBox1.Controls.Add(this.PropertyGridView);
            this.groupBox1.Controls.Add(this.EditPropertyButton);
            this.groupBox1.Controls.Add(this.NewPropertyButton);
            this.groupBox1.Location = new System.Drawing.Point(20, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties:";
            // 
            // DeletePropertyButton
            // 
            this.DeletePropertyButton.Location = new System.Drawing.Point(890, 172);
            this.DeletePropertyButton.Name = "DeletePropertyButton";
            this.DeletePropertyButton.Size = new System.Drawing.Size(75, 23);
            this.DeletePropertyButton.TabIndex = 4;
            this.DeletePropertyButton.Text = "Delete";
            this.DeletePropertyButton.UseVisualStyleBackColor = true;
            this.DeletePropertyButton.Click += new System.EventHandler(this.DeletePropertyButton_Click);
            // 
            // PropertyGridView
            // 
            this.PropertyGridView.AllowUserToAddRows = false;
            this.PropertyGridView.AllowUserToDeleteRows = false;
            this.PropertyGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PropertyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertyGridView.Location = new System.Drawing.Point(6, 30);
            this.PropertyGridView.MultiSelect = false;
            this.PropertyGridView.Name = "PropertyGridView";
            this.PropertyGridView.ReadOnly = true;
            this.PropertyGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PropertyGridView.Size = new System.Drawing.Size(855, 165);
            this.PropertyGridView.TabIndex = 0;
            // 
            // EditPropertyButton
            // 
            this.EditPropertyButton.Location = new System.Drawing.Point(890, 70);
            this.EditPropertyButton.Name = "EditPropertyButton";
            this.EditPropertyButton.Size = new System.Drawing.Size(75, 23);
            this.EditPropertyButton.TabIndex = 2;
            this.EditPropertyButton.Text = "Edit";
            this.EditPropertyButton.UseVisualStyleBackColor = true;
            this.EditPropertyButton.Click += new System.EventHandler(this.EditPropertyButton_Click);
            // 
            // NewPropertyButton
            // 
            this.NewPropertyButton.Location = new System.Drawing.Point(890, 30);
            this.NewPropertyButton.Name = "NewPropertyButton";
            this.NewPropertyButton.Size = new System.Drawing.Size(75, 23);
            this.NewPropertyButton.TabIndex = 3;
            this.NewPropertyButton.Text = "New";
            this.NewPropertyButton.UseVisualStyleBackColor = true;
            this.NewPropertyButton.Click += new System.EventHandler(this.NewPropertyButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DownloadAndPreviewButton);
            this.tabPage2.Controls.Add(this.UploadDocumentLoadingPictureBox);
            this.tabPage2.Controls.Add(this.UploadDocumentButton);
            this.tabPage2.Controls.Add(this.GDLoadFilesButton);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.GDGridView);
            this.tabPage2.Controls.Add(this.LoadingGDFilesPictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1090, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Google Drive";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DownloadAndPreviewButton
            // 
            this.DownloadAndPreviewButton.Location = new System.Drawing.Point(611, 165);
            this.DownloadAndPreviewButton.Name = "DownloadAndPreviewButton";
            this.DownloadAndPreviewButton.Size = new System.Drawing.Size(140, 23);
            this.DownloadAndPreviewButton.TabIndex = 6;
            this.DownloadAndPreviewButton.Text = "Download and Preview";
            this.DownloadAndPreviewButton.UseVisualStyleBackColor = true;
            this.DownloadAndPreviewButton.Click += new System.EventHandler(this.DownloadAndPreviewButton_Click);
            // 
            // UploadDocumentLoadingPictureBox
            // 
            this.UploadDocumentLoadingPictureBox.Image = global::RentalTracker.Properties.Resources.ajax_loader;
            this.UploadDocumentLoadingPictureBox.Location = new System.Drawing.Point(788, 135);
            this.UploadDocumentLoadingPictureBox.Name = "UploadDocumentLoadingPictureBox";
            this.UploadDocumentLoadingPictureBox.Size = new System.Drawing.Size(24, 22);
            this.UploadDocumentLoadingPictureBox.TabIndex = 5;
            this.UploadDocumentLoadingPictureBox.TabStop = false;
            this.UploadDocumentLoadingPictureBox.Visible = false;
            // 
            // UploadDocumentButton
            // 
            this.UploadDocumentButton.Location = new System.Drawing.Point(611, 113);
            this.UploadDocumentButton.Name = "UploadDocumentButton";
            this.UploadDocumentButton.Size = new System.Drawing.Size(121, 23);
            this.UploadDocumentButton.TabIndex = 4;
            this.UploadDocumentButton.Text = "Upload Document";
            this.UploadDocumentButton.UseVisualStyleBackColor = true;
            this.UploadDocumentButton.Click += new System.EventHandler(this.UploadDocumentButton_Click);
            // 
            // GDLoadFilesButton
            // 
            this.GDLoadFilesButton.Location = new System.Drawing.Point(36, 48);
            this.GDLoadFilesButton.Name = "GDLoadFilesButton";
            this.GDLoadFilesButton.Size = new System.Drawing.Size(174, 23);
            this.GDLoadFilesButton.TabIndex = 2;
            this.GDLoadFilesButton.Text = "Get Documents";
            this.GDLoadFilesButton.UseVisualStyleBackColor = true;
            this.GDLoadFilesButton.Click += new System.EventHandler(this.GDLoadFilesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documents:";
            // 
            // GDGridView
            // 
            this.GDGridView.AllowUserToAddRows = false;
            this.GDGridView.AllowUserToDeleteRows = false;
            this.GDGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GDGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDGridView.Location = new System.Drawing.Point(36, 113);
            this.GDGridView.MultiSelect = false;
            this.GDGridView.Name = "GDGridView";
            this.GDGridView.ReadOnly = true;
            this.GDGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GDGridView.Size = new System.Drawing.Size(495, 440);
            this.GDGridView.TabIndex = 0;
            // 
            // LoadingGDFilesPictureBox
            // 
            this.LoadingGDFilesPictureBox.Image = global::RentalTracker.Properties.Resources.ajax_loader;
            this.LoadingGDFilesPictureBox.Location = new System.Drawing.Point(225, 48);
            this.LoadingGDFilesPictureBox.Name = "LoadingGDFilesPictureBox";
            this.LoadingGDFilesPictureBox.Size = new System.Drawing.Size(27, 23);
            this.LoadingGDFilesPictureBox.TabIndex = 3;
            this.LoadingGDFilesPictureBox.TabStop = false;
            this.LoadingGDFilesPictureBox.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SqlServerConnectionButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1090, 598);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SqlServerConnectionButton
            // 
            this.SqlServerConnectionButton.Location = new System.Drawing.Point(38, 23);
            this.SqlServerConnectionButton.Name = "SqlServerConnectionButton";
            this.SqlServerConnectionButton.Size = new System.Drawing.Size(75, 23);
            this.SqlServerConnectionButton.TabIndex = 0;
            this.SqlServerConnectionButton.Text = "Connection";
            this.SqlServerConnectionButton.UseVisualStyleBackColor = true;
            this.SqlServerConnectionButton.Click += new System.EventHandler(this.SqlServerConnectionButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 624);
            this.Controls.Add(this.PropertyTenanInfoTab);
            this.Name = "Main";
            this.Text = "RentalTracker";
            this.PropertyTenanInfoTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TenantGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PropertyGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadDocumentLoadingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGDFilesPictureBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PropertyTenanInfoTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView PropertyGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button NewPropertyButton;
        private System.Windows.Forms.Button EditPropertyButton;
        private System.Windows.Forms.DataGridView TenantGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EditTenantButton;
        private System.Windows.Forms.Button NewTenantButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GDGridView;
        private System.Windows.Forms.Button GDLoadFilesButton;
        private System.Windows.Forms.PictureBox LoadingGDFilesPictureBox;
        private System.Windows.Forms.Button DeletePropertyButton;
        private System.Windows.Forms.Button DeleteTenantButton;
        private System.Windows.Forms.Button UploadDocumentButton;
        private System.Windows.Forms.PictureBox UploadDocumentLoadingPictureBox;
        private System.Windows.Forms.Button PreviewAgreementButton;
        private System.Windows.Forms.Button DownloadAndPreviewButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button SqlServerConnectionButton;
    }
}

