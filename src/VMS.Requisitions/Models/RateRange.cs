
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The rate range.
    /// </summary>
    public class RateRange : IRateRange
    {
        /// <summary>
        /// Gets or sets the rate from.
        /// </summary>
        /// DataMapping: Requisition.BillFromRate
        public decimal RateFrom { get; set; }

        /// <summary>
        /// Gets or sets the rate to.
        /// </summary>
        /// DataMapping: Requisition.BillToRate
        public decimal RateTo { get; set; }

        /// <summary>
        /// Gets or sets the rate period.
        /// </summary>
        /// DataMapping: Requisition.NotToExceedRatePeriod
        public RatePeriod RatePeriod { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        public Currency Currency { get; set; }
    }
}
