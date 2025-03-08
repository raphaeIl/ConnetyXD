using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ConnetyXD.Common.Utils
{
    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public static readonly JsonSerializerOptions SnakeCaseOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = new SnakeCaseNamingPolicy(),
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
            WriteIndented = true,
            TypeInfoResolver = new DefaultJsonTypeInfoResolver()
            {
                Modifiers = { DefaultValueModifier }
            }
        };

        private static void DefaultValueModifier(JsonTypeInfo type_info)
        {
            foreach (var property in type_info.Properties)
            {
                if (typeof(ICollection).IsAssignableFrom(property.PropertyType))
                {
                    property.ShouldSerialize = (_, val) => val is ICollection collection && collection.Count > 0;
                }
            }
        }

        private static void IgnoreEpmptyListOfStrings(JsonTypeInfo typeInfo)
        {
            var listOfStringProperties = typeInfo.Properties.Where(p => p.PropertyType == typeof(List<string>));

            foreach (JsonPropertyInfo propertyInfo in listOfStringProperties)
                propertyInfo.ShouldSerialize = ShouldSerializeListOfString;

            static bool ShouldSerializeListOfString(object _, object? value) => ListOfStringNotNullOrEmpty(value as List<string>);
            static bool ListOfStringNotNullOrEmpty(List<string>? list) => list != null && list.Any();
        }

        private static void IgnoreEpmptyListOfObjects(JsonTypeInfo typeInfo)
        {
            var listOfStringProperties = typeInfo.Properties.Where(p => p.PropertyType == typeof(List<object>));

            foreach (JsonPropertyInfo propertyInfo in listOfStringProperties)
                propertyInfo.ShouldSerialize = ShouldSerializeListOfString;

            static bool ShouldSerializeListOfString(object _, object? value) => ListOfStringNotNullOrEmpty(value as List<object>);
            static bool ListOfStringNotNullOrEmpty(List<object>? list) => list != null && list.Any();
        }

        private static void IgnoreEmptyDictionaries(JsonTypeInfo typeInfo)
        {
            var dictionaryProperties = typeInfo.Properties
                .Where(p => p.PropertyType.IsGenericType &&
                            p.PropertyType.GetGenericTypeDefinition() == typeof(Dictionary<,>)); // Ensures key type is string

            foreach (JsonPropertyInfo propertyInfo in dictionaryProperties)
                propertyInfo.ShouldSerialize = ShouldSerializeDictionary;

            static bool ShouldSerializeDictionary(object _, object? value) => DictionaryNotNullOrEmpty(value as IDictionary<object, object>);
            static bool DictionaryNotNullOrEmpty(IDictionary<object, object>? dict) => dict != null && dict.Count > 0;
        }


        public override string ConvertName(string name)
        {
            return Regex.Replace(name, "([a-z0-9])([A-Z])", "$1_$2").ToLower();
        }
    }
}
