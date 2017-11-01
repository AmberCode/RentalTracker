using Common.Model;
using RentalTracker.Services.Property;
using RentalTracker.Services.Tenant;
using System;
using System.Windows.Forms;
using RentalTracker.Services.GoogleDrive;
using RentalTracker.Services.Pdf;
using System.IO;
using Microsoft.Data.ConnectionUI;

namespace RentalTracker
{
    public partial class Main : Form
    {
        //TODO: Dependency injection (e.g. unity)
        private readonly IPropertyService _propertyService;
        private readonly ITenantService _tenantService;
        private readonly IGoogleDriveService _googleDriveService;
        private ErrorProvider _nameErrorProvider;
        public Main()
        {
            InitializeComponent();
            Load += Main_Load;

            _propertyService = new PropertyService();
            _tenantService = new TenantService();
            _googleDriveService = new GoogleDriveService();
            _nameErrorProvider = new ErrorProvider();
        }

        private void PropertyGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var property = (PropertyModel)PropertyGridView.CurrentRow.DataBoundItem;

                var tenants = _tenantService.GetByPropertyId(property.Id);

                TenantGridView.DataSource = tenants;
            }
            catch (Exception)
            {
                //log ex
                MessageBox.Show("System error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var propertyList = _propertyService.GetAll();

            PropertyGridView.DataSource = propertyList;
            
            PropertyGridView.ClearSelection();
            PropertyGridView.SelectionChanged += PropertyGridView_SelectionChanged;

            LoadingGDFilesPictureBox.Visible = false;
            UploadDocumentLoadingPictureBox.Visible = false;
        }

        private void NewPropertyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var propertyForm = new PropertyForm(null);
                if (propertyForm.ShowDialog(this) == DialogResult.OK)
                {
                    PropertyGridView.DataSource = _propertyService.GetAll();
                }
            }
            catch (Exception)
            {
                //log ex
                MessageBox.Show("System error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void EditPropertyButton_Click(object sender, EventArgs e)
        {
            if (PropertyGridView.CurrentRow == null)
            {
                return;
            }

            var property = (PropertyModel)PropertyGridView.CurrentRow.DataBoundItem;

            var propertyForm = new PropertyForm(property);

            if (propertyForm.ShowDialog(this) == DialogResult.OK)
            {
                PropertyGridView.DataSource = _propertyService.GetAll();
            }
        }

        private async void GDLoadFilesButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadingGDFilesPictureBox.Visible = true;

                var gdFiles = await _googleDriveService.GetAll();

                GDGridView.DataSource = gdFiles;

               
            }
            catch (Exception ex)
            {
                //log ex
                MessageBox.Show("System error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadingGDFilesPictureBox.Visible = false;
            }
        }

        private void NewTenantButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PropertyGridView.CurrentRow == null) return;

                var property = (PropertyModel)PropertyGridView.CurrentRow.DataBoundItem;

                var tenantForm = new TenantForm(null, property.Id);

