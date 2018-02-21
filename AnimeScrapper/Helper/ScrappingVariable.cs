using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeScrapper.Helper
{
    public class ScrappingVariable
    {
        protected static HtmlDocument htmlDocument;
        protected static List<string> animeUrls = new List<string>();
        protected static List<string> coverImageUrls = new List<string>();
        protected static List<string> genres = new List<string>();
        protected static List<string> titles = new List<string>();

        #region ClearAll

        protected static void ClearAll()
        {
            htmlDocument = new HtmlDocument();
            animeUrls = new List<string>();
            coverImageUrls = new List<string>();
            genres = new List<string>();
            titles = new List<string>();
        }

        #endregion

        #region LoadHtmlDocument

        protected static void LoadHtmlDocument(string htmlContent)
        {
            htmlDocument.LoadHtml(htmlContent);
        }

        #endregion
    }
}
