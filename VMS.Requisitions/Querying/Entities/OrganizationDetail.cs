namespace VMS.Requisitions.Querying.Entities
{
    using System;

    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The OrganizationDetail.
    /// </summary>
    public partial class OrganizationDetail
    {
        // TODO: Create types
        public EngagementType[] GetEngagementTypes()
        {
            return new[] { EngagementType.Contract };
        }
    }
}
