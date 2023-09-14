using LMS.Domain.Abstractions;
using LMS.Domain.Implementations;
using LMS.Entities;
using RedBook.Core;
using RedBook.Core.Repositories;

namespace LMS.API.Configurations
{
    /// <summary>
    /// Extension methods for resolving dependencies in Constructor DI using IOC Container
    /// </summary>
    public static class DependencyResolver
    {
        /// <summary>
        /// Registers Interfaces with corresponding implementation Classes for IOC Contaienr.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <param name="configuration">The <see cref="IConfiguration"/>.</param>
        public static void RosolveDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            // DB Context & Other relevant mappings for Blume Core Library
            CoreDependencyResolver<EurekhaLmsContext>.RosolveCoreDependencies(services, configuration);

            // Application Services
            services.AddScoped<ICourseService, CourseService>();

            // Application Repositories
            //services.AddScoped<IRepositoryBase<User>, RepositoryBase<User>>();
        }
    }
}
