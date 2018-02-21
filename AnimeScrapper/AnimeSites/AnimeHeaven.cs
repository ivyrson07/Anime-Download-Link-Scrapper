using AnimeScrapper.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeScrapper.AnimeSites
{
    public class AnimeHeaven : Helper.ScrappingVariable
    {
        #region ScrapeAnimeList

        public static Tuple<ScrapeResult, List<AnimeInformation>> ScrapeAnimeList(string htmlContent)
        {
            LoadHtmlDocument(htmlContent);

            List<AnimeInformation> info = new List<AnimeInformation>();

            var elements = htmlDocument.DocumentNode.SelectNodes("//html//body//div[@class='notmain']//div[@class='maindark']//div[@class='lisbox']//div[@class='conm']/a");
            
            foreach(var element in elements)
            {
                titles.Add(element.InnerHtml);
                animeUrls.Add(@"http://animeheaven.eu/" + element.Attributes["href"].Value);
            }

            elements = htmlDocument.DocumentNode.SelectNodes("//html//body//div[@class='notmain']//div[@class='maindark']//div[@class='lisbox']//div[@class='condm']/a");

            foreach (var element in elements)
            {
                titles.Add(element.InnerHtml);
                animeUrls.Add(@"http://animeheaven.eu/" + element.Attributes["href"].Value);
            }

            elements = htmlDocument.DocumentNode.SelectNodes("//html//body//div[@class='notmain']//div[@class='maindark']//div[@class='lisbox']//div[@class='conm']/div");

            foreach(var element in elements)
            {
                genres.Add(element.InnerHtml);
            }

            elements = htmlDocument.DocumentNode.SelectNodes("//html//body//div[@class='notmain']//div[@class='maindark']//div[@class='lisbox']//div[@class='condm']/div");

            foreach (var element in elements)
            {
                genres.Add(element.InnerHtml);
            }

            elements = htmlDocument.DocumentNode.SelectNodes("//html//body//div[@class='notmain']//div[@class='maindark']//div[@class='lisbox']//div[@class='iep']//div[@class='ieppic']//a/img");
            List<string> dubbedList = new List<string>();

            foreach (var element in elements)
            {
                string imageUrl = @"http://animeheaven.eu/" + element.Attributes["src"].Value;

                if (!imageUrl.Contains("Dubbed"))
                {
                    coverImageUrls.Add(imageUrl);
                }
                else dubbedList.Add(imageUrl);
            }

            coverImageUrls.AddRange(dubbedList.AsEnumerable());

            string pauseHere = "";
            return new Tuple<ScrapeResult, List<AnimeInformation>>(ScrapeManager.ScrapeResult, new List<AnimeInformation>());
        }

        #endregion
    }
}
