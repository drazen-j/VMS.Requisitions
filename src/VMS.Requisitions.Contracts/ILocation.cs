
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The Location interface.
    /// </summary>
    public interface ILocation
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }
    }
}