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
            int bytesProcessed = 0;
            Stream remoteStream;
            Stream localStream;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://animeheaven.eu/search.php?q=dfrag");//http://s6vpxik.animeheaven.eu/force.php?f=D-Fragments--1--1463440700");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();

            //remoteStream = response.GetResponseStream();

            //// Create the local file
            //localStream = File.Create(@"C:\Users\Kendrick Khoe\Desktop\Anime Episode 01.mp4");

            //// Allocate a 1k buffer
            //byte[] buffer = new byte[131072];// 1024];
            //int bytesRead;

            //// Simple do/while loop to read from stream until
            //// no bytes are returned
            //do
            //{
            //    // Read data (up to 1k) from the stream
            //    bytesRead = remoteStream.Read(buffer, 0, buffer.Length);

            //    // Write the data to the local file
            //    localStream.Write(buffer, 0, bytesRead);

            //    // Increment total bytes processed
            //    bytesProcessed += bytesRead;
            //} while (bytesRead > 0);

            string text = "";
            
            ScrapeManager.InitializeScrapper(AnimeSite.AnimeHeaven);
            ScrapeManager.CreateRequest(@"http://animeheaven.eu/coversjpg/Is_It_Wrong_to_Try_to_Pick_Up_Girls_in_a_Dungeon.jpg");
            Image img = Image.FromStream(ScrapeManager.ResponseInMediaFileFormat);
            
            sampleImg.Image = img;
            sampleImg.SizeMode = PictureBoxSizeMode.StretchImage;

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

                ScrapeManager.CreateRequest(string.Format(ScrapeManager.RestfulSearch, keyword));
                ScrapeManager.GetAnimeList(AnimeSite.AnimeHeaven, ScrapeManager.ResponseInHtmlFormat);

                searchTb.Text = "";
                //Thread.CurrentThread.Interrupt();
                //Thread.CurrentThread.Start();
            }
        }

        #endregion
    }
}
