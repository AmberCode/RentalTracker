using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalTracker
{
    public partial class PdfDocPreviewForm : Form
    {
        private readonly string _pdfFileName;
        public PdfDocPreviewForm(string pdfFileName)
        {
            InitializeComponent();
            Load += PdfDocPreviewForm_Load;

            _pdfFileName = pdfFileName;
        }

        private void PdfDocPreviewForm_Load(object sender, EventArgs e)
        {
            LoadPdfFile(_pdfFileName);
        }

        private void PrintPdfDocButton_Click(object sender, EventArgs e)
        {
            axAcroPDFViewer.printWithDialog();
        }

        private void LoadPdfFile(string fileName)
        {
            axAcroPDFViewer.LoadFile(_pdfFileName);
            axAcroPDFViewer.Show();
        }
    }
}
