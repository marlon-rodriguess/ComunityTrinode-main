using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Trinode.Application.UseCases.CreateUser;
using FluentValidation;
using MediatR;
using Trinode.Application.Shared.Behaviours;

namespace Trinode.Application.Services
{
    public static class ServicesExtensions 
    {
        public static void AplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(x => x.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            
            //Adiciono o registro do ValidatorBehavior para ser utilizado em todos os requests
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidatorBehavior<,>));
        }
    }
}

