using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth.Models;
using Auth.Models.Dtos;
using AutoMapper;

namespace Auth.Profiles
{
    public class AuthProfile : Profile
    {
        public AuthProfile()
        {
            CreateMap<RegisterRequestDto, ApplicationUser>().ForMember(dest => dest.UserName, u => u.MapFrom(reg => reg.Email));
        }
    }
}
