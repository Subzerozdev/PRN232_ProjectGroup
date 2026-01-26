namespace TetGift.BLL.Dtos
{
    public class RegisterRequest
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Email { get; set; } = "";
        public string? Fullname { get; set; }
        public string? Phone { get; set; }
    }

    public class VerifyOtpRequest
    {
        public string Username { get; set; } = "";
        public string Otp { get; set; } = "";
    }

    public class LoginRequest
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
    }

    public class AuthResultDto
    {
        public string Token { get; set; } = "";
        public int AccountId { get; set; }
        public string Username { get; set; } = "";
        public string? Email { get; set; }
        public string? Role { get; set; }
    }
}
