
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The RateRange interface.
    /// </summary>
    public interface IRateRange
    {
        /// <summary>
        /// Gets or sets the rate from.
        /// </summary>
        decimal RateFrom { get; set; }

        /// <summary>
        /// Gets or sets the rate to.
        /// </summary>
        decimal RateTo { get; set; }

        /// <summary>
        /// Gets or sets the rate period.
        /// </summary>
        RatePeriod RatePeriod { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        Currency Currency { get; set; }
    }
}
