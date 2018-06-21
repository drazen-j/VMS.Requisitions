
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The RequisitionClass interface.
    /// </summary>
    public interface IRequisitionClass
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the requisition class full name.
        /// </summary>
        string RequisitionClassFullName { get; set; }

        /// <summary>
        /// Gets or sets the maximum duration.
        /// </summary>
        string MaximumDuration { get; set; }
    }
}