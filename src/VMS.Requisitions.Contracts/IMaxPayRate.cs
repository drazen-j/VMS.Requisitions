﻿
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The Rate interface.
    /// </summary>
    public interface IMaxPayRate
    {
        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        Currency Currency { get; set; }

        /// <summary>
        /// Gets or sets the rate period.
        /// </summary>
        MaxPayRatePeriodType RatePeriod { get; set; }
    }
}
