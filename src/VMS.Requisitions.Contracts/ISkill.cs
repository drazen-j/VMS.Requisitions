
namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The Skill interface.
    /// </summary>
    public interface ISkill
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        int SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the skill type.
        /// </summary>
        SkillType SkillType { get; set; }

        /// <summary>
        /// Gets or sets the expertise rating.
        /// </summary>
        IExpertiseRating ExpertiseRating { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        IDuration Duration { get; set; }
    }
}