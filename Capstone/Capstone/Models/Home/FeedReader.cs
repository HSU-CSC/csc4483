using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml.Linq;

namespace Capstone.Models.Home
{
    public class FeedReader
    {
        private static string _blogURL = "http://www.hsu.edu/news/index.rss";
       // private static string _blogURL = Url;

    public static IEnumerable<FeedData> GetRssFeed()
        {
            XDocument feedXml = XDocument.Load(_blogURL);
            var RssFeeds = from i in feedXml.Descendants("item")
                        select new FeedData
                        {
                            Title = i.Element("title").Value,
                            Link = i.Element("link").Value,
                            PublishDate = i.Element("pubDate").Value,
                            Description = Regex.Match(i.Element("description").Value, @"^.{1,180}\b(?<!\s)").Value
                            
                        };
            return RssFeeds;
        }
         
    }

}
