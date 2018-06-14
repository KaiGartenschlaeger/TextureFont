using System.Drawing;

namespace TextureFontGenerator
{
    public class FontTexture
    {
        public Image Texture { get; set; }
        public char FirstChar { get; set; }
        public Rectangle[] Positions { get; set; }
    }
}