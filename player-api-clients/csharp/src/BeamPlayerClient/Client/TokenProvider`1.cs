// <auto-generated>
/*
 * Beam self custody API
 *
 * The Beam self custody API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Linq;
using System.Collections.Generic;
using BeamPlayerClient.Client;

namespace BeamPlayerClient
{
    /// <summary>
    /// A class which will provide tokens.
    /// </summary>
    public abstract class TokenProvider<TTokenBase> where TTokenBase : TokenBase
    {
        /// <summary>
        /// The array of tokens.
        /// </summary>
        protected TTokenBase[] _tokens;

        /// <summary>
        /// Sets the new token as a single token for the provider.
        /// </summary>
        public abstract void SetToken(TTokenBase newToken);

        public abstract System.Threading.Tasks.ValueTask<TTokenBase> GetAsync(string header = "x-api-key", System.Threading.CancellationToken cancellation = default);

        /// <summary>
        /// Instantiates a TokenProvider.
        /// </summary>
        /// <param name="tokens"></param>
        public TokenProvider(IEnumerable<TTokenBase> tokens)
        {
            _tokens = tokens.ToArray();

            if (_tokens.Length == 0)
                throw new ArgumentException("You did not provide any tokens.");
        }
    }

    /// <summary>
    /// Provides a token to the api clients. Your tokens will be used directly.
    /// </summary>
    /// <typeparam name="TTokenBase"></typeparam>
    public class SimpleApiKeyTokenProvider<TTokenBase> : TokenProvider<TTokenBase> where TTokenBase : ApiKeyToken
    {
        /// <summary>
        /// Instantiates a SimpleTokenProvider. Your tokens will be used directly.
        /// </summary>
        /// <param name="container"></param>
        public SimpleApiKeyTokenProvider(TokenContainer<TTokenBase> container) : base(container.Tokens)
        {
        }

        public override async System.Threading.Tasks.ValueTask<TTokenBase> GetAsync(string header = "x-api-key", System.Threading.CancellationToken cancellation = default)
            => _tokens.FirstOrDefault(t => string.Equals(t.Header, header, StringComparison.OrdinalIgnoreCase));


        /// <summary>
        /// Sets the new token as a single token for the provider.
        /// </summary>
        public override void SetToken(TTokenBase newToken)
        {
            _tokens = new TTokenBase[1] { newToken };
        }
    }
}