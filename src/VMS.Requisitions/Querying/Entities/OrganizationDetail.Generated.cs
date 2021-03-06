﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Entity Developer tool using EF Core template.
// -----------------------------------------------------------------------------
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;

namespace VMS.Requisitions.Querying.Entities
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public partial class OrganizationDetail {

        public OrganizationDetail()
        {
            this.IsApprovalRequiredBeforeRequisitionDistribution = true;
            this.IsEngagementTypeContractSupported = true;
            this.IsEngagementTypeContractToPermanentSupported = true;
            this.RateSalaryDescriptionFormatId = 1;
            this.UseDefaultNotToExceedRate = false;
            this.UsePayRateOnRequisition = false;
            OnCreated();
        }

        public virtual bool EnforceBudgetConstraint
        {
            get;
            set;
        }

        public virtual int Id
        {
            get;
            set;
        }

        public virtual bool IsApprovalRequiredBeforeRequisitionDistribution
        {
            get;
            set;
        }

        public virtual bool IsEngagementTypeContractSupported
        {
            get;
            set;
        }

        public virtual bool IsEngagementTypeContractToPermanentSupported
        {
            get;
            set;
        }

        public virtual int OrganizationId
        {
            get;
            set;
        }

        public virtual int RateSalaryDescriptionFormatId
        {
            get;
            set;
        }

        public virtual bool UseDefaultNotToExceedRate
        {
            get;
            set;
        }

        public virtual bool UsePayRateOnRequisition
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
