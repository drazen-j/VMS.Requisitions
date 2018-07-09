
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The GeneralLedger interface.
    /// </summary>
    public interface IGeneralLedger
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