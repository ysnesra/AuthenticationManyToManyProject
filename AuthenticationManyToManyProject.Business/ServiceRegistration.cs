using AuthenticationManyToManyProject.DataAccess.Contexts;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Reflection;


namespace AuthenticationManyToManyProject.Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services, ConfigurationManager _configurationManager)
        {
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;

        }

        public static IServiceCollection ServisRelationShip(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<ICallService, CallManager>();
            //services.AddScoped<ICallDal, EfCallDal>();


            services.AddDbContext<AuthenticationManyToManyDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("defaultConnection"));
                opt.UseLazyLoadingProxies();
            });

            return services;
        }

    }
}

