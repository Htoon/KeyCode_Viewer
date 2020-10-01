using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyCode_Viewer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            //=================================================================================
            // Form constructor
            //=================================================================================
            InitializeComponent();
            //=================================================================================
        }

        private void txtKeyInput_TextChanged(object sender, EventArgs e)
        {
            //=================================================================================
            // Text input change event
            //=================================================================================
            lblKeyCode.Text = showKeyCode(txtKeyInput.Text);
            //=================================================================================
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            //=================================================================================
            // Copy character codes to clipboard
            //=================================================================================
            Clipboard.SetText(lblKeyCode.Text, TextDataFormat.UnicodeText);
            //=================================================================================
        }

        private String showKeyCode(String str)
        {
            //=================================================================================
            // Show characters in string to character code
            //=================================================================================
            String result = String.Empty;

            foreach (char chr in str)
            {
                if (result.Length == 0)
                    result += ((int)chr).ToString("D4");
                else
                    result += " + " + ((int)chr).ToString("D4");
            }

            return (result);
            //=================================================================================
        }
    }
}
