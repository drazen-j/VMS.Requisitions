
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The expertise rating. EXPT_RTG_GRP JOIN EXPT_RTG (sp_get_ClientExpertiseRatings_a)
    /// </summary>
    public class ExpertiseRating : IExpertiseRating
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
    }
}
