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
    /// CommonStatsRequestInput
    /// </summary>
    public partial class CommonStatsRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonStatsRequestInput" /> class.
        /// </summary>
        /// <param name="attributes">attributes</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        [JsonConstructor]
        public CommonStatsRequestInput(Option<List<GetAssetsForContractBodyInputV2AttributesInner>?> attributes = default, Option<decimal?> chainId = default)
        {
            AttributesOption = attributes;
            ChainIdOption = chainId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Attributes
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetAssetsForContractBodyInputV2AttributesInner>?> AttributesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public List<GetAssetsForContractBodyInputV2AttributesInner>? Attributes { get { return this. AttributesOption; } set { this.AttributesOption = new(value); } }

        /// <summary>
        /// Used to track the state of ChainId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> ChainIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public decimal? ChainId { get { return this. ChainIdOption; } set { this.ChainIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommonStatsRequestInput {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
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
    /// A Json converter for type <see cref="CommonStatsRequestInput" />
    /// </summary>
    public class CommonStatsRequestInputJsonConverter : JsonConverter<CommonStatsRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="CommonStatsRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CommonStatsRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<GetAssetsForContractBodyInputV2AttributesInner>?> attributes = default;
            Option<decimal?> chainId = default;

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
                        case "attributes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                attributes = new Option<List<GetAssetsForContractBodyInputV2AttributesInner>?>(JsonSerializer.Deserialize<List<GetAssetsForContractBodyInputV2AttributesInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class CommonStatsRequestInput.");

            return new CommonStatsRequestInput(attributes, chainId);
        }

        /// <summary>
        /// Serializes a <see cref="CommonStatsRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="commonStatsRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CommonStatsRequestInput commonStatsRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, commonStatsRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CommonStatsRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="commonStatsRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CommonStatsRequestInput commonStatsRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (commonStatsRequestInput.AttributesOption.IsSet)
                if (commonStatsRequestInput.AttributesOption.Value != null)
                {
                    writer.WritePropertyName("attributes");
                    JsonSerializer.Serialize(writer, commonStatsRequestInput.Attributes, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("attributes");
            if (commonStatsRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", commonStatsRequestInput.ChainIdOption.Value!.Value);
        }
    }
}