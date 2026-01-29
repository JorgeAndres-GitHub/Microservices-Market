using Application.Interfaces;
using Domain;
using Infrastructure.Data;
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
        private readonly AppDbContext _context;

        public AuthRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<AuthResult> CreateUserAsync(User user)
        {
            var emailExists = _context.Users.Any(u => u.Email == user.Email);
            if (emailExists)
            {
                return new AuthResult
                {
                    Result = false,
                    Errors = new List<string> { "Email already in use." }
                };
            }

            // Password hashing should be done here before saving the user

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return new AuthResult
            {
                Result = true,
                User = user 
            };
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
