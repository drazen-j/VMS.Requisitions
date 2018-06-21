
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The requisition class.
    /// </summary>
    public class RequisitionClass : IRequisitionClass
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the requisition class full name.
        /// </summary>
        public string RequisitionClassFullName { get; set; }

        /// <summary>
        /// Gets or sets the maximum duration. Maximum Duration for this Requisition Class: 30 Days
        /// </summary>
        public string MaximumDuration { get; set; }

    }
}
