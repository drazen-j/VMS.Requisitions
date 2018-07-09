
namespace VMS.Requisitions.Controllers
{
    using EFCoreDynamicQuerying;

    using VMS.Requisitions.Contracts;

    using Requisition = Querying.Entities.Requisition;

    /// <summary>
    /// The requisition query transformer.
    /// </summary>
    public static class RequisitionQueryTransformer
    {
        /// <summary>
        /// The transform.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Requisition"/>.
        /// </returns>
        public static Models.Requisition Transform(Requisition entity)
        {
            return new Models.Requisition
                       {
                           Id = entity.Id,
                           Description = entity.Description,
                           FormatType = (FormatType)entity.FormatTypeId,
                           IsTemplate = entity.IsTemplate.GetValueOrDefault(),
                           NumberOfOpenings = entity.NumberOfOpenings,
                           Title = entity.Title,
                           RequisitionStatus = (RequisitionStatus)entity.RequisitionStatusId.GetValueOrDefault()
                       };
        }
    }
}