using Application.Interfaces;
using Domain;
using Interface_Adapters.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Adapters.Repository
{
    public class AuthRepository : IAuthRepository<User, AuthResult>
    {
        public async Task<AuthResult> CreateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<AuthResult> LoginAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUserAsync(User id)
        {
            throw new NotImplementedException();
        }
    }
}
