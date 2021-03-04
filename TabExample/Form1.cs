using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showTextButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Hello World!";
        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Hello World, says menu item!";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "TabControl and Menu example";
        }
    }
}
