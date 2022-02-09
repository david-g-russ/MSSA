using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Mod6Notepaddemo
{
    public partial class Form1 : Form
    {
        string filepath = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtArea.Clear();
            txtArea.Focus();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files(*.txt)|*.txt";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != string.Empty)
            {
                filepath = openFileDialog.FileName;
                txtArea.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filepath, txtArea.Text);
        }

        private void SaveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files(*.txt)|*.txt";
            saveFileDialog.ShowDialog();
            Stream fileStream = saveFileDialog.OpenFile(); // stream pointing to file in read / write
           
            StreamWriter streamWriter = new StreamWriter(fileStream);// pointing to file in write mode
            streamWriter.WriteLine(txtArea.Text); // records into file
            
            streamWriter.Close();
            fileStream.Close();
            
            
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
