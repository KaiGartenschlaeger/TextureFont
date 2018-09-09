using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Tools.Helper;

namespace TextureFontGenerator
{
    public partial class FormMain : Form
    {
        #region Fields

        private FontTexture _fontTexture = null;
        private Graphics _graphics = null;
        private Bitmap _bitmap = null;

        #endregion

        #region Constructor

        public FormMain()
        {
            InitializeComponent();
            InitGUI();

            _bitmap = new Bitmap(1, 1);
            _graphics = Graphics.FromImage(_bitmap);
        }

        #endregion

        #region Methods

        private void InitGUI()
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            foreach (FontFamily font in FontFamily.Families)
            {
                cbxFont.Items.Add(font.Name);
                source.Add(font.Name);
            }

            cbxFont.AutoCompleteCustomSource = source;

            if (cbxFont.SelectedIndex == -1 && cbxFont.Items.Count > 0)
            {
                cbxFont.SelectedItem = "Arial";
                if (cbxFont.SelectedIndex == -1)
                {
                    cbxFont.SelectedIndex = 0;
                }
            }

            cbxWhitespaceMode.SelectedIndex = 0;
            nudWhitespacePercent.Enabled = cbxWhitespaceMode.SelectedIndex > 0;

            OutlineModeChanged();

            RefreshSaveElement();
        }

        #endregion

        #region Control events

