
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The ComplianceItem interface.
    /// </summary>
    public interface IComplianceItem
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
        /// Gets or sets the owner.
        /// </summary>
        string Owner { get; set; }

        /// <summary>
        /// Gets or sets the due.
        /// </summary>
        ComplianceDue Due { get; set; }
    }
}