
namespace VMS.Requisitions.Contracts
{
    using System.Collections.Generic;

    /// <summary>
    /// The Budget interface.
    /// </summary>
    public interface IBudget
    {
        /// <summary>
        /// Gets or sets the budget lines.
        /// </summary>
        IList<IBudgetLine> BudgetLines { get; set; }

        /// <summary>
        /// Gets or sets the total labor.
        /// </summary>
        IMoney TotalLabor { get; set; }

        /// <summary>
        /// Gets or sets the total expense allowance.
        /// </summary>
        IMoney TotalExpenseAllowance { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        IMoney Total { get; set; }
    }
}