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

    public partial class tblSystemDates : XPLiteObject
    {
        Guid fSystemDatesGUID;
        [Key(true)]
        public Guid SystemDatesGUID
        {
            get { return fSystemDatesGUID; }
            set { SetPropertyValue<Guid>(nameof(SystemDatesGUID), ref fSystemDatesGUID, value); }
        }
        string fSystemDatesName;
        [Size(50)]
        public string SystemDatesName
        {
            get { return fSystemDatesName; }
            set { SetPropertyValue<string>(nameof(SystemDatesName), ref fSystemDatesName, value); }
        }
        int fSystemDatesID;
        public int SystemDatesID
        {
            get { return fSystemDatesID; }
            set { SetPropertyValue<int>(nameof(SystemDatesID), ref fSystemDatesID, value); }
        }
        DateTime fSystemDates;
        public DateTime SystemDates
        {
            get { return fSystemDates; }
            set { SetPropertyValue<DateTime>(nameof(SystemDates), ref fSystemDates, value); }
        }
    }

}