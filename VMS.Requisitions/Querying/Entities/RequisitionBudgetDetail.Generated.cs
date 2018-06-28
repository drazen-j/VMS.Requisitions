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
    public partial class RequisitionBudgetDetail {

        public RequisitionBudgetDetail()
        {
            OnCreated();
        }

        public virtual System.Nullable<int> BillingRuleDetailId
        {
            get;
            set;
        }

        public virtual System.Nullable<decimal> Duration
        {
            get;
            set;
        }

        public virtual System.Nullable<decimal> EstimatedBudget
        {
            get;
            set;
        }

        public virtual int Id
        {
            get;
            set;
        }

        public virtual System.Nullable<decimal> ManagementFee
        {
            get;
            set;
        }

        public virtual System.Nullable<decimal> Rate
        {
            get;
            set;
        }

        public virtual System.Nullable<int> RateTypeId
        {
            get;
            set;
        }

        public virtual int RequisitionId
        {
            get;
            set;
        }

        public virtual short SequenceNumber
        {
            get;
            set;
        }

        public virtual System.Nullable<decimal> WorkHoursPerWeek
        {
            get;
            set;
        }

        public virtual BillingRuleDetail BILLRULEDTL
        {
            get;
            set;
        }

        public virtual Requisition Requisition
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();

        public override bool Equals(object obj)
        {
          RequisitionBudgetDetail toCompare = obj as RequisitionBudgetDetail;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.Id, toCompare.Id))
            return false;
          if (!Object.Equals(this.RequisitionId, toCompare.RequisitionId))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + Id.GetHashCode();
          hashCode = (hashCode * 7) + RequisitionId.GetHashCode();
          return hashCode;
        }
        
        #endregion
    }

}