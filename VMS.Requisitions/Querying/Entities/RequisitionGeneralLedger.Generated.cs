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
    public partial class RequisitionGeneralLedger {

        public RequisitionGeneralLedger()
        {
            OnCreated();
        }

        public virtual int Id
        {
            get;
            set;
        }

        public virtual string Name
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();

        public override bool Equals(object obj)
        {
          RequisitionGeneralLedger toCompare = obj as RequisitionGeneralLedger;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.Id, toCompare.Id))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + Id.GetHashCode();
          return hashCode;
        }
        
        #endregion
    }

}
