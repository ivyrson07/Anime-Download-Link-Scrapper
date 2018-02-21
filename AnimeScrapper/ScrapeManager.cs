using AnimeScrapper.AnimeSites;
using AnimeScrapper.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace AnimeScrapper
{
    public enum AnimeSite
    {
        AnimeHeaven, AnimeMobile, ChiaAnime, GogoAnime
    }

    public class ScrapeManager
    {
        public static AnimeInformation AnimeInformation { get; set; }

        private static HttpWebRequest Request { get; set; }

        private static HttpWebResponse Response
        {
            get
            {
                return (HttpWebResponse)Request.GetResponse();
            }
        }

        public static string ResponseInHtmlFormat
        {
            get
            {
                return new StreamReader(Response.GetResponseStream()).ReadToEnd();
            }
        }

        public static Stream ResponseInMediaFileFormat
        {
            get
            {
                return Response.GetResponseStream();
            }
        }

        public static string RestfulSearch { get; set; }

        public static string RestfulWatch { get; set; }

        public static ScrapeResult ScrapeResult { get; set; }

        #region CreateRequest

        public static void CreateRequest(string request)
        {
            Request = (HttpWebRequest)WebRequest.Create(request);
        }

        #endregion

        #region GetAnimeList

        public static void GetAnimeList(AnimeSite site, string htmlContent)
        {
            switch (site)
            {
                case AnimeSite.AnimeHeaven:
                    AnimeHeaven.ScrapeAnimeList(htmlContent);
                    break;

                case AnimeSite.AnimeMobile:
                    break;

                case AnimeSite.ChiaAnime:
                    break;

                case AnimeSite.GogoAnime:
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region InitializeScrapper

        public static void InitializeScrapper(AnimeSite site)
        {
            switch (site)
            {
                case AnimeSite.AnimeHeaven:
                    RestfulSearch = @"http://animeheaven.eu/search.php?q={0}";
                    RestfulWatch = @"http://animeheaven.eu/watch.php?a={0}&e={1}";
                    break;

                case AnimeSite.AnimeMobile:
                    break;

                case AnimeSite.ChiaAnime:
                    break;

                case AnimeSite.GogoAnime:
                    break;

                default:
                    break;
            }
        }

        #endregion
    }
}
