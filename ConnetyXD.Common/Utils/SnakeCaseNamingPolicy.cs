using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace ConnetyXD.Common.Utils
{
    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public static readonly JsonSerializerOptions SnakeCaseOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = new SnakeCaseNamingPolicy(),
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
            WriteIndented = true
        };

        public override string ConvertName(string name)
        {
            return Regex.Replace(name, "([a-z0-9])([A-Z])", "$1_$2").ToLower();
        }
    }
}
