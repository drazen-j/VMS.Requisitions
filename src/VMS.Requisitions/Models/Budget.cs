
namespace VMS.Requisitions.Models
{
    using System.Collections.Generic;

    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The budget.
    /// </summary>
    public class Budget : IBudget
    {
        /// <summary>
        /// Gets or sets the budget lines.
        /// </summary>
        public IList<IBudgetLine> BudgetLines { get; set; }

        /// <summary>
        /// Gets or sets the total labor. '$0.00 USD'
        /// </summary>
        /// Data Mapping: Sum(BudgetLine.EstimatedBudget)
        public IMoney TotalLabor { get; set; }

        /// <summary>
        /// Gets or sets the total expense allowance. '$0.00 USD'
        /// </summary>
        /// Data Mapping: RequisitionFinancialDetail.EstimatedExpenses
        public IMoney TotalExpenseAllowance { get; set; }

        /// <summary>
        /// Gets or sets the total. '$0.00 USD'
        /// </summary>
        /// DataMapping: TotalLabor + TotalExpenseAllowance
        public IMoney Total { get; set; }
    }
}
