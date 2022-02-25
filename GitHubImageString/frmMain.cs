using System;
using System.Windows.Forms;

namespace GitHubImageString
{
    public partial class frmMain : Form
    {
        private bool isResetting = false; // Use this to prevent recursive calls to the Convert event when resetting the textbox.

        public frmMain()
        {
            InitializeComponent();
        }

        private void txtImageBB_TextChanged(object sender, EventArgs e)
        {
            if (!isResetting && chkAutoConvert.Checked) Convert();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            if (chkAutoConvert.Checked) Convert();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (chkAutoConvert.Checked) Convert();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void Convert()
        {
            // Don't waste time if there's no image text.
            if (txtImageBB.Text == "")
            {
                txtImageHTML.Text = "Need a BBCode string to manipulate.";
                return;
            }

            // Find the first open parenthesis mark.
            int indexOfParenthesis1 = txtImageBB.Text.IndexOf('(');

            // Find the second mark if the first one exists.
            int indexOfParenthesis2 = -1;
            if (indexOfParenthesis1 >= 0) indexOfParenthesis2 = txtImageBB.Text.Substring(indexOfParenthesis1).IndexOf(')');

            // Don't waste time if both parentheses weren't found.
            if (indexOfParenthesis1 < 0 || indexOfParenthesis2 < 0)
            {
                txtImageHTML.Text = "Need a valid string to manipulate.";
                return;
            }

            // Everything between parentheses should be the URL of the image. Get it.
            string url = txtImageBB.Text.Substring(indexOfParenthesis1 + 1, indexOfParenthesis2 - 1);

            // Setup the image tags.
            string tagOpen1 = "<img src='";
            string tagOpen2 = "'";
            string tagClose = " />";
            string tagWidth = (txtWidth.Text != "") ? " width='" + txtWidth.Text + "'" : "";
            string tagHeight = (txtHeight.Text != "") ? " height='" + txtHeight.Text + "'" : "";

            // Combine everything for the output.
            txtImageHTML.Text = tagOpen1 + url + tagOpen2 + tagWidth + tagHeight + tagClose;

            // If the other checkbox is ticked, delete the source string automagically.
            if (chkAutoDelete.Checked) isResetting = true; txtImageBB.Text = ""; isResetting = false;

            // If the checkbox is ticked, copy the string automagically.
            if (chkAutoCopy.Checked) CopyToClipboard();
        }

        private void CopyToClipboard()
        {
            Clipboard.SetDataObject(txtImageHTML.Text);
        }
    }
}
