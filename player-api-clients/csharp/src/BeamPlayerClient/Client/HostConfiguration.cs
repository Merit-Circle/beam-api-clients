/*
 * Player API
 *
 * The Player API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using BeamPlayerClient.Api;
using BeamPlayerClient.Model;

namespace BeamPlayerClient.Client
{
    /// <summary>
    /// Provides hosting configuration for BeamPlayerClient
    /// </summary>
    public class PlayerHostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class
        /// </summary>
        /// <param name="services"></param>
        public PlayerHostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new Check200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new Check200ResponseInfoValueJsonConverter());
            _jsonOptions.Converters.Add(new Check503ResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerAcceptAssetOfferRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerBuyAssetRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCancelAssetListingRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCancelAssetOfferRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonActivityResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonActivityResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonActivityResponseDataInnerAssetJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonActivityResponseDataInnerContractJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonActivityResponseDataInnerOrderJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonActivityResponseDataInnerTransactionJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonAssetActivityRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonContractActivityRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonOperationResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonOperationResponseTransactionsInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonStatsRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonStatsResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonStatsResponseCountJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCommonUserActivityRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerConfirmOperationRequestJsonConverter());
            _jsonOptions.Converters.Add(new PlayerConfirmOperationRequestTransactionsInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerConvertTokenRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCreateAssetOfferRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCreateConnectionRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCreateConnectionRequestResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCreateOperationRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCreateOperationRequestInputTransactionsInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCreateTransactionRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerCreateTransactionRequestInputInteractionsInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGenerateSessionRequestResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGenerateSessionUrlRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetActiveSessionResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetActiveSessionsResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetActiveSessionsResponseSessionsInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAllUsersResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAllUsersResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAllUsersResponseDataInnerWalletsInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetListingsResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetListingsResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetListingsResponseDataInnerPriceJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetListingsResponseDataInnerPriceAmountJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetListingsResponseDataInnerPriceCurrencyJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetResponseOwnersInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetsForContractBodyInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetsForContractBodyInputAttributesInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetsForContractResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetsForContractResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetsForUserBodyInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetsForUserResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetsForUserResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAssetsForUserResponseDataInnerAttributesInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAttributesResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAttributesResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetAttributesResponseDataInnerValuesInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetChainCurrenciesResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetChainCurrenciesResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetConnectionRequestResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetListedAssetsBodyInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetOwnerAssetsBodyInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetOwnerAssetsResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetOwnersResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetOwnersResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetOwnersResponsePaginationJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetQuoteResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetSessionRequestResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetTransactionResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetTransactionResponsePolicyJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetTransactionResponseUserJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetTransactionResponseUserEntitiesInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetTransactionResponseUserWalletJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetTransactionsResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetTransactionsResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetTransactionsResponseDataInnerIntentJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetTransactionsResponseDataInnerIntentInteractionsInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetTransactionsResponseDataInnerTransactionJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetTransactionsResponseDataInnerTransactionLogsInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetUserCurrenciesResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetUserCurrenciesResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetUserNativeCurrencyResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetUserNativeCurrencyResponseNativeTokenBalanceJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGetUserResponseJsonConverter());
            _jsonOptions.Converters.Add(new PlayerRefreshContractRequestBodyJsonConverter());
            _jsonOptions.Converters.Add(new PlayerRefreshTokenRequestBodyJsonConverter());
            _jsonOptions.Converters.Add(new PlayerRevokeSessionRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerSellAssetRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerTransferAssetRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerTransferAssetRequestInputAssetsInnerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerTransferNativeTokenRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerTransferTokenRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerUnwrappingTokenInputJsonConverter());
            _jsonOptions.Converters.Add(new PlayerWrappingTokenInputJsonConverter());
            PlayerJsonSerializerOptionsProvider jsonSerializerOptionsProvider = new(_jsonOptions);
            _services.AddSingleton(jsonSerializerOptionsProvider);
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddSingleton<PlayerActivityApiEvents>();
            _services.AddTransient<IPlayerActivityApi, PlayerActivityApi>();
            _services.AddSingleton<PlayerAssetsApiEvents>();
            _services.AddTransient<IPlayerAssetsApi, PlayerAssetsApi>();
            _services.AddSingleton<PlayerConnectorApiEvents>();
            _services.AddTransient<IPlayerConnectorApi, PlayerConnectorApi>();
            _services.AddSingleton<PlayerExchangeApiEvents>();
            _services.AddTransient<IPlayerExchangeApi, PlayerExchangeApi>();
            _services.AddSingleton<PlayerHealthApiEvents>();
            _services.AddTransient<IPlayerHealthApi, PlayerHealthApi>();
            _services.AddSingleton<PlayerMarketplaceApiEvents>();
            _services.AddTransient<IPlayerMarketplaceApi, PlayerMarketplaceApi>();
            _services.AddSingleton<PlayerOperationApiEvents>();
            _services.AddTransient<IPlayerOperationApi, PlayerOperationApi>();
            _services.AddSingleton<PlayerSessionsApiEvents>();
            _services.AddTransient<IPlayerSessionsApi, PlayerSessionsApi>();
            _services.AddSingleton<PlayerStatsApiEvents>();
            _services.AddTransient<IPlayerStatsApi, PlayerStatsApi>();
            _services.AddSingleton<PlayerTransactionsApiEvents>();
            _services.AddTransient<IPlayerTransactionsApi, PlayerTransactionsApi>();
            _services.AddSingleton<PlayerUsersApiEvents>();
            _services.AddTransient<IPlayerUsersApi, PlayerUsersApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public PlayerHostConfiguration AddBeamPlayerApiHttpClients
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<IPlayerActivityApi, PlayerActivityApi>(client));
            builders.Add(_services.AddHttpClient<IPlayerAssetsApi, PlayerAssetsApi>(client));
            builders.Add(_services.AddHttpClient<IPlayerConnectorApi, PlayerConnectorApi>(client));
            builders.Add(_services.AddHttpClient<IPlayerExchangeApi, PlayerExchangeApi>(client));
            builders.Add(_services.AddHttpClient<IPlayerHealthApi, PlayerHealthApi>(client));
            builders.Add(_services.AddHttpClient<IPlayerMarketplaceApi, PlayerMarketplaceApi>(client));
            builders.Add(_services.AddHttpClient<IPlayerOperationApi, PlayerOperationApi>(client));
            builders.Add(_services.AddHttpClient<IPlayerSessionsApi, PlayerSessionsApi>(client));
            builders.Add(_services.AddHttpClient<IPlayerStatsApi, PlayerStatsApi>(client));
            builders.Add(_services.AddHttpClient<IPlayerTransactionsApi, PlayerTransactionsApi>(client));
            builders.Add(_services.AddHttpClient<IPlayerUsersApi, PlayerUsersApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public PlayerHostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public PlayerHostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public PlayerHostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public PlayerHostConfiguration UseProvider<TTokenProvider, TTokenBase>()
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}
