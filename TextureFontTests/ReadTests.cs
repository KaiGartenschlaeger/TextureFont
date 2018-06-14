using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextureFontLibrary;

namespace TextureFontTests
{
    [TestClass]
    public class ReadTests
    {
        [TestMethod]
        public void ReadBinary()
        {
            TextureFont font = TextureFont.FromFile("./TestFiles/Arial 18.txf");

            Assert.IsNotNull(font);
            
            Assert.IsTrue(font.TextureData != null && font.TextureData.Length > 0);

            Assert.IsTrue(font.CharacterMap.Count == 224);
            Assert.IsTrue(font.CroppingData.Count == 224);

            Assert.IsTrue(font.CharacterMap[0] == ' ');
            Assert.IsTrue(font.CharacterMap[1] == '!');
        }
    }
}