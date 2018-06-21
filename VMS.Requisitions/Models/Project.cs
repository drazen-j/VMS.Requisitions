
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The project.
    /// </summary>
    public class Project : IProject
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
