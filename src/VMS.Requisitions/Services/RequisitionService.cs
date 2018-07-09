
namespace VMS.Requisitions.Services
{
    using System;
    using System.Linq;

    using ArgSentry;

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
        /// Initializes a new instance of the <see cref="RequisitionService"/> class.
        /// </summary>
        /// <param name="serviceProvider">
        /// The service provider.
        /// </param>
        public RequisitionService(IServiceProvider serviceProvider)
        {
            Prevent.NullObject(serviceProvider, nameof(serviceProvider));
            this.serviceProvider = serviceProvider;
            this.logger = serviceProvider.GetRequiredService<ILogger<RequisitionService>>();
        }




        /// <summary>
        /// The query requisitionss.
        /// </summary>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public IQueryable<Requisition> QueryRequisitions()
        {
            //var user = this.GetUserInfo();

            var parentOrganizationId = 362;

            var queryingContext = this.serviceProvider.GetRequiredService<IQueryingContext>();
            return queryingContext.Requisitions.Where(r => r.Organization.ParentOrganizationId == parentOrganizationId);
        }
    }
}
