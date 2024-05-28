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
using OpenAPIClientUtils = BeamSelfCustody.Client.ClientUtils;
using BeamSelfCustody.Client;

namespace BeamSelfCustody.Model
{
    /// <summary>
    /// OperationResponse
    /// </summary>
    public partial class OperationResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationResponse" /> class.
        /// </summary>
        /// <param name="chainId">chainId</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="game">game</param>
        /// <param name="gameId">gameId</param>
        /// <param name="id">id</param>
        /// <param name="status">status</param>
        /// <param name="transactions">transactions</param>
        /// <param name="url">url</param>
        /// <param name="userId">userId</param>
        /// <param name="updatedAt">updatedAt</param>
        [JsonConstructor]
        public OperationResponse(int chainId, DateTime createdAt, OperationResponseGame game, string gameId, string id, StatusEnum status, List<OperationResponseTransactionsInner> transactions, string url, string userId, DateTime? updatedAt = default)
        {
            ChainId = chainId;
            CreatedAt = createdAt;
            Game = game;
            GameId = gameId;
            Id = id;
            Status = status;
            Transactions = transactions;
            Url = url;
            UserId = userId;
            UpdatedAt = updatedAt;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Status
        /// </summary>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            Pending = 1,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            Rejected = 2,

            /// <summary>
            /// Enum Executed for value: Executed
            /// </summary>
            Executed = 3,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            Error = 4
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value.Equals("Pending"))
                return StatusEnum.Pending;

            if (value.Equals("Rejected"))
                return StatusEnum.Rejected;

            if (value.Equals("Executed"))
                return StatusEnum.Executed;

            if (value.Equals("Error"))
                return StatusEnum.Error;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StatusEnum? StatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Pending"))
                return StatusEnum.Pending;

            if (value.Equals("Rejected"))
                return StatusEnum.Rejected;

            if (value.Equals("Executed"))
                return StatusEnum.Executed;

            if (value.Equals("Error"))
                return StatusEnum.Error;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StatusEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StatusEnumToJsonValue(StatusEnum value)
        {
            if (value == StatusEnum.Pending)
                return "Pending";

            if (value == StatusEnum.Rejected)
                return "Rejected";

            if (value == StatusEnum.Executed)
                return "Executed";

            if (value == StatusEnum.Error)
                return "Error";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public int ChainId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Game
        /// </summary>
        [JsonPropertyName("game")]
        public OperationResponseGame Game { get; set; }

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
        /// Gets or Sets Transactions
        /// </summary>
        [JsonPropertyName("transactions")]
        public List<OperationResponseTransactionsInner> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OperationResponse {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Game: ").Append(Game).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
    /// A Json converter for type <see cref="OperationResponse" />
    /// </summary>
    public class OperationResponseJsonConverter : JsonConverter<OperationResponse>
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
        /// Deserializes json to <see cref="OperationResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override OperationResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> chainId = default;
            Option<DateTime?> createdAt = default;
            Option<OperationResponseGame?> game = default;
            Option<string?> gameId = default;
            Option<string?> id = default;
            Option<OperationResponse.StatusEnum?> status = default;
            Option<List<OperationResponseTransactionsInner>?> transactions = default;
            Option<string?> url = default;
            Option<string?> userId = default;
            Option<DateTime?> updatedAt = default;

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
                                chainId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "game":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                game = new Option<OperationResponseGame?>(JsonSerializer.Deserialize<OperationResponseGame>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "gameId":
                            gameId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<OperationResponse.StatusEnum?>(OperationResponse.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "transactions":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transactions = new Option<List<OperationResponseTransactionsInner>?>(JsonSerializer.Deserialize<List<OperationResponseTransactionsInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "url":
                            url = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "userId":
                            userId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class OperationResponse.", nameof(chainId));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class OperationResponse.", nameof(createdAt));

            if (!game.IsSet)
                throw new ArgumentException("Property is required for class OperationResponse.", nameof(game));

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class OperationResponse.", nameof(gameId));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class OperationResponse.", nameof(id));

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class OperationResponse.", nameof(status));

            if (!transactions.IsSet)
                throw new ArgumentException("Property is required for class OperationResponse.", nameof(transactions));

            if (!url.IsSet)
                throw new ArgumentException("Property is required for class OperationResponse.", nameof(url));

            if (!userId.IsSet)
                throw new ArgumentException("Property is required for class OperationResponse.", nameof(userId));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class OperationResponse.", nameof(updatedAt));

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class OperationResponse.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class OperationResponse.");

            if (game.IsSet && game.Value == null)
                throw new ArgumentNullException(nameof(game), "Property is not nullable for class OperationResponse.");

            if (gameId.IsSet && gameId.Value == null)
                throw new ArgumentNullException(nameof(gameId), "Property is not nullable for class OperationResponse.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class OperationResponse.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class OperationResponse.");

            if (transactions.IsSet && transactions.Value == null)
                throw new ArgumentNullException(nameof(transactions), "Property is not nullable for class OperationResponse.");

            if (url.IsSet && url.Value == null)
                throw new ArgumentNullException(nameof(url), "Property is not nullable for class OperationResponse.");

            if (userId.IsSet && userId.Value == null)
                throw new ArgumentNullException(nameof(userId), "Property is not nullable for class OperationResponse.");

            return new OperationResponse(chainId.Value!.Value!, createdAt.Value!.Value!, game.Value!, gameId.Value!, id.Value!, status.Value!.Value!, transactions.Value!, url.Value!, userId.Value!, updatedAt.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="OperationResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="operationResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, OperationResponse operationResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, operationResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="OperationResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="operationResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, OperationResponse operationResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (operationResponse.Game == null)
                throw new ArgumentNullException(nameof(operationResponse.Game), "Property is required for class OperationResponse.");

            if (operationResponse.GameId == null)
                throw new ArgumentNullException(nameof(operationResponse.GameId), "Property is required for class OperationResponse.");

            if (operationResponse.Id == null)
                throw new ArgumentNullException(nameof(operationResponse.Id), "Property is required for class OperationResponse.");

            if (operationResponse.Transactions == null)
                throw new ArgumentNullException(nameof(operationResponse.Transactions), "Property is required for class OperationResponse.");

            if (operationResponse.Url == null)
                throw new ArgumentNullException(nameof(operationResponse.Url), "Property is required for class OperationResponse.");

            if (operationResponse.UserId == null)
                throw new ArgumentNullException(nameof(operationResponse.UserId), "Property is required for class OperationResponse.");

            writer.WriteNumber("chainId", operationResponse.ChainId);

            writer.WriteString("createdAt", operationResponse.CreatedAt.ToString(CreatedAtFormat));

            writer.WritePropertyName("game");
            JsonSerializer.Serialize(writer, operationResponse.Game, jsonSerializerOptions);
            writer.WriteString("gameId", operationResponse.GameId);

            writer.WriteString("id", operationResponse.Id);

            var statusRawValue = OperationResponse.StatusEnumToJsonValue(operationResponse.Status);
            writer.WriteString("status", statusRawValue);
            writer.WritePropertyName("transactions");
            JsonSerializer.Serialize(writer, operationResponse.Transactions, jsonSerializerOptions);
            writer.WriteString("url", operationResponse.Url);

            writer.WriteString("userId", operationResponse.UserId);

            if (operationResponse.UpdatedAt != null)
                writer.WriteString("updatedAt", operationResponse.UpdatedAt.Value.ToString(UpdatedAtFormat));
            else
                writer.WriteNull("updatedAt");
        }
    }
}