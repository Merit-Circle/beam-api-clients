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
    /// AutomationGetGameResponseContractsInner
    /// </summary>
    public partial class AutomationGetGameResponseContractsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationGetGameResponseContractsInner" /> class.
        /// </summary>
        /// <param name="address">address</param>
        /// <param name="chainId">chainId</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="externalId">externalId</param>
        /// <param name="id">id</param>
        /// <param name="type">type</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="abi">abi</param>
        /// <param name="gameId">gameId</param>
        /// <param name="name">name</param>
        [JsonConstructor]
        public AutomationGetGameResponseContractsInner(string address, int chainId, DateTime createdAt, string externalId, string id, TypeEnum type, DateTime updatedAt, Object? abi = default, string? gameId = default, string? name = default)
        {
            Address = address;
            ChainId = chainId;
            CreatedAt = createdAt;
            ExternalId = externalId;
            Id = id;
            Type = type;
            UpdatedAt = updatedAt;
            Abi = abi;
            GameId = gameId;
            Name = name;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(TypeEnumJsonConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ERC20 for value: ERC20
            /// </summary>
            ERC20 = 1,

            /// <summary>
            /// Enum ERC721 for value: ERC721
            /// </summary>
            ERC721 = 2,

            /// <summary>
            /// Enum ERC1155 for value: ERC1155
            /// </summary>
            ERC1155 = 3,

            /// <summary>
            /// Enum SEAPORT for value: SEAPORT
            /// </summary>
            SEAPORT = 4,

            /// <summary>
            /// Enum UNISWAPV2 for value: UNISWAPV2
            /// </summary>
            UNISWAPV2 = 5
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("ERC20"))
                return TypeEnum.ERC20;

            if (value.Equals("ERC721"))
                return TypeEnum.ERC721;

            if (value.Equals("ERC1155"))
                return TypeEnum.ERC1155;

            if (value.Equals("SEAPORT"))
                return TypeEnum.SEAPORT;

            if (value.Equals("UNISWAPV2"))
                return TypeEnum.UNISWAPV2;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("ERC20"))
                return TypeEnum.ERC20;

            if (value.Equals("ERC721"))
                return TypeEnum.ERC721;

            if (value.Equals("ERC1155"))
                return TypeEnum.ERC1155;

            if (value.Equals("SEAPORT"))
                return TypeEnum.SEAPORT;

            if (value.Equals("UNISWAPV2"))
                return TypeEnum.UNISWAPV2;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="TypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string TypeEnumToJsonValue(TypeEnum value)
        {
            if (value == TypeEnum.ERC20)
                return "ERC20";

            if (value == TypeEnum.ERC721)
                return "ERC721";

            if (value == TypeEnum.ERC1155)
                return "ERC1155";

            if (value == TypeEnum.SEAPORT)
                return "SEAPORT";

            if (value == TypeEnum.UNISWAPV2)
                return "UNISWAPV2";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="TypeEnum"/> to and from the JSON value
        /// </summary>
        public static class TypeEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="TypeEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static TypeEnum FromString(string value)
            {
                    if (value.Equals("ERC20"))
                        return TypeEnum.ERC20;

                    if (value.Equals("ERC721"))
                        return TypeEnum.ERC721;

                    if (value.Equals("ERC1155"))
                        return TypeEnum.ERC1155;

                    if (value.Equals("SEAPORT"))
                        return TypeEnum.SEAPORT;

                    if (value.Equals("UNISWAPV2"))
                        return TypeEnum.UNISWAPV2;

                throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="TypeEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static TypeEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("ERC20"))
                        return TypeEnum.ERC20;

                    if (value.Equals("ERC721"))
                        return TypeEnum.ERC721;

                    if (value.Equals("ERC1155"))
                        return TypeEnum.ERC1155;

                    if (value.Equals("SEAPORT"))
                        return TypeEnum.SEAPORT;

                    if (value.Equals("UNISWAPV2"))
                        return TypeEnum.UNISWAPV2;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="TypeEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(TypeEnum value)
            {
                        if (value == TypeEnum.ERC20)
                            return "ERC20";

                        if (value == TypeEnum.ERC721)
                            return "ERC721";

                        if (value == TypeEnum.ERC1155)
                            return "ERC1155";

                        if (value == TypeEnum.SEAPORT)
                            return "SEAPORT";

                        if (value == TypeEnum.UNISWAPV2)
                            return "UNISWAPV2";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="TypeEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class TypeEnumJsonConverter : JsonConverter<TypeEnum>
        {
            /// <summary>
            /// Returns a TypeEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override TypeEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                TypeEnum? result = rawValue == null
                    ? null
                    : TypeEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the TypeEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="typeEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, TypeEnum typeEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(TypeEnumValueConverter.ToJsonValue(typeEnum));
            }
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

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
        /// Gets or Sets ExternalId
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Abi
        /// </summary>
        [JsonPropertyName("abi")]
        public Object? Abi { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [JsonPropertyName("gameId")]
        public string? GameId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationGetGameResponseContractsInner {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Abi: ").Append(Abi).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
    /// A Json converter for type <see cref="AutomationGetGameResponseContractsInner" />
    /// </summary>
    public class AutomationGetGameResponseContractsInnerJsonConverter : JsonConverter<AutomationGetGameResponseContractsInner>
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
        /// Deserializes json to <see cref="AutomationGetGameResponseContractsInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationGetGameResponseContractsInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> address = default;
            Option<int?> chainId = default;
            Option<DateTime?> createdAt = default;
            Option<string?> externalId = default;
            Option<string?> id = default;
            Option<AutomationGetGameResponseContractsInner.TypeEnum?> type = default;
            Option<DateTime?> updatedAt = default;
            Option<Object?> abi = default;
            Option<string?> gameId = default;
            Option<string?> name = default;

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
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "externalId":
                            externalId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            string? typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<AutomationGetGameResponseContractsInner.TypeEnum?>(AutomationGetGameResponseContractsInner.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "abi":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                abi = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "gameId":
                            gameId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!address.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseContractsInner.", nameof(address));

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseContractsInner.", nameof(chainId));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseContractsInner.", nameof(createdAt));

            if (!externalId.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseContractsInner.", nameof(externalId));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseContractsInner.", nameof(id));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseContractsInner.", nameof(type));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseContractsInner.", nameof(updatedAt));

            if (!abi.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseContractsInner.", nameof(abi));

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseContractsInner.", nameof(gameId));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseContractsInner.", nameof(name));

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class AutomationGetGameResponseContractsInner.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class AutomationGetGameResponseContractsInner.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class AutomationGetGameResponseContractsInner.");

            if (externalId.IsSet && externalId.Value == null)
                throw new ArgumentNullException(nameof(externalId), "Property is not nullable for class AutomationGetGameResponseContractsInner.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class AutomationGetGameResponseContractsInner.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class AutomationGetGameResponseContractsInner.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class AutomationGetGameResponseContractsInner.");

            return new AutomationGetGameResponseContractsInner(address.Value!, chainId.Value!.Value!, createdAt.Value!.Value!, externalId.Value!, id.Value!, type.Value!.Value!, updatedAt.Value!.Value!, abi.Value!, gameId.Value!, name.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationGetGameResponseContractsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetGameResponseContractsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationGetGameResponseContractsInner automationGetGameResponseContractsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, automationGetGameResponseContractsInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationGetGameResponseContractsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetGameResponseContractsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AutomationGetGameResponseContractsInner automationGetGameResponseContractsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationGetGameResponseContractsInner.Address == null)
                throw new ArgumentNullException(nameof(automationGetGameResponseContractsInner.Address), "Property is required for class AutomationGetGameResponseContractsInner.");

            if (automationGetGameResponseContractsInner.ExternalId == null)
                throw new ArgumentNullException(nameof(automationGetGameResponseContractsInner.ExternalId), "Property is required for class AutomationGetGameResponseContractsInner.");

            if (automationGetGameResponseContractsInner.Id == null)
                throw new ArgumentNullException(nameof(automationGetGameResponseContractsInner.Id), "Property is required for class AutomationGetGameResponseContractsInner.");

            writer.WriteString("address", automationGetGameResponseContractsInner.Address);

            writer.WriteNumber("chainId", automationGetGameResponseContractsInner.ChainId);

            writer.WriteString("createdAt", automationGetGameResponseContractsInner.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("externalId", automationGetGameResponseContractsInner.ExternalId);

            writer.WriteString("id", automationGetGameResponseContractsInner.Id);

            var typeRawValue = AutomationGetGameResponseContractsInner.TypeEnumToJsonValue(automationGetGameResponseContractsInner.Type);
            writer.WriteString("type", typeRawValue);
            writer.WriteString("updatedAt", automationGetGameResponseContractsInner.UpdatedAt.ToString(UpdatedAtFormat));

            if (automationGetGameResponseContractsInner.Abi != null)
            {
                writer.WritePropertyName("abi");
                JsonSerializer.Serialize(writer, automationGetGameResponseContractsInner.Abi, jsonSerializerOptions);
            }
            else
                writer.WriteNull("abi");
            if (automationGetGameResponseContractsInner.GameId != null)
                writer.WriteString("gameId", automationGetGameResponseContractsInner.GameId);
            else
                writer.WriteNull("gameId");

            if (automationGetGameResponseContractsInner.Name != null)
                writer.WriteString("name", automationGetGameResponseContractsInner.Name);
            else
                writer.WriteNull("name");
        }
    }
}