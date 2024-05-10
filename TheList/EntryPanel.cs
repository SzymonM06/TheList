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
    public partial class EntryPanel : UserControl
    {
        public EntryPanel()
        {
            InitializeComponent();
            this.HandleCreated += EntryPanel_HandleCreated;

        }

        private void EntryPanel_HandleCreated(object sender, EventArgs e)
        {
            // Set initial width to match the parent container (listPanel)
            if (this.Parent != null)
            {
                this.Width = this.Parent.Width - 53; // Adjust the width as needed (considering margins, padding, etc.)

            }
        }

        // default episode counter value
        private int episodeCounter = 0;

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

        private void moveUp_Click(object sender, EventArgs e)
        {
            Form1 form = this.FindForm() as Form1;
            form.ScrollToTop(); // Scroll to the top before moving
            form.MoveEntryUp(this); // Move the entry up
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            Form1 form = this.FindForm() as Form1;
            form.ScrollToTop(); // Scroll to the top before moving
            form.MoveEntryDown(this); // Move the entry down
        }
    }
}
