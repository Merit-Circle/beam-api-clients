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
    /// AcceptAssetOfferRequestInputV2
    /// </summary>
    public partial class AcceptAssetOfferRequestInputV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptAssetOfferRequestInputV2" /> class.
        /// </summary>
        /// <param name="offerId">offerId</param>
        /// <param name="quantity">quantity</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="optimistic">optimistic (default to false)</param>
        /// <param name="policyId">policyId</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        [JsonConstructor]
        public AcceptAssetOfferRequestInputV2(string offerId, decimal quantity, Option<decimal?> chainId = default, Option<bool?> optimistic = default, Option<string?> policyId = default, Option<bool?> sponsor = default)
        {
            OfferId = offerId;
            Quantity = quantity;
            ChainIdOption = chainId;
            OptimisticOption = optimistic;
            PolicyIdOption = policyId;
            SponsorOption = sponsor;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets OfferId
        /// </summary>
        [JsonPropertyName("offerId")]
        public string OfferId { get; set; }

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
            sb.Append("class AcceptAssetOfferRequestInputV2 {\n");
            sb.Append("  OfferId: ").Append(OfferId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
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
            // Quantity (decimal) minimum
            if (this.Quantity < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 1.", new [] { "Quantity" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="AcceptAssetOfferRequestInputV2" />
    /// </summary>
    public class AcceptAssetOfferRequestInputV2JsonConverter : JsonConverter<AcceptAssetOfferRequestInputV2>
    {
        /// <summary>
        /// Deserializes json to <see cref="AcceptAssetOfferRequestInputV2" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AcceptAssetOfferRequestInputV2 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> offerId = default;
            Option<decimal?> quantity = default;
            Option<decimal?> chainId = default;
            Option<bool?> optimistic = default;
            Option<string?> policyId = default;
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
                        case "offerId":
                            offerId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "quantity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quantity = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "optimistic":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                optimistic = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "policyId":
                            policyId = new Option<string?>(utf8JsonReader.GetString());
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

            if (!offerId.IsSet)
                throw new ArgumentException("Property is required for class AcceptAssetOfferRequestInputV2.", nameof(offerId));

            if (!quantity.IsSet)
                throw new ArgumentException("Property is required for class AcceptAssetOfferRequestInputV2.", nameof(quantity));

            if (offerId.IsSet && offerId.Value == null)
                throw new ArgumentNullException(nameof(offerId), "Property is not nullable for class AcceptAssetOfferRequestInputV2.");

            if (quantity.IsSet && quantity.Value == null)
                throw new ArgumentNullException(nameof(quantity), "Property is not nullable for class AcceptAssetOfferRequestInputV2.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class AcceptAssetOfferRequestInputV2.");

            if (optimistic.IsSet && optimistic.Value == null)
                throw new ArgumentNullException(nameof(optimistic), "Property is not nullable for class AcceptAssetOfferRequestInputV2.");

            if (sponsor.IsSet && sponsor.Value == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is not nullable for class AcceptAssetOfferRequestInputV2.");

            return new AcceptAssetOfferRequestInputV2(offerId.Value!, quantity.Value!.Value!, chainId, optimistic, policyId, sponsor);
        }

        /// <summary>
        /// Serializes a <see cref="AcceptAssetOfferRequestInputV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="acceptAssetOfferRequestInputV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AcceptAssetOfferRequestInputV2 acceptAssetOfferRequestInputV2, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, acceptAssetOfferRequestInputV2, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AcceptAssetOfferRequestInputV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="acceptAssetOfferRequestInputV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AcceptAssetOfferRequestInputV2 acceptAssetOfferRequestInputV2, JsonSerializerOptions jsonSerializerOptions)
        {
            if (acceptAssetOfferRequestInputV2.OfferId == null)
                throw new ArgumentNullException(nameof(acceptAssetOfferRequestInputV2.OfferId), "Property is required for class AcceptAssetOfferRequestInputV2.");

            writer.WriteString("offerId", acceptAssetOfferRequestInputV2.OfferId);

            writer.WriteNumber("quantity", acceptAssetOfferRequestInputV2.Quantity);

            if (acceptAssetOfferRequestInputV2.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", acceptAssetOfferRequestInputV2.ChainIdOption.Value!.Value);

            if (acceptAssetOfferRequestInputV2.OptimisticOption.IsSet)
                writer.WriteBoolean("optimistic", acceptAssetOfferRequestInputV2.OptimisticOption.Value!.Value);

            if (acceptAssetOfferRequestInputV2.PolicyIdOption.IsSet)
                if (acceptAssetOfferRequestInputV2.PolicyIdOption.Value != null)
                    writer.WriteString("policyId", acceptAssetOfferRequestInputV2.PolicyId);
                else
                    writer.WriteNull("policyId");

            if (acceptAssetOfferRequestInputV2.SponsorOption.IsSet)
                writer.WriteBoolean("sponsor", acceptAssetOfferRequestInputV2.SponsorOption.Value!.Value);
        }
    }
}