using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace TextureFontGenerator
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            FileVersionInfo info = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);

            lblText.Text = lblText.Text
                .Replace("{Name}", info.ProductName)
                .Replace("{Version}", info.ProductVersion)
                .Replace("{Copyright}", info.LegalCopyright);

            lnkWebsite.Text = lnkWebsite.Text
                .Replace("{Website}", info.CompanyName);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(lnkWebsite.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open url:\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}