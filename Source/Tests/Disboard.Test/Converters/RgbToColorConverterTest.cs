using System.Drawing;

using Disboard.Converters;

using Newtonsoft.Json;

using Xunit;

namespace Disboard.Test.Converters
{
    public class RgbToColorConverterTest
    {
        public class ExpectObject
        {
            [JsonProperty("color")]
            [JsonConverter(typeof(RgbToColorConverter))]
            public Color Color { get; set; }
        }

        [Fact]
        public void ReadJsonValidRgbaColor()
        {
            const string json = "{\"color\":\"rgba(125,255,63,128)\"}";
            var r = JsonConvert.DeserializeObject<ExpectObject>(json);
            r.Color.R.Is((byte) 125);
            r.Color.G.Is((byte) 255);
            r.Color.B.Is((byte) 63);
            r.Color.A.Is((byte) 128);
        }

        [Fact]
        public void ReadJsonValidRgbaColorIncludingSpaces()
        {
            const string json = "{\"color\":\"rgba(125, 255, 63, 128)\"}";
            var r = JsonConvert.DeserializeObject<ExpectObject>(json);
            r.Color.R.Is((byte) 125);
            r.Color.G.Is((byte) 255);
            r.Color.B.Is((byte) 63);
            r.Color.A.Is((byte) 128);
        }

        [Fact]
        public void ReadJsonValidRgbColor()
        {
            const string json = "{\"color\":\"rgb(125,172,253)\"}";
            var r = JsonConvert.DeserializeObject<ExpectObject>(json);
            r.Color.R.Is((byte) 125);
            r.Color.G.Is((byte) 172);
            r.Color.B.Is((byte) 253);
        }

        [Fact]
        public void ReadJsonValidRgbColorIncludingSpaces()
        {
            const string json = "{\"color\":\"rgb(125, 172, 253)\"}";
            var r = JsonConvert.DeserializeObject<ExpectObject>(json);
            r.Color.R.Is((byte) 125);
            r.Color.G.Is((byte) 172);
            r.Color.B.Is((byte) 253);
        }
    }
}