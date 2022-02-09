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
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.RegularExpressions;

namespace Assignment5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(150, groupBox1.BackColor);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtName.Focus();
            txtLocation.Clear();
            txtArtifacts.Clear();
        }
        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtName.Text != String.Empty && txtLocation.Text != String.Empty && txtArtifacts.Text != String.Empty)
            {
                Explorer explorer = new Explorer();
                explorer.ArtifactsDiscovered = Int32.Parse(txtArtifacts.Text);
                explorer.Name = txtName.Text;
                explorer.LastKnownLocation = txtLocation.Text;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files(*.txt)|*.txt";
                saveFileDialog.ShowDialog();

                Stream stream = saveFileDialog.OpenFile();
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, explorer);

                MessageBox.Show($"Explorer {explorer.Name} has been serialized to binary.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtArtifacts.Clear();
                txtLocation.Clear();
                txtName.Clear();
                stream.Close();
            }
            else
                MessageBox.Show("You haven't filled out every field. You'll never be an explorer at this rate.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtName.Text != String.Empty && txtLocation.Text != String.Empty && txtArtifacts.Text != String.Empty)
            {
                Explorer explorer = new Explorer();
                explorer.ArtifactsDiscovered = Int32.Parse(txtArtifacts.Text);
                explorer.Name = txtName.Text;
                explorer.LastKnownLocation = txtLocation.Text;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.ShowDialog();

                Stream stream = saveFileDialog.OpenFile();
                SoapFormatter formatter = new SoapFormatter();
                formatter.Serialize(stream, explorer);

                MessageBox.Show($"Explorer {explorer.Name} has been serialized to XML.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtArtifacts.Clear();
                txtLocation.Clear();
                txtName.Clear();
                stream.Close();
            }
            else
                MessageBox.Show("You haven't filled out every field. You'll never be an explorer at this rate.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtName.Text != String.Empty && txtLocation.Text != String.Empty && txtArtifacts.Text != String.Empty)
            {
                Explorer explorer = new Explorer();
                explorer.ArtifactsDiscovered = Int32.Parse(txtArtifacts.Text);
                explorer.Name = txtName.Text;
                explorer.LastKnownLocation = txtLocation.Text;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files(*.txt)|*.txt";
                saveFileDialog.ShowDialog();

                Stream stream = saveFileDialog.OpenFile();
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Explorer));
                serializer.WriteObject(stream, explorer);

                MessageBox.Show($"Explorer {explorer.Name} has been serialized to JSON.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtArtifacts.Clear();
                txtLocation.Clear();
                txtName.Clear();
                stream.Close();
            }
            else
                MessageBox.Show("You haven't filled out every field. You'll never be an explorer at this rate.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void obinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files(*.txt)|*.txt";
            openFileDialog.ShowDialog();

            try
            {
                Stream stream = openFileDialog.OpenFile();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                try
                {
                    Explorer explorer = (Explorer)binaryFormatter.Deserialize(stream);
                    txtArtifacts.Text = explorer.ArtifactsDiscovered.ToString();
                    txtName.Text = explorer.Name;
                    txtLocation.Text = explorer.LastKnownLocation;
                    MessageBox.Show($"Explorer {explorer.Name} has been deserialized from binary.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a file.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void oxMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            openFileDialog.ShowDialog();

            try
            {
                Stream stream = openFileDialog.OpenFile();
                SoapFormatter formatter = new SoapFormatter();
                try
                {
                    Explorer explorer = (Explorer)formatter.Deserialize(stream);
                    txtArtifacts.Text = explorer.ArtifactsDiscovered.ToString();
                    txtName.Text = explorer.Name;
                    txtLocation.Text = explorer.LastKnownLocation;
                    MessageBox.Show($"Explorer {explorer.Name} has been deserialized from XML.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    stream.Close();
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show("Please select a file.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ojSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files(*.txt)|*.txt";
            openFileDialog.ShowDialog();

            try
            {
                Stream stream = openFileDialog.OpenFile();
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Explorer));
                try
                {
                    Explorer explorer = (Explorer)serializer.ReadObject(stream);
                    txtArtifacts.Text = explorer.ArtifactsDiscovered.ToString();
                    txtName.Text = explorer.Name;
                    txtLocation.Text = explorer.LastKnownLocation;
                    MessageBox.Show($"Explorer {explorer.Name} has been deserialized from JSON.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a file.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtArtifacts_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtArtifacts.Text, @"^[1-9]\d*$"))
            {
                txtArtifacts.Clear();
                MessageBox.Show("That doesn't sound like any number I've ever heard of.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 30)
            {
                txtName.Clear();
                MessageBox.Show("Whoa there, partner. Let's try using your nickname instead", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            if (txtLocation.Text.Length > 30)
            {
                txtLocation.Clear();
                MessageBox.Show("We'll never find them with a name that long, what do the locals call it?", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}