namespace BMB_Services.DTOs
{
    public class LoginResponseModel
    {
        public string Token { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime ExpiresAt { get; set; }
    }
}
