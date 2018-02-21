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

        #region LoadHtmlDocument

        protected static void LoadHtmlDocument(string htmlContent)
        {
            htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(htmlContent);
        }

        #endregion
    }
}
