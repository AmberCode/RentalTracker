namespace RentalTracker
{
    partial class PdfDocPreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfDocPreviewForm));
            this.axAcroPDFViewer = new AxAcroPDFLib.AxAcroPDF();
            this.PrintPdfDocButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDFViewer
            // 
            this.axAcroPDFViewer.Dock = System.Windows.Forms.DockStyle.Left;
            this.axAcroPDFViewer.Enabled = true;
            this.axAcroPDFViewer.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDFViewer.Name = "axAcroPDFViewer";
            this.axAcroPDFViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDFViewer.OcxState")));
            this.axAcroPDFViewer.Size = new System.Drawing.Size(1000, 888);
            this.axAcroPDFViewer.TabIndex = 0;
            // 
            // PrintPdfDocButton
            // 
            this.PrintPdfDocButton.Location = new System.Drawing.Point(1036, 31);
            this.PrintPdfDocButton.Name = "PrintPdfDocButton";
            this.PrintPdfDocButton.Size = new System.Drawing.Size(75, 23);
            this.PrintPdfDocButton.TabIndex = 1;
            this.PrintPdfDocButton.Text = "Print";
            this.PrintPdfDocButton.UseVisualStyleBackColor = true;
            this.PrintPdfDocButton.Click += new System.EventHandler(this.PrintPdfDocButton_Click);
            // 
            // PdfDocPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 888);
            this.Controls.Add(this.PrintPdfDocButton);
            this.Controls.Add(this.axAcroPDFViewer);
            this.Name = "PdfDocPreviewForm";
            this.Text = "PdfDocPreviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDFViewer;
        private System.Windows.Forms.Button PrintPdfDocButton;
    }
}