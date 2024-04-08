using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button_newEntry_Click(object sender, EventArgs e)
        {
            // entryPanel
            Panel entryPanel = new Panel();
            entryPanel.Height = 52;
            entryPanel.Width = 300;
            entryPanel.BackColor = Color.LightGray;

            // textBox
            TextBox textBox = new TextBox();
            textBox.Size = new Size(50, 30); // Set size
            textBox.Location = new Point(35, 5); // Set position

            // deletion checkBox
            CheckBox delete_checkBox = new CheckBox();
            delete_checkBox.Location = new Point(90, 3); // Adjust position
            delete_checkBox.CheckedChanged += (s, ea) =>
            {
                if (delete_checkBox.Checked)
                {
                    // Mark the panel for deletion
                    entryPanel.Tag = "MarkedForDeletion";
                }
                else
                {
                    // Unmark the panel for deletion
                    entryPanel.Tag = null;
                }
            };
            // Episode counter for this entry
            int episodeCounter = 1;

            // Ep counter label
            Label label_epCounter = new Label();
            label_epCounter.Location = new Point(5, 30);
            label_epCounter.Width = 60;
            UpdateEpisodeCounterLabel(label_epCounter, episodeCounter);

            // episode plus button

            Button button_epPlus = new Button();
            button_epPlus.Size = new Size(20, 20);
            button_epPlus.Location = new Point(65, 27);
            button_epPlus.Text = "+";
            button_epPlus.Click += (s, ea) =>
            {
                episodeCounter++; 
                UpdateEpisodeCounterLabel(label_epCounter, episodeCounter);
            };

            // episode minus button

            Button button_epMinus = new Button();
            button_epMinus.Size = new Size(20, 20);
            button_epMinus.Location = new Point(90, 27);
            button_epMinus.Text = "-";
            button_epMinus.Click += (s, ea) =>
            {
                if (episodeCounter > 1) 
                {
                    episodeCounter--; 
                    UpdateEpisodeCounterLabel(label_epCounter, episodeCounter);
                }
            };


            // labels

            // Delete checkbox text
            Label label_delete = new Label();
            label_delete.Text = "Delete";
            label_delete.Height = 12;
            label_delete.Location = new Point(103, 8);

            // Title label
            Label label_Title = new Label();
            label_Title.Text = "Title:";
            label_Title.Width = 30;
            label_Title.Height = 12;
            label_Title.Location = new Point(5, 8);

            // entryPanel controls
            entryPanel.Controls.Add(label_Title);
            entryPanel.Controls.Add(label_epCounter);
            entryPanel.Controls.Add(label_delete);

            entryPanel.Controls.Add(textBox);
            entryPanel.Controls.Add(delete_checkBox);
            entryPanel.Controls.Add(button_epPlus);
            entryPanel.Controls.Add(button_epMinus);

            // listPanel controls
            listPanel.Controls.Add(entryPanel);

            // Fill empty gaps after deletion
            FixEntryPanels();
        }

        private void UpdateEpisodeCounterLabel(Label label_epCounter, int episodeCounter)
        {
            label_epCounter.Text = $"Episode: {episodeCounter}";
        }

        private void button_Delete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected entries?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                for (int i = listPanel.Controls.Count - 1; i >= 0; i--)
                {
                    Control control = listPanel.Controls[i];
                    if (control is Panel panel && panel.Tag?.ToString() == "MarkedForDeletion")
                    {
                        listPanel.Controls.RemoveAt(i);
                    }
                }
                FixEntryPanels();
            }
        }

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
