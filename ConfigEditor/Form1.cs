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
            MessageBox.Show(this,
                            "Configuration file editor 0.0\nExample project", 
                            "About",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
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
                variableDataGridView.Rows.Clear();
                foreach (var v in file.variableList)
                {
                    string[] row = { v.type, v.name, v.value };
                    variableDataGridView.Rows.Add(row);
                }
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
                updateFile();
                file.saveFile(fileName);
                //saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fileName=="")
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }
            updateFile();
            file.saveFile(fileName);
        }

        private void updateFile()
        {
            file.ClearList();
            for (int i = 0; i < variableDataGridView.Rows.Count; i++)
            {
                if (variableDataGridView.Rows[i].Cells[0].Value!=null && variableDataGridView.Rows[i].Cells[0].Value!=null && variableDataGridView.Rows[i].Cells[2].Value!=null)
                {
                    file.insertNewVariable(variableDataGridView.Rows[i].Cells[0].Value.ToString(),
                                           variableDataGridView.Rows[i].Cells[1].Value.ToString(),
                                           variableDataGridView.Rows[i].Cells[2].Value.ToString());
                }
            }
        }

        private void configureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.ShowDialog();
            if(ConfigForm.registered)
            {
                Text = "Registered";
            }
        }

        private bool inFindMode=false;
        private void findButton_Click(object sender, EventArgs e)
        {
            var textToFind = findTextBox.Text;

            inFindMode = (textToFind != "");
            variableDataGridView.Rows.Clear();
            foreach (var v in file.variableList)
            {
                string[] row = { v.type, v.name, v.value };
                foreach (var s in row)
                {
                    if (s.Contains(textToFind))
                    {
                        variableDataGridView.Rows.Add(row);
                        break;
                    }
                }
            }
            variableDataGridView.ReadOnly = inFindMode;
        }

        private void variableDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!inFindMode)
            {
                updateFile();
            }
        }
    }
}
