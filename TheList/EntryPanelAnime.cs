using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheList
{
    public partial class EntryPanelAnime : UserControl
    {
        public EntryPanelAnime()
        {
            InitializeComponent();
            this.HandleCreated += EntryPanel_size;
        }

        // ==================================================================
        // making so after clicking the pictureBox a file picker opens
        private void pictureBox_Image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Choose file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    pictureBox_Image.Image = Image.FromFile(selectedFilePath);
                    Image = pictureBox_Image.Image;
                }
            }
        }

        // ==================================================================
        // adds a default size for entrypanels
        private void EntryPanel_size(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Width = this.Parent.Width - 53;
            }
        }

        // ==================================================================
        // self explanatory i think
        private void delete_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (delete_checkBox.Checked)
            {
                // Mark the panel for deletion
                entryPanel_.Tag = "MarkedForDeletion";
            }
            else
            {
                // Unmark 
                entryPanel_.Tag = null;
            }
        }

        // ==================================================================
        // Episode counter

        // default episode counter value
        private int episodeCounter = 0;
        private void button_epPlus_Click(object sender, EventArgs e)
        {
            episodeCounter++;
            label_epCounter.Text = $"Episode: {episodeCounter}";
        }

        private void button_epMinus_Click(object sender, EventArgs e)
        {
            if (episodeCounter > 0)
            {
                episodeCounter--;
                label_epCounter.Text = $"Episode: {episodeCounter}";
            }
        }

        // ==================================================================
        // Season counter

        private int seasonCounter = 0;
        private void button_sPlus_Click(object sender, EventArgs e)
        {
            seasonCounter++;
            label_sCounter.Text = $"Season: {seasonCounter}";
        }

        private void button_sMinus_Click(object sender, EventArgs e)
        {
            if (seasonCounter > 0)
            {
                seasonCounter++;
                label_sCounter.Text = $"Season: {seasonCounter}";
            }
        }

        private void button_sClear_Click(object sender, EventArgs e)
        {
            seasonCounter = 0;
            label_sCounter.Text = $"Season: {seasonCounter}";
        }

        // ==================================================================
        // Moving entrypanels up and down
        private void moveUp_Click(object sender, EventArgs e)
        {
            AnimeList animeList = FindParentAnimeList(this);
            if (animeList != null)
            {
                animeList.MoveEntryUp(this);
            }
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            AnimeList animeList = FindParentAnimeList(this);
            if (animeList != null)
            {
                animeList.MoveEntryDown(this);
            }
        }

        // Helper method to find the parent AnimeList control
        private AnimeList FindParentAnimeList(Control control)
        {
            Control parent = control.Parent;
            while (parent != null && !(parent is AnimeList))
            {
                parent = parent.Parent;
            }
            return parent as AnimeList;
        }


        // ==================================================================
        // Making so these are accessable to Form1.cs
        public string NumberListText
        {
            get { return label_NumberList.Text; }
            set { label_NumberList.Text = value; }
        }

        public string Title
        {
            get { return textBox_Title.Text; }
            set { textBox_Title.Text = value; }
        }

        public bool DeleteChecked
        {
            get { return delete_checkBox.Checked; }
            set { delete_checkBox.Checked = value; }
        }

        public int EpisodeCounter
        {
            get { return episodeCounter; }
            set
            {
                episodeCounter = value;
                label_epCounter.Text = $"Episode: {episodeCounter}";
            }
        }

        public int SeasonCounter
        {
            get { return seasonCounter; }
            set
            {
                seasonCounter = value;
                label_sCounter.Text = $"Season: {seasonCounter}";
            }
        }

        public Image Image
        {
            get { return pictureBox_Image.Image; }
            set { pictureBox_Image.Image = value; }
        }
    }
}
