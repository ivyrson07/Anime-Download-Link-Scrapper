using AnimeScrapper.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeScrapper.Helper.UI
{
    public class Drawing
    {
        #region DisplayAnimeInformation

        public static void DisplayAnimeInformation(AnimeInformation info, Label titleLbl, Label descriptionLbl,
            Label genreLbl, Label statusLbl, Label yearReleasedLbl, PictureBox coverImagePb, Panel animeInfoPnl)
        {
            titleLbl.Text = info.Title.ToUpper();
            descriptionLbl.Text = info.Description;
            genreLbl.Text = info.Genre;
            statusLbl.Text = info.Status;
            yearReleasedLbl.Text = info.YearReleased.ToString();
            coverImagePb.Image = info.CoverImage;

            animeInfoPnl.BringToFront();
        }

        #endregion

        #region DisplaySearchedAnimeList

        public static void DisplaySearchedAnimeList(List<AnimeInformation> infoList, Panel searchResultPnl, 
            bool displayImages)
        {
            Panel panel = searchResultPnl;
            List<Image> img = new List<Image>();
            AnimeScrapper.AnimeListControls = new List<Control>();

            if (displayImages)
            {
                foreach (var imgUrl in infoList.Select(x => x.CoverImageUrl))
                {
                    ScrapeManager.CreateRequest(imgUrl);
                    img.Add(Image.FromStream(ScrapeManager.ResponseInMediaFileFormat));
                }
            }
            else
            {
                for (int i = 0; i < infoList.Count; i++)
                {
                    img.Add(Properties.Resources.noImage);
                }
            }

            int ctr = 0;
            int locationY = 0;

            panel.Controls.Clear();

            foreach (var info in infoList)
            {
                PictureBox pb = new PictureBox();
                pb.Tag = info.AnimeUrl;
                pb.Name = "[Image]" + info.AnimeUrl;
                pb.Size = new Size(226, 109);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Location = new Point(0, locationY);
                pb.Image = img[ctr];
                pb.Cursor = Cursors.Hand;
                pb.Click += AnimeScrapper.AnimeList_Clicked;
                pb.MouseMove += AnimeScrapper.AnimeList_MouseMove;
                pb.MouseLeave += AnimeScrapper.AnimeList_MouseLeave;

                panel.Controls.Add(pb);

                Label titleLbl = new Label();
                titleLbl.Text = info.Title;
                titleLbl.Tag = info.AnimeUrl;
                titleLbl.Name = "[Title]" + info.AnimeUrl;
                titleLbl.Font = new Font("Microsoft Sans Serif", 14);
                titleLbl.ForeColor = Color.White;
                titleLbl.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                titleLbl.Dock = DockStyle.None;
                titleLbl.AutoSize = true;
                titleLbl.Cursor = Cursors.Hand;
                titleLbl.MaximumSize = new Size(360, 77);
                titleLbl.Location = new Point(232, locationY);
                titleLbl.Click += AnimeScrapper.AnimeList_Clicked;
                titleLbl.MouseMove += AnimeScrapper.AnimeList_MouseMove;
                titleLbl.MouseLeave += AnimeScrapper.AnimeList_MouseLeave;

                panel.Controls.Add(titleLbl);

                Label genreLbl = new Label();
                genreLbl.Text = info.Genre;
                genreLbl.Tag = info.AnimeUrl;
                genreLbl.Name = "[Genre]" + info.AnimeUrl;
                genreLbl.Font = new Font("Microsoft Sans Serif", 8);
                genreLbl.ForeColor = Color.White;
                genreLbl.Cursor = Cursors.Hand;
                genreLbl.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                genreLbl.Dock = DockStyle.None;
                genreLbl.Size = new Size(378, 29);
                int genreLblLocationY = locationY + titleLbl.Height + 6;
                genreLbl.Location = new Point(232, genreLblLocationY);
                genreLbl.Click += AnimeScrapper.AnimeList_Clicked;
                genreLbl.MouseMove += AnimeScrapper.AnimeList_MouseMove;
                genreLbl.MouseLeave += AnimeScrapper.AnimeList_MouseLeave;

                panel.Controls.Add(genreLbl);

                AnimeScrapper.AnimeListControls.Add(pb);
                AnimeScrapper.AnimeListControls.Add(titleLbl);
                AnimeScrapper.AnimeListControls.Add(genreLbl);

                ctr++;
                locationY = locationY + 126;
            }
        }

        #endregion
    }
}
