
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The BillingRule interface.
    /// </summary>
    public interface IBillingRule
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }
    }
}
