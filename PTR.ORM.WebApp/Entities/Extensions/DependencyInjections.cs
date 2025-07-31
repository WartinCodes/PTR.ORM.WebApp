using PTR.ORM.WebApp.Data;
using PTR.ORM.WebApp.Models.Dtos.Requests;
using PTR.ORM.WebApp.Models.Validators;
using PTR.ORM.WebApp.Repositories.Implementations;
using PTR.ORM.WebApp.Repositories.Interfaces;
using PTR.ORM.WebApp.Services.Implementations;
using PTR.ORM.WebApp.Services.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

namespace PTR.ORM.WebApp.Entities.Extensions
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDatabase(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<RestaurantApiContext>(options => options.UseSqlServer(configuration.GetConnectionString("RestaurantAPI")));

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();

            services.AddScoped<IValidator<CreateProductRequestDto>, CreateProductRequestDtoValidator>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}