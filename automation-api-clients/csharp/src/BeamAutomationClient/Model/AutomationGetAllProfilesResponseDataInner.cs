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
    /// AutomationGetAllProfilesResponseDataInner
    /// </summary>
    public partial class AutomationGetAllProfilesResponseDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationGetAllProfilesResponseDataInner" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt</param>
        /// <param name="externalEntityId">externalEntityId</param>
        /// <param name="externalId">externalId</param>
        /// <param name="gameId">gameId</param>
        /// <param name="id">id</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="wallets">wallets</param>
        /// <param name="userConnectionCreatedAt">userConnectionCreatedAt</param>
        /// <param name="userId">userId</param>
        [JsonConstructor]
        public AutomationGetAllProfilesResponseDataInner(DateTime createdAt, string externalEntityId, string externalId, string gameId, string id, DateTime updatedAt, List<AutomationCreateProfileResponseWalletsInner> wallets, Option<DateTime?> userConnectionCreatedAt = default, string? userId = default)
        {
            CreatedAt = createdAt;
            ExternalEntityId = externalEntityId;
            ExternalId = externalId;
            GameId = gameId;
            Id = id;
            UpdatedAt = updatedAt;
            Wallets = wallets;
            UserConnectionCreatedAtOption = userConnectionCreatedAt;
            UserId = userId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ExternalEntityId
        /// </summary>
        [JsonPropertyName("externalEntityId")]
        public string ExternalEntityId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [JsonPropertyName("gameId")]
        public string GameId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Wallets
        /// </summary>
        [JsonPropertyName("wallets")]
        public List<AutomationCreateProfileResponseWalletsInner> Wallets { get; set; }

        /// <summary>
        /// Used to track the state of UserConnectionCreatedAt
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> UserConnectionCreatedAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets UserConnectionCreatedAt
        /// </summary>
        [JsonPropertyName("userConnectionCreatedAt")]
        public DateTime? UserConnectionCreatedAt { get { return this. UserConnectionCreatedAtOption; } set { this.UserConnectionCreatedAtOption = new(value); } }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationGetAllProfilesResponseDataInner {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExternalEntityId: ").Append(ExternalEntityId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Wallets: ").Append(Wallets).Append("\n");
            sb.Append("  UserConnectionCreatedAt: ").Append(UserConnectionCreatedAt).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
    /// A Json converter for type <see cref="AutomationGetAllProfilesResponseDataInner" />
    /// </summary>
    public class AutomationGetAllProfilesResponseDataInnerJsonConverter : JsonConverter<AutomationGetAllProfilesResponseDataInner>
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
        /// The format to use to serialize UserConnectionCreatedAt
        /// </summary>
        public static string UserConnectionCreatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="AutomationGetAllProfilesResponseDataInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationGetAllProfilesResponseDataInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime?> createdAt = default;
            Option<string?> externalEntityId = default;
            Option<string?> externalId = default;
            Option<string?> gameId = default;
            Option<string?> id = default;
            Option<DateTime?> updatedAt = default;
            Option<List<AutomationCreateProfileResponseWalletsInner>?> wallets = default;
            Option<DateTime?> userConnectionCreatedAt = default;
            Option<string?> userId = default;

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
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "externalEntityId":
                            externalEntityId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "externalId":
                            externalId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "gameId":
                            gameId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "wallets":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                wallets = new Option<List<AutomationCreateProfileResponseWalletsInner>?>(JsonSerializer.Deserialize<List<AutomationCreateProfileResponseWalletsInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "userConnectionCreatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                userConnectionCreatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "userId":
                            userId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAllProfilesResponseDataInner.", nameof(createdAt));

            if (!externalEntityId.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAllProfilesResponseDataInner.", nameof(externalEntityId));

            if (!externalId.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAllProfilesResponseDataInner.", nameof(externalId));

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAllProfilesResponseDataInner.", nameof(gameId));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAllProfilesResponseDataInner.", nameof(id));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAllProfilesResponseDataInner.", nameof(updatedAt));

            if (!wallets.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAllProfilesResponseDataInner.", nameof(wallets));

            if (!userId.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAllProfilesResponseDataInner.", nameof(userId));

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class AutomationGetAllProfilesResponseDataInner.");

            if (externalEntityId.IsSet && externalEntityId.Value == null)
                throw new ArgumentNullException(nameof(externalEntityId), "Property is not nullable for class AutomationGetAllProfilesResponseDataInner.");

            if (externalId.IsSet && externalId.Value == null)
                throw new ArgumentNullException(nameof(externalId), "Property is not nullable for class AutomationGetAllProfilesResponseDataInner.");

            if (gameId.IsSet && gameId.Value == null)
                throw new ArgumentNullException(nameof(gameId), "Property is not nullable for class AutomationGetAllProfilesResponseDataInner.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class AutomationGetAllProfilesResponseDataInner.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class AutomationGetAllProfilesResponseDataInner.");

            if (wallets.IsSet && wallets.Value == null)
                throw new ArgumentNullException(nameof(wallets), "Property is not nullable for class AutomationGetAllProfilesResponseDataInner.");

            return new AutomationGetAllProfilesResponseDataInner(createdAt.Value!.Value!, externalEntityId.Value!, externalId.Value!, gameId.Value!, id.Value!, updatedAt.Value!.Value!, wallets.Value!, userConnectionCreatedAt, userId.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationGetAllProfilesResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetAllProfilesResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationGetAllProfilesResponseDataInner automationGetAllProfilesResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, automationGetAllProfilesResponseDataInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationGetAllProfilesResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetAllProfilesResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AutomationGetAllProfilesResponseDataInner automationGetAllProfilesResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationGetAllProfilesResponseDataInner.ExternalEntityId == null)
                throw new ArgumentNullException(nameof(automationGetAllProfilesResponseDataInner.ExternalEntityId), "Property is required for class AutomationGetAllProfilesResponseDataInner.");

            if (automationGetAllProfilesResponseDataInner.ExternalId == null)
                throw new ArgumentNullException(nameof(automationGetAllProfilesResponseDataInner.ExternalId), "Property is required for class AutomationGetAllProfilesResponseDataInner.");

            if (automationGetAllProfilesResponseDataInner.GameId == null)
                throw new ArgumentNullException(nameof(automationGetAllProfilesResponseDataInner.GameId), "Property is required for class AutomationGetAllProfilesResponseDataInner.");

            if (automationGetAllProfilesResponseDataInner.Id == null)
                throw new ArgumentNullException(nameof(automationGetAllProfilesResponseDataInner.Id), "Property is required for class AutomationGetAllProfilesResponseDataInner.");

            if (automationGetAllProfilesResponseDataInner.Wallets == null)
                throw new ArgumentNullException(nameof(automationGetAllProfilesResponseDataInner.Wallets), "Property is required for class AutomationGetAllProfilesResponseDataInner.");

            writer.WriteString("createdAt", automationGetAllProfilesResponseDataInner.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("externalEntityId", automationGetAllProfilesResponseDataInner.ExternalEntityId);

            writer.WriteString("externalId", automationGetAllProfilesResponseDataInner.ExternalId);

            writer.WriteString("gameId", automationGetAllProfilesResponseDataInner.GameId);

            writer.WriteString("id", automationGetAllProfilesResponseDataInner.Id);

            writer.WriteString("updatedAt", automationGetAllProfilesResponseDataInner.UpdatedAt.ToString(UpdatedAtFormat));

            writer.WritePropertyName("wallets");
            JsonSerializer.Serialize(writer, automationGetAllProfilesResponseDataInner.Wallets, jsonSerializerOptions);
            if (automationGetAllProfilesResponseDataInner.UserConnectionCreatedAtOption.IsSet)
                if (automationGetAllProfilesResponseDataInner.UserConnectionCreatedAtOption.Value != null)
                    writer.WriteString("userConnectionCreatedAt", automationGetAllProfilesResponseDataInner.UserConnectionCreatedAtOption.Value!.Value.ToString(UserConnectionCreatedAtFormat));
                else
                    writer.WriteNull("userConnectionCreatedAt");

            if (automationGetAllProfilesResponseDataInner.UserId != null)
                writer.WriteString("userId", automationGetAllProfilesResponseDataInner.UserId);
            else
                writer.WriteNull("userId");
        }
    }
}