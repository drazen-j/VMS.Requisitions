
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The Question interface.
    /// </summary>
    public interface IQuestion
    {
        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        int SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the description text.
        /// </summary>
        string DescriptionText { get; set; }
    }
}