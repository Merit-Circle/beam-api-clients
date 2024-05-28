// <auto-generated>
/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
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
using OpenAPIClientUtils = Beam.Client.ClientUtils;
using Beam.Client;

namespace Beam.Model
{
    /// <summary>
    /// GetTransactionResponseV2
    /// </summary>
    public partial class GetTransactionResponseV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionResponseV2" /> class.
        /// </summary>
        /// <param name="chainId">chainId</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="id">id</param>
        /// <param name="intent">intent</param>
        /// <param name="policy">policy</param>
        /// <param name="profile">profile</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="transaction">transaction</param>
        [JsonConstructor]
        public GetTransactionResponseV2(decimal chainId, DateTime createdAt, string id, GetTransactionsResponseV2DataInnerIntent intent, GetTransactionResponseV2Policy policy, GetTransactionResponseV2Profile profile, DateTime updatedAt, Option<GetTransactionsResponseV2DataInnerTransaction?> transaction = default)
        {
            ChainId = chainId;
            CreatedAt = createdAt;
            Id = id;
            Intent = intent;
            Policy = policy;
            Profile = profile;
            UpdatedAt = updatedAt;
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
        public GetTransactionsResponseV2DataInnerIntent Intent { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [JsonPropertyName("policy")]
        public GetTransactionResponseV2Policy Policy { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [JsonPropertyName("profile")]
        public GetTransactionResponseV2Profile Profile { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Used to track the state of Transaction
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<GetTransactionsResponseV2DataInnerTransaction?> TransactionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [JsonPropertyName("transaction")]
        public GetTransactionsResponseV2DataInnerTransaction? Transaction { get { return this. TransactionOption; } set { this.TransactionOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionResponseV2 {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
    /// A Json converter for type <see cref="GetTransactionResponseV2" />
    /// </summary>
    public class GetTransactionResponseV2JsonConverter : JsonConverter<GetTransactionResponseV2>
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
        /// Deserializes json to <see cref="GetTransactionResponseV2" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetTransactionResponseV2 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> chainId = default;
            Option<DateTime?> createdAt = default;
            Option<string?> id = default;
            Option<GetTransactionsResponseV2DataInnerIntent?> intent = default;
            Option<GetTransactionResponseV2Policy?> policy = default;
            Option<GetTransactionResponseV2Profile?> profile = default;
            Option<DateTime?> updatedAt = default;
            Option<GetTransactionsResponseV2DataInnerTransaction?> transaction = default;

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
                                intent = new Option<GetTransactionsResponseV2DataInnerIntent?>(JsonSerializer.Deserialize<GetTransactionsResponseV2DataInnerIntent>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "policy":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                policy = new Option<GetTransactionResponseV2Policy?>(JsonSerializer.Deserialize<GetTransactionResponseV2Policy>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "profile":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                profile = new Option<GetTransactionResponseV2Profile?>(JsonSerializer.Deserialize<GetTransactionResponseV2Profile>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "transaction":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transaction = new Option<GetTransactionsResponseV2DataInnerTransaction?>(JsonSerializer.Deserialize<GetTransactionsResponseV2DataInnerTransaction>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponseV2.", nameof(chainId));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponseV2.", nameof(createdAt));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponseV2.", nameof(id));

            if (!intent.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponseV2.", nameof(intent));

            if (!policy.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponseV2.", nameof(policy));

            if (!profile.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponseV2.", nameof(profile));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponseV2.", nameof(updatedAt));

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class GetTransactionResponseV2.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class GetTransactionResponseV2.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GetTransactionResponseV2.");

            if (intent.IsSet && intent.Value == null)
                throw new ArgumentNullException(nameof(intent), "Property is not nullable for class GetTransactionResponseV2.");

            if (policy.IsSet && policy.Value == null)
                throw new ArgumentNullException(nameof(policy), "Property is not nullable for class GetTransactionResponseV2.");

            if (profile.IsSet && profile.Value == null)
                throw new ArgumentNullException(nameof(profile), "Property is not nullable for class GetTransactionResponseV2.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class GetTransactionResponseV2.");

            return new GetTransactionResponseV2(chainId.Value!.Value!, createdAt.Value!.Value!, id.Value!, intent.Value!, policy.Value!, profile.Value!, updatedAt.Value!.Value!, transaction);
        }

        /// <summary>
        /// Serializes a <see cref="GetTransactionResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetTransactionResponseV2 getTransactionResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getTransactionResponseV2, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetTransactionResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetTransactionResponseV2 getTransactionResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getTransactionResponseV2.Id == null)
                throw new ArgumentNullException(nameof(getTransactionResponseV2.Id), "Property is required for class GetTransactionResponseV2.");

            if (getTransactionResponseV2.Intent == null)
                throw new ArgumentNullException(nameof(getTransactionResponseV2.Intent), "Property is required for class GetTransactionResponseV2.");

            if (getTransactionResponseV2.Policy == null)
                throw new ArgumentNullException(nameof(getTransactionResponseV2.Policy), "Property is required for class GetTransactionResponseV2.");

            if (getTransactionResponseV2.Profile == null)
                throw new ArgumentNullException(nameof(getTransactionResponseV2.Profile), "Property is required for class GetTransactionResponseV2.");

            writer.WriteNumber("chainId", getTransactionResponseV2.ChainId);

            writer.WriteString("createdAt", getTransactionResponseV2.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("id", getTransactionResponseV2.Id);

            writer.WritePropertyName("intent");
            JsonSerializer.Serialize(writer, getTransactionResponseV2.Intent, jsonSerializerOptions);
            writer.WritePropertyName("policy");
            JsonSerializer.Serialize(writer, getTransactionResponseV2.Policy, jsonSerializerOptions);
            writer.WritePropertyName("profile");
            JsonSerializer.Serialize(writer, getTransactionResponseV2.Profile, jsonSerializerOptions);
            writer.WriteString("updatedAt", getTransactionResponseV2.UpdatedAt.ToString(UpdatedAtFormat));

            if (getTransactionResponseV2.TransactionOption.IsSet)
                if (getTransactionResponseV2.TransactionOption.Value != null)
                {
                    writer.WritePropertyName("transaction");
                    JsonSerializer.Serialize(writer, getTransactionResponseV2.Transaction, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("transaction");
        }
    }
}