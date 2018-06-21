
namespace VMS.Requisitions.Models
{
    using System.Collections.Generic;

    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The compliance group.
    /// </summary>
    public class ComplianceGroup : IComplianceGroup
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is global.
        /// </summary>
        public bool IsGlobal { get; set; }

        /// <summary>
        /// Gets or sets the compliance items.
        /// </summary>
        public List<IComplianceItem> ComplianceItems { get; set; }
    }
}
