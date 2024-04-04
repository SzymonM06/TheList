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
        int a = 0;
        int height = 5;
        private void button_newEntry_Click(object sender, EventArgs e)
        {
            

            a++;

            Label label = new Label();
            label.Text = a.ToString();

            // entryPanel
            Panel entryPanel = new Panel();
            entryPanel.Location = new Point(5, height);
            entryPanel.Height = 50;
            entryPanel.BackColor = Color.LightGray;

            // textBox
            TextBox textBox = new TextBox();
            textBox.Size = new Size(50, 30); // Set size
            textBox.Location = new Point(15, 10); // Set position

            // entryPanel controls
            entryPanel.Controls.Add(textBox);
            entryPanel.Controls.Add(label);

            // listPanel controls
            listPanel.Controls.Add(entryPanel);

            height = 55 + height;
        }
    }
}
