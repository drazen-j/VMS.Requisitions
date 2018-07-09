
namespace VMS.Requisitions.Contracts
{
    using System.Collections.Generic;

    /// <summary>
    /// The ComplianceGroup interface.
    /// </summary>
    public interface IComplianceGroup
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is global.
        /// </summary>
        bool IsGlobal { get; set; }

        /// <summary>
        /// Gets or sets the compliance items.
        /// </summary>
        List<IComplianceItem> ComplianceItems { get; set; }
    }
}