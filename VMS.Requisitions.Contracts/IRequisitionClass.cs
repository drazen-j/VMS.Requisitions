
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The RequisitionClass interface.
    /// </summary>
    public interface IRequisitionClass
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the req class description.
        /// </summary>
        string ReqClassDescription { get; set; }

        /// <summary>
        /// Gets or sets the requisition class full name. - heavy to get
        /// </summary>
        string RequisitionClassFullName { get; set; }

        /// <summary>
        /// Gets or sets the maximum duration.
        /// </summary>
        string MaximumDuration { get; set; }

        /// <summary>
        /// Gets or sets the hourly low rate.
        /// </summary>
        IMoney HourlyLowRate { get; set; }


        /// <summary>
        /// Gets or sets the hourly high rate.
        /// </summary>
        IMoney HourlyHighRate { get; set; }

        /// <summary>
        /// Gets or sets the salary range low.  $76,000 USD Per Year
        /// </summary>
        IMoney SalaryLow { get; set; }

        /// <summary>
        /// Gets or sets the salary range high.
        /// </summary>
        IMoney SalaryHigh { get; set; }
    }
}