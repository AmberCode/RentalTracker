using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Model;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Services;
using System.IO;
using Google.Apis.Download;

namespace RentalTracker.Services.GoogleDrive
{
    public class GoogleDriveService : IGoogleDriveService
    {
        //TODO: put these var values into config file
        private string client_secret_json =
            @"{'installed':{'client_id':'1012994236929-p8a7h5b9e0m401m27270ea8jp4p66136.apps.googleusercontent.com','project_id':'ornate-fragment-171506','auth_uri':'https://accounts.google.com/o/oauth2/auth','token_uri':'https://accounts.google.com/o/oauth2/token','auth_provider_x509_cert_url':'https://www.googleapis.com/oauth2/v1/certs','client_secret':'fPESa7pLAl-73tWuzipOuXA_','redirect_uris':['urn:ietf:wg:oauth:2.0:oob','http://localhost']}}";
        static string[] Scopes = { DriveService.Scope.Drive };
        static string ApplicationName = "RentalTracker";
        public async Task<IEnumerable<GoogleDriveFileModel>> GetAll()
        {
            try
            {
                var service = await GetDriveService();

                var files = await GetFilesAsync(service);

                return files.Select(x => new GoogleDriveFileModel
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            }
            catch (Exception ex)
            {
                //log ex
                throw;
            }
        }

        public async Task UploadDocument(FileStream fileStream, string targetFileName)
        {
            try
            {
                var driveService = await GetDriveService();

                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = targetFileName
                };

                FilesResource.CreateMediaUpload request;

                request = driveService.Files.Create(fileMetadata, fileStream, "application/pdf");
                request.Fields = "id";

                await request.UploadAsync();
            }
            catch (Exception)
            {
                //log
                throw;
            }
        }

        public MemoryStream DownloadDocument(string fileId)
        {
            try
            {
                var driveService = GetDriveService();

                var request = driveService.Result.Files.Get(fileId);

                var stream = new MemoryStream();

                request.Download(stream);

                return stream;
            }
            catch (Exception)
            {
                //log
                throw;
            }
        }

        private async Task<List<Google.Apis.Drive.v3.Data.File>> GetFilesAsync(DriveService service)
        {
            await Task.Delay(5000);

            var list = new List<Google.Apis.Drive.v3.Data.File>();

            string pageToken = null;
            do
            {
                var request = service.Files.List();
                request.PageSize = 10;
                request.Q = "mimeType='application/pdf'";
                request.Spaces = "drive";
                request.Fields = "nextPageToken, files(id, name)";
                request.PageToken = pageToken;
                var result = await request.ExecuteAsync();
                foreach (var file in result.Files)
                {
                    list.Add(file);
                }
                pageToken = result.NextPageToken;
            } while (pageToken != null);

            return list;
        }
        private Stream ToStream(string json)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(json);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
        private async Task<DriveService> GetDriveService()
        {
            UserCredential credential;

            using (var stream = ToStream(client_secret_json))
            {
                var credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = System.IO.Path.Combine(credPath, ".credentials/RentalTracker.json");

                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                Scopes,
                "user",
                CancellationToken.None,
                new FileDataStore(credPath, true));
            }

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            return service;
        }
    }
}
