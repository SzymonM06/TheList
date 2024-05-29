using Newtonsoft.Json;
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

namespace TheList
{
    public partial class SeriesList : UserControl
    {
        private string dataFilePath = "savedata/savedata_Series.json"; // save file name
        private List<EntryData> entries = new List<EntryData>(); // list of saving dataF
        int top = 0; // default top possition, used for adding entrypanels
        private int originalScrollPosition = 0;
        public SeriesList()
        {
            InitializeComponent();
            LoadData();
            this.Resize += Form1_Resize;
            RefreshEntryPanels(); //refresh on load
        }

        // ==================================================================
        // Saving the selected image to the app directory
        private string SaveImageFile(Image image)
        {
            string directoryPath = Path.Combine(Application.StartupPath, "imgs");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string fileName = Path.Combine(directoryPath, Guid.NewGuid().ToString() + ".png"); // Generate a unique file name
            image.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
            return fileName;
        }

        // ==================================================================
        // Handling the resizing of elements in Form1
        private void Form1_Resize(object sender, EventArgs e)
        {
            listPanel.Size = new Size(this.ClientSize.Width - 25, this.ClientSize.Height - 70);
            controlPanel.Size = new Size(this.ClientSize.Width - 25, controlPanel.Height);

            int margin = 10;

            int availableWidth = listPanel.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - margin * 2;
            foreach (Control control in listPanel.Controls)
            {
                if (control is EntryPanelAnime entryPanel)
                {
                    entryPanel.Width = availableWidth;

                }
            }
        }

        // ==================================================================
        // move a entrypanel up
        public void MoveEntryUp(EntryPanelAnime entryPanel)
        {
            ScrollToTop();
            int index = listPanel.Controls.GetChildIndex(entryPanel);
            if (index > 0)
            {
                listPanel.Controls.SetChildIndex(entryPanel, index - 1);
                RefreshEntryPanels();
            }
            RestoreScrollPosition();
        }

        // ==================================================================
        // move a entrypanel down
        public void MoveEntryDown(EntryPanelAnime entryPanel)
        {
            ScrollToTop();
            int index = listPanel.Controls.GetChildIndex(entryPanel);
            if (index < listPanel.Controls.Count - 1)
            {
                listPanel.Controls.SetChildIndex(entryPanel, index + 1);
                RefreshEntryPanels();
            }
            RestoreScrollPosition();
        }

        // ==================================================================
        // create new entry (panel) button
        private void button_newEntry_Click(object sender, EventArgs e)
        {
            ScrollToTop();
            EntryPanelAnime entryPanel = new EntryPanelAnime();

            listPanel.Controls.Add(entryPanel);
            entryPanel.EpisodeCounter = 0;
            RefreshEntryPanels();
            ScrollToBottom();
        }


        // ==================================================================
        // save button
        private void button_Save_Click(object sender, EventArgs e)
        {
            entries.Clear(); // Clear existing entries
            foreach (EntryPanelAnime entryPanel in listPanel.Controls)
            {
                string imagePath = null;
                if (entryPanel.Image != null)
                {
                    imagePath = SaveImageFile(entryPanel.Image);
                }

                entries.Add(new EntryData
                {
                    Title = entryPanel.Title,
                    DeleteChecked = entryPanel.DeleteChecked,
                    EpisodeCounter = entryPanel.EpisodeCounter,
                    SeasonCounter = entryPanel.SeasonCounter,
                    ImagePath = imagePath // Save the image file path
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
            public int SeasonCounter { get; set; }
            public string ImagePath { get; set; }
        }

        // ==================================================================
        // load data 
        private void LoadData()
        {
            if (File.Exists(dataFilePath))
            {
                string jsonData = File.ReadAllText(dataFilePath);
                entries = JsonConvert.DeserializeObject<List<EntryData>>(jsonData);

                foreach (EntryData entryData in entries)
                {
                    EntryPanelAnime entryPanel = new EntryPanelAnime();
                    entryPanel.Location = new Point(5, top);
                    entryPanel.Title = entryData.Title;
                    entryPanel.DeleteChecked = entryData.DeleteChecked;
                    entryPanel.EpisodeCounter = entryData.EpisodeCounter;
                    entryPanel.SeasonCounter = entryData.SeasonCounter;
                    listPanel.Controls.Add(entryPanel);
                    top += entryPanel.Height + 5;

                    // Load image if ImagePath is not null
                    if (!string.IsNullOrEmpty(entryData.ImagePath) && File.Exists(entryData.ImagePath))
                    {
                        entryPanel.Image = Image.FromFile(entryData.ImagePath);
                    }

                    listPanel.Controls.Add(entryPanel);
                    top += entryPanel.Height + 5;
                }
            }
        }

        // ==================================================================
        // delete button
        private void button_Delete_Click(object sender, EventArgs e)
        {
            bool anyDeleteChecked = false;

            // Check if any delete checkbox is checked
            foreach (Control control in listPanel.Controls)
            {
                if (control is EntryPanelAnime entryPanel && entryPanel.DeleteChecked)
                {
                    anyDeleteChecked = true;
                    break;
                }
            }

            if (anyDeleteChecked)
            {
                ScrollToTop();

                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected entries?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    for (int i = listPanel.Controls.Count - 1; i >= 0; i--)
                    {
                        if (listPanel.Controls[i] is EntryPanelAnime entryPanel && entryPanel.DeleteChecked)
                        {
                            listPanel.Controls.RemoveAt(i);
                        }
                    }

                    RefreshEntryPanels();
                }

                RestoreScrollPosition();
            }
        }

        // ==================================================================
        // Refreshing all the entrypanels
        public void RefreshEntryPanels()
        {
            int top = 0;
            for (int i = 0; i < listPanel.Controls.Count; i++)
            {
                if (listPanel.Controls[i] is EntryPanelAnime entryPanel)
                {
                    entryPanel.Location = new Point(5, top);
                    entryPanel.NumberListText = (i + 1).ToString();
                    top += entryPanel.Height + 5;
                }
            }
        }

        // ==================================================================
        // Return to main menu
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Form mainForm = this.FindForm();
            if (mainForm != null && mainForm is Main)
            {
                Main mainFormInstance = (Main)mainForm;
                mainFormInstance.HideSeriesList();
            }
        }

        public void ScrollToTop()
        {
            originalScrollPosition = listPanel.VerticalScroll.Value;
            listPanel.VerticalScroll.Value = 0;
        }

        private void ScrollToBottom()
        {
            listPanel.VerticalScroll.Value = listPanel.VerticalScroll.Maximum;
            listPanel.PerformLayout();
        }

        private void RestoreScrollPosition()
        {
            listPanel.VerticalScroll.Value = originalScrollPosition;
        }
    }
}
