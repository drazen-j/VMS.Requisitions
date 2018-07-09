
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
        /// DataMapping: CustomFields.EntityTypeId
        public ApplicationArea ApplicationArea { get; set; }

        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        /// DataMapping: CustomFields.SequenceNumber
        public int SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// DataMapping: CustomFields.Label
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// DataMapping: CustomValues.ValueText or CustomFieldListItems.ListItemText
        public string Text { get; set; }
    }
}
