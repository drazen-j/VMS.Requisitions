
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The BudgetLine interface.
    /// </summary>
    public interface IBudgetLine
    {
        /// <summary>
        /// Gets or sets the billing rule.
        /// </summary>
        IBillingRule BillingRule { get; set; }

        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        short SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        IMoney Rate { get; set; }

        /// <summary>
        /// Gets or sets the number of openings.
        /// </summary>
        int NumberOfOpenings { get; set; }

        /// <summary>
        /// Gets or sets the work hours per week.
        /// </summary>
        decimal WorkHoursPerWeek { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        decimal Duration { get; set; }

        /// <summary>
        /// Gets or sets the estimated budget.
        /// </summary>
        IMoney EstimatedBudget { get; set; }

        /// <summary>
        /// Gets or sets the estimated hours.
        /// </summary>
        decimal EstimatedHours { get; set; }
    }
}