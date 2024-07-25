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
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using BeamAutomationClient.Api;
using BeamAutomationClient.Model;

namespace BeamAutomationClient.Client
{
    /// <summary>
    /// Provides hosting configuration for BeamAutomationClient
    /// </summary>
    public class AutomationHostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class
        /// </summary>
        /// <param name="services"></param>
        public AutomationHostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new AutomationAcceptAssetOfferRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationAcceptOfferResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationAddContractRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AutomationAddContractResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationBuyAssetRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationBuyAssetResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationCancelAssetListingRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationCancelAssetListingResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationCancelAssetOfferRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationCancelOfferResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonActivityRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonActivityResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonActivityResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonActivityResponseDataInnerAssetJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonActivityResponseDataInnerContractJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonActivityResponseDataInnerOrderJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonActivityResponseDataInnerTransactionJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonAddPolicyRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonAddPolicyResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonGetPoliciesResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonGetPoliciesResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonRemovePolicyResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonStatsRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonStatsResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCommonStatsResponseCountJsonConverter());
            _jsonOptions.Converters.Add(new AutomationConvertTokenRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AutomationConvertTokenResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCreateAssetOfferRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationCreateOfferResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationCreateProfileRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCreateProfileResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCreateProfileResponseWalletsInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCreateTransactionRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationCreateTransactionRequestInputV2InteractionsInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationCreateTransactionResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationCreateWebhookForGameJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGenerateLinkCodeRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGenerateLinkCodeResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGenerateSignInCodeRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGenerateSignInCodeResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAllGasUsageResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAllGasUsageResponseChainsInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAllGasUsageResponseChainsInnerPoliciesInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAllGasUsageResponseChainsInnerPoliciesInnerPeriodsInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAllGasUsageResponseChainsInnerPoliciesInnerPolicyJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAllGasUsageResponseChainsInnerSummaryJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAllProfilesResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAllProfilesResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAllProfilesResponsePaginationJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetListingsResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetListingsResponseV2DataInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetListingsResponseV2DataInnerPriceJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetListingsResponseV2DataInnerPriceAmountJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetListingsResponseV2DataInnerPriceCurrencyJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetResponseV2OwnersInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetsForContractBodyInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetsForContractBodyInputV2AttributesInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetsForContractResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetsForContractResponseV2DataInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetsForProfileBodyInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetsForProfileResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetsForProfileResponseV2DataInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetAssetsForProfileResponseV2DataInnerAttributesInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetChainCurrenciesResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetChainCurrenciesResponseV2DataInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetChainResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetChainResponseNativeCurrencyJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetEstimateResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetGameResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetGameResponseContractsInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetGameResponseDepositorJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetGameResponseDevelopersInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetGameResponseDevelopersInnerDeveloperJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetGameResponsePoliciesInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetGasUsageResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetListedAssetsBodyInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetPolicyUsageResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetProfileCurrenciesResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetProfileCurrenciesResponseV2DataInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetProfileNativeCurrencyResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetProfileNativeCurrencyResponseV2NativeTokenBalanceJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetProfileResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetQuoteResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetTransactionResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetTransactionResponseV2PolicyJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetTransactionResponseV2ProfileJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetTransactionResponseV2ProfileWalletJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetTransactionsResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetTransactionsResponseV2DataInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetTransactionsResponseV2DataInnerIntentJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetTransactionsResponseV2DataInnerIntentInteractionsInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetTransactionsResponseV2DataInnerTransactionJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetTransactionsResponseV2DataInnerTransactionLogsInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetWebhooksForGameResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationGetWebhooksForGameResponseWebhooksInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationRefreshContractRequestBodyJsonConverter());
            _jsonOptions.Converters.Add(new AutomationRefreshTokenRequestBodyJsonConverter());
            _jsonOptions.Converters.Add(new AutomationRegenerateGameApiKeysResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationRegenerateGameApiKeysResponseApiKeysInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationRemoveContractResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationSellAssetRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationSellAssetResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationTradeTokensRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AutomationTradeTokensRequestInputInitiatorJsonConverter());
            _jsonOptions.Converters.Add(new AutomationTradeTokensRequestInputInitiatorTokensInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationTradeTokensResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationTransferAssetRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationTransferAssetRequestInputV2AssetsInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationTransferAssetResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationTransferNativeTokenRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationTransferTokenRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationTransferTokenResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AutomationUpdateGameRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AutomationUpdateGameResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationUpdateGameResponsePoliciesInnerJsonConverter());
            _jsonOptions.Converters.Add(new AutomationUpdateProfileRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AutomationUpdateProfileResponseJsonConverter());
            _jsonOptions.Converters.Add(new AutomationWebhookForGameResponseJsonConverter());
            _jsonOptions.Converters.Add(new Check200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new Check200ResponseInfoValueJsonConverter());
            _jsonOptions.Converters.Add(new Check503ResponseJsonConverter());
            AutomationJsonSerializerOptionsProvider jsonSerializerOptionsProvider = new(_jsonOptions);
            _services.AddSingleton(jsonSerializerOptionsProvider);
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddSingleton<AutomationActivityApiEvents>();
            _services.AddTransient<IAutomationActivityApi, AutomationActivityApi>();
            _services.AddSingleton<AutomationAssetsV2ApiEvents>();
            _services.AddTransient<IAutomationAssetsV2Api, AutomationAssetsV2Api>();
            _services.AddSingleton<AutomationChainApiEvents>();
            _services.AddTransient<IAutomationChainApi, AutomationChainApi>();
            _services.AddSingleton<AutomationExchangeApiEvents>();
            _services.AddTransient<IAutomationExchangeApi, AutomationExchangeApi>();
            _services.AddSingleton<AutomationGameApiEvents>();
            _services.AddTransient<IAutomationGameApi, AutomationGameApi>();
            _services.AddSingleton<AutomationHealthApiEvents>();
            _services.AddTransient<IAutomationHealthApi, AutomationHealthApi>();
            _services.AddSingleton<AutomationMarketplaceV2ApiEvents>();
            _services.AddTransient<IAutomationMarketplaceV2Api, AutomationMarketplaceV2Api>();
            _services.AddSingleton<AutomationPolicyApiEvents>();
            _services.AddTransient<IAutomationPolicyApi, AutomationPolicyApi>();
            _services.AddSingleton<AutomationProfilesApiEvents>();
            _services.AddTransient<IAutomationProfilesApi, AutomationProfilesApi>();
            _services.AddSingleton<AutomationReportingApiEvents>();
            _services.AddTransient<IAutomationReportingApi, AutomationReportingApi>();
            _services.AddSingleton<AutomationStatsApiEvents>();
            _services.AddTransient<IAutomationStatsApi, AutomationStatsApi>();
            _services.AddSingleton<AutomationTradingApiEvents>();
            _services.AddTransient<IAutomationTradingApi, AutomationTradingApi>();
            _services.AddSingleton<AutomationTransactionsV2ApiEvents>();
            _services.AddTransient<IAutomationTransactionsV2Api, AutomationTransactionsV2Api>();
            _services.AddSingleton<AutomationWebhooksApiEvents>();
            _services.AddTransient<IAutomationWebhooksApi, AutomationWebhooksApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public AutomationHostConfiguration AddBeamAutomationApiHttpClients
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<IAutomationActivityApi, AutomationActivityApi>(client));
            builders.Add(_services.AddHttpClient<IAutomationAssetsV2Api, AutomationAssetsV2Api>(client));
            builders.Add(_services.AddHttpClient<IAutomationChainApi, AutomationChainApi>(client));
            builders.Add(_services.AddHttpClient<IAutomationExchangeApi, AutomationExchangeApi>(client));
            builders.Add(_services.AddHttpClient<IAutomationGameApi, AutomationGameApi>(client));
            builders.Add(_services.AddHttpClient<IAutomationHealthApi, AutomationHealthApi>(client));
            builders.Add(_services.AddHttpClient<IAutomationMarketplaceV2Api, AutomationMarketplaceV2Api>(client));
            builders.Add(_services.AddHttpClient<IAutomationPolicyApi, AutomationPolicyApi>(client));
            builders.Add(_services.AddHttpClient<IAutomationProfilesApi, AutomationProfilesApi>(client));
            builders.Add(_services.AddHttpClient<IAutomationReportingApi, AutomationReportingApi>(client));
            builders.Add(_services.AddHttpClient<IAutomationStatsApi, AutomationStatsApi>(client));
            builders.Add(_services.AddHttpClient<IAutomationTradingApi, AutomationTradingApi>(client));
            builders.Add(_services.AddHttpClient<IAutomationTransactionsV2Api, AutomationTransactionsV2Api>(client));
            builders.Add(_services.AddHttpClient<IAutomationWebhooksApi, AutomationWebhooksApi>(client));
            
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
        public AutomationHostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
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
        public AutomationHostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public AutomationHostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
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
        public AutomationHostConfiguration UseProvider<TTokenProvider, TTokenBase>()
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}
