namespace TetGift.BLL.Interfaces
{
    public interface IEmailTemplateRenderer
    {
        string RenderOtp(string otp, int minutes);
    }
}
