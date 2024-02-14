// <auto-generated>
/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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
using Beam.Client;

namespace Beam.Model
{
    /// <summary>
    /// TransferAssetRequestInputV2AssetsInner
    /// </summary>
    public partial class TransferAssetRequestInputV2AssetsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAssetRequestInputV2AssetsInner" /> class.
        /// </summary>
        /// <param name="assetAddress">assetAddress</param>
        /// <param name="assetId">assetId</param>
        /// <param name="amountToTransfer">amountToTransfer (default to 1M)</param>
        /// <param name="receiverEntityId">receiverEntityId</param>
        /// <param name="receiverWalletAddress">receiverWalletAddress</param>
        [JsonConstructor]
        public TransferAssetRequestInputV2AssetsInner(string assetAddress, string assetId, Option<decimal?> amountToTransfer = default, Option<string> receiverEntityId = default, Option<string> receiverWalletAddress = default)
        {
            AssetAddress = assetAddress;
            AssetId = assetId;
            AmountToTransferOption = amountToTransfer;
            ReceiverEntityIdOption = receiverEntityId;
            ReceiverWalletAddressOption = receiverWalletAddress;
            OnCreated();
        }

        partial void OnCreated();

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
        /// Used to track the state of AmountToTransfer
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> AmountToTransferOption { get; private set; }

        /// <summary>
        /// Gets or Sets AmountToTransfer
        /// </summary>
        [JsonPropertyName("amountToTransfer")]
        public decimal? AmountToTransfer { get { return this. AmountToTransferOption; } set { this.AmountToTransferOption = new(value); } }

