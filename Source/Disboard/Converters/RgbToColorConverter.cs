using System;
using System.Drawing;
using System.Text.RegularExpressions;

using Newtonsoft.Json;

namespace Disboard.Converters
{
    /// <summary>
    ///     rgb(r,g,b) / rgba(r,g,b,a) to Color
    /// </summary>
    public class RgbToColorConverter : JsonConverter
    {
        private readonly Regex _color = new Regex(@"rgba?\((?<red>\w{1,3}),\s?(?<green>\w{1,3}),\s?(?<blue>\w{1,3})(,\s?(?<alpha>\w{1,3}))?\)", RegexOptions.Compiled);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;
            if (reader.TokenType != JsonToken.String)
                throw new NotSupportedException();

            var color = reader.Value as string;
            if (!_color.IsMatch(color ?? throw new InvalidOperationException()))
                throw new NotSupportedException();

            var match = _color.Match(color);
            var (r, g, b) = (int.Parse(match.Groups["red"].Value), int.Parse(match.Groups["green"].Value), int.Parse(match.Groups["blue"].Value));
            if (string.IsNullOrEmpty(match.Groups["alpha"].Value))
                return Color.FromArgb(r, g, b);

            var a = int.Parse(match.Groups["alpha"].Value);
            return Color.FromArgb(a, r, g, b);
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}