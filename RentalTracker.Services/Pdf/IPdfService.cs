
namespace RentalTracker.Services.Pdf
{
    public interface IPdfService
    {
        byte[] GenerateRentalDocument(string ownerName, string tenantName);
    }
}
