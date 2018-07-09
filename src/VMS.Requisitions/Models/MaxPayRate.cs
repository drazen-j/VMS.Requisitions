

namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The max pay rate.
    /// </summary>
    /// visible if OrganizationDetail.UsePayRateOnRequisition And RequisitonClass.UsePayRateOnRequisition
    public class MaxPayRate : IMaxPayRate
    {
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// Data mapping: Requisition.MaxPayRate
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Gets or sets the rate period.
        /// </summary>
        /// Data mapping: Requisition.MaxPayRatePeriodTypeId
        public MaxPayRatePeriodType RatePeriod { get; set; }
    }
}
