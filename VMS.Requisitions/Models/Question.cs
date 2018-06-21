
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The question.
    /// </summary>
    public class Question : IQuestion
    {
        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        public int SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the description text.
        /// </summary>
        public string DescriptionText { get; set; }

    }
}
