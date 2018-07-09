using System;
using System.Collections.Generic;
using System.Text;

namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The rate.
    /// </summary>
    public class Rate : IRate
    {
        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Gets or sets the rate period.
        /// </summary>
        public RatePeriod RatePeriod { get; set; }
    }
}
