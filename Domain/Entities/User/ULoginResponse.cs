namespace Domain.Entities.User
{
    public class ULoginResponse
    {
        public bool Status { get; set; }
        public string StatusMsg { get; set; }
        
        public string UserRole { get; set; }
        public string Token { get; set; }
    }
}