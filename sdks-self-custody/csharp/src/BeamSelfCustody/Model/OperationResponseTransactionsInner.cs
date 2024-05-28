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
    /// OperationResponseTransactionsInner
    /// </summary>
    public partial class OperationResponseTransactionsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationResponseTransactionsInner" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="status">status</param>
        /// <param name="type">type</param>
        /// <param name="data">data</param>
        /// <param name="externalId">externalId</param>
        /// <param name="operationId">operationId</param>
        /// <param name="signature">signature</param>
        [JsonConstructor]
        public OperationResponseTransactionsInner(string id, StatusEnum status, TypeEnum type, OperationResponseTransactionsInnerData? data = default, string? externalId = default, string? operationId = default, string? signature = default)
        {
            Id = id;
            Status = status;
            Type = type;
            Data = data;
            ExternalId = externalId;
            OperationId = operationId;
            Signature = signature;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Status
        /// </summary>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            Pending = 1,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            Rejected = 2,

            /// <summary>
            /// Enum Executed for value: Executed
            /// </summary>
            Executed = 3,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            Error = 4
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value.Equals("Pending"))
                return StatusEnum.Pending;

            if (value.Equals("Rejected"))
                return StatusEnum.Rejected;

            if (value.Equals("Executed"))
                return StatusEnum.Executed;

            if (value.Equals("Error"))
                return StatusEnum.Error;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StatusEnum? StatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Pending"))
                return StatusEnum.Pending;

            if (value.Equals("Rejected"))
                return StatusEnum.Rejected;

            if (value.Equals("Executed"))
                return StatusEnum.Executed;

            if (value.Equals("Error"))
                return StatusEnum.Error;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StatusEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StatusEnumToJsonValue(StatusEnum value)
        {
            if (value == StatusEnum.Pending)
                return "Pending";

            if (value == StatusEnum.Rejected)
                return "Rejected";

            if (value == StatusEnum.Executed)
                return "Executed";

            if (value == StatusEnum.Error)
                return "Error";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Defines Type
        /// </summary>
        public enum TypeEnum
        {
            /// <summary>
            /// Enum OpenfortTransaction for value: OpenfortTransaction
            /// </summary>
            OpenfortTransaction = 1,

            /// <summary>
            /// Enum OpenfortReservoirOrder for value: OpenfortReservoirOrder
            /// </summary>
            OpenfortReservoirOrder = 2
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("OpenfortTransaction"))
                return TypeEnum.OpenfortTransaction;

            if (value.Equals("OpenfortReservoirOrder"))
                return TypeEnum.OpenfortReservoirOrder;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("OpenfortTransaction"))
                return TypeEnum.OpenfortTransaction;

            if (value.Equals("OpenfortReservoirOrder"))
                return TypeEnum.OpenfortReservoirOrder;

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
            if (value == TypeEnum.OpenfortTransaction)
                return "OpenfortTransaction";

            if (value == TypeEnum.OpenfortReservoirOrder)
                return "OpenfortReservoirOrder";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public OperationResponseTransactionsInnerData? Data { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [JsonPropertyName("operationId")]
        public string? OperationId { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OperationResponseTransactionsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
    /// A Json converter for type <see cref="OperationResponseTransactionsInner" />
    /// </summary>
    public class OperationResponseTransactionsInnerJsonConverter : JsonConverter<OperationResponseTransactionsInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="OperationResponseTransactionsInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override OperationResponseTransactionsInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<OperationResponseTransactionsInner.StatusEnum?> status = default;
            Option<OperationResponseTransactionsInner.TypeEnum?> type = default;
            Option<OperationResponseTransactionsInnerData?> data = default;
            Option<string?> externalId = default;
            Option<string?> operationId = default;
            Option<string?> signature = default;

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
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<OperationResponseTransactionsInner.StatusEnum?>(OperationResponseTransactionsInner.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "type":
                            string? typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<OperationResponseTransactionsInner.TypeEnum?>(OperationResponseTransactionsInner.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<OperationResponseTransactionsInnerData?>(JsonSerializer.Deserialize<OperationResponseTransactionsInnerData>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "externalId":
                            externalId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "operationId":
                            operationId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "signature":
                            signature = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class OperationResponseTransactionsInner.", nameof(id));

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class OperationResponseTransactionsInner.", nameof(status));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class OperationResponseTransactionsInner.", nameof(type));

            if (!data.IsSet)
                throw new ArgumentException("Property is required for class OperationResponseTransactionsInner.", nameof(data));

            if (!externalId.IsSet)
                throw new ArgumentException("Property is required for class OperationResponseTransactionsInner.", nameof(externalId));

            if (!operationId.IsSet)
                throw new ArgumentException("Property is required for class OperationResponseTransactionsInner.", nameof(operationId));

            if (!signature.IsSet)
                throw new ArgumentException("Property is required for class OperationResponseTransactionsInner.", nameof(signature));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class OperationResponseTransactionsInner.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class OperationResponseTransactionsInner.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class OperationResponseTransactionsInner.");

            return new OperationResponseTransactionsInner(id.Value!, status.Value!.Value!, type.Value!.Value!, data.Value!, externalId.Value!, operationId.Value!, signature.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="OperationResponseTransactionsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="operationResponseTransactionsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, OperationResponseTransactionsInner operationResponseTransactionsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, operationResponseTransactionsInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="OperationResponseTransactionsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="operationResponseTransactionsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, OperationResponseTransactionsInner operationResponseTransactionsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (operationResponseTransactionsInner.Id == null)
                throw new ArgumentNullException(nameof(operationResponseTransactionsInner.Id), "Property is required for class OperationResponseTransactionsInner.");

            writer.WriteString("id", operationResponseTransactionsInner.Id);

            var statusRawValue = OperationResponseTransactionsInner.StatusEnumToJsonValue(operationResponseTransactionsInner.Status);
            writer.WriteString("status", statusRawValue);
            var typeRawValue = OperationResponseTransactionsInner.TypeEnumToJsonValue(operationResponseTransactionsInner.Type);
            writer.WriteString("type", typeRawValue);
            if (operationResponseTransactionsInner.Data != null)
            {
                writer.WritePropertyName("data");
                JsonSerializer.Serialize(writer, operationResponseTransactionsInner.Data, jsonSerializerOptions);
            }
            else
                writer.WriteNull("data");
            if (operationResponseTransactionsInner.ExternalId != null)
                writer.WriteString("externalId", operationResponseTransactionsInner.ExternalId);
            else
                writer.WriteNull("externalId");

            if (operationResponseTransactionsInner.OperationId != null)
                writer.WriteString("operationId", operationResponseTransactionsInner.OperationId);
            else
                writer.WriteNull("operationId");

            if (operationResponseTransactionsInner.Signature != null)
                writer.WriteString("signature", operationResponseTransactionsInner.Signature);
            else
                writer.WriteNull("signature");
        }
    }
}