
namespace VMS.Requisitions.Models
{
    // TODO: Figure out statuses description loading/displaying
    // TODO: Figure out organization based customized statuses: RequisitionStatus, CitizenStatus, MaxPayRateType, RateType (RatePeriodType)

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
        /// Gets or sets the client region.
        /// </summary>
        public IClientRegion ClientRegion { get; set; }

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
        //public string Ext { get; set; }

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
        /// Only for Format Type = 1 (Long Form)
        public RequisitionCitizenStatus RequisitionCitizenStatus { get; set; }


        /// <summary>
        /// Gets or sets the open until. No new submittals after:
        /// </summary>
        public DateTime? OpenUntil { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// Data Mapping: DurationValue, DurationTypeId
        /// Only for Format Type = 1 (Long Form)
        public IDuration Duration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is for salaried contractors.
        /// </summary>
        /// Data Mapping: IsSalariedContractor
        /// TODO: Add properties if needed; Visible if: oClientSettings.UseSalariedContractorConstraints And oReqCls.UseSalariedContractorFieldFg And oClientSettings.UsePayRateOnRequirement And oReqCls.UsePayRtReq
        public bool IsForSalariedContractors { get; set; }

        /// <summary>
        /// Gets or sets the client internal number.
        /// </summary>
        /// Data Mapping: InternalNumber
        /// Only for Format Type = 1 (Long Form)
        public string ClientInternalNumber { get; set; }

        /// <summary>
        /// Gets or sets the requisition priority.
        /// </summary>
        /// Only for Format Type = 1 (Long Form)
        public RequisitionPriority RequisitionPriority { get; set; }

        /// <summary>
        /// Gets or sets the maximum submittals by vendor per opening.
        /// </summary>
        /// Data Mapping: MaximumSubmittalsByVendor
        /// TODO: Visible if OrganizationDetail.DefaultMaximumCandidateSubmittals
        public int? MaximumSubmittalsByVendorPerOpening { get; set; }

        /// <summary>
        /// Gets or sets the custom fields.
        /// </summary>
        public IList<ICustomField> CustomFields { get; set; }

        // **** pnlDescription

        /// <summary>
        /// Gets or sets the engagement types.
        /// </summary>
        /// DataMapping: OrganizationDetail.IsEngagementTypeContractSupported, OrganizationDetail.IsEngagementTypeContractToPermanentSupported, OrganizationDetail.IsEngagementTypePermanentSupported
        public IList<EngagementType> EngagementTypes { get; set; }

        /// <summary>
        /// Gets or sets the short description.
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the description. TODO: Add
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the characteristics.
        /// </summary>
        /// Only for Format Type = 1 (Long Form)
        public string Characteristics { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is req fill bill.
        /// </summary>
        /// Visible if OrganizationDetail.DisplayAutoApproveOnRequirement - TODO: add
        public bool IsReqFillBill { get; set; }


        /// <summary>
        /// Gets or sets the alternate email.
        /// </summary>
        /// Only for Format Type = 1 (Long Form)
        public string AlternateEmail { get; set; }

        // **** pnlContacts TODO: Do not show in Vendor Org if RequisitionClass.ContactFlag is False

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        public IList<IRequisitionContact> Contacts { get; set; }

        // **** pnlClientInfo

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// TODO: Visible if oAppsUsed.LocationList
        public ILocation Location { get; set; }

        /// <summary>
        /// Gets or sets the general ledger.
        /// </summary>
        /// Data Mapping: RequisitionGeneralLedger
        /// TODO: Visible if oGeneralLedgerConfig.Utilization.Key not equal to GeneralLedgerUtilization.NotAvailable.Key
        public IList<IGeneralLedger> GeneralLedger { get; set; }

        /// <summary>
        /// Gets or sets the cost center.
        /// </summary>
        /// Data Mapping: RequisitionCostCenter
        /// TODO: Visible if oCostCenterConfig.Utilization.Key not equal to CostCenterUtilization.NotAvailable.Key
        public IList<ICostCenter> CostCenter { get; set; }

        /// <summary>
        /// Gets or sets the project.
        /// </summary>
        /// Data Mapping: RequisitionProject
        /// TODO: Visible if OrganizaitonDetail.RequirementProjects
        public IList<IProject> Project { get; set; }

        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// Data Mapping: DepartmentName (Label: 'Div/Branch')
        /// Only for Format Type = 1 (Long Form)
        public string Department { get; set; }

        // **** pnlRate ****

        /// <summary>
        /// Gets or sets the estimated expenses per opening.  
        /// </summary>
        /// Label: 'Expense Allowance' TODO: Add, '$200.54 USD Per Opening'
        /// Data Mapping: RequisitionFinanciaDetail.EstimatedExpenses
        /// Show if OrganizationDetail.EnforceBudgetConstraint = true, in client org and if Expenses are on and used by req class 
        public IMoney EstimatedExpensesPerOpening { get; set; }

        /// <summary>
        /// Gets or sets the rate structure. rate structure
        /// </summary>
        /// TODO: Visible if: oClientSettings.UseRateStructures
        public IRateStructure RateStructure { get; set; }

        // **** **** cntRate **** ****

        // TODO: Check if pay comment is necessary

        /// <summary>
        /// Gets or sets the rate range.
        /// </summary>
        /// Only for Format Type = 1 (Medium Form) if NOT (OrganizationDetail.UsePayRateOnRequisition And RequisitonClass.UsePayRateOnRequisition)
        public IRateRange RateRange { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether use not to exceed. (Label: 'do not allow submission above max bill rate')
        /// </summary>
        /// Data Mapping: Requisition.UseNotToExceed
        /// Display if: , OrganizationDetail.UseDefaultNotToExceedRate and FormatType = 1 (Medium)
        public bool UseNotToExceed { get; set; }

        /// <summary>
        /// Gets or sets the not to exceed rate.
        /// </summary>
        /// Display if: , OrganizationDetail.UseDefaultNotToExceedRate and FormatType = 1 (Medium)
        public IRate NotToExceedRate { get; set; }

        /// <summary>
        /// Gets or sets the max pay rate.
        /// </summary>
        /// Do not show if OrganizationDetail.EnforceBudgetConstraint = false
        public IMaxPayRate MaxPayRate { get; set; }

        /// <summary>
        /// Gets or sets the max rate.
        /// </summary>
        /// Data Mapping: Requisition.MaxRate
        public IMoney MaxRate { get; set; }

        /// <summary>
        /// Gets or sets the hours per day.
        /// </summary>
        /// Data Mapping: Requisition.HoursPerDay
        /// OrganizationDetail.EnforceBudgetConstraint and OrganizationDetail.UsePayRateOnRequirement And RequisitionClass.UsePayRtReq
        public decimal HoursPerDay { get; set; }

        /// <summary>
        /// Gets or sets the days per week.
        /// </summary>
        /// Data Mapping: Requisition.DaysPerWeek
        /// OrganizationDetail.EnforceBudgetConstraint and OrganizationDetail.UsePayRateOnRequirement And RequisitionClass.UsePayRtReq
        public int DaysPerWeek { get; set; }

        /// <summary>
        /// Gets or sets the rate info text. Label: 'Rate/Salary Description'
        /// </summary>
        /// Data Mapping: Requisition.RateInformationText
        /// Only for Format Type = 1 (Long Form); Requisition.FormatTypeId
        /// NOT visible if OrganizationDetail.UsePayRateOnRequisition And RequisitonClass.UsePayRateOnRequisition
        /// TODO: format based on OrganizationDetail.RateSalaryDescriptionFormatId as a text or currency
        public string RateInfoText { get; set; }

        /// <summary>
        /// Gets or sets the current budget.
        /// </summary>
        /// Show if OrganizationDetail.EnforceBudgetConstraint
        public IBudget CurrentBudget { get; set; }

        /// <summary>
        /// Gets or sets the requisition organization messages.
        /// </summary>
        public IList<IOrganizationMessage> RequisitionOrganizationMessages { get; set; }

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
        /// Note: Did not include group lists
        public IList<IComplianceGroup> ComplianceGroups { get; set; }
    }
}
