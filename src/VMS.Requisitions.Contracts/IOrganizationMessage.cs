
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The OrganizationMessage interface.
    /// </summary>
    public interface IOrganizationMessage
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        OrganizationMessageType Type { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        string Text { get; set; }
    }

}
