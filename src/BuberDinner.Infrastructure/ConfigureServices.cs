using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuberDinner.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using BuberDinner.Application.Common.Interfaces;
using BuberDinner.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using BuberDinner.Infrastructure.Identity;

namespace BuberDinner.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MMTDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MMTConnection")));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<MMTDbContext>());
            services.AddSingleton<IInMemoryDatabase, InMemoryDatabase>();

            services.AddTransient<IDateTimeService, DateTimeService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddTransient<IIdentityService, IdentityService>();

            return services;
        }
    }
}
