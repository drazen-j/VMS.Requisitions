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
    public enum RequisitionStatus : int
    {

        Draft = 1,    
        PendingApproval = 2,    
        NotApproved = 3,    
        Open = 4,    
        InterviewsOccuring = 5,    
        Filled = 6,    
        ClosedCancelled = 8,    
        OnHold = 9,    
        PedningBuySideApproval = 10,    
        BuySideBudgetNotApproved = 11
    }
}
