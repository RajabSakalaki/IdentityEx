using identityEx.Core.Dtos;

namespace identityEx.Core.Interfaces
{
    public interface IAuthService
    {
        Task<AuthServiceResponseDto> SeedRolesAsync();
        Task<AuthServiceResponseDto> RegisterAsync(RegisterDTO registerDto);
        Task<AuthServiceResponseDto> LoginAsync(LoginDTO loginDto);
        Task<AuthServiceResponseDto> MakeAdminAsync(UpdatePermissionDTO updatePermissionDto);
        Task<AuthServiceResponseDto> MakeOwnerAsync(UpdatePermissionDTO updatePermissionDto);
    }
}