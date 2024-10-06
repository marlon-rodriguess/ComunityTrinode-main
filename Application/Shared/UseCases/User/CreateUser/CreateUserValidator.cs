using FluentValidation;

//Pacote adicional necessário: FluentValidation
//Utilizado para validar os dados de entrada do caso de uso CreateUser
namespace Trinode.Application.UseCases.CreateUser
{
    public sealed class CreateUserValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress().MinimumLength(50).MaximumLength(100);
            RuleFor(x => x.Name).NotEmpty().MinimumLength(5).MaximumLength(50);
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8).MaximumLength(20);
        }
    }   
}