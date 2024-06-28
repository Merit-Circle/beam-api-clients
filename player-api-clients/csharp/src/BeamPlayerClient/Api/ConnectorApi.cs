// <auto-generated>
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
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using BeamPlayerClient.Client;
using BeamPlayerClient.Model;
using System.Diagnostics.CodeAnalysis;

namespace BeamPlayerClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IConnectorApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        ConnectorApiEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="createConnectionRequestInput"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICreateConnectionRequestApiResponse"/>&gt;</returns>
        Task<ICreateConnectionRequestApiResponse> CreateConnectionRequestAsync(CreateConnectionRequestInput createConnectionRequestInput, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="createConnectionRequestInput"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICreateConnectionRequestApiResponse"/>?&gt;</returns>
        Task<ICreateConnectionRequestApiResponse?> CreateConnectionRequestOrDefaultAsync(CreateConnectionRequestInput createConnectionRequestInput, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetConnectionRequestApiResponse"/>&gt;</returns>
        Task<IGetConnectionRequestApiResponse> GetConnectionRequestAsync(string requestId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetConnectionRequestApiResponse"/>?&gt;</returns>
        Task<IGetConnectionRequestApiResponse?> GetConnectionRequestOrDefaultAsync(string requestId, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="ICreateConnectionRequestApiResponse"/>
    /// </summary>
    public interface ICreateConnectionRequestApiResponse : BeamPlayerClient.Client.IApiResponse, IOk<BeamPlayerClient.Model.CreateConnectionRequestResponse?>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }
    }

    /// <summary>
    /// The <see cref="IGetConnectionRequestApiResponse"/>
    /// </summary>
    public interface IGetConnectionRequestApiResponse : BeamPlayerClient.Client.IApiResponse, IOk<BeamPlayerClient.Model.GetConnectionRequestResponse?>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConnectorApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnCreateConnectionRequest;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorCreateConnectionRequest;

        internal void ExecuteOnCreateConnectionRequest(ConnectorApi.CreateConnectionRequestApiResponse apiResponse)
        {
            OnCreateConnectionRequest?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorCreateConnectionRequest(Exception exception)
        {
            OnErrorCreateConnectionRequest?.Invoke(this, new ExceptionEventArgs(exception));
        }

        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnGetConnectionRequest;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorGetConnectionRequest;

        internal void ExecuteOnGetConnectionRequest(ConnectorApi.GetConnectionRequestApiResponse apiResponse)
        {
            OnGetConnectionRequest?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorGetConnectionRequest(Exception exception)
        {
            OnErrorGetConnectionRequest?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class ConnectorApi : IConnectorApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<ConnectorApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public ConnectorApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectorApi(ILogger<ConnectorApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, ConnectorApiEvents connectorApiEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<ConnectorApi>();
            HttpClient = httpClient;
            Events = connectorApiEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatCreateConnectionRequest(CreateConnectionRequestInput createConnectionRequestInput);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="createConnectionRequestInput"></param>
        /// <returns></returns>
        private void ValidateCreateConnectionRequest(CreateConnectionRequestInput createConnectionRequestInput)
        {
            if (createConnectionRequestInput == null)
                throw new ArgumentNullException(nameof(createConnectionRequestInput));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="createConnectionRequestInput"></param>
        private void AfterCreateConnectionRequestDefaultImplementation(ICreateConnectionRequestApiResponse apiResponseLocalVar, CreateConnectionRequestInput createConnectionRequestInput)
        {
            bool suppressDefaultLog = false;
            AfterCreateConnectionRequest(ref suppressDefaultLog, apiResponseLocalVar, createConnectionRequestInput);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="createConnectionRequestInput"></param>
        partial void AfterCreateConnectionRequest(ref bool suppressDefaultLog, ICreateConnectionRequestApiResponse apiResponseLocalVar, CreateConnectionRequestInput createConnectionRequestInput);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="createConnectionRequestInput"></param>
        private void OnErrorCreateConnectionRequestDefaultImplementation(Exception exception, string pathFormat, string path, CreateConnectionRequestInput createConnectionRequestInput)
        {
            bool suppressDefaultLog = false;
            OnErrorCreateConnectionRequest(ref suppressDefaultLog, exception, pathFormat, path, createConnectionRequestInput);
            if (!suppressDefaultLog)
                Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="createConnectionRequestInput"></param>
        partial void OnErrorCreateConnectionRequest(ref bool suppressDefaultLog, Exception exception, string pathFormat, string path, CreateConnectionRequestInput createConnectionRequestInput);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="createConnectionRequestInput"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICreateConnectionRequestApiResponse"/>&gt;</returns>
        public async Task<ICreateConnectionRequestApiResponse?> CreateConnectionRequestOrDefaultAsync(CreateConnectionRequestInput createConnectionRequestInput, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await CreateConnectionRequestAsync(createConnectionRequestInput, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="createConnectionRequestInput"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICreateConnectionRequestApiResponse"/>&gt;</returns>
        public async Task<ICreateConnectionRequestApiResponse> CreateConnectionRequestAsync(CreateConnectionRequestInput createConnectionRequestInput, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateCreateConnectionRequest(createConnectionRequestInput);

                FormatCreateConnectionRequest(createConnectionRequestInput);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/v1/connection/request";

                    httpRequestMessageLocalVar.Content = (createConnectionRequestInput as object) is System.IO.Stream stream
                        ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                        : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(createConnectionRequestInput, _jsonSerializerOptions));

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    ApiKeyToken apiKeyTokenLocalVar1 = (ApiKeyToken) await ApiKeyProvider.GetAsync("x-api-key", cancellationToken).ConfigureAwait(false);
                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar1);
                    apiKeyTokenLocalVar1.UseInHeader(httpRequestMessageLocalVar);

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] contentTypes = new string[] {
                        "application/json"
                    };

                    string? contentTypeLocalVar = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentTypeLocalVar != null && httpRequestMessageLocalVar.Content != null)
                        httpRequestMessageLocalVar.Content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeLocalVar);

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Post;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<CreateConnectionRequestApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<CreateConnectionRequestApiResponse>();

                        CreateConnectionRequestApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/v1/connection/request", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterCreateConnectionRequestDefaultImplementation(apiResponseLocalVar, createConnectionRequestInput);

                        Events.ExecuteOnCreateConnectionRequest(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorCreateConnectionRequestDefaultImplementation(e, "/v1/connection/request", uriBuilderLocalVar.Path, createConnectionRequestInput);
                Events.ExecuteOnErrorCreateConnectionRequest(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="CreateConnectionRequestApiResponse"/>
        /// </summary>
        public partial class CreateConnectionRequestApiResponse : BeamPlayerClient.Client.ApiResponse, ICreateConnectionRequestApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<CreateConnectionRequestApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="CreateConnectionRequestApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public CreateConnectionRequestApiResponse(ILogger<CreateConnectionRequestApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public BeamPlayerClient.Model.CreateConnectionRequestResponse? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<BeamPlayerClient.Model.CreateConnectionRequestResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out BeamPlayerClient.Model.CreateConnectionRequestResponse? result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }

        partial void FormatGetConnectionRequest(ref string requestId);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        private void ValidateGetConnectionRequest(string requestId)
        {
            if (requestId == null)
                throw new ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="requestId"></param>
        private void AfterGetConnectionRequestDefaultImplementation(IGetConnectionRequestApiResponse apiResponseLocalVar, string requestId)
        {
            bool suppressDefaultLog = false;
            AfterGetConnectionRequest(ref suppressDefaultLog, apiResponseLocalVar, requestId);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="requestId"></param>
        partial void AfterGetConnectionRequest(ref bool suppressDefaultLog, IGetConnectionRequestApiResponse apiResponseLocalVar, string requestId);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="requestId"></param>
        private void OnErrorGetConnectionRequestDefaultImplementation(Exception exception, string pathFormat, string path, string requestId)
        {
            bool suppressDefaultLog = false;
            OnErrorGetConnectionRequest(ref suppressDefaultLog, exception, pathFormat, path, requestId);
            if (!suppressDefaultLog)
                Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="requestId"></param>
        partial void OnErrorGetConnectionRequest(ref bool suppressDefaultLog, Exception exception, string pathFormat, string path, string requestId);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetConnectionRequestApiResponse"/>&gt;</returns>
        public async Task<IGetConnectionRequestApiResponse?> GetConnectionRequestOrDefaultAsync(string requestId, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetConnectionRequestAsync(requestId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetConnectionRequestApiResponse"/>&gt;</returns>
        public async Task<IGetConnectionRequestApiResponse> GetConnectionRequestAsync(string requestId, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateGetConnectionRequest(requestId);

                FormatGetConnectionRequest(ref requestId);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/v1/connection/request/{requestId}";
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BrequestId%7D", Uri.EscapeDataString(requestId.ToString()));

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    ApiKeyToken apiKeyTokenLocalVar1 = (ApiKeyToken) await ApiKeyProvider.GetAsync("x-api-key", cancellationToken).ConfigureAwait(false);
                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar1);
                    apiKeyTokenLocalVar1.UseInHeader(httpRequestMessageLocalVar);

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Get;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<GetConnectionRequestApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<GetConnectionRequestApiResponse>();

                        GetConnectionRequestApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/v1/connection/request/{requestId}", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetConnectionRequestDefaultImplementation(apiResponseLocalVar, requestId);

                        Events.ExecuteOnGetConnectionRequest(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetConnectionRequestDefaultImplementation(e, "/v1/connection/request/{requestId}", uriBuilderLocalVar.Path, requestId);
                Events.ExecuteOnErrorGetConnectionRequest(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="GetConnectionRequestApiResponse"/>
        /// </summary>
        public partial class GetConnectionRequestApiResponse : BeamPlayerClient.Client.ApiResponse, IGetConnectionRequestApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<GetConnectionRequestApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="GetConnectionRequestApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public GetConnectionRequestApiResponse(ILogger<GetConnectionRequestApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public BeamPlayerClient.Model.GetConnectionRequestResponse? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<BeamPlayerClient.Model.GetConnectionRequestResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out BeamPlayerClient.Model.GetConnectionRequestResponse? result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}
