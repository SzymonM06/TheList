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
    public partial class Main : Form
    {
        private MainMenu mainMenu = new MainMenu();
        private AnimeList animeList = new AnimeList();
        private SeriesList seriesList = new SeriesList();

        public Main()
        {
            InitializeComponent();

            mainMenu.Dock = DockStyle.Fill;
            animeList.Dock = DockStyle.Fill;
            seriesList.Dock = DockStyle.Fill;

            this.Controls.Add(mainMenu);
            this.Controls.Add(animeList);
            this.Controls.Add(seriesList);
            animeList.Hide();
            seriesList.Hide();
        }


        //Anime
        public void ShowAnimeList()
        {
            mainMenu.Hide();
            animeList.Show();
        }

        public void HideAnimeList()
        {
            mainMenu.Show();
            animeList.Hide();
        }

        //Series
        public void ShowSeriesList()
        {
            mainMenu.Hide();
            seriesList.Show();
        }

        public void HideSeriesList() 
        {
            mainMenu.Show();
            seriesList.Hide();
        }
    }
}
