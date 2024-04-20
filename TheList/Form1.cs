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
        private string dataFilePath = "data.json"; // save file name
        private List<EntryData> entries = new List<EntryData>(); // list of saving data
        int top = 0; // for loading in new entries in LoadData
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        // ==================================================================
        // create new entry (panel) button
        private void button_newEntry_Click(object sender, EventArgs e)
        {
            listPanel.VerticalScroll.Value = 0; // scroll all the way up

            EntryPanel entryPanel = new EntryPanel();

            listPanel.Controls.Add(entryPanel);
            entryPanel.EpisodeCounter = 0;

            // unfuck the panels
            FixEntryPanels();
        }


        // ==================================================================
        // save button
        private void button_Save_Click(object sender, EventArgs e)
        {
            entries.Clear(); // Clear existing entries
            foreach (EntryPanel entryPanel in listPanel.Controls)
            {
                entries.Add(new EntryData
                {
                    Title = entryPanel.Title,
                    DeleteChecked = entryPanel.DeleteChecked,
                    EpisodeCounter = entryPanel.EpisodeCounter
                });
            }

            // Serialize and write the data to the file
            string jsonData = JsonConvert.SerializeObject(entries, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(dataFilePath, jsonData);
        }

        // ==================================================================
        // holding data to put into save file
        private class EntryData
        {
            public string Title { get; set; }
            public bool DeleteChecked { get; set; }
            public int EpisodeCounter { get; set; }
        }

        // ==================================================================
        // load data method
        private void LoadData()
        {
            if (File.Exists(dataFilePath))
            {
                string jsonData = File.ReadAllText(dataFilePath);
                entries = JsonConvert.DeserializeObject<List<EntryData>>(jsonData);

                foreach (EntryData entryData in entries)
                {
                    EntryPanel entryPanel = new EntryPanel();
                    entryPanel.Location = new Point(5, top);
                    entryPanel.Title = entryData.Title;
                    entryPanel.DeleteChecked = entryData.DeleteChecked;
                    entryPanel.EpisodeCounter = entryData.EpisodeCounter;
                    listPanel.Controls.Add(entryPanel);
                    top += entryPanel.Height + 5;
                }
            }
        }

        // ==================================================================
        // delete button
        private void button_Delete_Click(object sender, EventArgs e)
        {
            listPanel.VerticalScroll.Value = 0; // scroll all the way up

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected entries?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                for (int i = listPanel.Controls.Count - 1; i >= 0; i--)
                {
                    if (listPanel.Controls[i] is EntryPanel entryPanel && entryPanel.DeleteChecked)
                    {
                        listPanel.Controls.RemoveAt(i);
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