                if (tenantForm.ShowDialog(this) == DialogResult.OK)
                {                   
                    TenantGridView.DataSource = _tenantService.GetByPropertyId(property.Id);
                }
            }
            catch (Exception ex)
            {
                //log ex
                MessageBox.Show("System error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditTenantButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PropertyGridView.CurrentRow == null || TenantGridView.CurrentRow == null)
                {
                    return;
                }

                var property = (PropertyModel)PropertyGridView.CurrentRow.DataBoundItem;
                var tenant = (TenantModel)TenantGridView.CurrentRow.DataBoundItem;

                var tenantForm = new TenantForm(tenant, property.Id);

                if (tenantForm.ShowDialog(this) == DialogResult.OK)
                {
                    TenantGridView.DataSource = _tenantService.GetByPropertyId(property.Id);
                }
            }
            catch (Exception)
            {
                //log ex
                MessageBox.Show("System error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeletePropertyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(PropertyGridView.CurrentRow == null) return;

                var property = (PropertyModel)PropertyGridView.CurrentRow.DataBoundItem;

                _propertyService.Delete(property.Id);

                PropertyGridView.DataSource = _propertyService.GetAll();
            }
            catch (Exception)
            {
                //log ex
                MessageBox.Show("System error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTenantButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TenantGridView.CurrentRow == null || PropertyGridView.CurrentRow == null) return;

                var tenant = (TenantModel)TenantGridView.CurrentRow.DataBoundItem;

                _tenantService.Delete(tenant.Id);

                var property = (PropertyModel)PropertyGridView.CurrentRow.DataBoundItem;

                TenantGridView.DataSource = _tenantService.GetByPropertyId(property.Id);
            }
            catch (Exception)
            {
                //log ex
                MessageBox.Show("System error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UploadDocumentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    UploadDocumentLoadingPictureBox.Visible = true;

                    using (var stream = new System.IO.FileStream(openFileDialog.FileName, System.IO.FileMode.Open))
                    {
                        await _googleDriveService.UploadDocument(stream, openFileDialog.SafeFileName);
                    }

                    var gdFiles = await _googleDriveService.GetAll();

                    GDGridView.DataSource = gdFiles;
                }            
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                UploadDocumentLoadingPictureBox.Visible = false;
            }
        }

        private void PreviewAgreementButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TenantGridView.CurrentRow == null || PropertyGridView.CurrentRow == null) return;

                var tenant = (TenantModel)TenantGridView.CurrentRow.DataBoundItem;

                var property = (PropertyModel)PropertyGridView.CurrentRow.DataBoundItem;
                                
                var pdfService = new PdfService();

                var pdfDoc = pdfService.GenerateRentalDocument(property.OwnerName, tenant.Name);

                var pdfFileName = $"rental_agreement_{property.OwnerName}_{tenant.Name}.pdf";

                System.IO.File.WriteAllBytes(pdfFileName, pdfDoc);

                var pdfPreviewForm = new PdfDocPreviewForm(pdfFileName);

                pdfPreviewForm.ShowDialog(this);

                if (System.IO.File.Exists(pdfFileName))
                {
                    System.IO.File.Delete(pdfFileName);
                }                      
            }
            catch (Exception ex)
            {
                //log ex
                MessageBox.Show("System error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DownloadAndPreviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (GDGridView.CurrentRow == null) return;

                var gdFile = (GoogleDriveFileModel)GDGridView.CurrentRow.DataBoundItem;

                UploadDocumentLoadingPictureBox.Visible = true;

                var pdfDocMemoryStream = _googleDriveService.DownloadDocument(gdFile.Id);

                using (StreamWriter writer = new StreamWriter(pdfDocMemoryStream))
                {
                    pdfDocMemoryStream.Seek(0, SeekOrigin.Begin);

                    using (FileStream fs = new FileStream(gdFile.Name, FileMode.OpenOrCreate))
                    {
                        pdfDocMemoryStream.CopyTo(fs);
                        fs.Flush();
                    }
                }    

                var pdfPreviewForm = new PdfDocPreviewForm(gdFile.Name);

                pdfPreviewForm.ShowDialog(this);

                if (System.IO.File.Exists(gdFile.Name))
                {
                    System.IO.File.Delete(gdFile.Name);
                }
            }
            catch (Exception)
            {
                //log ex
                MessageBox.Show("System error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UploadDocumentLoadingPictureBox.Visible = false;
            }
        }

        private void SqlServerConnectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataConnectionDialog dcd = new DataConnectionDialog();
                DataSource.AddStandardDataSources(dcd);
                dcd.SelectedDataSource = DataSource.SqlDataSource;
                //DataConnectionConfiguration dcs = new DataConnectionConfiguration(null);

                DataConnectionDialog.Show(dcd);
            }
            catch (Exception ex)
            {
                //log ex
                MessageBox.Show("System error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
