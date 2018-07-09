
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The requisition citizen status.
    /// </summary>
    public enum RequisitionCitizenStatus
    {
        /// <summary>
        /// The us citizen.
        /// </summary>
        UsCitizen = 1,

        /// <summary>
        /// The authorized us worker.
        /// </summary>
        AuthorizedUsWorker = 2,

        /// <summary>
        /// The open.
        /// </summary>
        Open = 3,

        /// <summary>
        /// The authorized canadian worker.
        /// </summary>
        AuthorizedCanadiannWorker = 4,

        /// <summary>
        /// The canadian citizen.
        /// </summary>
        CanadianCitizen = 5,

        /// <summary>
        /// The landed immigrant.
        /// </summary>
        LandedImmigrant = 6
    }
}
