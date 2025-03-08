using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConnetyXD.Common.Utils
{
    public class IgnoreEmptyCollectionsConverter<T> : JsonConverter<T> where T : ICollection<T>
    {
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<T>(ref reader, options);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            if (value.Count > 0) // Only serialize if not empty
            {
                JsonSerializer.Serialize(writer, value, options);
            }
        }
    }
}
