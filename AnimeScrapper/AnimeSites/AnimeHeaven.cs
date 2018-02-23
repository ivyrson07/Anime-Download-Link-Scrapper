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
        #region ScrapeAnimeInformation

        public static Tuple<ScrapeResult, AnimeInformation> ScrapeAnimeInformation(string htmlContent)
        {
            try
            {
                LoadHtmlDocument(htmlContent);

                AnimeInformation info = new AnimeInformation();

                var elements = htmlDocument.DocumentNode.SelectNodes("//html//body//div[@class='notmain']//div[@class='maindark']//div[@class='infobox']//div[@class='infoboxc']//div[@class='infodesbox']");

                info.Description = elements.Select(x => x.SelectSingleNode("//div[@class='infodes2']")).First().InnerHtml;
                info.Status = elements.Select(x => x.SelectSingleNode("//div[@class='infodes2']")).Last().SelectNodes("//div[@class='textd']")[2].NextSibling.InnerHtml;
                info.EpisodeCount = Convert.ToInt32(htmlDocument.DocumentNode.SelectNodes("//html//body//div[@class='notmain']//div[@class='maindark']//div[@class='infobox']//div[@class='infoepboxmain']//div[@class='infoepbox']//a//div//div//div//div")[3].InnerHtml);
                info.YearReleased = Convert.ToInt32(elements.Select(x => x.SelectSingleNode("//div[@class='infodes2']")).Last().SelectNodes("//div[@class='textd']")[4].NextSibling.InnerHtml.Substring(0, 4));

                ScrapeManager.ScrapeResult.Message = "Successfully scrapped anime information";
                ScrapeManager.ScrapeResult.Success = true;
                return new Tuple<ScrapeResult, AnimeInformation>(ScrapeManager.ScrapeResult, info);
            }
            catch (Exception e)
            {
                ScrapeManager.ScrapeResult.Message = e.Message;
                ScrapeManager.ScrapeResult.Success = false;
                return new Tuple<ScrapeResult, AnimeInformation>(ScrapeManager.ScrapeResult, new AnimeInformation());
            }
        }

        #endregion

        #region ScrapeAnimeList

        public static Tuple<ScrapeResult, List<AnimeInformation>> ScrapeAnimeList(string htmlContent)
        {
            try
            {
                ClearAll();
                LoadHtmlDocument(htmlContent);

                List<AnimeInformation> info = new List<AnimeInformation>();

                var elements = htmlDocument.DocumentNode.SelectNodes("//html//body//div[@class='notmain']//div[@class='maindark']//div[@class='lisbox']//div[@class='conm']/a");

                foreach (var element in elements)
                {
                    titles.Add(element.InnerHtml);
                    animeUrls.Add(@"http://animeheaven.eu/" + element.Attributes["href"].Value);
                }

                elements = htmlDocument.DocumentNode.SelectNodes("//html//body//div[@class='notmain']//div[@class='maindark']//div[@class='lisbox']//div[@class='conm']/div");

                foreach (var element in elements)
                {
                    genres.Add(element.InnerHtml);
                }

                // This try block is for dubbed anime
                try
                {
                    elements = htmlDocument.DocumentNode.SelectNodes("//html//body//div[@class='notmain']//div[@class='maindark']//div[@class='lisbox']//div[@class='condm']/a");

                    foreach (var element in elements)
                    {
                        titles.Add(element.InnerHtml);
                        animeUrls.Add(@"http://animeheaven.eu/" + element.Attributes["href"].Value);
                    }

                    elements = htmlDocument.DocumentNode.SelectNodes("//html//body//div[@class='notmain']//div[@class='maindark']//div[@class='lisbox']//div[@class='condm']/div");

                    foreach (var element in elements)
                    {
                        genres.Add(element.InnerHtml);
                    }
                }
                catch (Exception er) { }

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

                for (int i = 0; i < elements.Count; i++)
                {
                    info.Add(new AnimeInformation
                    {
                        AnimeUrl = animeUrls[i],
                        CoverImageUrl = coverImageUrls[i],
                        Genre = genres[i],
                        Title = titles[i]
                    });
                }
                
                ScrapeManager.ScrapeResult.Message = "Successfully Scrapped Anime List";
                ScrapeManager.ScrapeResult.RecordCount = elements.Count;
                ScrapeManager.ScrapeResult.Success = true;
                return new Tuple<ScrapeResult, List<AnimeInformation>>(ScrapeManager.ScrapeResult, info);
            }
            catch (Exception e)
            {
                ScrapeManager.ScrapeResult.Message = e.Message;
                ScrapeManager.ScrapeResult.RecordCount = 0;
                ScrapeManager.ScrapeResult.Success = false;
                return new Tuple<ScrapeResult, List<AnimeInformation>>(ScrapeManager.ScrapeResult, new List<AnimeInformation>());
            }
        }

        #endregion
    }
}
