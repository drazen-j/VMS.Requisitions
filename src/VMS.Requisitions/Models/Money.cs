
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The money.
    /// </summary>
    public class Money : IMoney
    {
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// Data Mapping: LocalizationOrganization.CurrencySymbolId
        public Currency Currency { get; set; }
    }
}
