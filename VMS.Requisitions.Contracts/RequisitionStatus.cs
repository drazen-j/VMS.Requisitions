
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The requisition status.
    /// </summary>
    public enum RequisitionStatus
    {
        /// <summary>
        /// The draft.
        /// </summary>
        Draft = 1,

        /// <summary>
        /// The pending approval.
        /// </summary>
        PendingApproval = 2,

        /// <summary>
        /// The not approved.
        /// </summary>
        NotApproved = 3,

        /// <summary>
        /// The open.
        /// </summary>
        Open = 4,

        /// <summary>
        /// The interviews occurring.
        /// </summary>
        InterviewsOccurring = 5,

        /// <summary>
        /// The filled.
        /// </summary>
        Filled = 6,

        /// <summary>
        /// The closed cancelled.
        /// </summary>
        ClosedCancelled = 8,

        /// <summary>
        /// The on hold.
        /// </summary>
        OnHold = 9,

        /// <summary>
        /// The pending buy side approval.
        /// </summary>
        PendingBuySideApproval = 10,

        /// <summary>
        /// The buy side budget not approved.
        /// </summary>
        BuySideBudgetNotApproved = 11
    }
}
