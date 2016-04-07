namespace Capstone.Models
{
    /// <summary>
    /// Contains information that pertains to an organization.
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// The organization's unique identification number.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the organization.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The organization's email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The organization's phone number.
        /// </summary>
        public string Phone { get; set; }
        
        /// <summary>
        /// The organization's address.
        /// </summary>
        public string Address { get; set; }
    }
}