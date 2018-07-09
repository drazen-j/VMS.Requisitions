

namespace VMS.Requisitions.Contracts
{
    /// <summary>
    /// The organization message type.
    /// </summary>
    public enum OrganizationMessageType
    {
        /// <summary>
        /// The home page.
        /// </summary>
        HomePage = 1,

        /// <summary>
        /// The candidate submit.
        /// </summary>
        CandidateSubmit = 2,

        /// <summary>
        /// The requirement submit.
        /// </summary>
        RequirementSubmit = 3,

        /// <summary>
        /// The engagement details.
        /// </summary>
        EngagementDetails = 4,

        /// <summary>
        /// The application title.
        /// </summary>
        ApplicationTitle = 5,

        /// <summary>
        /// The expense report details.
        /// </summary>
        ExpenseReportDetails = 6,

        /// <summary>
        /// The timesheet entry.
        /// </summary>
        TimesheetEntry = 7,

        /// <summary>
        /// The engt time settings.
        /// </summary>
        EngtTimeSettings = 8,

        /// <summary>
        /// The login denied.
        /// </summary>
        LoginDenied = 9,

        /// <summary>
        /// The requirement settings.
        /// </summary>
        RequirementSettings = 10,

        /// <summary>
        /// The enhanced timesheet notice.
        /// </summary>
        EnhancedTimesheetNotice = 11,

        /// <summary>
        /// The requirement justification.
        /// </summary>
        RequirementJustification = 12,

        /// <summary>
        /// The requirement approval.
        /// </summary>
        RequirementApproval = 13,

        /// <summary>
        /// The engagement justification.
        /// </summary>
        EngagementJustification = 14,

        /// <summary>
        /// The engagement approval.
        /// </summary>
        EngagementApproval = 15,

        /// <summary>
        /// The requirement vendor restriction.
        /// </summary>
        RequirementVendorRestriction = 16,

        /// <summary>
        /// The timesheet ssn requirement.
        /// </summary>
        TimesheetSsnRequirement = 17,

        /// <summary>
        /// The project requirement details.
        /// </summary>
        ProjectRequirementDetails = 18,

        /// <summary>
        /// The proposal details.
        /// </summary>
        ProposalDetails = 19,

        /// <summary>
        /// The engaged proposal details.
        /// </summary>
        EngagedProposalDetails = 20,

        /// <summary>
        /// The engaged proposal settings.
        /// </summary>
        EngagedProposalSettings = 21,

        /// <summary>
        /// The project payment schedule.
        /// </summary>
        ProjectPaymentSchedule = 22,

        /// <summary>
        /// The project invoice entry.
        /// </summary>
        ProjectInvoiceEntry = 23,

        /// <summary>
        /// The requirement financial defaults.
        /// </summary>
        RequirementFinancialDefaults = 24,

        /// <summary>
        /// The engagement financial defaults.
        /// </summary>
        EngagementFinancialDefaults = 25,

        /// <summary>
        /// The timesheet allert missing proj.
        /// </summary>
        TimesheetAllertMissingProj = 26
    }
}
