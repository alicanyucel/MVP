using MVP.Application.Features.Auth.Login;
using MVP.Domain.Entities;

namespace MVP.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
