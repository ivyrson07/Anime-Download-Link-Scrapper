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
        private static AnimeScrapper a;

        public static List<Control> AnimeListControls { get; set; }

        #region CreateParams

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        #endregion

        public AnimeScrapper()
        {
            InitializeComponent();

            ScrapeManager.InitializeScrapper(AnimeSite.AnimeHeaven);

            searchResultPnl.AutoScroll = false;
            searchResultPnl.HorizontalScroll.Enabled = false;
            searchResultPnl.HorizontalScroll.Visible = false;
            searchResultPnl.HorizontalScroll.Maximum = 0;
            searchResultPnl.AutoScroll = true;

            //epToBeScrappedPnl.AutoScroll = false;
            //epToBeScrappedPnl.HorizontalScroll.Enabled = false;
            //epToBeScrappedPnl.HorizontalScroll.Visible = false;
            //epToBeScrappedPnl.HorizontalScroll.Maximum = 0;
            //epToBeScrappedPnl.AutoScroll = true;

            a = this;
        }

        #region Shared Event - Anime List Selection

        public static void AnimeList_Clicked(object sender, EventArgs e)
        {
            animeUrl = ((Control)sender).Tag.ToString();

            pb = (PictureBox)(AnimeListControls.Where(x => x.Name == "[Image]" + animeUrl).First());
            title = (Label)(AnimeListControls.Where(x => x.Name == "[Title]" + animeUrl).First());
            genre = (Label)(AnimeListControls.Where(x => x.Name == "[Genre]" + animeUrl).First());

            ScrapeManager.CreateRequest(animeUrl);

            Drawing.DisplayAnimeInformation(
                ScrapeManager.GetAnimeInformation(AnimeSite.AnimeHeaven, ScrapeManager.ResponseInHtmlFormat,
                    title.Text, genre.Text, pb.Image),
                a.titleLbl,
                a.descriptionLbl,
                a.genreLbl,
                a.statusLbl,
                a.yearReleasedLbl,
                a.coverImagePb,
                a.AnimeInformationPanel
            );
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

        #region Anime Information > Go Back Btn

        private void animeInfoGoBackBtn_Click(object sender, EventArgs e)
        {
            SearchPanel.BringToFront();
        }

        #endregion

        #region Anime Information > Next Btn

        private void nextBtn_Click(object sender, EventArgs e)
        {
            ScrapePanel.BringToFront();
        }

        #endregion

        #region Scrape > Go Back Btn

        private void scrapeGoBackBtn_Click(object sender, EventArgs e)
        {
            AnimeInformationPanel.BringToFront();
        }

        #endregion

        #region Search > Search Tb

        private void searchTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string keyword = searchTb.Text;
                string searchThis = string.Format(ScrapeManager.SearchLink, keyword);

                ScrapeManager.CreateRequest(searchThis);
                var list = ScrapeManager.GetAnimeList(AnimeSite.AnimeHeaven, ScrapeManager.ResponseInHtmlFormat);

                Helper.UI.Drawing.DisplaySearchedAnimeList(list, searchResultPnl, displayImagesChk.Checked);

                searchTb.Text = "";
            }
        }

        #endregion
    }
}
