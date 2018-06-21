
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The requisition contact.
    /// </summary>
    public class RequisitionContact : IRequisitionContact
    {
        /// <summary>
        /// Gets or sets the requisition contact type.
        /// </summary>
        public RequisitionContactType RequisitionContactType { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the middle initial.
        /// </summary>
        public string MiddleInitial { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

    }
}
