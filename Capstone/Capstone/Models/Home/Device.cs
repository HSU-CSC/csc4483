namespace Capstone.Models
{
    /// <summary>
    /// Contains information that pertains to a device.
    /// </summary>
    public class Device
    {
        /// <summary>
        /// The device's unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The id of the organization the device belongs to.
        /// </summary>
        public int OrganizationId { get; set; }

        /// <summary>
        /// The MAC Address of the device.
        /// </summary>
        public string MacAddress { get; set; }

        /// <summary>
        /// The physical location of the device.
        /// </summary>
        public string Location { get; set; }
    }
}