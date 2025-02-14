// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class BastionHostIPRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            writer.WriteEndObject();
        }

        internal static BastionHostIPRule DeserializeBastionHostIPRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> addressPrefix = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressPrefix"u8))
                {
                    addressPrefix = property.Value.GetString();
                    continue;
                }
            }
            return new BastionHostIPRule(addressPrefix.Value);
        }
    }
}
