using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Adapters.DTOs
{
    public record RegisterUserDto(
        string Name,
        string Email,
        string Password,
        string ConfirmPassword,
        string Rol
    );
}
