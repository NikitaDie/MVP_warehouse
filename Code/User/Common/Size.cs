using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse_graphic.PackageLogic
{
    public readonly struct Size
    {
        public Size(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public float Length { get; }
        public float Width { get; }
        public float Height { get; }

        public float GetVolume()
        {
            return Length * Width * Height;
        }

    }
}
