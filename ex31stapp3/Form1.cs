using System;
using System.Windows.Forms;
using System.IO;

namespace ex31stapp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            string fileName = filenameTextBox.Text;
            string[] tbl = File.ReadAllLines(fileName);
            foreach (var line in tbl)
            {
                outputTextBox.AppendText(line+Environment.NewLine);
            }

        }
    }
}
