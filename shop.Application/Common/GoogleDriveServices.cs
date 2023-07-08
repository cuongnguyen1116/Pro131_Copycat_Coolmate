using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Application.Common
{
    public class GoogleDriveServices
    {
        private DriveService _driveService;

        public GoogleDriveServices()
        {
            // Đường dẫn tới file JSON chứa thông tin xác thực
            string credentialsPath = "path/to/credentials.json";

            // Scopes (phạm vi truy cập) cần thiết cho ứng dụng của bạn
            string[] scopes = { DriveService.Scope.Drive };

            // Thiết lập thông tin xác thực
            UserCredential credential;
            using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore("GoogleDriveService")
                ).Result;
            }

            // Tạo DriveService từ thông tin xác thực
            _driveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Your Application Name"
            });
        }

        public void UploadImage(string imagePath)
        {
            // Tạo metadata cho file
            var fileMetadata = new File()
            {
                Name = Path.GetFileName(imagePath),
                Parents = new List<string>() { "folderId" } // ID của thư mục trên Google Drive
            };

            // Đọc nội dung của file
            byte[] fileContent;
            using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (var memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    fileContent = memoryStream.ToArray();
                }
            }

            // Tạo yêu cầu tải lên
            var request = _driveService.Files.Create(fileMetadata, new MemoryStream(fileContent), "image/jpeg");
            request.Fields = "id"; // Chỉ lấy ID của file

            // Gửi yêu cầu tới Google Drive API và lấy thông tin về file đã tải lên
            var uploadedFile = request.Execute();

            // Lấy ID của file đã tải lên
            string fileId = uploadedFile.Id;

            // In ra ID của file đã tải lên
            Console.WriteLine("File uploaded with ID: " + fileId);
        }
    }
}
