
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The RequisitionContact interface.
    /// </summary>
    public interface IRequisitionContact
    {
        /// <summary>
        /// Gets or sets the requisition contact type.
        /// </summary>
        RequisitionContactType RequisitionContactType { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the middle initial.
        /// </summary>
        string MiddleInitial { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        string LastName { get; set; }
    }
}