        /// <summary>
        /// Used to track the state of ReceiverEntityId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ReceiverEntityIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ReceiverEntityId
        /// </summary>
        [JsonPropertyName("receiverEntityId")]
        public string ReceiverEntityId { get { return this. ReceiverEntityIdOption; } set { this.ReceiverEntityIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ReceiverWalletAddress
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ReceiverWalletAddressOption { get; private set; }

        /// <summary>
        /// Gets or Sets ReceiverWalletAddress
        /// </summary>
        [JsonPropertyName("receiverWalletAddress")]
        public string ReceiverWalletAddress { get { return this. ReceiverWalletAddressOption; } set { this.ReceiverWalletAddressOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferAssetRequestInputV2AssetsInner {\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AmountToTransfer: ").Append(AmountToTransfer).Append("\n");
            sb.Append("  ReceiverEntityId: ").Append(ReceiverEntityId).Append("\n");
            sb.Append("  ReceiverWalletAddress: ").Append(ReceiverWalletAddress).Append("\n");
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
            // AmountToTransfer (decimal) minimum
            if (this.AmountToTransferOption.IsSet && this.AmountToTransferOption.Value < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountToTransfer, must be a value greater than or equal to 0.", new [] { "AmountToTransfer" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TransferAssetRequestInputV2AssetsInner" />
    /// </summary>
    public class TransferAssetRequestInputV2AssetsInnerJsonConverter : JsonConverter<TransferAssetRequestInputV2AssetsInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="TransferAssetRequestInputV2AssetsInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TransferAssetRequestInputV2AssetsInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> assetAddress = default;
            Option<string> assetId = default;
            Option<decimal?> amountToTransfer = default;
            Option<string> receiverEntityId = default;
            Option<string> receiverWalletAddress = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "assetAddress":
                            assetAddress = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "assetId":
                            assetId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "amountToTransfer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                amountToTransfer = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "receiverEntityId":
                            receiverEntityId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "receiverWalletAddress":
                            receiverWalletAddress = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!assetAddress.IsSet)
                throw new ArgumentException("Property is required for class TransferAssetRequestInputV2AssetsInner.", nameof(assetAddress));

            if (!assetId.IsSet)
                throw new ArgumentException("Property is required for class TransferAssetRequestInputV2AssetsInner.", nameof(assetId));

            if (assetAddress.IsSet && assetAddress.Value == null)
                throw new ArgumentNullException(nameof(assetAddress), "Property is not nullable for class TransferAssetRequestInputV2AssetsInner.");

            if (assetId.IsSet && assetId.Value == null)
                throw new ArgumentNullException(nameof(assetId), "Property is not nullable for class TransferAssetRequestInputV2AssetsInner.");

            if (amountToTransfer.IsSet && amountToTransfer.Value == null)
                throw new ArgumentNullException(nameof(amountToTransfer), "Property is not nullable for class TransferAssetRequestInputV2AssetsInner.");

            if (receiverEntityId.IsSet && receiverEntityId.Value == null)
                throw new ArgumentNullException(nameof(receiverEntityId), "Property is not nullable for class TransferAssetRequestInputV2AssetsInner.");

            if (receiverWalletAddress.IsSet && receiverWalletAddress.Value == null)
                throw new ArgumentNullException(nameof(receiverWalletAddress), "Property is not nullable for class TransferAssetRequestInputV2AssetsInner.");

            return new TransferAssetRequestInputV2AssetsInner(assetAddress.Value, assetId.Value, amountToTransfer, receiverEntityId, receiverWalletAddress);
        }

        /// <summary>
        /// Serializes a <see cref="TransferAssetRequestInputV2AssetsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="transferAssetRequestInputV2AssetsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TransferAssetRequestInputV2AssetsInner transferAssetRequestInputV2AssetsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, transferAssetRequestInputV2AssetsInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TransferAssetRequestInputV2AssetsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="transferAssetRequestInputV2AssetsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, TransferAssetRequestInputV2AssetsInner transferAssetRequestInputV2AssetsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (transferAssetRequestInputV2AssetsInner.AssetAddress == null)
                throw new ArgumentNullException(nameof(transferAssetRequestInputV2AssetsInner.AssetAddress), "Property is required for class TransferAssetRequestInputV2AssetsInner.");

            if (transferAssetRequestInputV2AssetsInner.AssetId == null)
                throw new ArgumentNullException(nameof(transferAssetRequestInputV2AssetsInner.AssetId), "Property is required for class TransferAssetRequestInputV2AssetsInner.");

            if (transferAssetRequestInputV2AssetsInner.ReceiverEntityIdOption.IsSet && transferAssetRequestInputV2AssetsInner.ReceiverEntityId == null)
                throw new ArgumentNullException(nameof(transferAssetRequestInputV2AssetsInner.ReceiverEntityId), "Property is required for class TransferAssetRequestInputV2AssetsInner.");

            if (transferAssetRequestInputV2AssetsInner.ReceiverWalletAddressOption.IsSet && transferAssetRequestInputV2AssetsInner.ReceiverWalletAddress == null)
                throw new ArgumentNullException(nameof(transferAssetRequestInputV2AssetsInner.ReceiverWalletAddress), "Property is required for class TransferAssetRequestInputV2AssetsInner.");

            writer.WriteString("assetAddress", transferAssetRequestInputV2AssetsInner.AssetAddress);

            writer.WriteString("assetId", transferAssetRequestInputV2AssetsInner.AssetId);

            if (transferAssetRequestInputV2AssetsInner.AmountToTransferOption.IsSet)
                writer.WriteNumber("amountToTransfer", transferAssetRequestInputV2AssetsInner.AmountToTransferOption.Value.Value);

            if (transferAssetRequestInputV2AssetsInner.ReceiverEntityIdOption.IsSet)
                writer.WriteString("receiverEntityId", transferAssetRequestInputV2AssetsInner.ReceiverEntityId);

            if (transferAssetRequestInputV2AssetsInner.ReceiverWalletAddressOption.IsSet)
                writer.WriteString("receiverWalletAddress", transferAssetRequestInputV2AssetsInner.ReceiverWalletAddress);
        }
    }
}
