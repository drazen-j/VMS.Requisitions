
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The ClientRegion interface.
    /// </summary>
    public interface IClientRegion
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        string Description { get; set; }
    }
}