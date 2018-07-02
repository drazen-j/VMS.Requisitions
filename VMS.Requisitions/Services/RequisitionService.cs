
namespace VMS.Requisitions.Services
{
    using System;
    using System.Linq;

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    using VMS.Requisitions.Querying;
    using VMS.Requisitions.Querying.Entities;

    /// <summary>
    /// The requisition service.
    /// </summary>
    public class RequisitionService : IRequisitionService
    {
        /// <summary>
        /// The service provider.
        /// </summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        /// The logger.
        /// </summary>
        private readonly ILogger<RequisitionService> logger;

        /// <summary>
        /// The query requisitionss.
        /// </summary>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public IQueryable<Requisition> QueryRequisitions()
        {
            //var user = this.GetUserInfo();

            var parentOrganizationId = 1987;

            var queryingContext = this.serviceProvider.GetRequiredService<IQueryingContext>();
            return queryingContext.Requisitions.Where(r => r.Organization.ParentOrganizationId == parentOrganizationId);
        }
    }
}
