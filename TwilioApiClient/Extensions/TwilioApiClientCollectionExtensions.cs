using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TwilioApiClient.Extensions
{
    public static class TwilioApiClientCollectionExtensions
    {
        public static IServiceCollection AddTwilioApiClientService(this IServiceCollection collection, IConfiguration config)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (config == null) throw new ArgumentNullException(nameof(config));
 
            collection.Configure<TwilioApiOptions>(config);
            return collection.AddTransient<ITwilioApiClient, TwilioApiClient>();
        }
    }
}
