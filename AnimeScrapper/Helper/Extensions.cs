using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnimeScrapper.Helper
{
    public static class Extensions
    {
        #region ContainsOtherEpisodeInput

        public static bool ContainsOtherEpisodeInput(this string input)
        {
            return Regex.Matches(input, @"[0-9\-\,]").Count != input.Count();
        }

        #endregion

        #region ExceededMaxEpisode

        public static bool ExceededMaxEpisode(this string input, int maxEpisode)
        {
            try
            {
                return
                    input.Split(new char[2] { ',', '-' })
                        .Select(x => x.ToInt() > maxEpisode)
                        .Contains(true);
            }
            catch (OverflowException e)
            {
                return true;
            }
        }

        #endregion

        #region FormatString

        public static string FormatString(this string input, string keyword)
        {
            return string.Format(input, keyword);
        }

        public static string FormatString(this string input, string anime, int episode)
        {
            return string.Format(input, anime, episode);
        }

        #endregion

        #region HasError

        private static bool HasError(this string input, int maxEpisode = 0)
        {
            return
                input.IsNullEmptyOrWhiteSpace() ||
                input.ContainsOtherEpisodeInput() ||
                input.HasInvalidBaseChar() ||
                input.HasInvalidLastChar() ||
                input.HasConsistentChar() ||
                input.ExceededMaxEpisode(maxEpisode);
        }

        #endregion

        #region HasConsistentChar

        public static bool HasConsistentChar(this string input)
        {
            return
                input.Contains("--") ||
                input.Contains(",,") ||
                input.Contains("-,") ||
                input.Contains(",-");
        }

        #endregion

        #region HasInvalidBaseChar

        public static bool HasInvalidBaseChar(this string input)
        {
            return
                input[0] == '0' ||
                input[0] == '-' ||
                input[0] == ',';
        }

        #endregion

        #region HasInvalidLastChar

        public static bool HasInvalidLastChar(this string input)
        {
            return
                input[input.Length - 1] == '-' ||
                input[input.Length - 1] == ',';
        }

        #endregion

        #region IsNullEmptyOrWhiteSpace

        public static bool IsNullEmptyOrWhiteSpace(this string input)
        {
            return
                String.IsNullOrEmpty(input) ||
                String.IsNullOrWhiteSpace(input);
        }

        #endregion

        #region ToEpisodeList

        public static int?[] ToEpisodeList(this string input, int maxEpisode = 0)
        {
            string fInput = input.Replace(" ", "").ToUpper();
            bool error = fInput.HasError(maxEpisode);

            if (error)
                return null;
            else
            {
                string[] initStr = fInput.Split(',');
                List<int> epList = new List<int>();

                foreach (string iStr in initStr)
                {
                    if (iStr.Contains("-"))
                    {
                        string[] rangeStr = iStr.Split('-');

                        if (rangeStr[0].ToInt() == 0)
                            break;
                        else
                            for (int i = rangeStr[0].ToInt(); i <= rangeStr[1].ToInt(); i++)
                                epList.Add(i);
                    }
                    else epList.Add(iStr.ToInt());
                }

                return epList.Cast<int?>().Distinct().ToArray();
            }
        }

        #endregion

        #region ToEpisodeText

        public static string ToEpisodeText(this int?[] episodeList)
        {
            bool fromConsecutive = false;
            string text = "";
            int ep = 0;

            foreach (int episode in episodeList.OrderBy(x => x))
            {
                if (ep == 0)
                    text = "- Episode " + episode;
                else if (ep + 1 == episode)
                {
                    fromConsecutive = true;

                    if (episode == episodeList.Last())
                    {
                        text = text + " to Episode " + episode;
                        break;
                    }
                    else
                    {
                        ep = episode;
                        continue;
                    }
                }
                else
                {
                    if (fromConsecutive)
                        text = text + " to Episode " + ep + "\n- Episode " + episode;
                    else
                        text = text + "\n- Episode " + episode;

                    fromConsecutive = false;
                }

                ep = episode;
            }

            return text;
        }

        #endregion

        #region ToHtmlContents

        public static List<string> ToHtmlContents(this List<string> watchLinks)
        {
            List<string> htmlContents = new List<string>();
            //GeckoWebBrowser b = new GeckoWebBrowser();

            //foreach (string link in watchLinks)
            //{
            //    ScrapeManager.CreateRequest(link);
            //    b.LoadHtml(ScrapeManager.ResponseInHtmlFormat);
            //    GeckoDocument d = b.Document;
            //}

            return htmlContents;
        }

        #endregion

        #region ToInt

        public static int ToInt(this string input)
        {
            return Convert.ToInt32(input);
        }

        #endregion

        #region ToWatchLinks

        public static List<string> ToWatchLinks(this int[] episodes, string anime)
        {
            List<string> links = new List<string>();

            foreach (int episode in episodes)
                links.Add(ScrapeManager.WatchLink.FormatString(anime, episode));

            return links;
        }

        #endregion
    }
}
