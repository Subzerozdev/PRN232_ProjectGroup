using TetGift.BLL.Dtos;

namespace TetGift.BLL.Interfaces
{
    public interface IAuthService
    {
        Task RequestRegisterOtpAsync(RegisterRequest req);
        Task<AuthResultDto> VerifyRegisterOtpAsync(VerifyOtpRequest req);
        Task<AuthResultDto> LoginAsync(LoginRequest req);
    }
}
