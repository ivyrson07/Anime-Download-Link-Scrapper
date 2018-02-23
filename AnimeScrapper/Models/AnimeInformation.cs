using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeScrapper.Models
{
    public class AnimeInformation
    {
        public string AnimeUrl { get; set; }

        public System.Drawing.Image CoverImage { get; set; }

        public string CoverImageUrl { get; set; }

        public string Description { get; set; }

        public int EpisodeCount { get; set; }

        public string Genre { get; set; }

        public string Status { get; set; }

        public string Title { get; set; }

        public int YearReleased { get; set; }
    }
}
