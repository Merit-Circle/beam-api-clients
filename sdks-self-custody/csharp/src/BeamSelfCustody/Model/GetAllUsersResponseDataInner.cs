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
    /// GetAllUsersResponseDataInner
    /// </summary>
    public partial class GetAllUsersResponseDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllUsersResponseDataInner" /> class.
        /// </summary>
        /// <param name="externalEntityId">externalEntityId</param>
        /// <param name="gameId">gameId</param>
        /// <param name="userId">userId</param>
        /// <param name="wallets">wallets</param>
        [JsonConstructor]
        public GetAllUsersResponseDataInner(string externalEntityId, string gameId, string userId, List<GetAllUsersResponseDataInnerWalletsInner> wallets)
        {
            ExternalEntityId = externalEntityId;
            GameId = gameId;
            UserId = userId;
            Wallets = wallets;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ExternalEntityId
        /// </summary>
        [JsonPropertyName("externalEntityId")]
        public string ExternalEntityId { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [JsonPropertyName("gameId")]
        public string GameId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets Wallets
        /// </summary>
        [JsonPropertyName("wallets")]
        public List<GetAllUsersResponseDataInnerWalletsInner> Wallets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAllUsersResponseDataInner {\n");
            sb.Append("  ExternalEntityId: ").Append(ExternalEntityId).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Wallets: ").Append(Wallets).Append("\n");
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
    /// A Json converter for type <see cref="GetAllUsersResponseDataInner" />
    /// </summary>
    public class GetAllUsersResponseDataInnerJsonConverter : JsonConverter<GetAllUsersResponseDataInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAllUsersResponseDataInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAllUsersResponseDataInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> externalEntityId = default;
            Option<string?> gameId = default;
            Option<string?> userId = default;
            Option<List<GetAllUsersResponseDataInnerWalletsInner>?> wallets = default;

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
                        case "externalEntityId":
                            externalEntityId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "gameId":
                            gameId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "userId":
                            userId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "wallets":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                wallets = new Option<List<GetAllUsersResponseDataInnerWalletsInner>?>(JsonSerializer.Deserialize<List<GetAllUsersResponseDataInnerWalletsInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!externalEntityId.IsSet)
                throw new ArgumentException("Property is required for class GetAllUsersResponseDataInner.", nameof(externalEntityId));

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class GetAllUsersResponseDataInner.", nameof(gameId));

            if (!userId.IsSet)
                throw new ArgumentException("Property is required for class GetAllUsersResponseDataInner.", nameof(userId));

            if (!wallets.IsSet)
                throw new ArgumentException("Property is required for class GetAllUsersResponseDataInner.", nameof(wallets));

            if (externalEntityId.IsSet && externalEntityId.Value == null)
                throw new ArgumentNullException(nameof(externalEntityId), "Property is not nullable for class GetAllUsersResponseDataInner.");

            if (gameId.IsSet && gameId.Value == null)
                throw new ArgumentNullException(nameof(gameId), "Property is not nullable for class GetAllUsersResponseDataInner.");

            if (userId.IsSet && userId.Value == null)
                throw new ArgumentNullException(nameof(userId), "Property is not nullable for class GetAllUsersResponseDataInner.");

            if (wallets.IsSet && wallets.Value == null)
                throw new ArgumentNullException(nameof(wallets), "Property is not nullable for class GetAllUsersResponseDataInner.");

            return new GetAllUsersResponseDataInner(externalEntityId.Value!, gameId.Value!, userId.Value!, wallets.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GetAllUsersResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAllUsersResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAllUsersResponseDataInner getAllUsersResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getAllUsersResponseDataInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAllUsersResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAllUsersResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetAllUsersResponseDataInner getAllUsersResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAllUsersResponseDataInner.ExternalEntityId == null)
                throw new ArgumentNullException(nameof(getAllUsersResponseDataInner.ExternalEntityId), "Property is required for class GetAllUsersResponseDataInner.");

            if (getAllUsersResponseDataInner.GameId == null)
                throw new ArgumentNullException(nameof(getAllUsersResponseDataInner.GameId), "Property is required for class GetAllUsersResponseDataInner.");

            if (getAllUsersResponseDataInner.UserId == null)
                throw new ArgumentNullException(nameof(getAllUsersResponseDataInner.UserId), "Property is required for class GetAllUsersResponseDataInner.");

            if (getAllUsersResponseDataInner.Wallets == null)
                throw new ArgumentNullException(nameof(getAllUsersResponseDataInner.Wallets), "Property is required for class GetAllUsersResponseDataInner.");

            writer.WriteString("externalEntityId", getAllUsersResponseDataInner.ExternalEntityId);

            writer.WriteString("gameId", getAllUsersResponseDataInner.GameId);

            writer.WriteString("userId", getAllUsersResponseDataInner.UserId);

            writer.WritePropertyName("wallets");
            JsonSerializer.Serialize(writer, getAllUsersResponseDataInner.Wallets, jsonSerializerOptions);
        }
    }
}