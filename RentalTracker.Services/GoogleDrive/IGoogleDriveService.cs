
using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Model;
using System.IO;

namespace RentalTracker.Services.GoogleDrive
{
    public interface IGoogleDriveService
    {
        Task<IEnumerable<GoogleDriveFileModel>> GetAll();
        Task UploadDocument(FileStream fileStream, string fileName);
        MemoryStream DownloadDocument(string fileId);
    }
}
