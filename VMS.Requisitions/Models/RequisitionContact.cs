
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
        /// DataMapping: RequisitionsContact.ContactRoleId
        public RequisitionContactType RequisitionContactType { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// DataMapping: RequisitionsContact.FirstName
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the middle initial.
        /// </summary>
        /// DataMapping: RequisitionsContact.MiddleInitial
        public string MiddleInitial { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// DataMapping: RequisitionsContact.LastName
        public string LastName { get; set; }

    }
}
