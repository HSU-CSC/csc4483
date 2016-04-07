namespace Capstone.Models.Home
{
    public class ImageMap
    {
        /// <summary>
        /// The image map id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The id for the device the image map is associated with.
        /// </summary>
        public int DeviceId { get; set; }

        /// <summary>
        /// The file name of the image.
        /// </summary>
        public string ImageFile { get; set; }
    }
}