        private void cbxWhitespaceMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudWhitespacePercent.Enabled = cbxWhitespaceMode.SelectedIndex > 0;
        }

        private void chbOutline_CheckedChanged(object sender, EventArgs e)
        {
            OutlineModeChanged();
        }

        private void OutlineModeChanged()
        {
            nudOutline.Enabled = chbOutline.Checked;
            chbAntiAlias.Enabled = !chbOutline.Checked;
            chbShadow.Enabled = !chbOutline.Checked;
        }

        private void ConfigureGraphics(Graphics graphics)
        {
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (chbAntiAlias.Checked)
            {
                graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            }
            else
            {
                graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
            }
        }

        private SizeF CalculateWhitespaceSize(Font font, char minChar, char maxChar)
        {
            switch (cbxWhitespaceMode.SelectedIndex)
            {
                case 0: // Original
                    return _graphics.MeasureString(" ", font);

                case 1: // Avarage width
                case 2: // Max Width
                    float fullWidth = 0;
                    float maxWidth = 0;
                    float maxHeight = 0;

                    for (char i = minChar; i <= maxChar; i++)
                    {
                        if (i != ' ')
                        {
                            SizeF s = _graphics.MeasureString(i.ToString(), font);

                            fullWidth += s.Width;
                            maxWidth = Math.Max(maxWidth, s.Width);
                            maxHeight = Math.Max(maxHeight, s.Height);
                        }
                    }

                    if (cbxWhitespaceMode.SelectedIndex == 1)
                    {
                        return new SizeF(
                            (fullWidth / (maxChar - minChar)) * ((float)nudWhitespacePercent.Value / 100),
                            maxHeight);
                    }
                    else
                    {
                        return new SizeF(
                            maxWidth * ((float)nudWhitespacePercent.Value / 100),
                            maxHeight);
                    }

                default:
                    throw new NotImplementedException();
            }
        }

        private Bitmap RasterizeChar(char ch, char minChar, char maxChar, Font font, bool drawShadow,
            SolidBrush brushText, SolidBrush brushShadow, PixelFormat format)
        {
            string text = ch.ToString();

            if (chbOutline.Checked && ch != ' ')
            {
                var size = _graphics.MeasureString(text, font);
                var width = (int)Math.Ceiling(size.Width + 20);
                var height = (int)Math.Ceiling(size.Height);

                var sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                var bitmap = new Bitmap(width, height, format);

                using (var brushBg = new SolidBrush(panTextColor.BackColor))
                using (var penFg = new Pen(panShadowColor.BackColor, (float)nudOutline.Value))
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    //graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                    //graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    //graphics.PixelOffsetMode = PixelOffsetMode.Default;

                    sf.Alignment = StringAlignment.Near;
                    sf.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.FitBlackBox | StringFormatFlags.NoFontFallback | StringFormatFlags.NoClip;
                    sf.HotkeyPrefix = HotkeyPrefix.None;
                    sf.Trimming = StringTrimming.None;

                    graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.Half;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    using (var path = new GraphicsPath())
                    {
                        path.AddString(ch.ToString(),
                            font.FontFamily,
                            (int)font.Style,
                            font.Size,
                            new Rectangle(
                                0,
                                0,
                                (int)size.Width,
                                (int)size.Height),
                            sf);

                        graphics.FillPath(brushBg, path);
                        graphics.DrawPath(penFg, path);
                    }
                }

                return CropChar(bitmap);
            }
            else
            {
                SizeF size;
                if (ch == ' ')
                    size = CalculateWhitespaceSize(font, minChar, maxChar);
                else
                    size = _graphics.MeasureString(text, font);

                int width = (int)Math.Ceiling(size.Width);
                int height = (int)Math.Ceiling(size.Height);

                var bitmap = new Bitmap(width, height, format);
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    if (chbAntiAlias.Checked)
                    {
                        graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                    }
                    else
                    {
                        graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
                    }

                    graphics.Clear(Color.Transparent);
                    using (var sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Near;
                        sf.LineAlignment = StringAlignment.Near;

                        if (drawShadow)
                        {
                            graphics.DrawString(text, font, brushShadow, 1, 1, sf);
                        }

                        graphics.DrawString(text, font, brushText, 0, 0, sf);
                    }

                    graphics.Flush();
                }

                if (ch == ' ')
                    return bitmap;
                else
                    return CropChar(bitmap);
            }
        }

        private Bitmap CropChar(Bitmap bitmap)
        {
            if (chbTrimCharWidth.Checked)
            {
                int cropLeft = 0;
                int cropRight = bitmap.Width - 1;

                while ((cropLeft < cropRight) && (IsEmpty(bitmap, cropLeft)))
                    cropLeft++;

                while ((cropRight > cropLeft) && (IsEmpty(bitmap, cropRight)))
                    cropRight--;

                cropLeft = Math.Max(cropLeft - 1, 0);
                cropRight = Math.Min(cropRight + 1, bitmap.Width - 1);

                int width = cropRight - cropLeft + 1;

                var croppedBitmap = new Bitmap(width, bitmap.Height, bitmap.PixelFormat);
                using (var graphics = Graphics.FromImage(croppedBitmap))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;

                    graphics.DrawImage(bitmap, 0, 0,
                        new Rectangle(cropLeft, 0, width, bitmap.Height),
                        GraphicsUnit.Pixel);

                    graphics.Flush();
                }

                return croppedBitmap;
            }
            else
            {
                return bitmap;
            }
        }

        private bool IsEmpty(Bitmap bitmap, int x)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                if (bitmap.GetPixel(x, y).A != 0)
                {
                    return false;
                }
            }

            return true;
        }

        private FontTexture GenerateResult()
        {
            try
            {
                // load font
                FontStyle style = FontStyle.Regular;

                if (chbBold.Checked)
                    style |= FontStyle.Bold;
                if (chbItalic.Checked)
                    style |= FontStyle.Italic;

                Font font = null;
                try
                {
                    font = new Font(
                        cbxFont.SelectedItem.ToString(),
                        (int)nudSize.Value,
                        style,
                        GraphicsUnit.Pixel);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Unsupported font", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return null;
                }

                // get generator settings
                int minChar = Convert.ToInt32(tbxMinChar.Text.Trim());
                int maxChar = Convert.ToInt32(tbxMaxChar.Text.Trim());
                int padding = (int)nudPadding.Value;
                int canvasWidth = (int)nudImageWidth.Value;

                // find image format
                var format = PixelFormat.Format32bppArgb;
                if (chbPremultipliedAlpha.Checked)
                {
                    format = PixelFormat.Format32bppPArgb;
                }

                // create text and background brush
                var brushText = new SolidBrush(panTextColor.BackColor);
                var brushShadow = new SolidBrush(panShadowColor.BackColor);
                var brushBg = new SolidBrush(panBackgroundColor.BackColor);

                // create one bitmap for each character
                var chars = new List<Bitmap>();
                var linesCount = 1;
                var lineHeight = 0;

                var width = 0;
                for (char ch = (char)minChar; ch <= (char)maxChar; ch++)
                {
                    Bitmap chBitmap = RasterizeChar(ch,
                        (char)minChar, (char)maxChar,
                        font,
                        chbShadow.Checked,
                        brushText, brushShadow,
                        format);

                    chars.Add(chBitmap);

                    lineHeight = Math.Max(lineHeight, chBitmap.Height);

                    if (width + chBitmap.Width > canvasWidth)
                    {
                        width = 0;
                        linesCount++;
                    }
                    else
                    {
                        width += chBitmap.Width + padding;
                    }
                }

                // create bitmap for the whole texture
                var charPositions = new Rectangle[chars.Count];

                var bitmap = new Bitmap(
                    canvasWidth,
                    (linesCount * lineHeight) + ((linesCount + 1) * padding), format);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // clear the background
                    if (chbBackgroundTransparent.Checked)
                    {
                        graphics.Clear(Color.Transparent);
                    }
                    else
                    {
                        graphics.Clear(panBackColorImage.BackColor);
                    }

                    // draw characters to background
                    int drawX = padding;
                    int drawY = padding;

                    for (int i = 0; i < chars.Count; i++)
                    {
                        if (drawX + chars[i].Width + padding > canvasWidth)
                        {
                            drawX = padding;
                            drawY += lineHeight + padding;
                        }

                        if (!chbBackgroundTransparent.Checked)
                        {
                            graphics.FillRectangle(brushBg,
                                drawX, drawY,
                                chars[i].Width, chars[i].Height);
                        }

                        graphics.DrawImage(chars[i], drawX, drawY);

                        charPositions[i] = new Rectangle(
                            drawX, drawY, chars[i].Width, chars[i].Height);

                        drawX += chars[i].Width + padding;
                    }

                    graphics.Flush();
                }

                return new FontTexture()
                {
                    Texture = bitmap,
                    FirstChar = (char)minChar,
                    Positions = charPositions
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed:\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FontTexture result = GenerateResult();
            if (result != null)
            {
                pbxPreview.Image = result.Texture;
                _fontTexture = result;
            }
            else
            {
                pbxPreview.Image = null;
                _fontTexture = null;
            }

            RefreshSaveElement();
        }

        private void RefreshSaveElement()
        {
            chbCompressImage.Enabled = pbxPreview.Image != null;
            chbPremultipliedAlpha.Enabled = pbxPreview.Image != null;
            btnSave.Enabled = pbxPreview.Image != null;
        }

        private void SaveXnaXmlContentFile(string path)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.Indent = true;

            using (var stream = File.Create(path))
            {
                using (var writer = XmlWriter.Create(stream, settings))
                {
                    writer.WriteStartDocument();

                    writer.WriteStartElement("XnaContent");

                    writer.WriteStartElement("Asset");
                    writer.WriteAttributeString("Type", "TextureFontGenerator.TextureFontInfo");

                    var imageFileName = Path.GetFileNameWithoutExtension(path);
                    string pathImage = Path.Combine(
                        Path.GetDirectoryName(path),
                        imageFileName + ".png");

                    _fontTexture.Texture.Save(pathImage, ImageFormat.Png);

                    writer.WriteElementString("TextureName", Path.GetFileNameWithoutExtension(path));
                    writer.WriteElementString("DefaultCharacter", "*");
                    writer.WriteElementString("FirstCharacter", ((int)_fontTexture.FirstChar).ToString());

                    writer.WriteStartElement("CropData");

                    var cropDataBuffer = new StringBuilder();
                    for (int i = 0; i < _fontTexture.Positions.Length; i++)
                    {
                        cropDataBuffer.AppendFormat("{0} {1} {2} {3}",
                            _fontTexture.Positions[i].X,
                            _fontTexture.Positions[i].Y,
                            _fontTexture.Positions[i].Width,
                            _fontTexture.Positions[i].Height);
                        cropDataBuffer.AppendLine();
                    }

                    writer.WriteString(cropDataBuffer.ToString());
                    writer.WriteEndElement(); // CropData

                    writer.WriteElementString("Spacing", "0");

                    writer.WriteEndElement(); // Asset
                    writer.WriteEndElement(); // XnaContent

                    writer.WriteEndDocument();
                }
            }

            string pathCsFile = Path.Combine(
                Path.GetDirectoryName(path),
                Path.GetFileNameWithoutExtension(path) + ".cs");

            var bufferCs = new StringBuilder();
            bufferCs.AppendLine("using Microsoft.Xna.Framework;");
            bufferCs.AppendLine();
            bufferCs.AppendLine("namespace TextureFontGenerator");
            bufferCs.AppendLine("{");
            bufferCs.AppendLine("    public class TextureFontInfo");
            bufferCs.AppendLine("    {");
            bufferCs.AppendLine("       public string TextureName { get; set; }");
            bufferCs.AppendLine("       public char DefaultCharacter { get; set; }");
            bufferCs.AppendLine("       public ushort FirstCharacter { get; set; }");
            bufferCs.AppendLine("       public Rectangle[] CropData { get; set; }");
            bufferCs.AppendLine("       public ushort Spacing { get; set; }");
            bufferCs.AppendLine("    }");
            bufferCs.AppendLine("}");

            File.WriteAllText(pathCsFile, bufferCs.ToString());
        }

        private void SaveXml(string path, bool includeImage)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.Indent = true;

            using (Stream stream = File.Create(path))
            {
                using (XmlWriter writer = XmlWriter.Create(stream, settings))
                {
                    writer.WriteStartDocument();

                    writer.WriteStartElement("TextureFont");

                    if (includeImage)
                    {
                        writer.WriteStartElement("Texture");
                        writer.WriteElementString("Width", _fontTexture.Texture.Width.ToString());
                        writer.WriteElementString("Height", _fontTexture.Texture.Height.ToString());
                        writer.WriteElementString("IsCompressed", chbCompressImage.Checked.ToString());

                        byte[] imageData = null;
                        using (var mem = new MemoryStream())
                        {
                            _fontTexture.Texture.Save(mem, ImageFormat.Png);
                            imageData = mem.ToArray();
                        }

                        if (chbCompressImage.Checked)
                        {
                            imageData = CompressHelper.GZIPCompress(imageData);
                        }

                        var image = EncodingHelper.EncodeBase64(imageData, null);

                        writer.WriteElementString("Data", image);
                        writer.WriteEndElement();
                    }
                    else
                    {
                        string pathImage = Path.Combine(
                            Path.GetDirectoryName(path),
                            Path.GetFileNameWithoutExtension(path) + ".png");

                        _fontTexture.Texture.Save(pathImage, ImageFormat.Png);
                    }

                    writer.WriteStartElement("Characters");

                    writer.WriteStartElement("FirstChar");
                    writer.WriteAttributeString("C", _fontTexture.FirstChar.ToString());
                    writer.WriteAttributeString("A", ((int)_fontTexture.FirstChar).ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("Chars");
                    for (int i = 0; i < _fontTexture.Positions.Length; i++)
                    {
                        writer.WriteStartElement("Char");
                        writer.WriteAttributeString("X", _fontTexture.Positions[i].X.ToString());
                        writer.WriteAttributeString("Y", _fontTexture.Positions[i].Y.ToString());
                        writer.WriteAttributeString("W", _fontTexture.Positions[i].Width.ToString());
                        writer.WriteAttributeString("H", _fontTexture.Positions[i].Height.ToString());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();

                    writer.WriteEndElement(); // characters
                    writer.WriteEndElement(); // texture font

                    writer.WriteEndDocument();
                }
            }
        }

        private void SaveBinary(string path)
        {
            using (Stream stream = File.Create(path))
            {
                using (BinaryWriter writer = new BinaryWriter(stream, Encoding.UTF8))
                {
                    writer.Write(new char[] { 'T', 'F' }); // magic string
                    writer.Write((byte)1); // version

                    byte[] imageData = null;
                    using (MemoryStream mem = new MemoryStream())
                    {
                        _fontTexture.Texture.Save(mem, ImageFormat.Png);
                        imageData = mem.ToArray();
                    }

                    if (chbCompressImage.Checked)
                    {
                        imageData = CompressHelper.GZIPCompress(imageData);
                    }

                    writer.Write(chbCompressImage.Checked); // is compressed image
                    writer.Write(imageData.Length); // image length
                    writer.Write(imageData); // image data

                    writer.Write(_fontTexture.FirstChar); // first character
                    writer.Write(_fontTexture.Positions.Length); // amount of characters
                    for (int i = 0; i < _fontTexture.Positions.Length; i++)
                    {
                        writer.Write((ushort)_fontTexture.Positions[i].X); // x position
                        writer.Write((ushort)_fontTexture.Positions[i].Y); // y position
                        writer.Write((byte)_fontTexture.Positions[i].Width); // char width
                        writer.Write((byte)_fontTexture.Positions[i].Height); // char height
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_fontTexture != null)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Save TextureFont";
                    dialog.FilterIndex = 3;
                    dialog.Filter = "Xml-File with external image|*.xml|Xml-File with included image|*.xml|XNA XmlContent file with external image|.xml|Binary file|*.txf";
                    dialog.FileName = cbxFont.SelectedItem.ToString().Replace(" ", "") + nudSize.Value.ToString();
                    dialog.AddExtension = true;

                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        switch (dialog.FilterIndex)
                        {
                            case 1:
                                SaveXml(dialog.FileName, false);
                                break;
                            case 2:
                                SaveXml(dialog.FileName, true);
                                break;
                            case 3:
                                SaveXnaXmlContentFile(dialog.FileName);
                                break;
                            case 4:
                                SaveBinary(dialog.FileName);
                                break;

                            default:
                                throw new NotImplementedException();
                        }
                    }
                }
            }
        }

        private void panBackgroundColor_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            using (ColorDialog dialog = new ColorDialog())
            {
                dialog.Color = panel.BackColor;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    panel.BackColor = dialog.Color;
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            using (FormAbout dialog = new FormAbout())
            {
                dialog.ShowDialog(this);
            }
        }

        #endregion
    }
}