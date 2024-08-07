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
    /// PlayerCommonOperationResponse
    /// </summary>
    public partial class PlayerCommonOperationResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerCommonOperationResponse" /> class.
        /// </summary>
        /// <param name="chainId">chainId</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="gameId">gameId</param>
        /// <param name="id">id</param>
        /// <param name="processing">processing</param>
        /// <param name="status">status</param>
        /// <param name="transactions">transactions</param>
        /// <param name="url">url</param>
        /// <param name="userId">userId</param>
        /// <param name="updatedAt">updatedAt</param>
        [JsonConstructor]
        public PlayerCommonOperationResponse(int chainId, DateTime createdAt, string gameId, string id, ProcessingEnum processing, StatusEnum status, List<PlayerCommonOperationResponseTransactionsInner> transactions, string url, string userId, DateTime? updatedAt = default)
        {
            ChainId = chainId;
            CreatedAt = createdAt;
            GameId = gameId;
            Id = id;
            Processing = processing;
            Status = status;
            Transactions = transactions;
            Url = url;
            UserId = userId;
            UpdatedAt = updatedAt;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Processing
        /// </summary>
        [JsonConverter(typeof(ProcessingEnumJsonConverter))]
        public enum ProcessingEnum
        {
            /// <summary>
            /// Enum SignOnly for value: SignOnly
            /// </summary>
            SignOnly = 1,

            /// <summary>
            /// Enum Execute for value: Execute
            /// </summary>
            Execute = 2
        }

        /// <summary>
        /// Returns a <see cref="ProcessingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static ProcessingEnum ProcessingEnumFromString(string value)
        {
            if (value.Equals("SignOnly"))
                return ProcessingEnum.SignOnly;

            if (value.Equals("Execute"))
                return ProcessingEnum.Execute;

            throw new NotImplementedException($"Could not convert value to type ProcessingEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="ProcessingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ProcessingEnum? ProcessingEnumFromStringOrDefault(string value)
        {
            if (value.Equals("SignOnly"))
                return ProcessingEnum.SignOnly;

            if (value.Equals("Execute"))
                return ProcessingEnum.Execute;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="ProcessingEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ProcessingEnumToJsonValue(ProcessingEnum value)
        {
            if (value == ProcessingEnum.SignOnly)
                return "SignOnly";

            if (value == ProcessingEnum.Execute)
                return "Execute";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="ProcessingEnum"/> to and from the JSON value
        /// </summary>
        public static class ProcessingEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="ProcessingEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static ProcessingEnum FromString(string value)
            {
                    if (value.Equals("SignOnly"))
                        return ProcessingEnum.SignOnly;

                    if (value.Equals("Execute"))
                        return ProcessingEnum.Execute;

                throw new NotImplementedException($"Could not convert value to type ProcessingEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="ProcessingEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static ProcessingEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("SignOnly"))
                        return ProcessingEnum.SignOnly;

                    if (value.Equals("Execute"))
                        return ProcessingEnum.Execute;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="ProcessingEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(ProcessingEnum value)
            {
                        if (value == ProcessingEnum.SignOnly)
                            return "SignOnly";

                        if (value == ProcessingEnum.Execute)
                            return "Execute";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="ProcessingEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class ProcessingEnumJsonConverter : JsonConverter<ProcessingEnum>
        {
            /// <summary>
            /// Returns a ProcessingEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override ProcessingEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                ProcessingEnum? result = rawValue == null
                    ? null
                    : ProcessingEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the ProcessingEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="processingEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, ProcessingEnum processingEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(ProcessingEnumValueConverter.ToJsonValue(processingEnum));
            }
        }

        /// <summary>
        /// Gets or Sets Processing
        /// </summary>
        [JsonPropertyName("processing")]
        public ProcessingEnum Processing { get; set; }

        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StatusEnumJsonConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Signed for value: Signed
            /// </summary>
            Signed = 1,

            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            Pending = 2,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            Rejected = 3,

            /// <summary>
            /// Enum Executed for value: Executed
            /// </summary>
            Executed = 4,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            Error = 5
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value.Equals("Signed"))
                return StatusEnum.Signed;

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
            if (value.Equals("Signed"))
                return StatusEnum.Signed;

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
            if (value == StatusEnum.Signed)
                return "Signed";

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
        /// Converts <see cref="StatusEnum"/> to and from the JSON value
        /// </summary>
        public static class StatusEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="StatusEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static StatusEnum FromString(string value)
            {
                    if (value.Equals("Signed"))
                        return StatusEnum.Signed;

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
            /// Parses a given value to <see cref="StatusEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static StatusEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("Signed"))
                        return StatusEnum.Signed;

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
            public static string ToJsonValue(StatusEnum value)
            {
                        if (value == StatusEnum.Signed)
                            return "Signed";

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
        }

        /// <summary>
        /// A Json converter for type <see cref="StatusEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class StatusEnumJsonConverter : JsonConverter<StatusEnum>
        {
            /// <summary>
            /// Returns a StatusEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override StatusEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                StatusEnum? result = rawValue == null
                    ? null
                    : StatusEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the StatusEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="statusEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, StatusEnum statusEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(StatusEnumValueConverter.ToJsonValue(statusEnum));
            }
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
        public List<PlayerCommonOperationResponseTransactionsInner> Transactions { get; set; }

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
            sb.Append("class PlayerCommonOperationResponse {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Processing: ").Append(Processing).Append("\n");
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
    /// A Json converter for type <see cref="PlayerCommonOperationResponse" />
    /// </summary>
    public class PlayerCommonOperationResponseJsonConverter : JsonConverter<PlayerCommonOperationResponse>
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
        /// Deserializes json to <see cref="PlayerCommonOperationResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerCommonOperationResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> chainId = default;
            Option<DateTime?> createdAt = default;
            Option<string?> gameId = default;
            Option<string?> id = default;
            Option<PlayerCommonOperationResponse.ProcessingEnum?> processing = default;
            Option<PlayerCommonOperationResponse.StatusEnum?> status = default;
            Option<List<PlayerCommonOperationResponseTransactionsInner>?> transactions = default;
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
                        case "gameId":
                            gameId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "processing":
                            string? processingRawValue = utf8JsonReader.GetString();
                            if (processingRawValue != null)
                                processing = new Option<PlayerCommonOperationResponse.ProcessingEnum?>(PlayerCommonOperationResponse.ProcessingEnumFromStringOrDefault(processingRawValue));
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<PlayerCommonOperationResponse.StatusEnum?>(PlayerCommonOperationResponse.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "transactions":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transactions = new Option<List<PlayerCommonOperationResponseTransactionsInner>?>(JsonSerializer.Deserialize<List<PlayerCommonOperationResponseTransactionsInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
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
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponse.", nameof(chainId));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponse.", nameof(createdAt));

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponse.", nameof(gameId));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponse.", nameof(id));

            if (!processing.IsSet)
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponse.", nameof(processing));

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponse.", nameof(status));

            if (!transactions.IsSet)
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponse.", nameof(transactions));

            if (!url.IsSet)
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponse.", nameof(url));

            if (!userId.IsSet)
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponse.", nameof(userId));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponse.", nameof(updatedAt));

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerCommonOperationResponse.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class PlayerCommonOperationResponse.");

            if (gameId.IsSet && gameId.Value == null)
                throw new ArgumentNullException(nameof(gameId), "Property is not nullable for class PlayerCommonOperationResponse.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class PlayerCommonOperationResponse.");

            if (processing.IsSet && processing.Value == null)
                throw new ArgumentNullException(nameof(processing), "Property is not nullable for class PlayerCommonOperationResponse.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class PlayerCommonOperationResponse.");

            if (transactions.IsSet && transactions.Value == null)
                throw new ArgumentNullException(nameof(transactions), "Property is not nullable for class PlayerCommonOperationResponse.");

            if (url.IsSet && url.Value == null)
                throw new ArgumentNullException(nameof(url), "Property is not nullable for class PlayerCommonOperationResponse.");

            if (userId.IsSet && userId.Value == null)
                throw new ArgumentNullException(nameof(userId), "Property is not nullable for class PlayerCommonOperationResponse.");

            return new PlayerCommonOperationResponse(chainId.Value!.Value!, createdAt.Value!.Value!, gameId.Value!, id.Value!, processing.Value!.Value!, status.Value!.Value!, transactions.Value!, url.Value!, userId.Value!, updatedAt.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerCommonOperationResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCommonOperationResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerCommonOperationResponse playerCommonOperationResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, playerCommonOperationResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerCommonOperationResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCommonOperationResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PlayerCommonOperationResponse playerCommonOperationResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerCommonOperationResponse.GameId == null)
                throw new ArgumentNullException(nameof(playerCommonOperationResponse.GameId), "Property is required for class PlayerCommonOperationResponse.");

            if (playerCommonOperationResponse.Id == null)
                throw new ArgumentNullException(nameof(playerCommonOperationResponse.Id), "Property is required for class PlayerCommonOperationResponse.");

            if (playerCommonOperationResponse.Transactions == null)
                throw new ArgumentNullException(nameof(playerCommonOperationResponse.Transactions), "Property is required for class PlayerCommonOperationResponse.");

            if (playerCommonOperationResponse.Url == null)
                throw new ArgumentNullException(nameof(playerCommonOperationResponse.Url), "Property is required for class PlayerCommonOperationResponse.");

            if (playerCommonOperationResponse.UserId == null)
                throw new ArgumentNullException(nameof(playerCommonOperationResponse.UserId), "Property is required for class PlayerCommonOperationResponse.");

            writer.WriteNumber("chainId", playerCommonOperationResponse.ChainId);

            writer.WriteString("createdAt", playerCommonOperationResponse.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("gameId", playerCommonOperationResponse.GameId);

            writer.WriteString("id", playerCommonOperationResponse.Id);

            var processingRawValue = PlayerCommonOperationResponse.ProcessingEnumToJsonValue(playerCommonOperationResponse.Processing);
            writer.WriteString("processing", processingRawValue);
            var statusRawValue = PlayerCommonOperationResponse.StatusEnumToJsonValue(playerCommonOperationResponse.Status);
            writer.WriteString("status", statusRawValue);
            writer.WritePropertyName("transactions");
            JsonSerializer.Serialize(writer, playerCommonOperationResponse.Transactions, jsonSerializerOptions);
            writer.WriteString("url", playerCommonOperationResponse.Url);

            writer.WriteString("userId", playerCommonOperationResponse.UserId);

            if (playerCommonOperationResponse.UpdatedAt != null)
                writer.WriteString("updatedAt", playerCommonOperationResponse.UpdatedAt.Value.ToString(UpdatedAtFormat));
            else
                writer.WriteNull("updatedAt");
        }
    }
}