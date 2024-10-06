using AutoMapper;
using Trinode.Application.UseCases.CreateUser;
using Trinode.Domain.Entities;

//Utilizado para mapear os objetos de entrada e saída do caso de uso CreateUser
//Pacote adicional necessário: AutoMapper.Extensions.Microsoft.DependencyInjection
namespace Trinode.Application.UseCases.CreateUser
{
    public sealed class CreateUserMap : Profile
    {
        public CreateUserMap()
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, CreateUserResponse>();
        }
    }
}