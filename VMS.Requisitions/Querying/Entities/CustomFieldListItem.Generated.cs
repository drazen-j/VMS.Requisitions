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
    public partial class CustomFieldListItem {

        public CustomFieldListItem()
        {
            this.CustomValues = new List<CustomValue>();
            OnCreated();
        }

        public virtual int Id
        {
            get;
            set;
        }

        public virtual string ListItemText
        {
            get;
            set;
        }

        public virtual IList<CustomValue> CustomValues
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
