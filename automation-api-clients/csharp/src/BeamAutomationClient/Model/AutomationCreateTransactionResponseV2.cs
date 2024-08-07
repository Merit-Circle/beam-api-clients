// <auto-generated>
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
using OpenAPIClientUtils = BeamAutomationClient.Client.ClientUtils;
using BeamAutomationClient.Client;

namespace BeamAutomationClient.Model
{
    /// <summary>
    /// AutomationCreateTransactionResponseV2
    /// </summary>
    public partial class AutomationCreateTransactionResponseV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationCreateTransactionResponseV2" /> class.
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
        public AutomationCreateTransactionResponseV2(decimal chainId, DateTime createdAt, string id, AutomationGetTransactionsResponseV2DataInnerIntent intent, AutomationGetTransactionResponseV2Policy policy, AutomationGetTransactionResponseV2Profile profile, DateTime updatedAt, Option<AutomationGetTransactionsResponseV2DataInnerTransaction?> transaction = default)
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
        public AutomationGetTransactionsResponseV2DataInnerIntent Intent { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [JsonPropertyName("policy")]
        public AutomationGetTransactionResponseV2Policy Policy { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [JsonPropertyName("profile")]
        public AutomationGetTransactionResponseV2Profile Profile { get; set; }

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
        public Option<AutomationGetTransactionsResponseV2DataInnerTransaction?> TransactionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [JsonPropertyName("transaction")]
        public AutomationGetTransactionsResponseV2DataInnerTransaction? Transaction { get { return this. TransactionOption; } set { this.TransactionOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationCreateTransactionResponseV2 {\n");
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
    /// A Json converter for type <see cref="AutomationCreateTransactionResponseV2" />
    /// </summary>
    public class AutomationCreateTransactionResponseV2JsonConverter : JsonConverter<AutomationCreateTransactionResponseV2>
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
        /// Deserializes json to <see cref="AutomationCreateTransactionResponseV2" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationCreateTransactionResponseV2 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> chainId = default;
            Option<DateTime?> createdAt = default;
            Option<string?> id = default;
            Option<AutomationGetTransactionsResponseV2DataInnerIntent?> intent = default;
            Option<AutomationGetTransactionResponseV2Policy?> policy = default;
            Option<AutomationGetTransactionResponseV2Profile?> profile = default;
            Option<DateTime?> updatedAt = default;
            Option<AutomationGetTransactionsResponseV2DataInnerTransaction?> transaction = default;

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
                                intent = new Option<AutomationGetTransactionsResponseV2DataInnerIntent?>(JsonSerializer.Deserialize<AutomationGetTransactionsResponseV2DataInnerIntent>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "policy":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                policy = new Option<AutomationGetTransactionResponseV2Policy?>(JsonSerializer.Deserialize<AutomationGetTransactionResponseV2Policy>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "profile":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                profile = new Option<AutomationGetTransactionResponseV2Profile?>(JsonSerializer.Deserialize<AutomationGetTransactionResponseV2Profile>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "transaction":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transaction = new Option<AutomationGetTransactionsResponseV2DataInnerTransaction?>(JsonSerializer.Deserialize<AutomationGetTransactionsResponseV2DataInnerTransaction>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateTransactionResponseV2.", nameof(chainId));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateTransactionResponseV2.", nameof(createdAt));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateTransactionResponseV2.", nameof(id));

            if (!intent.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateTransactionResponseV2.", nameof(intent));

            if (!policy.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateTransactionResponseV2.", nameof(policy));

            if (!profile.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateTransactionResponseV2.", nameof(profile));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateTransactionResponseV2.", nameof(updatedAt));

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class AutomationCreateTransactionResponseV2.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class AutomationCreateTransactionResponseV2.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class AutomationCreateTransactionResponseV2.");

            if (intent.IsSet && intent.Value == null)
                throw new ArgumentNullException(nameof(intent), "Property is not nullable for class AutomationCreateTransactionResponseV2.");

            if (policy.IsSet && policy.Value == null)
                throw new ArgumentNullException(nameof(policy), "Property is not nullable for class AutomationCreateTransactionResponseV2.");

            if (profile.IsSet && profile.Value == null)
                throw new ArgumentNullException(nameof(profile), "Property is not nullable for class AutomationCreateTransactionResponseV2.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class AutomationCreateTransactionResponseV2.");

            return new AutomationCreateTransactionResponseV2(chainId.Value!.Value!, createdAt.Value!.Value!, id.Value!, intent.Value!, policy.Value!, profile.Value!, updatedAt.Value!.Value!, transaction);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationCreateTransactionResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationCreateTransactionResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationCreateTransactionResponseV2 automationCreateTransactionResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, automationCreateTransactionResponseV2, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationCreateTransactionResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationCreateTransactionResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AutomationCreateTransactionResponseV2 automationCreateTransactionResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationCreateTransactionResponseV2.Id == null)
                throw new ArgumentNullException(nameof(automationCreateTransactionResponseV2.Id), "Property is required for class AutomationCreateTransactionResponseV2.");

            if (automationCreateTransactionResponseV2.Intent == null)
                throw new ArgumentNullException(nameof(automationCreateTransactionResponseV2.Intent), "Property is required for class AutomationCreateTransactionResponseV2.");

            if (automationCreateTransactionResponseV2.Policy == null)
                throw new ArgumentNullException(nameof(automationCreateTransactionResponseV2.Policy), "Property is required for class AutomationCreateTransactionResponseV2.");

            if (automationCreateTransactionResponseV2.Profile == null)
                throw new ArgumentNullException(nameof(automationCreateTransactionResponseV2.Profile), "Property is required for class AutomationCreateTransactionResponseV2.");

            writer.WriteNumber("chainId", automationCreateTransactionResponseV2.ChainId);

            writer.WriteString("createdAt", automationCreateTransactionResponseV2.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("id", automationCreateTransactionResponseV2.Id);

            writer.WritePropertyName("intent");
            JsonSerializer.Serialize(writer, automationCreateTransactionResponseV2.Intent, jsonSerializerOptions);
            writer.WritePropertyName("policy");
            JsonSerializer.Serialize(writer, automationCreateTransactionResponseV2.Policy, jsonSerializerOptions);
            writer.WritePropertyName("profile");
            JsonSerializer.Serialize(writer, automationCreateTransactionResponseV2.Profile, jsonSerializerOptions);
            writer.WriteString("updatedAt", automationCreateTransactionResponseV2.UpdatedAt.ToString(UpdatedAtFormat));

            if (automationCreateTransactionResponseV2.TransactionOption.IsSet)
                if (automationCreateTransactionResponseV2.TransactionOption.Value != null)
                {
                    writer.WritePropertyName("transaction");
                    JsonSerializer.Serialize(writer, automationCreateTransactionResponseV2.Transaction, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("transaction");
        }
    }
}