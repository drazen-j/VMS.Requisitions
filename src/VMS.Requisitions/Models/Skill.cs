
namespace VMS.Requisitions.Models
{
    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The skill.
    /// </summary>
    public class Skill : ISkill
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        public int SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the skill type. values: Desired, Highly desired, Nice to have, Not Required, Required
        /// </summary>
        public SkillType SkillType { get; set; }

        /// <summary>
        /// Gets or sets the expertise rating. region customized
        /// </summary>
        public IExpertiseRating ExpertiseRating { get; set; }

        /// <summary>
        /// Gets or sets the duration. amount + period
        /// </summary>
        public IDuration Duration { get; set; }

    }
}
