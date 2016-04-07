using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models.Home
{
    public class ImageMapRegion
    {
        /// <summary>
        /// The unique id for the region.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The id of the image map the region is associated with.
        /// </summary>
        public int ImageMapId { get; set; }

        /// <summary>
        /// The X coordiate of the top-left point.
        /// </summary>
        public int TopLeftX { get; set; }

        /// <summary>
        /// The Y coordinate of the top-left point.
        /// </summary>
        public int TopLeftY { get; set; }

        /// <summary>
        /// The X coordiate of the bottom-right point.
        /// </summary>
        public int BottomRightX { get; set; }

        /// <summary>
        /// The Y coordiate of the bottom-right point.
        /// </summary>
        public int BottomRightY { get; set; }

        /// <summary>
        /// The link to where the region goes when clicked.
        /// </summary>
        public string PostbackURL { get; set; }
    }
}