
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The Money interface.
    /// </summary>
    public interface IMoney
    {
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        Currency Currency { get; set; }
    }
}