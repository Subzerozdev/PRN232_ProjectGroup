using TetGift.BLL.Interfaces;

namespace TetGift.BLL.Services
{
    public class FileEmailTemplateRenderer : IEmailTemplateRenderer
    {
        public string RenderOtp(string otp, int minutes)
        {
            var path = Path.Combine(AppContext.BaseDirectory, "EmailTemplates", "OtpEmail.html");
            if (!File.Exists(path))
                path = Path.Combine(Directory.GetCurrentDirectory(), "EmailTemplates", "OtpEmail.html");

            var html = File.ReadAllText(path);

            return html.Replace("{{OTP}}", otp)
                       .Replace("{{MINUTES}}", minutes.ToString());
        }
    }
}
