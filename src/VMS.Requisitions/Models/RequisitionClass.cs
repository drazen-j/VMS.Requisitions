
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
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the requisition class full name.
        /// </summary>
        /// Try to avoid
        public string RequisitionClassFullName { get; set; }

        /// <summary>
        /// Gets or sets the maximum duration. Maximum Duration for this Requisition Class: 30 Days
        /// </summary>
        /// Data Mapping: RequisitionClass.MaximumDurationValue, RequisitionClass.MaximumDurationTypeId
        public IDuration MaximumDuration { get; set; }

        /// <summary>
        /// Gets or sets the hourly low rate.  Hourly low bill rate $98.32 USD 
        /// </summary>
        /// Data Mapping: Amount -> RequisitionClass.HourlyLowRateValue, Currency -> LocalizationOrganization.CurrencySymbolId\
        /// Only for Format Type = 1 (Long Form); Client Only
        public IMoney HourlyLowRate { get; set; }


        /// <summary>
        /// Gets or sets the hourly high rate. Hourly high bill rate $98.32 USD
        /// </summary>
        /// Data Mapping: Amount -> RequisitionClass.HourlyHighRateValue, Currency -> LocalizationOrganization.CurrencySymbolId
        /// Only for Format Type = 1 (Long Form); Client Only
        public IMoney HourlyHighRate { get; set; }

        /// <summary>
        /// Gets or sets the salary range low.  $76,000 USD Per Year
        /// </summary>
        /// Data Mapping: Amount -> RequisitionClass.SalaryLowValue,  Currency -> LocalizationOrganization.CurrencySymbolId; Client Only
        public IMoney SalaryLow { get; set; }

        /// <summary>
        /// Gets or sets the salary range high.
        /// </summary>
        /// Data Mapping: Amount -> RequisitionClass.SalaryHighValue, Currency -> LocalizationOrganization.CurrencySymbolId; Client Only
        public IMoney SalaryHigh { get; set; }
    }
}

