using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAuthRepository<TEntity, TAuthenticationOutput>
    {
        Task<TEntity> GetUserByIdAsync(int id);
        Task<TAuthenticationOutput> CreateUserAsync(TEntity user);
        Task<TAuthenticationOutput> LoginAsync(string email, string password);
        Task UpdateUserAsync(TEntity id);
        Task DeleteUserAsync(int id);
    }
}
