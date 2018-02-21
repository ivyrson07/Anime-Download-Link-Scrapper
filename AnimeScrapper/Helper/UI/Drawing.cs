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
        #region DisplaySearchedAnimeList

        public static void DisplaySearchedAnimeList(List<AnimeInformation> infoList, Panel searchResultPnl)
        {
            Panel panel = searchResultPnl;
            List<Image> img = new List<Image>();

            foreach (var imgUrl in infoList.Select(x => x.CoverImageUrl))
            {
                ScrapeManager.CreateRequest(imgUrl);
                img.Add(Image.FromStream(ScrapeManager.ResponseInMediaFileFormat));
            }

            int ctr = 0;
            int locationY = 0;

            panel.Controls.Clear();

            foreach (var info in infoList)
            {
                PictureBox pb = new PictureBox();
                pb.Tag = info.AnimeUrl;
                pb.Size = new Size(226, 109);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Location = new Point(0, locationY);
                pb.Image = img[ctr];

                panel.Controls.Add(pb);

                Label titleLbl = new Label();
                titleLbl.Text = info.Title;
                titleLbl.Tag = info.AnimeUrl;
                titleLbl.Font = new Font("Microsoft Sans Serif", 14);
                titleLbl.ForeColor = Color.White;
                titleLbl.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                titleLbl.Dock = DockStyle.None;
                titleLbl.AutoSize = true;
                titleLbl.MaximumSize = new Size(360, 77);
                titleLbl.Location = new Point(232, locationY);

                panel.Controls.Add(titleLbl);

                Label genreLbl = new Label();
                genreLbl.Text = info.Genre;
                genreLbl.Tag = info.AnimeUrl;
                genreLbl.Font = new Font("Microsoft Sans Serif", 8);
                genreLbl.ForeColor = Color.White;
                genreLbl.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                genreLbl.Dock = DockStyle.None;
                genreLbl.Size = new Size(378, 29);
                int genreLblLocationY = locationY + titleLbl.Height + 6;
                genreLbl.Location = new Point(232, genreLblLocationY);

                panel.Controls.Add(genreLbl);

                ctr++;
                locationY = locationY + 126;
            }
        }

        #endregion
    }
}
