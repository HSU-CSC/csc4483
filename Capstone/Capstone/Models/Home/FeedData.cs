using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models.Home
{
    public class FeedData
    {   //<summary>
        //Id number for the news feed
        //</summary>
        public int Id { get; set; }
        //<summary>
        //URL pointing to the feed's XML data
        //</summary>
        public string FeedUrl { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string PublishDate { get; set; }
        public string Description { get; set; }
    }
}