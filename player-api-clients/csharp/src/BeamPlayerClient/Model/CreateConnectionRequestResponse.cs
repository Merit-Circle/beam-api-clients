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
    /// CreateConnectionRequestResponse
    /// </summary>
    public partial class CreateConnectionRequestResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectionRequestResponse" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt</param>
        /// <param name="id">id</param>
        /// <param name="status">status</param>
        /// <param name="url">url</param>
        /// <param name="updatedAt">updatedAt</param>
        [JsonConstructor]
        public CreateConnectionRequestResponse(DateTime createdAt, string id, StatusEnum status, string url, DateTime? updatedAt = default)
        {
            CreatedAt = createdAt;
            Id = id;
            Status = status;
            Url = url;
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
            /// Enum Connected for value: Connected
            /// </summary>
            Connected = 2,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            Error = 3
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

            if (value.Equals("Connected"))
                return StatusEnum.Connected;

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

            if (value.Equals("Connected"))
                return StatusEnum.Connected;

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

            if (value == StatusEnum.Connected)
                return "Connected";

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
        /// Gets or Sets Url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

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
            sb.Append("class CreateConnectionRequestResponse {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
    /// A Json converter for type <see cref="CreateConnectionRequestResponse" />
    /// </summary>
    public class CreateConnectionRequestResponseJsonConverter : JsonConverter<CreateConnectionRequestResponse>
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
        /// Deserializes json to <see cref="CreateConnectionRequestResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateConnectionRequestResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime?> createdAt = default;
            Option<string?> id = default;
            Option<CreateConnectionRequestResponse.StatusEnum?> status = default;
            Option<string?> url = default;
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
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<CreateConnectionRequestResponse.StatusEnum?>(CreateConnectionRequestResponse.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "url":
                            url = new Option<string?>(utf8JsonReader.GetString()!);
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

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class CreateConnectionRequestResponse.", nameof(createdAt));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class CreateConnectionRequestResponse.", nameof(id));

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class CreateConnectionRequestResponse.", nameof(status));

            if (!url.IsSet)
                throw new ArgumentException("Property is required for class CreateConnectionRequestResponse.", nameof(url));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class CreateConnectionRequestResponse.", nameof(updatedAt));

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class CreateConnectionRequestResponse.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class CreateConnectionRequestResponse.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class CreateConnectionRequestResponse.");

            if (url.IsSet && url.Value == null)
                throw new ArgumentNullException(nameof(url), "Property is not nullable for class CreateConnectionRequestResponse.");

            return new CreateConnectionRequestResponse(createdAt.Value!.Value!, id.Value!, status.Value!.Value!, url.Value!, updatedAt.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="CreateConnectionRequestResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createConnectionRequestResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateConnectionRequestResponse createConnectionRequestResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, createConnectionRequestResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateConnectionRequestResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createConnectionRequestResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CreateConnectionRequestResponse createConnectionRequestResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createConnectionRequestResponse.Id == null)
                throw new ArgumentNullException(nameof(createConnectionRequestResponse.Id), "Property is required for class CreateConnectionRequestResponse.");

            if (createConnectionRequestResponse.Url == null)
                throw new ArgumentNullException(nameof(createConnectionRequestResponse.Url), "Property is required for class CreateConnectionRequestResponse.");

            writer.WriteString("createdAt", createConnectionRequestResponse.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("id", createConnectionRequestResponse.Id);

            var statusRawValue = CreateConnectionRequestResponse.StatusEnumToJsonValue(createConnectionRequestResponse.Status);
            writer.WriteString("status", statusRawValue);
            writer.WriteString("url", createConnectionRequestResponse.Url);

            if (createConnectionRequestResponse.UpdatedAt != null)
                writer.WriteString("updatedAt", createConnectionRequestResponse.UpdatedAt.Value.ToString(UpdatedAtFormat));
            else
                writer.WriteNull("updatedAt");
        }
    }
}