
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The Duration interface.
    /// </summary>
    public interface IDuration
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the duration type.
        /// </summary>
        DurationType DurationType { get; set; }
    }
}