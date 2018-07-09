// ReSharper disable once CheckNamespace - extension method class
namespace Microsoft.Extensions.DependencyInjection
{
    using System.Diagnostics.CodeAnalysis;

    using ArgSentry;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    using VMS.Domain.EntityFramework.DomainProcessEventStore;
    using VMS.Requisitions.Querying;
    using VMS.Messaging;

    /// <summary>
    /// The service collection extensions.
    /// </summary>
    [ExcludeFromCodeCoverage] // These methods are just wrappers around MS utilities...
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds services required for injecting the IOptions{T} interface and 
        /// registers all custom option types that should be injectable.
        /// </summary>
        /// <param name="services">
        /// The services collection.
        /// </param>
        /// <param name="configuration">
        /// The configuration root.
        /// </param>
        /// <returns>
        /// The <see cref="IServiceCollection"/>.
        /// </returns>
        /// TODO: What should we do with this? Can we make it more generic? Does it add value? Where should it live?
        public static IServiceCollection AddInjectableCustomOptions(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            Prevent.NullObject(configuration, nameof(configuration));

            // Add functionality to inject IOptions<T>
            services.AddOptions();

            return services;
        }

        /// <summary>
        /// Registers all required DB contexts.
        /// </summary>
        /// <param name="services">
        /// The services collection.
        /// </param>
        /// <param name="configuration">
        /// The configuration.
        /// </param>
        /// <returns>
        /// The <see cref="IServiceCollection"/>.
        /// </returns>
        public static IServiceCollection AddDbContexts(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            Prevent.NullObject(configuration, nameof(configuration));

            // Add querying DB context
            services.AddDbContext<QueryingContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("VMS")),
                ServiceLifetime.Transient);

            services.AddTransient<IQueryingContext, QueryingContext>();

            // Add domain process event store DB context
            services.AddDbContext<ProcessEventStoreContext>(
                options => options.UseNpgsql(configuration.GetConnectionString("VMS.Requisitons")),
                ServiceLifetime.Transient);

            services.AddTransient<IProcessEventStoreContext, ProcessEventStoreContext>();

            return services;
        }
    }
}