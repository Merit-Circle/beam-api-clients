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
using OpenAPIClientUtils = BeamPlayerClient.Client.ClientUtils;
using BeamPlayerClient.Client;

namespace BeamPlayerClient.Model
{
    /// <summary>
    /// GetAssetListingsResponseDataInnerPriceCurrency
    /// </summary>
    public partial class GetAssetListingsResponseDataInnerPriceCurrency : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetListingsResponseDataInnerPriceCurrency" /> class.
        /// </summary>
        /// <param name="address">address</param>
        /// <param name="decimals">decimals</param>
        /// <param name="symbol">symbol</param>
        [JsonConstructor]
        public GetAssetListingsResponseDataInnerPriceCurrency(string address, int decimals, Option<SymbolEnum?> symbol = default)
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
        public enum SymbolEnum
        {
            /// <summary>
            /// Enum BEAM for value: BEAM
            /// </summary>
            BEAM = 1,

            /// <summary>
            /// Enum WBEAM for value: WBEAM
            /// </summary>
            WBEAM = 2,

            /// <summary>
            /// Enum USDC for value: USDC
            /// </summary>
            USDC = 3,

            /// <summary>
            /// Enum USDT for value: USDT
            /// </summary>
            USDT = 4,

            /// <summary>
            /// Enum IMX for value: IMX
            /// </summary>
            IMX = 5,

            /// <summary>
            /// Enum WIMX for value: WIMX
            /// </summary>
            WIMX = 6
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

            if (value.Equals("WBEAM"))
                return SymbolEnum.WBEAM;

            if (value.Equals("USDC"))
                return SymbolEnum.USDC;

            if (value.Equals("USDT"))
                return SymbolEnum.USDT;

            if (value.Equals("IMX"))
                return SymbolEnum.IMX;

            if (value.Equals("WIMX"))
                return SymbolEnum.WIMX;

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

            if (value.Equals("WBEAM"))
                return SymbolEnum.WBEAM;

            if (value.Equals("USDC"))
                return SymbolEnum.USDC;

            if (value.Equals("USDT"))
                return SymbolEnum.USDT;

            if (value.Equals("IMX"))
                return SymbolEnum.IMX;

            if (value.Equals("WIMX"))
                return SymbolEnum.WIMX;

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

            if (value == SymbolEnum.WBEAM)
                return "WBEAM";

            if (value == SymbolEnum.USDC)
                return "USDC";

            if (value == SymbolEnum.USDT)
                return "USDT";

            if (value == SymbolEnum.IMX)
                return "IMX";

            if (value == SymbolEnum.WIMX)
                return "WIMX";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
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
            sb.Append("class GetAssetListingsResponseDataInnerPriceCurrency {\n");
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
    /// A Json converter for type <see cref="GetAssetListingsResponseDataInnerPriceCurrency" />
    /// </summary>
    public class GetAssetListingsResponseDataInnerPriceCurrencyJsonConverter : JsonConverter<GetAssetListingsResponseDataInnerPriceCurrency>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAssetListingsResponseDataInnerPriceCurrency" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAssetListingsResponseDataInnerPriceCurrency Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> address = default;
            Option<int?> decimals = default;
            Option<GetAssetListingsResponseDataInnerPriceCurrency.SymbolEnum?> symbol = default;

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
                                symbol = new Option<GetAssetListingsResponseDataInnerPriceCurrency.SymbolEnum?>(GetAssetListingsResponseDataInnerPriceCurrency.SymbolEnumFromStringOrDefault(symbolRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!address.IsSet)
                throw new ArgumentException("Property is required for class GetAssetListingsResponseDataInnerPriceCurrency.", nameof(address));

            if (!decimals.IsSet)
                throw new ArgumentException("Property is required for class GetAssetListingsResponseDataInnerPriceCurrency.", nameof(decimals));

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class GetAssetListingsResponseDataInnerPriceCurrency.");

            if (decimals.IsSet && decimals.Value == null)
                throw new ArgumentNullException(nameof(decimals), "Property is not nullable for class GetAssetListingsResponseDataInnerPriceCurrency.");

            return new GetAssetListingsResponseDataInnerPriceCurrency(address.Value!, decimals.Value!.Value!, symbol);
        }

        /// <summary>
        /// Serializes a <see cref="GetAssetListingsResponseDataInnerPriceCurrency" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetListingsResponseDataInnerPriceCurrency"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAssetListingsResponseDataInnerPriceCurrency getAssetListingsResponseDataInnerPriceCurrency, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getAssetListingsResponseDataInnerPriceCurrency, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAssetListingsResponseDataInnerPriceCurrency" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetListingsResponseDataInnerPriceCurrency"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetAssetListingsResponseDataInnerPriceCurrency getAssetListingsResponseDataInnerPriceCurrency, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAssetListingsResponseDataInnerPriceCurrency.Address == null)
                throw new ArgumentNullException(nameof(getAssetListingsResponseDataInnerPriceCurrency.Address), "Property is required for class GetAssetListingsResponseDataInnerPriceCurrency.");

            writer.WriteString("address", getAssetListingsResponseDataInnerPriceCurrency.Address);

            writer.WriteNumber("decimals", getAssetListingsResponseDataInnerPriceCurrency.Decimals);

            var symbolRawValue = GetAssetListingsResponseDataInnerPriceCurrency.SymbolEnumToJsonValue(getAssetListingsResponseDataInnerPriceCurrency.SymbolOption.Value!.Value);
            if (symbolRawValue != null)
                writer.WriteString("symbol", symbolRawValue);
            else
                writer.WriteNull("symbol");
        }
    }
}