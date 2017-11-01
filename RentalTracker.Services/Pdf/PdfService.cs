using PdfSharp;
using System.IO;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace RentalTracker.Services.Pdf
{
    public class PdfService : IPdfService
    {
        public byte[] GenerateRentalDocument(string ownerName, string tenantName)
        {
            //TODO: only for prototype purpose
            var template = GetHtmlDocumentTemplate();

            template = template.Replace("{PROPERTY_OWNER_NAME}", ownerName).Replace("{TENANT_NAME}", tenantName);
            
            var pdfDoc = PdfGenerator.GeneratePdf(template, PageSize.A4);
            pdfDoc.Info.Title = "Rental agreement";

            using (var stream = new MemoryStream())
            {
                pdfDoc.Save(stream, true);
                return stream.ToArray();
            }
        }

        private string GetHtmlDocumentTemplate()
        {
            return @"<html>
            <body>
            <h1>Rental agreement</h1>
            <p>This is test rental agreement between property owner {PROPERTY_OWNER_NAME} and tenant {TENANT_NAME}</p>
            <body>
            </html>";
        }
    }
}
