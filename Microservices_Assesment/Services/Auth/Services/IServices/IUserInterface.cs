using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth.Models.Dtos;

namespace Auth.Services.IServices
{
    public interface IUserInterface
    {
        Task<string> RegisterUser(RegisterRequestDto registerRequestDto);
        Task<LoginResponseDto> LoginUser(LoginRequestDto loginRequestDto);
        Task<bool> AssignUserRole(string email, string RoleName);
    }
}
