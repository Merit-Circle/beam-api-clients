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
    /// AutomationGetAssetListingsResponseV2DataInnerPriceCurrency
    /// </summary>
    public partial class AutomationGetAssetListingsResponseV2DataInnerPriceCurrency : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationGetAssetListingsResponseV2DataInnerPriceCurrency" /> class.
        /// </summary>
        /// <param name="address">address</param>
        /// <param name="decimals">decimals</param>
        /// <param name="symbol">symbol</param>
        [JsonConstructor]
        public AutomationGetAssetListingsResponseV2DataInnerPriceCurrency(string address, int decimals, Option<SymbolEnum?> symbol = default)
        {
            Address = address;
            Decimals = decimals;
            SymbolOption = symbol;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Symbol
        /// </summary>
        [JsonConverter(typeof(SymbolEnumJsonConverter))]
        public enum SymbolEnum
        {
            /// <summary>
            /// Enum BEAM for value: BEAM
            /// </summary>
            BEAM = 1,

            /// <summary>
            /// Enum IMX for value: IMX
            /// </summary>
            IMX = 2,

            /// <summary>
            /// Enum SOPH for value: SOPH
            /// </summary>
            SOPH = 3,

            /// <summary>
            /// Enum WBEAM for value: WBEAM
            /// </summary>
            WBEAM = 4,

            /// <summary>
            /// Enum WIMX for value: WIMX
            /// </summary>
            WIMX = 5,

            /// <summary>
            /// Enum WSOPH for value: WSOPH
            /// </summary>
            WSOPH = 6,

            /// <summary>
            /// Enum USDC for value: USDC
            /// </summary>
            USDC = 7
        }

        /// <summary>
        /// Returns a <see cref="SymbolEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static SymbolEnum SymbolEnumFromString(string value)
        {
            if (value.Equals("BEAM"))
                return SymbolEnum.BEAM;

            if (value.Equals("IMX"))
                return SymbolEnum.IMX;

            if (value.Equals("SOPH"))
                return SymbolEnum.SOPH;

            if (value.Equals("WBEAM"))
                return SymbolEnum.WBEAM;

            if (value.Equals("WIMX"))
                return SymbolEnum.WIMX;

            if (value.Equals("WSOPH"))
                return SymbolEnum.WSOPH;

            if (value.Equals("USDC"))
                return SymbolEnum.USDC;

            throw new NotImplementedException($"Could not convert value to type SymbolEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="SymbolEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SymbolEnum? SymbolEnumFromStringOrDefault(string value)
        {
            if (value.Equals("BEAM"))
                return SymbolEnum.BEAM;

            if (value.Equals("IMX"))
                return SymbolEnum.IMX;

            if (value.Equals("SOPH"))
                return SymbolEnum.SOPH;

            if (value.Equals("WBEAM"))
                return SymbolEnum.WBEAM;

            if (value.Equals("WIMX"))
                return SymbolEnum.WIMX;

            if (value.Equals("WSOPH"))
                return SymbolEnum.WSOPH;

            if (value.Equals("USDC"))
                return SymbolEnum.USDC;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="SymbolEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string? SymbolEnumToJsonValue(SymbolEnum? value)
        {
            if (value == null)
                return null;

            if (value == SymbolEnum.BEAM)
                return "BEAM";

            if (value == SymbolEnum.IMX)
                return "IMX";

            if (value == SymbolEnum.SOPH)
                return "SOPH";

            if (value == SymbolEnum.WBEAM)
                return "WBEAM";

            if (value == SymbolEnum.WIMX)
                return "WIMX";

            if (value == SymbolEnum.WSOPH)
                return "WSOPH";

            if (value == SymbolEnum.USDC)
                return "USDC";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="SymbolEnum"/> to and from the JSON value
        /// </summary>
        public static class SymbolEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="SymbolEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static SymbolEnum FromString(string value)
            {
                    if (value.Equals("BEAM"))
                        return SymbolEnum.BEAM;

                    if (value.Equals("IMX"))
                        return SymbolEnum.IMX;

                    if (value.Equals("SOPH"))
                        return SymbolEnum.SOPH;

                    if (value.Equals("WBEAM"))
                        return SymbolEnum.WBEAM;

                    if (value.Equals("WIMX"))
                        return SymbolEnum.WIMX;

                    if (value.Equals("WSOPH"))
                        return SymbolEnum.WSOPH;

                    if (value.Equals("USDC"))
                        return SymbolEnum.USDC;

                throw new NotImplementedException($"Could not convert value to type SymbolEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="SymbolEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static SymbolEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("BEAM"))
                        return SymbolEnum.BEAM;

                    if (value.Equals("IMX"))
                        return SymbolEnum.IMX;

                    if (value.Equals("SOPH"))
                        return SymbolEnum.SOPH;

                    if (value.Equals("WBEAM"))
                        return SymbolEnum.WBEAM;

                    if (value.Equals("WIMX"))
                        return SymbolEnum.WIMX;

                    if (value.Equals("WSOPH"))
                        return SymbolEnum.WSOPH;

                    if (value.Equals("USDC"))
                        return SymbolEnum.USDC;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="SymbolEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(SymbolEnum value)
            {
                        if (value == SymbolEnum.BEAM)
                            return "BEAM";

                        if (value == SymbolEnum.IMX)
                            return "IMX";

                        if (value == SymbolEnum.SOPH)
                            return "SOPH";

                        if (value == SymbolEnum.WBEAM)
                            return "WBEAM";

                        if (value == SymbolEnum.WIMX)
                            return "WIMX";

                        if (value == SymbolEnum.WSOPH)
                            return "WSOPH";

                        if (value == SymbolEnum.USDC)
                            return "USDC";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="SymbolEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class SymbolEnumJsonConverter : JsonConverter<SymbolEnum>
        {
            /// <summary>
            /// Returns a SymbolEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override SymbolEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                SymbolEnum? result = rawValue == null
                    ? null
                    : SymbolEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the SymbolEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="symbolEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, SymbolEnum symbolEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(SymbolEnumValueConverter.ToJsonValue(symbolEnum));
            }
        }

        /// <summary>
        /// Used to track the state of Symbol
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<SymbolEnum?> SymbolOption { get; private set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public SymbolEnum? Symbol { get { return this.SymbolOption; } set { this.SymbolOption = new(value); } }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Decimals
        /// </summary>
        [JsonPropertyName("decimals")]
        public int Decimals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationGetAssetListingsResponseV2DataInnerPriceCurrency {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
    /// A Json converter for type <see cref="AutomationGetAssetListingsResponseV2DataInnerPriceCurrency" />
    /// </summary>
    public class AutomationGetAssetListingsResponseV2DataInnerPriceCurrencyJsonConverter : JsonConverter<AutomationGetAssetListingsResponseV2DataInnerPriceCurrency>
    {
        /// <summary>
        /// Deserializes json to <see cref="AutomationGetAssetListingsResponseV2DataInnerPriceCurrency" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationGetAssetListingsResponseV2DataInnerPriceCurrency Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> address = default;
            Option<int?> decimals = default;
            Option<AutomationGetAssetListingsResponseV2DataInnerPriceCurrency.SymbolEnum?> symbol = default;

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
                        case "address":
                            address = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "decimals":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                decimals = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "symbol":
                            string? symbolRawValue = utf8JsonReader.GetString();
                            if (symbolRawValue != null)
                                symbol = new Option<AutomationGetAssetListingsResponseV2DataInnerPriceCurrency.SymbolEnum?>(AutomationGetAssetListingsResponseV2DataInnerPriceCurrency.SymbolEnumFromStringOrDefault(symbolRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!address.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAssetListingsResponseV2DataInnerPriceCurrency.", nameof(address));

            if (!decimals.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAssetListingsResponseV2DataInnerPriceCurrency.", nameof(decimals));

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class AutomationGetAssetListingsResponseV2DataInnerPriceCurrency.");

            if (decimals.IsSet && decimals.Value == null)
                throw new ArgumentNullException(nameof(decimals), "Property is not nullable for class AutomationGetAssetListingsResponseV2DataInnerPriceCurrency.");

            return new AutomationGetAssetListingsResponseV2DataInnerPriceCurrency(address.Value!, decimals.Value!.Value!, symbol);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationGetAssetListingsResponseV2DataInnerPriceCurrency" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetAssetListingsResponseV2DataInnerPriceCurrency"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationGetAssetListingsResponseV2DataInnerPriceCurrency automationGetAssetListingsResponseV2DataInnerPriceCurrency, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, automationGetAssetListingsResponseV2DataInnerPriceCurrency, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationGetAssetListingsResponseV2DataInnerPriceCurrency" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetAssetListingsResponseV2DataInnerPriceCurrency"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AutomationGetAssetListingsResponseV2DataInnerPriceCurrency automationGetAssetListingsResponseV2DataInnerPriceCurrency, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationGetAssetListingsResponseV2DataInnerPriceCurrency.Address == null)
                throw new ArgumentNullException(nameof(automationGetAssetListingsResponseV2DataInnerPriceCurrency.Address), "Property is required for class AutomationGetAssetListingsResponseV2DataInnerPriceCurrency.");

            writer.WriteString("address", automationGetAssetListingsResponseV2DataInnerPriceCurrency.Address);

            writer.WriteNumber("decimals", automationGetAssetListingsResponseV2DataInnerPriceCurrency.Decimals);

            var symbolRawValue = AutomationGetAssetListingsResponseV2DataInnerPriceCurrency.SymbolEnumToJsonValue(automationGetAssetListingsResponseV2DataInnerPriceCurrency.SymbolOption.Value!.Value);
            if (symbolRawValue != null)
                writer.WriteString("symbol", symbolRawValue);
            else
                writer.WriteNull("symbol");
        }
    }
}