
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The requisition class.
    /// </summary>
    public class RequisitionClass : IRequisitionClass
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string ReqClassDescription { get; set; }

        /// <summary>
        /// Gets or sets the requisition class full name.
        /// </summary>
        public string RequisitionClassFullName { get; set; }

        /// <summary>
        /// Gets or sets the maximum duration. Maximum Duration for this Requisition Class: 30 Days
        /// </summary>
        public string MaximumDuration { get; set; }

        /// <summary>
        /// Gets or sets the hourly low rate.  Hourly low bill rate $98.32 USD - From ReqClass
        /// </summary>
        public IMoney HourlyLowRate { get; set; }


        /// <summary>
        /// Gets or sets the hourly high rate. Hourly high bill rate $98.32 USD - From ReqClass
        /// </summary>
        public IMoney HourlyHighRate { get; set; }

        /// <summary>
        /// Gets or sets the salary range low.  $76,000 USD Per Year
        /// </summary>
        public IMoney SalaryLow { get; set; }

        /// <summary>
        /// Gets or sets the salary range high.
        /// </summary>
        public IMoney SalaryHigh { get; set; }
    }
}
