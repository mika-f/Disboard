using System.Drawing;

using Disboard.Converters;
using Disboard.Models;

using Newtonsoft.Json;

namespace Disboard.Misskey.Models
{
    public class MediaProperty : ApiResponse
    {
        [JsonProperty("avgColor")]
        [JsonConverter(typeof(RgbToColorConverter))]
        public Color AvgColor { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }
}