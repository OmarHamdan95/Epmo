using System.Text.Json;
using Epmo.Domain.Common;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Epmo.Database.DataBaseType;

public class SerializerLocalizedTextConverter :ValueConverter<LocalizedText, string>
{

    public SerializerLocalizedTextConverter()
        : base(
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null), // Convert to JSON string
            v => JsonSerializer.Deserialize<LocalizedText>(v, (JsonSerializerOptions)null)) // Convert from JSON string
    {
    }
}
