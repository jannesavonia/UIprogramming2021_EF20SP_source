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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Configuration file editor 0.0");
        }

        private string fileType= "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        private string fileName = "";
        private ConfigFile file = new ConfigFile();

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = ".";
            openFileDialog.Filter = fileType;
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                //MessageBox.Show("Open " + filePath);
                file.readFile(fileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = fileType;
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                //MessageBox.Show("Save to " + fileName);
                file.saveFile(fileName);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fileName=="")
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }

            file.saveFile(fileName);
        }
    }
}
