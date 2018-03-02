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

        public static string SearchLink { get; set; }

        private static ScrapeResult _sr;

        public static ScrapeResult ScrapeResult
        {
            get
            {
                if (_sr == null)
                    _sr = new ScrapeResult();

                return _sr;
            }
        }

        public static string WatchLink { get; set; }

        #region CreateRequest

        public static void CreateRequest(string request)
        {
            Request = (HttpWebRequest)WebRequest.Create(request);
        }

        #endregion

        #region GetAnimeInformation

        public static AnimeInformation GetAnimeInformation(AnimeSite site, string htmlContent, string animeTitle = "", 
            string animeGenre = "", System.Drawing.Image animeCoverImage = null)
        {
            Tuple<ScrapeResult, AnimeInformation> result = null;

            switch (site)
            {
                case AnimeSite.AnimeHeaven:
                    result = AnimeHeaven.ScrapeAnimeInformation(htmlContent);
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

            if (result.Item1.Success)
            {
                result.Item2.CoverImage = animeCoverImage;
                result.Item2.Genre = animeGenre;
                result.Item2.Title = animeTitle;

                return result.Item2;
            }
            else return new AnimeInformation();
        }

        #endregion

        #region GetAnimeList

        public static List<AnimeInformation> GetAnimeList(AnimeSite site, string htmlContent)
        {
            Tuple<ScrapeResult, List<AnimeInformation>> result = null;

            switch (site)
            {
                case AnimeSite.AnimeHeaven:
                    result = AnimeHeaven.ScrapeAnimeList(htmlContent);
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

            if (result.Item1.Success)
            {
                return result.Item2;
            }
            else return new List<AnimeInformation>();
        }

        #endregion

        #region GetDownloadLinks

        public static List<string> GetDownloadLinks(AnimeSite site, List<string> htmlContents)
        {
            Tuple<ScrapeResult, List<string>> result = null;

            switch (site)
            {
                case AnimeSite.AnimeHeaven:
                    result = AnimeHeaven.ScrapeDownloadLinks(htmlContents);
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

            if (result.Item1.Success)
            {
                return result.Item2;
            }
            else return new List<string>();
        }

        #endregion

        #region InitializeScrapper

        public static void InitializeScrapper(AnimeSite site)
        {
            switch (site)
            {
                case AnimeSite.AnimeHeaven:
                    SearchLink = @"http://animeheaven.eu/search.php?q={0}";
                    WatchLink = @"http://animeheaven.eu/watch.php?a={0}&e={1}";
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
