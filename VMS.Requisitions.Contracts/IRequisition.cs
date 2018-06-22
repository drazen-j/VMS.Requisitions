
namespace VMS.Requisitions.Contracts
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The Requisition interface.
    /// </summary>
    public interface IRequisition
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is template.
        /// </summary>
        bool IsTemplate { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the ext.
        /// </summary>
        string Ext { get; set; }

        /// <summary>
        /// Gets or sets the number of openings.
        /// </summary>
        int NumberOfOpenings { get; set; }

        /// <summary>
        /// Gets or sets the number of filled.
        /// </summary>
        int NumberOfFilled { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the requisition class.
        /// </summary>
        IRequisitionClass RequisitionClass { get; set; }

        /// <summary>
        /// Gets or sets the requisition status.
        /// </summary>
        RequisitionStatus RequisitionStatus { get; set; }

        /// <summary>
        /// Gets or sets the requisition citizen status.
        /// </summary>
        RequisitionCitizenStatus RequisitionCitizenStatus { get; set; }

        /// <summary>
        /// Gets or sets the open until.
        /// </summary>
        DateTime? OpenUntil { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        IDuration Duration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is for salaried contractors.
        /// </summary>
        bool IsForSalariedContractors { get; set; }

        /// <summary>
        /// Gets or sets the client internal number.
        /// </summary>
        string ClientInternalNumber { get; set; }

        /// <summary>
        /// Gets or sets the requisition priority.
        /// </summary>
        RequisitionPriority RequisitionPriority { get; set; }

        /// <summary>
        /// Gets or sets the maximum submittals by vendor per opening.
        /// </summary>
        int? MaximumSubmittalsByVendorPerOpening { get; set; }

        /// <summary>
        /// Gets or sets the custom fields.
        /// </summary>
        IList<ICustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or sets the engagement types.
        /// </summary>
        IList<EngagementType> EngagementTypes { get; set; }

        /// <summary>
        /// Gets or sets the short description.
        /// </summary>
        string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the characteristics.
        /// </summary>
        string Characteristics { get; set; }

        /// <summary>
        /// Gets or sets the alternate email.
        /// </summary>
        string AlternateEmail { get; set; }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        IList<IRequisitionContact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        ILocation Location { get; set; }

        /// <summary>
        /// Gets or sets the general ledger.
        /// </summary>
        IList<IGeneralLedger> GeneralLedger { get; set; }

        /// <summary>
        /// Gets or sets the cost center.
        /// </summary>
        IList<ICostCenter> CostCenter { get; set; }

        /// <summary>
        /// Gets or sets the project.
        /// </summary>
        IList<IProject> Project { get; set; }

        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        string Department { get; set; }

        /// <summary>
        /// Gets or sets the estimated expenses per opening.
        /// </summary>
        IMoney EstimatedExpensesPerOpening { get; set; }

        /// <summary>
        /// Gets or sets the rate structure.
        /// </summary>
        IRateStructure RateStructure { get; set; }

        /// <summary>
        /// Gets or sets the bill range from rate.
        /// </summary>
        IMoney BillRangeFromRate { get; set; }

        /// <summary>
        /// Gets or sets the bill range to rate.
        /// </summary>
        IMoney BillRangeToRate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether do not allow submission above max bill rate.
        /// </summary>
        bool DoNotAllowSubmissionAboveMaxBillRate { get; set; }

        /// <summary>
        /// Gets or sets the max pay rate.
        /// </summary>
        IMoney MaxPayRate { get; set; }

        /// <summary>
        /// Gets or sets the hours per day.
        /// </summary>
        decimal HoursPerDay { get; set; }

        /// <summary>
        /// Gets or sets the days per week.
        /// </summary>
        int DaysPerWeek { get; set; }

        /// <summary>
        /// Gets or sets the rate info text.
        /// </summary>
        string RateInfoText { get; set; }

        /// <summary>
        /// Gets or sets the current budget.
        /// </summary>
        IBudget CurrentBudget { get; set; }

        /// <summary>
        /// Gets or sets the skills.
        /// </summary>
        IList<ISkill> Skills { get; set; }

        /// <summary>
        /// Gets or sets the global skills.
        /// </summary>
        IList<ISkill> GlobalSkills { get; set; }

        /// <summary>
        /// Gets or sets the questions.
        /// </summary>
        IList<IQuestion> Questions { get; set; }

        /// <summary>
        /// Gets or sets the compliance groups.
        /// </summary>
        IList<IComplianceGroup> ComplianceGroups { get; set; }
    }
}