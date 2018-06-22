
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The budget line.
    /// </summary>
    public class BudgetLine : IBudgetLine
    {
        /// <summary>
        /// Gets or sets the billing rule.
        /// </summary>
        public IBillingRule BillingRule { get; set; }

        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        public short SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the rate. '$98.32 USD'
        /// </summary>
        public IMoney Rate { get; set; }

        /// <summary>
        /// Gets or sets the number of openings. From requisition.
        /// </summary>
        public int NumberOfOpenings { get; set; }

        /// <summary>
        /// Gets or sets the work hours per week.
        /// </summary>
        public decimal WorkHoursPerWeek { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        public decimal Duration { get; set; }

        /// <summary>
        /// Gets or sets the estimated budget. '$82588.80 USD'
        /// </summary>
        public IMoney EstimatedBudget { get; set; }

        /// <summary>
        /// Gets or sets the estimated hours.
        /// </summary>
        public decimal EstimatedHours { get; set; }
    }
}
