/*
 * Automation API
 *
 * The Automation API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using BeamAutomationClient.Client;

namespace BeamAutomationClient.Extensions
{
    /// <summary>
    /// Extension methods for IServiceCollection
    /// </summary>
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add the api to your host builder.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        public static void AddBeamAutomationApi(this IServiceCollection services, Action<AutomationHostConfiguration> options)
        {
            AutomationHostConfiguration config = new(services);
            options(config);
            AddBeamAutomationApi(services, config);
        }

        /// <summary>
        /// Add the api to your host builder.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        [Obsolete("Use AddBeamAutomationApi")]
        public static void AddApi(this IServiceCollection services, Action<AutomationHostConfiguration> options)
        {
            AutomationHostConfiguration config = new(services);
            options(config);
            AddBeamAutomationApi(services, config);
        }

        internal static void AddBeamAutomationApi(IServiceCollection services, AutomationHostConfiguration host)
        {
            if (!host.HttpClientsAdded)
                host.AddBeamAutomationApiHttpClients();

            services.AddSingleton<CookieContainer>();

            services.AddSingleton<SimpleApiKeyTokenProvider<AutomationApiKeyToken>>();
            services.AddTransient(typeof(TokenProvider<>).MakeGenericType(typeof(AutomationApiKeyToken)),
                        s => s.GetRequiredService(typeof(SimpleApiKeyTokenProvider<>).MakeGenericType(typeof(AutomationApiKeyToken))));
        }
    }
}