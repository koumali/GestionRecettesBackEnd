namespace AutomotiveApi.Models.Entities.Param
{
    public class EmailVerificationToken
    {

        public int Id { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public DateTime ExpirationDate { get; set; }


    }
}