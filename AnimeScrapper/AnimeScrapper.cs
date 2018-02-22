using AnimeScrapper.Helper.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AnimeScrapper
{
    public partial class AnimeScrapper : Form
    {
        private static PictureBox pb;
        private static Label title;
        private static Label genre;
        private static string animeUrl;

        public static List<Control> AnimeListControls { get; set; }

        public AnimeScrapper()
        {
            InitializeComponent();

            ScrapeManager.InitializeScrapper(AnimeSite.AnimeHeaven);

            searchResultPnl.AutoScroll = false;
            searchResultPnl.HorizontalScroll.Enabled = false;
            searchResultPnl.HorizontalScroll.Visible = false;
            searchResultPnl.HorizontalScroll.Maximum = 0;
            searchResultPnl.AutoScroll = true;
        }

        #region Shared Event - Anime List Selection

        public static void AnimeList_Clicked(object sender, EventArgs e)
        {
            animeUrl = ((Control)sender).Tag.ToString();

            MessageBox.Show(animeUrl);
        }

        public static void AnimeList_MouseMove(object sender, MouseEventArgs e)
        {
            animeUrl = ((Control)sender).Tag.ToString();

            title = (Label)(AnimeListControls.Where(x => x.Name == "[Title]" + animeUrl).First());
            genre = (Label)(AnimeListControls.Where(x => x.Name == "[Genre]" + animeUrl).First());

            UIControl.HoverOnLabel(title);
            UIControl.HoverOnLabel(genre);
        }

        public static void AnimeList_MouseLeave(object sender, EventArgs e)
        {
            animeUrl = ((Control)sender).Tag.ToString();

            title = (Label)(AnimeListControls.Where(x => x.Name == "[Title]" + animeUrl).First());
            genre = (Label)(AnimeListControls.Where(x => x.Name == "[Genre]" + animeUrl).First());

            UIControl.PlainOnLabel(title);
            UIControl.PlainOnLabel(genre);
        }

        #endregion

        #region Search Tb

        private void searchTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string keyword = searchTb.Text;
                string searchThis = string.Format(ScrapeManager.RestfulSearch, keyword);

                ScrapeManager.CreateRequest(searchThis);
                var list = ScrapeManager.GetAnimeList(AnimeSite.AnimeHeaven, ScrapeManager.ResponseInHtmlFormat);

                Helper.UI.Drawing.DisplaySearchedAnimeList(list, searchResultPnl);

                searchTb.Text = "";
                //Thread.CurrentThread.Interrupt();
                //Thread.CurrentThread.Start();
            }
        }

        #endregion
    }
}
