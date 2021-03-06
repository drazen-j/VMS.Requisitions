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
    public partial class Organization {

        public Organization()
        {
            this.CUSTOMFLDs = new List<CustomField>();
            this.LOCALORGs = new List<LocalizationOrganization>();
            this.ORGMSGs = new List<OrganizationMessage>();
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

        public virtual int OrganizationTypeId
        {
            get;
            set;
        }

        public virtual System.Nullable<int> ParentOrganizationId
        {
            get;
            set;
        }

        public virtual string RegionDescription
        {
            get;
            set;
        }

        public virtual string ShortName
        {
            get;
            set;
        }

        public virtual IList<CustomField> CUSTOMFLDs
        {
            get;
            set;
        }

        public virtual IList<LocalizationOrganization> LOCALORGs
        {
            get;
            set;
        }

        public virtual IList<OrganizationMessage> ORGMSGs
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
