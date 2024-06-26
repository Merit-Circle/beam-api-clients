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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = BeamPlayerClient.Client.ClientUtils;
using BeamPlayerClient.Client;

namespace BeamPlayerClient.Model
{
    /// <summary>
    /// GetTransactionResponse
    /// </summary>
    public partial class GetTransactionResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionResponse" /> class.
        /// </summary>
        /// <param name="chainId">chainId</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="id">id</param>
        /// <param name="intent">intent</param>
        /// <param name="policy">policy</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="user">user</param>
        /// <param name="transaction">transaction</param>
        [JsonConstructor]
        public GetTransactionResponse(decimal chainId, DateTime createdAt, string id, GetTransactionsResponseDataInnerIntent intent, GetTransactionResponsePolicy policy, DateTime updatedAt, GetTransactionResponseUser user, Option<GetTransactionsResponseDataInnerTransaction?> transaction = default)
        {
            ChainId = chainId;
            CreatedAt = createdAt;
            Id = id;
            Intent = intent;
            Policy = policy;
            UpdatedAt = updatedAt;
            User = user;
            TransactionOption = transaction;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public decimal ChainId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Intent
        /// </summary>
        [JsonPropertyName("intent")]
        public GetTransactionsResponseDataInnerIntent Intent { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [JsonPropertyName("policy")]
        public GetTransactionResponsePolicy Policy { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [JsonPropertyName("user")]
        public GetTransactionResponseUser User { get; set; }

        /// <summary>
        /// Used to track the state of Transaction
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<GetTransactionsResponseDataInnerTransaction?> TransactionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [JsonPropertyName("transaction")]
        public GetTransactionsResponseDataInnerTransaction? Transaction { get { return this. TransactionOption; } set { this.TransactionOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionResponse {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="GetTransactionResponse" />
    /// </summary>
    public class GetTransactionResponseJsonConverter : JsonConverter<GetTransactionResponse>
    {
        /// <summary>
        /// The format to use to serialize CreatedAt
        /// </summary>
        public static string CreatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UpdatedAt
        /// </summary>
        public static string UpdatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="GetTransactionResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetTransactionResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> chainId = default;
            Option<DateTime?> createdAt = default;
            Option<string?> id = default;
            Option<GetTransactionsResponseDataInnerIntent?> intent = default;
            Option<GetTransactionResponsePolicy?> policy = default;
            Option<DateTime?> updatedAt = default;
            Option<GetTransactionResponseUser?> user = default;
            Option<GetTransactionsResponseDataInnerTransaction?> transaction = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "intent":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                intent = new Option<GetTransactionsResponseDataInnerIntent?>(JsonSerializer.Deserialize<GetTransactionsResponseDataInnerIntent>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "policy":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                policy = new Option<GetTransactionResponsePolicy?>(JsonSerializer.Deserialize<GetTransactionResponsePolicy>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "user":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                user = new Option<GetTransactionResponseUser?>(JsonSerializer.Deserialize<GetTransactionResponseUser>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "transaction":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transaction = new Option<GetTransactionsResponseDataInnerTransaction?>(JsonSerializer.Deserialize<GetTransactionsResponseDataInnerTransaction>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponse.", nameof(chainId));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponse.", nameof(createdAt));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponse.", nameof(id));

            if (!intent.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponse.", nameof(intent));

            if (!policy.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponse.", nameof(policy));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponse.", nameof(updatedAt));

            if (!user.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponse.", nameof(user));

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class GetTransactionResponse.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class GetTransactionResponse.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GetTransactionResponse.");

            if (intent.IsSet && intent.Value == null)
                throw new ArgumentNullException(nameof(intent), "Property is not nullable for class GetTransactionResponse.");

            if (policy.IsSet && policy.Value == null)
                throw new ArgumentNullException(nameof(policy), "Property is not nullable for class GetTransactionResponse.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class GetTransactionResponse.");

            if (user.IsSet && user.Value == null)
                throw new ArgumentNullException(nameof(user), "Property is not nullable for class GetTransactionResponse.");

            return new GetTransactionResponse(chainId.Value!.Value!, createdAt.Value!.Value!, id.Value!, intent.Value!, policy.Value!, updatedAt.Value!.Value!, user.Value!, transaction);
        }

        /// <summary>
        /// Serializes a <see cref="GetTransactionResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetTransactionResponse getTransactionResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getTransactionResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetTransactionResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetTransactionResponse getTransactionResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getTransactionResponse.Id == null)
                throw new ArgumentNullException(nameof(getTransactionResponse.Id), "Property is required for class GetTransactionResponse.");

            if (getTransactionResponse.Intent == null)
                throw new ArgumentNullException(nameof(getTransactionResponse.Intent), "Property is required for class GetTransactionResponse.");

            if (getTransactionResponse.Policy == null)
                throw new ArgumentNullException(nameof(getTransactionResponse.Policy), "Property is required for class GetTransactionResponse.");

            if (getTransactionResponse.User == null)
                throw new ArgumentNullException(nameof(getTransactionResponse.User), "Property is required for class GetTransactionResponse.");

            writer.WriteNumber("chainId", getTransactionResponse.ChainId);

            writer.WriteString("createdAt", getTransactionResponse.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("id", getTransactionResponse.Id);

            writer.WritePropertyName("intent");
            JsonSerializer.Serialize(writer, getTransactionResponse.Intent, jsonSerializerOptions);
            writer.WritePropertyName("policy");
            JsonSerializer.Serialize(writer, getTransactionResponse.Policy, jsonSerializerOptions);
            writer.WriteString("updatedAt", getTransactionResponse.UpdatedAt.ToString(UpdatedAtFormat));

            writer.WritePropertyName("user");
            JsonSerializer.Serialize(writer, getTransactionResponse.User, jsonSerializerOptions);
            if (getTransactionResponse.TransactionOption.IsSet)
                if (getTransactionResponse.TransactionOption.Value != null)
                {
                    writer.WritePropertyName("transaction");
                    JsonSerializer.Serialize(writer, getTransactionResponse.Transaction, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("transaction");
        }
    }
}