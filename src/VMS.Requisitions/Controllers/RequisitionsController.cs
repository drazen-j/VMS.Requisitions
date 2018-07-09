using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VMS.Requisitions.Controllers
{
    using ArgSentry;

    using EFCoreDynamicQuerying.AspNet;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    using VMS.Requisitions.Services;
    using VMS.Shared.Logging;

    /// <summary>
    /// The requisitions controller.
    /// </summary>
    [Route("/")]
    [DynamicQueryApiRoot(configPath: "API_ROOT_URL")]
    public class RequisitionsController : Controller
    {
        /// <summary>
        /// The API root URL configuration key.
        /// </summary>
        private const string ApiRootUrlKey = "API_ROOT_URL";

        /// <summary>
        /// The logger.
        /// </summary>
        private readonly ILogger<RequisitionsController> logger;

        /// <summary>
        /// The requisition service.
        /// </summary>
        private readonly IRequisitionService requisitionService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequisitionsController"/> class.
        /// </summary>
        /// <param name="serviceProvider">
        /// The service provider.
        /// </param>
        public RequisitionsController(IServiceProvider serviceProvider)
        {
            Prevent.NullObject(serviceProvider, nameof(serviceProvider));

            this.logger = serviceProvider.GetRequiredService<ILogger<RequisitionsController>>();
            this.requisitionService = serviceProvider.GetRequiredService<IRequisitionService>();
        }



        /// <summary>
        /// Gets a requisition.
        /// </summary>
        /// <param name="id">
        /// The requisition id
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        [HttpGet("/{id:int}")]
        public IActionResult Get(int id)
        {
            this.logger.LogInformation(
                LoggingEvents.GET_REQUEST_RECEIVED,
                $"Requisitions GET request received: {id}");


            var result = this.UseDynamicQuery<Querying.Entities.Requisition>().ApplyToAndGetSingleTransformedResult(
                this.requisitionService.QueryRequisitions().Where(r => r.Id == id),
                RequisitionQueryTransformer.Transform);

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        /// <summary>
        /// Gets requisitions.
        /// </summary>
        /// <returns>
        /// The <see cref="IActionResult"/>
        /// </returns>
        [HttpGet]
        public IActionResult Get()
        {
            this.logger.LogInformation(LoggingEvents.GET_REQUEST_RECEIVED, "Requisitions GET request received");

            var result = this.UseDynamicQuery<Querying.Entities.Requisition>()
                .ApplyToAndGetTransformedPagedQueryResult(
                    this.requisitionService.QueryRequisitions(),
                    RequisitionQueryTransformer.Transform);

            return this.Ok(result);
        }
    }
}
