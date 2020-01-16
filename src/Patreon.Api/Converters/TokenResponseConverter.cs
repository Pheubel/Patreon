using Patreon.Api.V2;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Patreon.Api.Converters
{
    internal class TokenResponseConverter : JsonConverter<TokenResponse>
    {
        static readonly byte[] ACCESS_TOKEN = new byte[] { 0x61, 0x63, 0x63, 0x65, 0x73, 0x73, 0x5f, 0x74, 0x6f, 0x6b, 0x65, 0x6e };
        static readonly byte[] REFRESH_TOKEN = new byte[] { 0x72, 0x65, 0x66, 0x72, 0x65, 0x73, 0x68, 0x5f, 0x74, 0x6f, 0x6b, 0x65, 0x6e };
        static readonly byte[] EXPIRES_IN = new byte[] { 0x65, 0x78, 0x70, 0x69, 0x72, 0x65, 0x73, 0x5f, 0x69, 0x6e };
        static readonly byte[] SCOPE = new byte[] { 0x73, 0x63, 0x6f, 0x70, 0x65 };

        public override TokenResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            var tokenResponse = new TokenResponse();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = reader.ValueSpan;

                    if (!reader.Read())
                        throw new JsonException();

                    if (propertyName.SequenceEqual(ACCESS_TOKEN))
                        tokenResponse.AccessToken = reader.GetString();
                    else if (propertyName.SequenceEqual(REFRESH_TOKEN))
                        tokenResponse.RefreshToken = reader.GetString();
                    else if (propertyName.SequenceEqual(EXPIRES_IN))
                        tokenResponse.ExpiresAt = DateTime.UtcNow.AddSeconds(reader.GetInt32());
                    else if (propertyName.SequenceEqual(SCOPE))
                        tokenResponse.Scope = ScopeUtility.ParseScopeString( reader.GetString());
                }
                else if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return tokenResponse;
                }
            }

            throw new JsonException();

        }

        public override void Write(Utf8JsonWriter writer, TokenResponse value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("access_token", value.AccessToken);
            writer.WriteNumber("expires_in", Math.Floor((value.ExpiresAt - DateTime.UtcNow).TotalSeconds));
            writer.WriteString("token_type", TokenResponse.TokenType);
            writer.WriteString("scope", ScopeUtility.ToScopeString(value.Scope));
            writer.WriteString("refresh_token", value.RefreshToken);
            writer.WriteEndObject();
        }
    }
}
