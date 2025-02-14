// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class GalleryImageIdentifier : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("publisher"u8);
            writer.WriteStringValue(Publisher);
            writer.WritePropertyName("offer"u8);
            writer.WriteStringValue(Offer);
            writer.WritePropertyName("sku"u8);
            writer.WriteStringValue(Sku);
            writer.WriteEndObject();
        }

        internal static GalleryImageIdentifier DeserializeGalleryImageIdentifier(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string publisher = default;
            string offer = default;
            string sku = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisher"u8))
                {
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offer"u8))
                {
                    offer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
            }
            return new GalleryImageIdentifier(publisher, offer, sku);
        }
    }
}
