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

    public partial class PD_Main : XPLiteObject
    {
        Guid fPeriod_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid Period_ID
        {
            get { return fPeriod_ID; }
            set { SetPropertyValue<Guid>(nameof(Period_ID), ref fPeriod_ID, value); }
        }
        int fPeriod_Index;
        public int Period_Index
        {
            get { return fPeriod_Index; }
            set { SetPropertyValue<int>(nameof(Period_Index), ref fPeriod_Index, value); }
        }
        string fPeriod_Name;
        [Size(50)]
        public string Period_Name
        {
            get { return fPeriod_Name; }
            set { SetPropertyValue<string>(nameof(Period_Name), ref fPeriod_Name, value); }
        }
    }

}