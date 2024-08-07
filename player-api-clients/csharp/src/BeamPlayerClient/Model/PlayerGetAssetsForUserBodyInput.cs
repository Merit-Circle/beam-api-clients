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
    /// PlayerGetAssetsForUserBodyInput
    /// </summary>
    public partial class PlayerGetAssetsForUserBodyInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetAssetsForUserBodyInput" /> class.
        /// </summary>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="continuation">continuation</param>
        /// <param name="contract">contract</param>
        /// <param name="includeAttributes">includeAttributes (default to false)</param>
        /// <param name="limit">limit (default to 20M)</param>
        /// <param name="sortBy">sortBy (default to SortByEnum.AcquiredAt)</param>
        /// <param name="sortDirection">sortDirection (default to SortDirectionEnum.Asc)</param>
        [JsonConstructor]
        public PlayerGetAssetsForUserBodyInput(Option<decimal?> chainId = default, Option<string?> continuation = default, Option<string?> contract = default, Option<bool?> includeAttributes = default, Option<decimal?> limit = default, Option<SortByEnum?> sortBy = default, Option<SortDirectionEnum?> sortDirection = default)
        {
            ChainIdOption = chainId;
            ContinuationOption = continuation;
            ContractOption = contract;
            IncludeAttributesOption = includeAttributes;
            LimitOption = limit;
            SortByOption = sortBy;
            SortDirectionOption = sortDirection;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines SortBy
        /// </summary>
        [JsonConverter(typeof(SortByEnumJsonConverter))]
        public enum SortByEnum
        {
            /// <summary>
            /// Enum AcquiredAt for value: acquiredAt
            /// </summary>
            AcquiredAt = 1,

            /// <summary>
            /// Enum LastAppraisalValue for value: lastAppraisalValue
            /// </summary>
            LastAppraisalValue = 2
        }

        /// <summary>
        /// Returns a <see cref="SortByEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static SortByEnum SortByEnumFromString(string value)
        {
            if (value.Equals("acquiredAt"))
                return SortByEnum.AcquiredAt;

            if (value.Equals("lastAppraisalValue"))
                return SortByEnum.LastAppraisalValue;

            throw new NotImplementedException($"Could not convert value to type SortByEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="SortByEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SortByEnum? SortByEnumFromStringOrDefault(string value)
        {
            if (value.Equals("acquiredAt"))
                return SortByEnum.AcquiredAt;

            if (value.Equals("lastAppraisalValue"))
                return SortByEnum.LastAppraisalValue;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="SortByEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string SortByEnumToJsonValue(SortByEnum? value)
        {
            if (value == SortByEnum.AcquiredAt)
                return "acquiredAt";

            if (value == SortByEnum.LastAppraisalValue)
                return "lastAppraisalValue";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="SortByEnum"/> to and from the JSON value
        /// </summary>
        public static class SortByEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="SortByEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static SortByEnum FromString(string value)
            {
                    if (value.Equals("acquiredAt"))
                        return SortByEnum.AcquiredAt;

                    if (value.Equals("lastAppraisalValue"))
                        return SortByEnum.LastAppraisalValue;

                throw new NotImplementedException($"Could not convert value to type SortByEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="SortByEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static SortByEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("acquiredAt"))
                        return SortByEnum.AcquiredAt;

                    if (value.Equals("lastAppraisalValue"))
                        return SortByEnum.LastAppraisalValue;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="SortByEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(SortByEnum value)
            {
                        if (value == SortByEnum.AcquiredAt)
                            return "acquiredAt";

                        if (value == SortByEnum.LastAppraisalValue)
                            return "lastAppraisalValue";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="SortByEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class SortByEnumJsonConverter : JsonConverter<SortByEnum>
        {
            /// <summary>
            /// Returns a SortByEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override SortByEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                SortByEnum? result = rawValue == null
                    ? null
                    : SortByEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the SortByEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="sortByEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, SortByEnum sortByEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(SortByEnumValueConverter.ToJsonValue(sortByEnum));
            }
        }

        /// <summary>
        /// Used to track the state of SortBy
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<SortByEnum?> SortByOption { get; private set; }

        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [JsonPropertyName("sortBy")]
        public SortByEnum? SortBy { get { return this.SortByOption; } set { this.SortByOption = new(value); } }

        /// <summary>
        /// Defines SortDirection
        /// </summary>
        [JsonConverter(typeof(SortDirectionEnumJsonConverter))]
        public enum SortDirectionEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            Desc = 2
        }

        /// <summary>
        /// Returns a <see cref="SortDirectionEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static SortDirectionEnum SortDirectionEnumFromString(string value)
        {
            if (value.Equals("asc"))
                return SortDirectionEnum.Asc;

            if (value.Equals("desc"))
                return SortDirectionEnum.Desc;

            throw new NotImplementedException($"Could not convert value to type SortDirectionEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="SortDirectionEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SortDirectionEnum? SortDirectionEnumFromStringOrDefault(string value)
        {
            if (value.Equals("asc"))
                return SortDirectionEnum.Asc;

            if (value.Equals("desc"))
                return SortDirectionEnum.Desc;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="SortDirectionEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string SortDirectionEnumToJsonValue(SortDirectionEnum? value)
        {
            if (value == SortDirectionEnum.Asc)
                return "asc";

            if (value == SortDirectionEnum.Desc)
                return "desc";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="SortDirectionEnum"/> to and from the JSON value
        /// </summary>
        public static class SortDirectionEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="SortDirectionEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static SortDirectionEnum FromString(string value)
            {
                    if (value.Equals("asc"))
                        return SortDirectionEnum.Asc;

                    if (value.Equals("desc"))
                        return SortDirectionEnum.Desc;

                throw new NotImplementedException($"Could not convert value to type SortDirectionEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="SortDirectionEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static SortDirectionEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("asc"))
                        return SortDirectionEnum.Asc;

                    if (value.Equals("desc"))
                        return SortDirectionEnum.Desc;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="SortDirectionEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(SortDirectionEnum value)
            {
                        if (value == SortDirectionEnum.Asc)
                            return "asc";

                        if (value == SortDirectionEnum.Desc)
                            return "desc";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="SortDirectionEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class SortDirectionEnumJsonConverter : JsonConverter<SortDirectionEnum>
        {
            /// <summary>
            /// Returns a SortDirectionEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override SortDirectionEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                SortDirectionEnum? result = rawValue == null
                    ? null
                    : SortDirectionEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the SortDirectionEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="sortDirectionEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, SortDirectionEnum sortDirectionEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(SortDirectionEnumValueConverter.ToJsonValue(sortDirectionEnum));
            }
        }

        /// <summary>
        /// Used to track the state of SortDirection
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<SortDirectionEnum?> SortDirectionOption { get; private set; }

        /// <summary>
        /// Gets or Sets SortDirection
        /// </summary>
        [JsonPropertyName("sortDirection")]
        public SortDirectionEnum? SortDirection { get { return this.SortDirectionOption; } set { this.SortDirectionOption = new(value); } }

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
        /// Used to track the state of Continuation
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ContinuationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Continuation
        /// </summary>
        [JsonPropertyName("continuation")]
        public string? Continuation { get { return this. ContinuationOption; } set { this.ContinuationOption = new(value); } }

        /// <summary>
        /// Used to track the state of Contract
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ContractOption { get; private set; }

        /// <summary>
        /// Gets or Sets Contract
        /// </summary>
        [JsonPropertyName("contract")]
        public string? Contract { get { return this. ContractOption; } set { this.ContractOption = new(value); } }

        /// <summary>
        /// Used to track the state of IncludeAttributes
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IncludeAttributesOption { get; private set; }

        /// <summary>
        /// Gets or Sets IncludeAttributes
        /// </summary>
        [JsonPropertyName("includeAttributes")]
        public bool? IncludeAttributes { get { return this. IncludeAttributesOption; } set { this.IncludeAttributesOption = new(value); } }

        /// <summary>
        /// Used to track the state of Limit
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> LimitOption { get; private set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [JsonPropertyName("limit")]
        public decimal? Limit { get { return this. LimitOption; } set { this.LimitOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetAssetsForUserBodyInput {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Continuation: ").Append(Continuation).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  IncludeAttributes: ").Append(IncludeAttributes).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SortDirection: ").Append(SortDirection).Append("\n");
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
            // Limit (decimal) maximum
            if (this.LimitOption.IsSet && this.LimitOption.Value > (decimal)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value less than or equal to 100.", new [] { "Limit" });
            }

            // Limit (decimal) minimum
            if (this.LimitOption.IsSet && this.LimitOption.Value < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value greater than or equal to 1.", new [] { "Limit" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="PlayerGetAssetsForUserBodyInput" />
    /// </summary>
    public class PlayerGetAssetsForUserBodyInputJsonConverter : JsonConverter<PlayerGetAssetsForUserBodyInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerGetAssetsForUserBodyInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetAssetsForUserBodyInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> chainId = default;
            Option<string?> continuation = default;
            Option<string?> contract = default;
            Option<bool?> includeAttributes = default;
            Option<decimal?> limit = default;
            Option<PlayerGetAssetsForUserBodyInput.SortByEnum?> sortBy = default;
            Option<PlayerGetAssetsForUserBodyInput.SortDirectionEnum?> sortDirection = default;

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
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "continuation":
                            continuation = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "contract":
                            contract = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "includeAttributes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                includeAttributes = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "limit":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                limit = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "sortBy":
                            string? sortByRawValue = utf8JsonReader.GetString();
                            if (sortByRawValue != null)
                                sortBy = new Option<PlayerGetAssetsForUserBodyInput.SortByEnum?>(PlayerGetAssetsForUserBodyInput.SortByEnumFromStringOrDefault(sortByRawValue));
                            break;
                        case "sortDirection":
                            string? sortDirectionRawValue = utf8JsonReader.GetString();
                            if (sortDirectionRawValue != null)
                                sortDirection = new Option<PlayerGetAssetsForUserBodyInput.SortDirectionEnum?>(PlayerGetAssetsForUserBodyInput.SortDirectionEnumFromStringOrDefault(sortDirectionRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerGetAssetsForUserBodyInput.");

            if (limit.IsSet && limit.Value == null)
                throw new ArgumentNullException(nameof(limit), "Property is not nullable for class PlayerGetAssetsForUserBodyInput.");

            if (sortBy.IsSet && sortBy.Value == null)
                throw new ArgumentNullException(nameof(sortBy), "Property is not nullable for class PlayerGetAssetsForUserBodyInput.");

            if (sortDirection.IsSet && sortDirection.Value == null)
                throw new ArgumentNullException(nameof(sortDirection), "Property is not nullable for class PlayerGetAssetsForUserBodyInput.");

            return new PlayerGetAssetsForUserBodyInput(chainId, continuation, contract, includeAttributes, limit, sortBy, sortDirection);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetAssetsForUserBodyInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetAssetsForUserBodyInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetAssetsForUserBodyInput playerGetAssetsForUserBodyInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, playerGetAssetsForUserBodyInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetAssetsForUserBodyInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetAssetsForUserBodyInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PlayerGetAssetsForUserBodyInput playerGetAssetsForUserBodyInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetAssetsForUserBodyInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", playerGetAssetsForUserBodyInput.ChainIdOption.Value!.Value);

            if (playerGetAssetsForUserBodyInput.ContinuationOption.IsSet)
                if (playerGetAssetsForUserBodyInput.ContinuationOption.Value != null)
                    writer.WriteString("continuation", playerGetAssetsForUserBodyInput.Continuation);
                else
                    writer.WriteNull("continuation");

            if (playerGetAssetsForUserBodyInput.ContractOption.IsSet)
                if (playerGetAssetsForUserBodyInput.ContractOption.Value != null)
                    writer.WriteString("contract", playerGetAssetsForUserBodyInput.Contract);
                else
                    writer.WriteNull("contract");

            if (playerGetAssetsForUserBodyInput.IncludeAttributesOption.IsSet)
                if (playerGetAssetsForUserBodyInput.IncludeAttributesOption.Value != null)
                    writer.WriteBoolean("includeAttributes", playerGetAssetsForUserBodyInput.IncludeAttributesOption.Value!.Value);
                else
                    writer.WriteNull("includeAttributes");

            if (playerGetAssetsForUserBodyInput.LimitOption.IsSet)
                writer.WriteNumber("limit", playerGetAssetsForUserBodyInput.LimitOption.Value!.Value);

            var sortByRawValue = PlayerGetAssetsForUserBodyInput.SortByEnumToJsonValue(playerGetAssetsForUserBodyInput.SortByOption.Value!.Value);
            writer.WriteString("sortBy", sortByRawValue);
            var sortDirectionRawValue = PlayerGetAssetsForUserBodyInput.SortDirectionEnumToJsonValue(playerGetAssetsForUserBodyInput.SortDirectionOption.Value!.Value);
            writer.WriteString("sortDirection", sortDirectionRawValue);
        }
    }
}