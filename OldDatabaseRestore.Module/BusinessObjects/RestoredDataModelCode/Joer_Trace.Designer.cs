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

    public partial class Joer_Trace : XPLiteObject
    {
        Guid fID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid ID
        {
            get { return fID; }
            set { SetPropertyValue<Guid>(nameof(ID), ref fID, value); }
        }
        string fDataTest;
        public string DataTest
        {
            get { return fDataTest; }
            set { SetPropertyValue<string>(nameof(DataTest), ref fDataTest, value); }
        }
        DateTime fDate_Time_Mark;
        [ColumnDbDefaultValue("(getdate())")]
        public DateTime Date_Time_Mark
        {
            get { return fDate_Time_Mark; }
            set { SetPropertyValue<DateTime>(nameof(Date_Time_Mark), ref fDate_Time_Mark, value); }
        }
    }

}
