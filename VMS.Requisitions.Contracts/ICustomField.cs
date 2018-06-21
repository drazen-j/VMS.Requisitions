
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The CustomField interface.
    /// </summary>
    public interface ICustomField
    {
        /// <summary>
        /// Gets or sets the application area.
        /// </summary>
        ApplicationArea ApplicationArea { get; set; }

        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        int SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        string Label { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        string Text { get; set; }
    }
}