
namespace VMS.Requisitions.Models
{
    using System;
    using System.Collections.Generic;

    using VMS.Requisitions.Contracts;

    /// <summary>
    /// The requisition.
    /// </summary>
    public class Requisition : IRequisition
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is template.
        /// </summary>
        public bool IsTemplate { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the ext. only 1 record in db has the value!?
        /// </summary>
        public string Ext { get; set; }

        /// <summary>
        /// Gets or sets the number of openings.
        /// </summary>
        public int NumberOfOpenings { get; set; }

        /// <summary>
        /// Gets or sets the number of filled.
        /// </summary>
        public int NumberOfFilled { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the requisition class.
        /// </summary>
        public IRequisitionClass RequisitionClass { get; set; }

        /// <summary>
        /// Gets or sets the requisition status.
        /// </summary>
        public RequisitionStatus RequisitionStatus { get; set; }

        /// <summary>
        /// Gets or sets the requisition citizen status.
        /// </summary>
        public RequisitionCitizenStatus RequisitionCitizenStatus { get; set; }


        /// <summary>
        /// Gets or sets the open until. No new submittals after:
        /// </summary>
        public DateTime? OpenUntil { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        public IDuration Duration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is for salaried contractors.
        /// </summary>
        public bool IsForSalariedContractors { get; set; }

        /// <summary>
        /// Gets or sets the client internal number.
        /// </summary>
        public string ClientInternalNumber { get; set; }

        /// <summary>
        /// Gets or sets the requisition priority.
        /// </summary>
        public RequisitionPriority RequisitionPriority { get; set; }

        /// <summary>
        /// Gets or sets the maximum submittals by vendor per opening.
        /// </summary>
        public int? MaximumSubmittalsByVendorPerOpening { get; set; }

        /// <summary>
        /// Gets or sets the custom fields.
        /// </summary>
        public IList<ICustomField> CustomFields { get; set; }

        // **** pnlDescription

        /// <summary>
        /// Gets or sets the engagement types. RegionSettings - TODO: Add, use OrganizationDetail
        /// </summary>
        public IList<EngagementType> EngagementTypes { get; set; }

        /// <summary>
        /// Gets or sets the short description. TODO: Add
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the description. TODO: Add
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the characteristics. TODO: Add
        /// </summary>
        public string Characteristics { get; set; }

        /// <summary>
        /// Gets or sets the alternate email. TODO: Add
        /// </summary>
        public string AlternateEmail { get; set; }

        // **** pnlContacts

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        public IList<IRequisitionContact> Contacts { get; set; }

        // **** pnlClientInfo

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public ILocation Location { get; set; }

        /// <summary>
        /// Gets or sets the general ledger.
        /// </summary>
        public IList<IGeneralLedger> GeneralLedger { get; set; }

        /// <summary>
        /// Gets or sets the cost center.
        /// </summary>
        public IList<ICostCenter> CostCenter { get; set; }

        /// <summary>
        /// Gets or sets the project.
        /// </summary>
        public IList<IProject> Project { get; set; }

        /// <summary>
        /// Gets or sets the department. Label: 'Div/Branch' TODO: Add
        /// </summary>
        public string Department { get; set; }

        // **** pnlRate ****

        /// <summary>
        /// Gets or sets the estimated expenses per opening.  Label: 'Expense Allowance' TODO: Add, '$200.54 USD Per Opening'
        /// </summary>
        public IMoney EstimatedExpensesPerOpening { get; set; }

        /// <summary>
        /// Gets or sets the rate structure. rate structure name, TODO: Add 
        /// </summary>
        public IRateStructure RateStructure { get; set; }

        // **** **** cntRate **** ****

       
        /// <summary>
        /// Gets or sets the bill range from rate. Bill Range
        /// </summary>
        public IMoney BillRangeFromRate { get; set; }

        /// <summary>
        /// Gets or sets the bill range to rate.
        /// </summary>
        public IMoney BillRangeToRate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether do not allow submission above max bill rate.  chkNotExceedFg
        /// </summary>
        public bool DoNotAllowSubmissionAboveMaxBillRate { get; set; }


        /// <summary>
        /// Gets or sets the max pay rate. Hourly High Bill Rate: $10.00 USD
        /// </summary>
        public IMoney MaxPayRate { get; set; }

        /// <summary>
        /// Gets or sets the hours per day.
        /// </summary>
        public decimal HoursPerDay { get; set; }

        /// <summary>
        /// Gets or sets the days per week.
        /// </summary>
        public int DaysPerWeek { get; set; }


        //public string NotToExceedRate { get; set; }

        /// <summary>
        /// Gets or sets the rate info text. Label: 'Rate/Salary Description'; TODO: Add req.Rt_Info_Tx
        /// </summary>
        public string RateInfoText { get; set; }

        /// <summary>
        /// Gets or sets the current budget.
        /// </summary>
        public IBudget CurrentBudget {get; set;}

        /// <summary>
        /// Gets or sets the skills.
        /// </summary>
        public IList<ISkill> Skills { get; set; }

        /// <summary>
        /// Gets or sets the global skills.
        /// </summary>
        public IList<ISkill> GlobalSkills { get; set; }

        /// <summary>
        /// Gets or sets the questions.
        /// </summary>
        public IList<IQuestion> Questions { get; set; }

        /// <summary>
        /// Gets or sets the compliance groups.
        /// </summary>
        public IList<IComplianceGroup> ComplianceGroups { get; set; }
    }
}
