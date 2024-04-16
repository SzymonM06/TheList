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
        }

        // default episode counter value
        int episodeCounter = 0;

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

        public string TextBoxText
        {
            get { return textBox_Title.Text; }
            set { textBox_Title.Text = value; }
        }

        public bool DeleteCheckBoxChecked
        {
            get { return delete_checkBox.Checked; }
            set { delete_checkBox.Checked = value; }
        }

        public string EpisodeCounterText
        {
            get { return label_epCounter.Text; }
            set { label_epCounter.Text = value; }
        }
    }
}
