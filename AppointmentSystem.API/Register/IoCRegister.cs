using AppointmentSystem.Application.Contracts.IServices;
using AppointmentSystem.Application.Services;
using AppointmentSystem.DataAccess.Contracts.IRepositories;
using AppointmentSystem.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AppointmentSystem.API.Register
{
    /// <summary>
    /// IoCRegister
    /// </summary>
    public static class IoCRegister
    {
        /// <summary>
        /// AddRegistration
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {

            services.AddRegisterServices();
            services.AddRegisterRepositories();
            services.AddRegisterOthers();
            return services;
        }
        /// <summary>
        /// Add Register Services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IAppointmentService, AppointmentService>();
            return services;
        }
        /// <summary>
        /// Add Register Repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IAppointmentSystemDBContext, AppointmentSystemDBContext>();
            return services;
        }
        /// <summary>
        /// Add Register Others
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterOthers(this IServiceCollection services)
        {
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            IConfiguration _configuration = serviceProvider.GetService<IConfiguration>();
            services.AddDbContext<AppointmentSystemDBContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DataBaseConnection")));
            services.AddMvc();
            return services;
        }
    }
}
