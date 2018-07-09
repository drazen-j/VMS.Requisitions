
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The compliance item.
    /// </summary>
    public class ComplianceItem : IComplianceItem
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
        /// Gets or sets the owner. Client, Vendor
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets the due. Optional/Before Engagement...
        /// </summary>
        public ComplianceDue Due { get; set; }
    }
}
