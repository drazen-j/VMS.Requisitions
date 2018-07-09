
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The Project interface.
    /// </summary>
    public interface IProject
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