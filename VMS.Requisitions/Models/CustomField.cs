
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The custom field.
    /// </summary>
    public class CustomField : ICustomField
    {
        /// <summary>
        /// Gets or sets the application area.
        /// </summary>
        public ApplicationArea ApplicationArea { get; set; }

        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        public int SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string Text { get; set; }
    }
}
