using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class Point
    {
        /// <summary>
        /// The coordinate's unique id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The id of the image map the coordinate belongs to.
        /// </summary>
        public int ImageMapId { get; set; }
    }
}