namespace Capstone.Models
{
    /// <summary>
    /// Contains information for an image with clickable regions.
    /// </summary>
    public class ImageMapClass
    {
        /// <summary>
        /// The image map's unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The device which the image map is associated with.
        /// </summary>
        public int DeviceId { get; set; }

        /// <summary>
        /// The name of the image file.
        /// </summary>
        public string FileName { get; set; }

        // TODO: Figure out how we are going to store the coordinates.
    }
}