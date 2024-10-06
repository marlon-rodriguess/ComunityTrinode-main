using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Trinode.Domain.Interfaces;
using Trinode.Infrastructure.Data;
using Trinode.Infrastructure.Repositories;

namespace Trinode.Infrastructure
{
    public static class ServicesExtensions 
    {   
        public static void ConfigureInfraServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TrinodeDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("connectionString")));

            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<CategoryRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IModuleRepository, ModuleRepository>();
            services.AddScoped<ILectureRepository, LectureRepository>();
            services.AddScoped<IDbCommit, DbCommit>();
        }
    }
}

