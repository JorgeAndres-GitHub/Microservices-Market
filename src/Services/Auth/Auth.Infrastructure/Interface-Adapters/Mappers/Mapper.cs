using Application.Interfaces;
using Domain;
using Interface_Adapters.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Adapters.Mappers
{
    public class Mapper : IMapper<RegisterUserDto, User>
    {
        public User MapToEntity(RegisterUserDto input) => new User
        {
            Name = input.Name,
            Email = input.Email,
            Password = input.Password
        };
    }
}
