
namespace VMS.Requisitions.Services
{
    using System.Linq;

    /// <summary>
    /// The RequisitionService interface.
    /// </summary>
    public interface IRequisitionService
    {
        /// <summary>
        /// Queries the requisitions.
        /// </summary>
        /// <returns>
        /// The <see cref="IQueryable{GeneralLedger}"/>.
        /// </returns>
        IQueryable<Querying.Entities.Requisition> QueryRequisitions();
    }
}
