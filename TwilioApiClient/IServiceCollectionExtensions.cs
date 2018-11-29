using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace TwilioApiClient
{
    public static class IServiceCollectionExtensions
    {
        private const string Identifier = "Twilio";
        
        public static IServiceCollection AddActiveCampaignApiClient(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddOptions();
            services.Configure<TwilioApiOptions>(configuration.GetSection(Identifier));
            services.TryAddTransient<ITwilioApiClient>((sp) =>
            {
                var options = sp.GetService<IOptions<TwilioApiOptions>>().Value;
                return new TwilioApiClient(options);
            });

            return services;
        }
    }
}