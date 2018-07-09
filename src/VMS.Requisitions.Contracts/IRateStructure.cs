
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The RateStructure interface.
    /// </summary>
    public interface IRateStructure
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        string Code { get; set; }
        
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }
    }
}