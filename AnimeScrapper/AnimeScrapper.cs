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
