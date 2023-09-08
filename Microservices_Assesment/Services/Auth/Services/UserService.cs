using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth.Data;
using Auth.Models;
using Auth.Models.Dtos;
using Auth.Services.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace Auth.Services
{
    public class UserService : IUserInterface
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        public UserService(AppDbContext context,UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }
        public Task<bool> AssignUserRole(string email, string RoleName)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponseDto> LoginUser(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RegisterUser(RegisterRequestDto registerRequestDto)
        {
            var user = _mapper.Map<ApplicationUser>(registerRequestDto);
            try
            {
                var result = await _userManager.CreateAsync(user, registerRequestDto.Password);
                if(result.Succeeded){
                    return "";
                }else{
                    return err
                }
            } catch(Exception ex)
            {
                return(ex.Message);
            }
            return result.ToString();
        }
    }
}
