
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The cost center.
    /// </summary>
    public class CostCenter : ICostCenter
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
    }
}
