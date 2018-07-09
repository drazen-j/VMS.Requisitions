
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The location.
    /// </summary>
    public class Location : ILocation
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// DataMapping: Location.Id
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// DataMapping: Location.Name
        public string Name { get; set; }
    }
}
