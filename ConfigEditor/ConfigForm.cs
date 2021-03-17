using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigEditor
{
    public partial class ConfigForm : Form
    {
        public static bool registered = false;
        string regCode = "0000-1111-2222-3333";
        public ConfigForm()
        {
            InitializeComponent();
            if(registered)
            {
                registerButton.Visible = false;
                codeTextBox.Visible = false;
                codeLabel.Text = "Registered";
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(codeTextBox.Text == regCode)
            {
                registered = true;
            }
            Close();
        }
    }
}
