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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }        
        private void button_AnimeList_Click(object sender, EventArgs e)
        {
            Form mainForm = this.FindForm();
            if (mainForm != null && mainForm is Main)
            {
                Main mainFormInstance = (Main)mainForm;
                mainFormInstance.ShowAnimeList();
            }
        }

        private void button_SeriesList_Click(object sender, EventArgs e)
        {
            Form mainForm = this.FindForm();
            if (mainForm != null && mainForm is Main)
            {
                Main mainFormInstance = (Main)mainForm;
                mainFormInstance.ShowSeriesList();
            }
        }
    }
}