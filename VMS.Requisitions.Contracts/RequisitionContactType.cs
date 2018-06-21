
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The requisition contact type. XREF_REQ_ROLE_TP
    /// </summary>
    public enum RequisitionContactType
    {
        /// <summary>
        /// The owner.
        /// </summary>
        Owner = 1,

        /// <summary>
        /// The reports to.
        /// </summary>
        ReportsTo = 2,

        /// <summary>
        /// The main contact. Client Contact
        /// </summary>
        MainContact = 3,
    }
}
