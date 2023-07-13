namespace AutomotiveApi.Utility{
    public interface IFileHelper
    {
        Task<String> UploadImage(IFormFile file, string folder);
    }    
}