using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayout.Common
{
    public readonly struct Size
    {
        public Size(float length, float width, float height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        [JsonProperty("Length")]
        public float Length { get; }

        [JsonProperty("Width")]
        public float Width { get; }

        [JsonProperty("Height")]
        public float Height { get; }

        public float GetVolume()
        {
            return Length * Width * Height;
        }

    }
}
