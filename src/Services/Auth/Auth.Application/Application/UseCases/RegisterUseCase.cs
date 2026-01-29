using Application.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class RegisterUseCase<TDto, TResult>
    {
        private IMapper<TDto, User> _mapper;
        private IAuthRepository<User, TResult> _authRepository;

        public RegisterUseCase(IMapper<TDto, User> mapper, IAuthRepository<User, TResult> authRepository)
        {
            _mapper = mapper;
            _authRepository = authRepository;
        }

        public async Task<TResult> Execute(TDto user)
        {
            var mappedUser = _mapper.MapToEntity(user);

            var result = await _authRepository.CreateUserAsync(mappedUser);
            return result;
        }
            
            
    }
}
