
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The client region.
    /// </summary>
    /// Data Mapping: Organization
    public class ClientRegion : IClientRegion
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// Data Mapping: RegionDescription
        public string Description { get; set; }

    }
}
