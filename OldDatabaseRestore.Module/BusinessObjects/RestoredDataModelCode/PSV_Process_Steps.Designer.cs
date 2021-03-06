﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace OldDatabaseRestore.Module.BusinessObjects.BCI_Database_V2A2013
{

    public partial class PSV_Process_Steps : XPLiteObject
    {
        Guid fPSVProcessStepID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid PSVProcessStepID
        {
            get { return fPSVProcessStepID; }
            set { SetPropertyValue<Guid>(nameof(PSVProcessStepID), ref fPSVProcessStepID, value); }
        }
        PSV_Process fProcessID;
        [Association(@"PSV_Process_StepsReferencesPSV_Process")]
        public PSV_Process ProcessID
        {
            get { return fProcessID; }
            set { SetPropertyValue<PSV_Process>(nameof(ProcessID), ref fProcessID, value); }
        }
        PSV_Type fTypeID;
        [Association(@"PSV_Process_StepsReferencesPSV_Type")]
        public PSV_Type TypeID
        {
            get { return fTypeID; }
            set { SetPropertyValue<PSV_Type>(nameof(TypeID), ref fTypeID, value); }
        }
        int fProcessOrder;
        public int ProcessOrder
        {
            get { return fProcessOrder; }
            set { SetPropertyValue<int>(nameof(ProcessOrder), ref fProcessOrder, value); }
        }
    }

}
