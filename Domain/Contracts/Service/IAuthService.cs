using Domain.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Service
{
    public interface IAuthService
    {
        void Register(RegisterDto registerDto);
        User Login(LoginDto loginDto);
    }
}
