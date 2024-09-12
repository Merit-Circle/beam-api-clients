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
    /// PlayerCreateAssetOfferRequestInput
    /// </summary>
    public partial class PlayerCreateAssetOfferRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerCreateAssetOfferRequestInput" /> class.
        /// </summary>
        /// <param name="assetAddress">assetAddress</param>
        /// <param name="assetId">assetId</param>
        /// <param name="price">price</param>
        /// <param name="quantity">quantity</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="currency">currency (default to CurrencyEnum.WBEAM)</param>
        /// <param name="endTime">endTime</param>
        /// <param name="operationId">operationId</param>
        /// <param name="operationProcessing">operationProcessing (default to OperationProcessingEnum.Execute)</param>
        /// <param name="startTime">startTime</param>
        [JsonConstructor]
        public PlayerCreateAssetOfferRequestInput(string assetAddress, string assetId, string price, decimal quantity, Option<decimal?> chainId = default, Option<CurrencyEnum?> currency = default, Option<DateTime?> endTime = default, Option<string?> operationId = default, Option<OperationProcessingEnum?> operationProcessing = default, Option<DateTime?> startTime = default)
        {
            AssetAddress = assetAddress;
            AssetId = assetId;
            Price = price;
            Quantity = quantity;
            ChainIdOption = chainId;
            CurrencyOption = currency;
            EndTimeOption = endTime;
            OperationIdOption = operationId;
            OperationProcessingOption = operationProcessing;
            StartTimeOption = startTime;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Currency
        /// </summary>
        [JsonConverter(typeof(CurrencyEnumJsonConverter))]
        public enum CurrencyEnum
        {
            /// <summary>
            /// Enum WBEAM for value: WBEAM
            /// </summary>
            WBEAM = 1,

            /// <summary>
            /// Enum WIMX for value: WIMX
            /// </summary>
            WIMX = 2,

            /// <summary>
            /// Enum WSOPH for value: WSOPH
            /// </summary>
            WSOPH = 3,

            /// <summary>
            /// Enum RAT for value: RAT
            /// </summary>
            RAT = 4,

            /// <summary>
            /// Enum USDC for value: USDC
            /// </summary>
            USDC = 5
        }

        /// <summary>
        /// Returns a <see cref="CurrencyEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static CurrencyEnum CurrencyEnumFromString(string value)
        {
            if (value.Equals("WBEAM"))
                return CurrencyEnum.WBEAM;

            if (value.Equals("WIMX"))
                return CurrencyEnum.WIMX;

            if (value.Equals("WSOPH"))
                return CurrencyEnum.WSOPH;

            if (value.Equals("RAT"))
                return CurrencyEnum.RAT;

            if (value.Equals("USDC"))
                return CurrencyEnum.USDC;

            throw new NotImplementedException($"Could not convert value to type CurrencyEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="CurrencyEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CurrencyEnum? CurrencyEnumFromStringOrDefault(string value)
        {
            if (value.Equals("WBEAM"))
                return CurrencyEnum.WBEAM;

            if (value.Equals("WIMX"))
                return CurrencyEnum.WIMX;

            if (value.Equals("WSOPH"))
                return CurrencyEnum.WSOPH;

            if (value.Equals("RAT"))
                return CurrencyEnum.RAT;

            if (value.Equals("USDC"))
                return CurrencyEnum.USDC;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="CurrencyEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string CurrencyEnumToJsonValue(CurrencyEnum? value)
        {
            if (value == CurrencyEnum.WBEAM)
                return "WBEAM";

            if (value == CurrencyEnum.WIMX)
                return "WIMX";

            if (value == CurrencyEnum.WSOPH)
                return "WSOPH";

            if (value == CurrencyEnum.RAT)
                return "RAT";

            if (value == CurrencyEnum.USDC)
                return "USDC";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="CurrencyEnum"/> to and from the JSON value
        /// </summary>
        public static class CurrencyEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="CurrencyEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static CurrencyEnum FromString(string value)
            {
                    if (value.Equals("WBEAM"))
                        return CurrencyEnum.WBEAM;

                    if (value.Equals("WIMX"))
                        return CurrencyEnum.WIMX;

                    if (value.Equals("WSOPH"))
                        return CurrencyEnum.WSOPH;

                    if (value.Equals("RAT"))
                        return CurrencyEnum.RAT;

                    if (value.Equals("USDC"))
                        return CurrencyEnum.USDC;

                throw new NotImplementedException($"Could not convert value to type CurrencyEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="CurrencyEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static CurrencyEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("WBEAM"))
                        return CurrencyEnum.WBEAM;

                    if (value.Equals("WIMX"))
                        return CurrencyEnum.WIMX;

                    if (value.Equals("WSOPH"))
                        return CurrencyEnum.WSOPH;

                    if (value.Equals("RAT"))
                        return CurrencyEnum.RAT;

                    if (value.Equals("USDC"))
                        return CurrencyEnum.USDC;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="CurrencyEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(CurrencyEnum value)
            {
                        if (value == CurrencyEnum.WBEAM)
                            return "WBEAM";

                        if (value == CurrencyEnum.WIMX)
                            return "WIMX";

                        if (value == CurrencyEnum.WSOPH)
                            return "WSOPH";

                        if (value == CurrencyEnum.RAT)
                            return "RAT";

                        if (value == CurrencyEnum.USDC)
                            return "USDC";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="CurrencyEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class CurrencyEnumJsonConverter : JsonConverter<CurrencyEnum>
        {
            /// <summary>
            /// Returns a CurrencyEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override CurrencyEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                CurrencyEnum? result = rawValue == null
                    ? null
                    : CurrencyEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the CurrencyEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="currencyEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, CurrencyEnum currencyEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(CurrencyEnumValueConverter.ToJsonValue(currencyEnum));
            }
        }

        /// <summary>
        /// Used to track the state of Currency
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<CurrencyEnum?> CurrencyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [JsonPropertyName("currency")]
        public CurrencyEnum? Currency { get { return this.CurrencyOption; } set { this.CurrencyOption = new(value); } }

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
        /// Gets or Sets AssetAddress
        /// </summary>
        [JsonPropertyName("assetAddress")]
        public string AssetAddress { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [JsonPropertyName("assetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

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
        /// Used to track the state of EndTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> EndTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get { return this. EndTimeOption; } set { this.EndTimeOption = new(value); } }

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
        /// Used to track the state of StartTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> StartTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get { return this. StartTimeOption; } set { this.StartTimeOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerCreateAssetOfferRequestInput {\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  OperationProcessing: ").Append(OperationProcessing).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            if (this.AssetId != null) {
                // AssetId (string) pattern
                Regex regexAssetId = new Regex(@"^\d+$", RegexOptions.CultureInvariant);

                if (!regexAssetId.Match(this.AssetId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssetId, must match a pattern of " + regexAssetId, new [] { "AssetId" });
                }
            }

            // Quantity (decimal) minimum
            if (this.Quantity < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 1.", new [] { "Quantity" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="PlayerCreateAssetOfferRequestInput" />
    /// </summary>
    public class PlayerCreateAssetOfferRequestInputJsonConverter : JsonConverter<PlayerCreateAssetOfferRequestInput>
    {
        /// <summary>
        /// The format to use to serialize EndTime
        /// </summary>
        public static string EndTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize StartTime
        /// </summary>
        public static string StartTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="PlayerCreateAssetOfferRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerCreateAssetOfferRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> assetAddress = default;
            Option<string?> assetId = default;
            Option<string?> price = default;
            Option<decimal?> quantity = default;
            Option<decimal?> chainId = default;
            Option<PlayerCreateAssetOfferRequestInput.CurrencyEnum?> currency = default;
            Option<DateTime?> endTime = default;
            Option<string?> operationId = default;
            Option<PlayerCreateAssetOfferRequestInput.OperationProcessingEnum?> operationProcessing = default;
            Option<DateTime?> startTime = default;

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
                        case "assetAddress":
                            assetAddress = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "assetId":
                            assetId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "price":
                            price = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "quantity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quantity = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "currency":
                            string? currencyRawValue = utf8JsonReader.GetString();
                            if (currencyRawValue != null)
                                currency = new Option<PlayerCreateAssetOfferRequestInput.CurrencyEnum?>(PlayerCreateAssetOfferRequestInput.CurrencyEnumFromStringOrDefault(currencyRawValue));
                            break;
                        case "endTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endTime = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "operationId":
                            operationId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "operationProcessing":
                            string? operationProcessingRawValue = utf8JsonReader.GetString();
                            if (operationProcessingRawValue != null)
                                operationProcessing = new Option<PlayerCreateAssetOfferRequestInput.OperationProcessingEnum?>(PlayerCreateAssetOfferRequestInput.OperationProcessingEnumFromStringOrDefault(operationProcessingRawValue));
                            break;
                        case "startTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startTime = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!assetAddress.IsSet)
                throw new ArgumentException("Property is required for class PlayerCreateAssetOfferRequestInput.", nameof(assetAddress));

            if (!assetId.IsSet)
                throw new ArgumentException("Property is required for class PlayerCreateAssetOfferRequestInput.", nameof(assetId));

            if (!price.IsSet)
                throw new ArgumentException("Property is required for class PlayerCreateAssetOfferRequestInput.", nameof(price));

            if (!quantity.IsSet)
                throw new ArgumentException("Property is required for class PlayerCreateAssetOfferRequestInput.", nameof(quantity));

            if (assetAddress.IsSet && assetAddress.Value == null)
                throw new ArgumentNullException(nameof(assetAddress), "Property is not nullable for class PlayerCreateAssetOfferRequestInput.");

            if (assetId.IsSet && assetId.Value == null)
                throw new ArgumentNullException(nameof(assetId), "Property is not nullable for class PlayerCreateAssetOfferRequestInput.");

            if (price.IsSet && price.Value == null)
                throw new ArgumentNullException(nameof(price), "Property is not nullable for class PlayerCreateAssetOfferRequestInput.");

            if (quantity.IsSet && quantity.Value == null)
                throw new ArgumentNullException(nameof(quantity), "Property is not nullable for class PlayerCreateAssetOfferRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerCreateAssetOfferRequestInput.");

            if (currency.IsSet && currency.Value == null)
                throw new ArgumentNullException(nameof(currency), "Property is not nullable for class PlayerCreateAssetOfferRequestInput.");

            if (endTime.IsSet && endTime.Value == null)
                throw new ArgumentNullException(nameof(endTime), "Property is not nullable for class PlayerCreateAssetOfferRequestInput.");

            if (operationProcessing.IsSet && operationProcessing.Value == null)
                throw new ArgumentNullException(nameof(operationProcessing), "Property is not nullable for class PlayerCreateAssetOfferRequestInput.");

            if (startTime.IsSet && startTime.Value == null)
                throw new ArgumentNullException(nameof(startTime), "Property is not nullable for class PlayerCreateAssetOfferRequestInput.");

            return new PlayerCreateAssetOfferRequestInput(assetAddress.Value!, assetId.Value!, price.Value!, quantity.Value!.Value!, chainId, currency, endTime, operationId, operationProcessing, startTime);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerCreateAssetOfferRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCreateAssetOfferRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerCreateAssetOfferRequestInput playerCreateAssetOfferRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, playerCreateAssetOfferRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerCreateAssetOfferRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCreateAssetOfferRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PlayerCreateAssetOfferRequestInput playerCreateAssetOfferRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerCreateAssetOfferRequestInput.AssetAddress == null)
                throw new ArgumentNullException(nameof(playerCreateAssetOfferRequestInput.AssetAddress), "Property is required for class PlayerCreateAssetOfferRequestInput.");

            if (playerCreateAssetOfferRequestInput.AssetId == null)
                throw new ArgumentNullException(nameof(playerCreateAssetOfferRequestInput.AssetId), "Property is required for class PlayerCreateAssetOfferRequestInput.");

            if (playerCreateAssetOfferRequestInput.Price == null)
                throw new ArgumentNullException(nameof(playerCreateAssetOfferRequestInput.Price), "Property is required for class PlayerCreateAssetOfferRequestInput.");

            writer.WriteString("assetAddress", playerCreateAssetOfferRequestInput.AssetAddress);

            writer.WriteString("assetId", playerCreateAssetOfferRequestInput.AssetId);

            writer.WriteString("price", playerCreateAssetOfferRequestInput.Price);

            writer.WriteNumber("quantity", playerCreateAssetOfferRequestInput.Quantity);

            if (playerCreateAssetOfferRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", playerCreateAssetOfferRequestInput.ChainIdOption.Value!.Value);

            var currencyRawValue = PlayerCreateAssetOfferRequestInput.CurrencyEnumToJsonValue(playerCreateAssetOfferRequestInput.CurrencyOption.Value!.Value);
            writer.WriteString("currency", currencyRawValue);
            if (playerCreateAssetOfferRequestInput.EndTimeOption.IsSet)
                writer.WriteString("endTime", playerCreateAssetOfferRequestInput.EndTimeOption.Value!.Value.ToString(EndTimeFormat));

            if (playerCreateAssetOfferRequestInput.OperationIdOption.IsSet)
                if (playerCreateAssetOfferRequestInput.OperationIdOption.Value != null)
                    writer.WriteString("operationId", playerCreateAssetOfferRequestInput.OperationId);
                else
                    writer.WriteNull("operationId");

            var operationProcessingRawValue = PlayerCreateAssetOfferRequestInput.OperationProcessingEnumToJsonValue(playerCreateAssetOfferRequestInput.OperationProcessingOption.Value!.Value);
            writer.WriteString("operationProcessing", operationProcessingRawValue);
            if (playerCreateAssetOfferRequestInput.StartTimeOption.IsSet)
                writer.WriteString("startTime", playerCreateAssetOfferRequestInput.StartTimeOption.Value!.Value.ToString(StartTimeFormat));
        }
    }
}