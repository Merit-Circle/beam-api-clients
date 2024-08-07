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
    /// PlayerConvertTokenRequestInput
    /// </summary>
    public partial class PlayerConvertTokenRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerConvertTokenRequestInput" /> class.
        /// </summary>
        /// <param name="amountIn">amountIn</param>
        /// <param name="amountOut">amountOut</param>
        /// <param name="tokenIn">tokenIn</param>
        /// <param name="tokenOut">tokenOut</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="operationId">operationId</param>
        /// <param name="operationProcessing">operationProcessing (default to OperationProcessingEnum.Execute)</param>
        /// <param name="optimistic">optimistic (default to false)</param>
        /// <param name="policyId">policyId</param>
        /// <param name="receiverEntityId">receiverEntityId</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        [JsonConstructor]
        public PlayerConvertTokenRequestInput(string amountIn, string amountOut, string tokenIn, string tokenOut, Option<decimal?> chainId = default, Option<string?> operationId = default, Option<OperationProcessingEnum?> operationProcessing = default, Option<bool?> optimistic = default, Option<string?> policyId = default, Option<string?> receiverEntityId = default, Option<bool?> sponsor = default)
        {
            AmountIn = amountIn;
            AmountOut = amountOut;
            TokenIn = tokenIn;
            TokenOut = tokenOut;
            ChainIdOption = chainId;
            OperationIdOption = operationId;
            OperationProcessingOption = operationProcessing;
            OptimisticOption = optimistic;
            PolicyIdOption = policyId;
            ReceiverEntityIdOption = receiverEntityId;
            SponsorOption = sponsor;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines OperationProcessing
        /// </summary>
        [JsonConverter(typeof(OperationProcessingEnumJsonConverter))]
        public enum OperationProcessingEnum
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
        /// Returns a <see cref="OperationProcessingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static OperationProcessingEnum OperationProcessingEnumFromString(string value)
        {
            if (value.Equals("SignOnly"))
                return OperationProcessingEnum.SignOnly;

            if (value.Equals("Execute"))
                return OperationProcessingEnum.Execute;

            throw new NotImplementedException($"Could not convert value to type OperationProcessingEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="OperationProcessingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OperationProcessingEnum? OperationProcessingEnumFromStringOrDefault(string value)
        {
            if (value.Equals("SignOnly"))
                return OperationProcessingEnum.SignOnly;

            if (value.Equals("Execute"))
                return OperationProcessingEnum.Execute;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="OperationProcessingEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string OperationProcessingEnumToJsonValue(OperationProcessingEnum? value)
        {
            if (value == OperationProcessingEnum.SignOnly)
                return "SignOnly";

            if (value == OperationProcessingEnum.Execute)
                return "Execute";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="OperationProcessingEnum"/> to and from the JSON value
        /// </summary>
        public static class OperationProcessingEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="OperationProcessingEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static OperationProcessingEnum FromString(string value)
            {
                    if (value.Equals("SignOnly"))
                        return OperationProcessingEnum.SignOnly;

                    if (value.Equals("Execute"))
                        return OperationProcessingEnum.Execute;

                throw new NotImplementedException($"Could not convert value to type OperationProcessingEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="OperationProcessingEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static OperationProcessingEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("SignOnly"))
                        return OperationProcessingEnum.SignOnly;

                    if (value.Equals("Execute"))
                        return OperationProcessingEnum.Execute;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="OperationProcessingEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(OperationProcessingEnum value)
            {
                        if (value == OperationProcessingEnum.SignOnly)
                            return "SignOnly";

                        if (value == OperationProcessingEnum.Execute)
                            return "Execute";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="OperationProcessingEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class OperationProcessingEnumJsonConverter : JsonConverter<OperationProcessingEnum>
        {
            /// <summary>
            /// Returns a OperationProcessingEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override OperationProcessingEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                OperationProcessingEnum? result = rawValue == null
                    ? null
                    : OperationProcessingEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the OperationProcessingEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="operationProcessingEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, OperationProcessingEnum operationProcessingEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(OperationProcessingEnumValueConverter.ToJsonValue(operationProcessingEnum));
            }
        }

        /// <summary>
        /// Used to track the state of OperationProcessing
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<OperationProcessingEnum?> OperationProcessingOption { get; private set; }

        /// <summary>
        /// Gets or Sets OperationProcessing
        /// </summary>
        [JsonPropertyName("operationProcessing")]
        public OperationProcessingEnum? OperationProcessing { get { return this.OperationProcessingOption; } set { this.OperationProcessingOption = new(value); } }

        /// <summary>
        /// Gets or Sets AmountIn
        /// </summary>
        [JsonPropertyName("amountIn")]
        public string AmountIn { get; set; }

        /// <summary>
        /// Gets or Sets AmountOut
        /// </summary>
        [JsonPropertyName("amountOut")]
        public string AmountOut { get; set; }

        /// <summary>
        /// Gets or Sets TokenIn
        /// </summary>
        [JsonPropertyName("tokenIn")]
        public string TokenIn { get; set; }

        /// <summary>
        /// Gets or Sets TokenOut
        /// </summary>
        [JsonPropertyName("tokenOut")]
        public string TokenOut { get; set; }

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
        /// Used to track the state of OperationId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OperationIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [JsonPropertyName("operationId")]
        public string? OperationId { get { return this. OperationIdOption; } set { this.OperationIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Optimistic
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> OptimisticOption { get; private set; }

        /// <summary>
        /// Gets or Sets Optimistic
        /// </summary>
        [JsonPropertyName("optimistic")]
        public bool? Optimistic { get { return this. OptimisticOption; } set { this.OptimisticOption = new(value); } }

        /// <summary>
        /// Used to track the state of PolicyId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PolicyIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [JsonPropertyName("policyId")]
        public string? PolicyId { get { return this. PolicyIdOption; } set { this.PolicyIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ReceiverEntityId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ReceiverEntityIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ReceiverEntityId
        /// </summary>
        [JsonPropertyName("receiverEntityId")]
        public string? ReceiverEntityId { get { return this. ReceiverEntityIdOption; } set { this.ReceiverEntityIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Sponsor
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> SponsorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Sponsor
        /// </summary>
        [JsonPropertyName("sponsor")]
        public bool? Sponsor { get { return this. SponsorOption; } set { this.SponsorOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerConvertTokenRequestInput {\n");
            sb.Append("  AmountIn: ").Append(AmountIn).Append("\n");
            sb.Append("  AmountOut: ").Append(AmountOut).Append("\n");
            sb.Append("  TokenIn: ").Append(TokenIn).Append("\n");
            sb.Append("  TokenOut: ").Append(TokenOut).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  OperationProcessing: ").Append(OperationProcessing).Append("\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  ReceiverEntityId: ").Append(ReceiverEntityId).Append("\n");
            sb.Append("  Sponsor: ").Append(Sponsor).Append("\n");
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
    /// A Json converter for type <see cref="PlayerConvertTokenRequestInput" />
    /// </summary>
    public class PlayerConvertTokenRequestInputJsonConverter : JsonConverter<PlayerConvertTokenRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerConvertTokenRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerConvertTokenRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> amountIn = default;
            Option<string?> amountOut = default;
            Option<string?> tokenIn = default;
            Option<string?> tokenOut = default;
            Option<decimal?> chainId = default;
            Option<string?> operationId = default;
            Option<PlayerConvertTokenRequestInput.OperationProcessingEnum?> operationProcessing = default;
            Option<bool?> optimistic = default;
            Option<string?> policyId = default;
            Option<string?> receiverEntityId = default;
            Option<bool?> sponsor = default;

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
                        case "amountIn":
                            amountIn = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "amountOut":
                            amountOut = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tokenIn":
                            tokenIn = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tokenOut":
                            tokenOut = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "operationId":
                            operationId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "operationProcessing":
                            string? operationProcessingRawValue = utf8JsonReader.GetString();
                            if (operationProcessingRawValue != null)
                                operationProcessing = new Option<PlayerConvertTokenRequestInput.OperationProcessingEnum?>(PlayerConvertTokenRequestInput.OperationProcessingEnumFromStringOrDefault(operationProcessingRawValue));
                            break;
                        case "optimistic":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                optimistic = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "policyId":
                            policyId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "receiverEntityId":
                            receiverEntityId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "sponsor":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sponsor = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!amountIn.IsSet)
                throw new ArgumentException("Property is required for class PlayerConvertTokenRequestInput.", nameof(amountIn));

            if (!amountOut.IsSet)
                throw new ArgumentException("Property is required for class PlayerConvertTokenRequestInput.", nameof(amountOut));

            if (!tokenIn.IsSet)
                throw new ArgumentException("Property is required for class PlayerConvertTokenRequestInput.", nameof(tokenIn));

            if (!tokenOut.IsSet)
                throw new ArgumentException("Property is required for class PlayerConvertTokenRequestInput.", nameof(tokenOut));

            if (amountIn.IsSet && amountIn.Value == null)
                throw new ArgumentNullException(nameof(amountIn), "Property is not nullable for class PlayerConvertTokenRequestInput.");

            if (amountOut.IsSet && amountOut.Value == null)
                throw new ArgumentNullException(nameof(amountOut), "Property is not nullable for class PlayerConvertTokenRequestInput.");

            if (tokenIn.IsSet && tokenIn.Value == null)
                throw new ArgumentNullException(nameof(tokenIn), "Property is not nullable for class PlayerConvertTokenRequestInput.");

            if (tokenOut.IsSet && tokenOut.Value == null)
                throw new ArgumentNullException(nameof(tokenOut), "Property is not nullable for class PlayerConvertTokenRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerConvertTokenRequestInput.");

            if (operationProcessing.IsSet && operationProcessing.Value == null)
                throw new ArgumentNullException(nameof(operationProcessing), "Property is not nullable for class PlayerConvertTokenRequestInput.");

            if (optimistic.IsSet && optimistic.Value == null)
                throw new ArgumentNullException(nameof(optimistic), "Property is not nullable for class PlayerConvertTokenRequestInput.");

            if (receiverEntityId.IsSet && receiverEntityId.Value == null)
                throw new ArgumentNullException(nameof(receiverEntityId), "Property is not nullable for class PlayerConvertTokenRequestInput.");

            if (sponsor.IsSet && sponsor.Value == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is not nullable for class PlayerConvertTokenRequestInput.");

            return new PlayerConvertTokenRequestInput(amountIn.Value!, amountOut.Value!, tokenIn.Value!, tokenOut.Value!, chainId, operationId, operationProcessing, optimistic, policyId, receiverEntityId, sponsor);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerConvertTokenRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerConvertTokenRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerConvertTokenRequestInput playerConvertTokenRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, playerConvertTokenRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerConvertTokenRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerConvertTokenRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PlayerConvertTokenRequestInput playerConvertTokenRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerConvertTokenRequestInput.AmountIn == null)
                throw new ArgumentNullException(nameof(playerConvertTokenRequestInput.AmountIn), "Property is required for class PlayerConvertTokenRequestInput.");

            if (playerConvertTokenRequestInput.AmountOut == null)
                throw new ArgumentNullException(nameof(playerConvertTokenRequestInput.AmountOut), "Property is required for class PlayerConvertTokenRequestInput.");

            if (playerConvertTokenRequestInput.TokenIn == null)
                throw new ArgumentNullException(nameof(playerConvertTokenRequestInput.TokenIn), "Property is required for class PlayerConvertTokenRequestInput.");

            if (playerConvertTokenRequestInput.TokenOut == null)
                throw new ArgumentNullException(nameof(playerConvertTokenRequestInput.TokenOut), "Property is required for class PlayerConvertTokenRequestInput.");

            if (playerConvertTokenRequestInput.ReceiverEntityIdOption.IsSet && playerConvertTokenRequestInput.ReceiverEntityId == null)
                throw new ArgumentNullException(nameof(playerConvertTokenRequestInput.ReceiverEntityId), "Property is required for class PlayerConvertTokenRequestInput.");

            writer.WriteString("amountIn", playerConvertTokenRequestInput.AmountIn);

            writer.WriteString("amountOut", playerConvertTokenRequestInput.AmountOut);

            writer.WriteString("tokenIn", playerConvertTokenRequestInput.TokenIn);

            writer.WriteString("tokenOut", playerConvertTokenRequestInput.TokenOut);

            if (playerConvertTokenRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", playerConvertTokenRequestInput.ChainIdOption.Value!.Value);

            if (playerConvertTokenRequestInput.OperationIdOption.IsSet)
                if (playerConvertTokenRequestInput.OperationIdOption.Value != null)
                    writer.WriteString("operationId", playerConvertTokenRequestInput.OperationId);
                else
                    writer.WriteNull("operationId");

            var operationProcessingRawValue = PlayerConvertTokenRequestInput.OperationProcessingEnumToJsonValue(playerConvertTokenRequestInput.OperationProcessingOption.Value!.Value);
            writer.WriteString("operationProcessing", operationProcessingRawValue);
            if (playerConvertTokenRequestInput.OptimisticOption.IsSet)
                writer.WriteBoolean("optimistic", playerConvertTokenRequestInput.OptimisticOption.Value!.Value);

            if (playerConvertTokenRequestInput.PolicyIdOption.IsSet)
                if (playerConvertTokenRequestInput.PolicyIdOption.Value != null)
                    writer.WriteString("policyId", playerConvertTokenRequestInput.PolicyId);
                else
                    writer.WriteNull("policyId");

            if (playerConvertTokenRequestInput.ReceiverEntityIdOption.IsSet)
                writer.WriteString("receiverEntityId", playerConvertTokenRequestInput.ReceiverEntityId);

            if (playerConvertTokenRequestInput.SponsorOption.IsSet)
                writer.WriteBoolean("sponsor", playerConvertTokenRequestInput.SponsorOption.Value!.Value);
        }
    }
}