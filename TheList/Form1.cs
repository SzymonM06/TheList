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
            entryPanel.Height = 50;
            entryPanel.Width = 300;
            entryPanel.BackColor = Color.LightGray;

            // textBox
            TextBox textBox = new TextBox();
            textBox.Size = new Size(50, 30); // Set size
            textBox.Location = new Point(35, 5); // Set position

            // deletion checkBox
            CheckBox delete_checkBox = new CheckBox();
            delete_checkBox.Text = "Delete";
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

            // labels

            // Title label
            Label label_Title = new Label();
            label_Title.Text = "Title:";
            label_Title.Width = 30;
            label_Title.Height = 12;
            label_Title.Location = new Point(5, 8);

            // entryPanel controls
            entryPanel.Controls.Add(label_Title);

            entryPanel.Controls.Add(textBox);
            entryPanel.Controls.Add(delete_checkBox);

            // listPanel controls
            listPanel.Controls.Add(entryPanel);

            // Fill empty gaps after deletion
            FixEntryPanels();
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
