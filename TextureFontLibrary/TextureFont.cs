using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace TextureFontLibrary
{
    public class TextureFont
    {
        #region Consts

        public const string MagicString = "TF";
        public const byte MaxSupportedVersion = 1;

        #endregion

        #region Constructor

        private TextureFont()
        {
            this.DefaultCharacter = '?';
            this.Spacing = 0;
        }

        #endregion

        #region Helper

        private static byte[] DecompressData(byte[] compressedData)
        {
            byte[] result = null;
            using (MemoryStream mem = new MemoryStream(compressedData))
            {
                using (GZipStream stream = new GZipStream(mem, CompressionMode.Decompress))
                {
                    const int size = 4096;
                    byte[] buffer = new byte[4096];

                    using (MemoryStream mem_result = new MemoryStream())
                    {
                        int count = 0;

                        do
                        {
                            count = stream.Read(buffer, 0, size);
                            if (count > 0)
                            {
                                mem_result.Write(buffer, 0, count);
                            }
                        }
                        while (count > 0);

                        result = mem_result.ToArray();
                    }
                }
            }

            return result;
        }

        #endregion

        #region Methods

        public static TextureFont FromFile(string path)
        {
            using (Stream stream = File.OpenRead(path))
            {
                return FromStream(stream);
            }
        }

        public static TextureFont FromStream(Stream stream)
        {
            TextureFont result = new TextureFont();

            using (BinaryReader reader = new BinaryReader(stream, Encoding.UTF8))
            {
                foreach (char ch in MagicString)
                {
                    if (ch != reader.ReadChar())
                    {
                        throw new Exception("Invalid texture font file");
                    }
                }

                byte version = reader.ReadByte();
                if (version < 0 || version > MaxSupportedVersion)
                {
                    throw new Exception("Unsupported texture font file");
                }

                // image

                bool isCompressed = reader.ReadBoolean();
                int imageDataLength = reader.ReadInt32();

                result.TextureData = reader.ReadBytes(imageDataLength);
                if (isCompressed)
                {
                    result.TextureData = DecompressData(result.TextureData);
                }

                // characters

                int firstChar = (int)reader.ReadChar();
                int charsAmount = reader.ReadInt32();

                List<char> characterMap = new List<char>();
                List<Rectangle> croopingData = new List<Rectangle>();

                for (int i = 0; i < charsAmount; i++)
                {
                    char ch = (char)(firstChar + i);

                    characterMap.Add(ch);
                    croopingData.Add(new Rectangle(
                        reader.ReadUInt16(), reader.ReadUInt16(),
                        reader.ReadByte(), reader.ReadByte()));
                }

                result.CharacterMap = new ReadOnlyCollection<char>(characterMap);
                result.CroppingData = new ReadOnlyCollection<Rectangle>(croopingData);
            }

            return result;
        }

        #endregion

        #region Properties

        public byte[] TextureData { get; private set; }
        public ReadOnlyCollection<char> CharacterMap { get; private set; }
        public ReadOnlyCollection<Rectangle> CroppingData { get; private set; }
        public char DefaultCharacter { get; set; }
        public int Spacing { get; set; }

        #endregion
    }
}