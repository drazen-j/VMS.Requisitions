
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The CostCenter interface.
    /// </summary>
    public interface ICostCenter
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