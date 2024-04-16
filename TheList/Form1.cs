using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace TheList
{
    public partial class Form1 : Form
    {
        // save file name
        private string dataFilePath = "data.json";

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        // ==================================================================
        // create new entry (panel) button
        private void button_newEntry_Click(object sender, EventArgs e)
        {
            EntryPanel entryPanel = new EntryPanel();

            listPanel.Controls.Add(entryPanel);

            // unfuck the panels
            FixEntryPanels();
        }


        // ==================================================================
        // save button
        private void button_Save_Click(object sender, EventArgs e)
        {
            List<EntryData> entries = new List<EntryData>();

            foreach (Control control in listPanel.Controls)
            {
                if (control is EntryPanel entryPanel)
                {
                    EntryData entryData = new EntryData();
                    entryData.X = entryPanel.Location.X;
                    entryData.Y = entryPanel.Location.Y;

                    foreach (Control entryControl in entryPanel.Controls)
                    {
                        if (entryControl is TextBox textBox && entryControl.Name == "TextBox_Title")
                        {
                            entryData.TextBoxContent = textBox.Text;
                        }
                        else if (entryControl is CheckBox deleteCheckBox && entryControl.Name == "delete_checkBox")
                        {
                            entryData.DeleteChecked = deleteCheckBox.Checked;
                        }
                        else if (entryControl is Label label && label.Name == "label_epCounter")
                        {
                            entryData.EpisodeCounter = int.Parse(label.Text.Split(':')[1].Trim());
                        }
                    }

                    entries.Add(entryData);
                }
            }

            // Serialize and write the data to the file
            string jsonData = JsonConvert.SerializeObject(entries, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(dataFilePath, jsonData);
        }

        // ==================================================================
        // holding data to put into save file
        private class EntryData
        {
            public string TextBoxContent { get; set; }
            public int EpisodeCounter { get; set; }
            public bool DeleteChecked { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
        }

        // ==================================================================
        // load data method
        private void LoadData()
        {
            if (File.Exists(dataFilePath))
            {
                using (StreamReader reader = new StreamReader(dataFilePath))
                {
                    var jsonData = reader.ReadToEnd();
                    var entries = JsonConvert.DeserializeObject<List<EntryData>>(jsonData);

                    foreach (var entryData in entries)
                    {
                        EntryPanel entryPanel = new EntryPanel();
                        entryPanel.Location = new Point(entryData.X, entryData.Y);

                        // Set properties based on entryData
                        entryPanel.TextBoxText = entryData.TextBoxContent;
                        entryPanel.DeleteCheckBoxChecked = entryData.DeleteChecked;
                        entryPanel.EpisodeCounterText = $"Episode: {entryData.EpisodeCounter}";

                        listPanel.Controls.Add(entryPanel);
                    }
                }
            }
        }

        // ==================================================================
        // delete button
        private void button_Delete_Click_1(object sender, EventArgs e)
        {
            // Display confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected entries?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Loop through all EntryPanel controls
                for (int i = listPanel.Controls.Count - 1; i >= 0; i--)
                {
                    if (listPanel.Controls[i] is EntryPanel entryPanel)
                    {
                        // Check if the delete checkbox is checked
                        if (entryPanel.DeleteCheckBoxChecked)
                        {
                            listPanel.Controls.RemoveAt(i);
                        }
                    }
                }

                FixEntryPanels();
            }
        }

        // ==================================================================
        // reorganising the panels (entries) after deleting or creating one
        private void FixEntryPanels()
        {
            int top = 0;
            foreach (Control control in listPanel.Controls)
            {
                control.Location = new Point(5, top);
                top += control.Height + 5;
            }
        }
    }
}