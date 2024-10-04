using CustomMediator.Net.Configurations;
using Microsoft.Extensions.DependencyInjection;

namespace CustomMediator.Net.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomMediator(this IServiceCollection services, Action<CustomMediatorServiceConfiguration> configuration) 
        {
            var serviceConfig = new CustomMediatorServiceConfiguration();

            configuration.Invoke(serviceConfig);

            return services.AddCustomMediator(serviceConfig);
        }

        public static IServiceCollection AddCustomMediator(this IServiceCollection services, CustomMediatorServiceConfiguration configuration)
        {

            return services;
        }
    }
}
