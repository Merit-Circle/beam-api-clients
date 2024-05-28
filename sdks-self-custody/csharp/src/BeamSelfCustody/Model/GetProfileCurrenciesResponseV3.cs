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
    /// GetProfileCurrenciesResponseV3
    /// </summary>
    public partial class GetProfileCurrenciesResponseV3 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProfileCurrenciesResponseV3" /> class.
        /// </summary>
        /// <param name="data">data</param>
        [JsonConstructor]
        public GetProfileCurrenciesResponseV3(List<GetProfileCurrenciesResponseV3DataInner> data)
        {
            Data = data;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public List<GetProfileCurrenciesResponseV3DataInner> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetProfileCurrenciesResponseV3 {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
    /// A Json converter for type <see cref="GetProfileCurrenciesResponseV3" />
    /// </summary>
    public class GetProfileCurrenciesResponseV3JsonConverter : JsonConverter<GetProfileCurrenciesResponseV3>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetProfileCurrenciesResponseV3" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetProfileCurrenciesResponseV3 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<GetProfileCurrenciesResponseV3DataInner>?> data = default;

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
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<List<GetProfileCurrenciesResponseV3DataInner>?>(JsonSerializer.Deserialize<List<GetProfileCurrenciesResponseV3DataInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!data.IsSet)
                throw new ArgumentException("Property is required for class GetProfileCurrenciesResponseV3.", nameof(data));

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class GetProfileCurrenciesResponseV3.");

            return new GetProfileCurrenciesResponseV3(data.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GetProfileCurrenciesResponseV3" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getProfileCurrenciesResponseV3"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetProfileCurrenciesResponseV3 getProfileCurrenciesResponseV3, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getProfileCurrenciesResponseV3, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetProfileCurrenciesResponseV3" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getProfileCurrenciesResponseV3"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetProfileCurrenciesResponseV3 getProfileCurrenciesResponseV3, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getProfileCurrenciesResponseV3.Data == null)
                throw new ArgumentNullException(nameof(getProfileCurrenciesResponseV3.Data), "Property is required for class GetProfileCurrenciesResponseV3.");

            writer.WritePropertyName("data");
            JsonSerializer.Serialize(writer, getProfileCurrenciesResponseV3.Data, jsonSerializerOptions);
        }
    }
}