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
    /// AddContractRequestInput
    /// </summary>
    public partial class AddContractRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddContractRequestInput" /> class.
        /// </summary>
        /// <param name="address">address</param>
        /// <param name="chainId">chainId</param>
        /// <param name="name">name</param>
        /// <param name="type">type</param>
        [JsonConstructor]
        public AddContractRequestInput(string address, int chainId, string name, TypeEnum type)
        {
            Address = address;
            ChainId = chainId;
            Name = name;
            Type = type;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Type
        /// </summary>
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
            UNISWAPV2 = 5,

            /// <summary>
            /// Enum WETH for value: WETH
            /// </summary>
            WETH = 6
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

            if (value.Equals("WETH"))
                return TypeEnum.WETH;

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

            if (value.Equals("WETH"))
                return TypeEnum.WETH;

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

            if (value == TypeEnum.WETH)
                return "WETH";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
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
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddContractRequestInput {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
    /// A Json converter for type <see cref="AddContractRequestInput" />
    /// </summary>
    public class AddContractRequestInputJsonConverter : JsonConverter<AddContractRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="AddContractRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AddContractRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> address = default;
            Option<int?> chainId = default;
            Option<string?> name = default;
            Option<AddContractRequestInput.TypeEnum?> type = default;

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
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            string? typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<AddContractRequestInput.TypeEnum?>(AddContractRequestInput.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!address.IsSet)
                throw new ArgumentException("Property is required for class AddContractRequestInput.", nameof(address));

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class AddContractRequestInput.", nameof(chainId));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class AddContractRequestInput.", nameof(name));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class AddContractRequestInput.", nameof(type));

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class AddContractRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class AddContractRequestInput.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class AddContractRequestInput.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class AddContractRequestInput.");

            return new AddContractRequestInput(address.Value!, chainId.Value!.Value!, name.Value!, type.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AddContractRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addContractRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AddContractRequestInput addContractRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, addContractRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AddContractRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addContractRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AddContractRequestInput addContractRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (addContractRequestInput.Address == null)
                throw new ArgumentNullException(nameof(addContractRequestInput.Address), "Property is required for class AddContractRequestInput.");

            if (addContractRequestInput.Name == null)
                throw new ArgumentNullException(nameof(addContractRequestInput.Name), "Property is required for class AddContractRequestInput.");

            writer.WriteString("address", addContractRequestInput.Address);

            writer.WriteNumber("chainId", addContractRequestInput.ChainId);

            writer.WriteString("name", addContractRequestInput.Name);

            var typeRawValue = AddContractRequestInput.TypeEnumToJsonValue(addContractRequestInput.Type);
            writer.WriteString("type", typeRawValue);
        }
    }
}