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
    /// CommonActivityResponseDataInnerTransaction
    /// </summary>
    public partial class CommonActivityResponseDataInnerTransaction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonActivityResponseDataInnerTransaction" /> class.
        /// </summary>
        /// <param name="from">from</param>
        /// <param name="hash">hash</param>
        /// <param name="timestamp">timestamp</param>
        /// <param name="to">to</param>
        [JsonConstructor]
        public CommonActivityResponseDataInnerTransaction(Option<string?> from = default, Option<string?> hash = default, Option<decimal?> timestamp = default, Option<string?> to = default)
        {
            FromOption = from;
            HashOption = hash;
            TimestampOption = timestamp;
            ToOption = to;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of From
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FromOption { get; private set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [JsonPropertyName("from")]
        public string? From { get { return this. FromOption; } set { this.FromOption = new(value); } }

        /// <summary>
        /// Used to track the state of Hash
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> HashOption { get; private set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [JsonPropertyName("hash")]
        public string? Hash { get { return this. HashOption; } set { this.HashOption = new(value); } }

        /// <summary>
        /// Used to track the state of Timestamp
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> TimestampOption { get; private set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [JsonPropertyName("timestamp")]
        public decimal? Timestamp { get { return this. TimestampOption; } set { this.TimestampOption = new(value); } }

        /// <summary>
        /// Used to track the state of To
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ToOption { get; private set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [JsonPropertyName("to")]
        public string? To { get { return this. ToOption; } set { this.ToOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommonActivityResponseDataInnerTransaction {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
    /// A Json converter for type <see cref="CommonActivityResponseDataInnerTransaction" />
    /// </summary>
    public class CommonActivityResponseDataInnerTransactionJsonConverter : JsonConverter<CommonActivityResponseDataInnerTransaction>
    {
        /// <summary>
        /// Deserializes json to <see cref="CommonActivityResponseDataInnerTransaction" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CommonActivityResponseDataInnerTransaction Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> from = default;
            Option<string?> hash = default;
            Option<decimal?> timestamp = default;
            Option<string?> to = default;

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
                        case "from":
                            from = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "hash":
                            hash = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "timestamp":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                timestamp = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "to":
                            to = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new CommonActivityResponseDataInnerTransaction(from, hash, timestamp, to);
        }

        /// <summary>
        /// Serializes a <see cref="CommonActivityResponseDataInnerTransaction" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="commonActivityResponseDataInnerTransaction"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CommonActivityResponseDataInnerTransaction commonActivityResponseDataInnerTransaction, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, commonActivityResponseDataInnerTransaction, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CommonActivityResponseDataInnerTransaction" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="commonActivityResponseDataInnerTransaction"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CommonActivityResponseDataInnerTransaction commonActivityResponseDataInnerTransaction, JsonSerializerOptions jsonSerializerOptions)
        {
            if (commonActivityResponseDataInnerTransaction.FromOption.IsSet)
                if (commonActivityResponseDataInnerTransaction.FromOption.Value != null)
                    writer.WriteString("from", commonActivityResponseDataInnerTransaction.From);
                else
                    writer.WriteNull("from");

            if (commonActivityResponseDataInnerTransaction.HashOption.IsSet)
                if (commonActivityResponseDataInnerTransaction.HashOption.Value != null)
                    writer.WriteString("hash", commonActivityResponseDataInnerTransaction.Hash);
                else
                    writer.WriteNull("hash");

            if (commonActivityResponseDataInnerTransaction.TimestampOption.IsSet)
                if (commonActivityResponseDataInnerTransaction.TimestampOption.Value != null)
                    writer.WriteNumber("timestamp", commonActivityResponseDataInnerTransaction.TimestampOption.Value!.Value);
                else
                    writer.WriteNull("timestamp");

            if (commonActivityResponseDataInnerTransaction.ToOption.IsSet)
                if (commonActivityResponseDataInnerTransaction.ToOption.Value != null)
                    writer.WriteString("to", commonActivityResponseDataInnerTransaction.To);
                else
                    writer.WriteNull("to");
        }
    }
}