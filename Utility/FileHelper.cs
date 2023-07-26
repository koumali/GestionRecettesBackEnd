namespace AutomotiveApi.Utility
{
    public class FileHelper : IFileHelper
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public FileHelper(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<String> UploadImage(IFormFile file, string folder, string name)
        {
            var dbImgPath = "";
            if (file != null && file.Length > 0)
            {
                var imgsPath = Path.Combine(_hostingEnvironment.WebRootPath, folder);
                if (!Directory.Exists(imgsPath))
                {
                    Directory.CreateDirectory(imgsPath);
                }

                string fileName = name!=null ? name : Guid.NewGuid().ToString() ;
                fileName += Path.GetExtension(file.FileName);
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, folder, fileName);



                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                dbImgPath = Path.Combine(folder, fileName);
            }
            return dbImgPath;
        }
    }
}