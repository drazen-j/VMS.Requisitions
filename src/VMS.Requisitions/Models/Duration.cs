
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The duration.
    /// </summary>
    public class Duration : IDuration
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the duration type.
        /// </summary>
        public DurationType DurationType { get; set; }
    }
}
