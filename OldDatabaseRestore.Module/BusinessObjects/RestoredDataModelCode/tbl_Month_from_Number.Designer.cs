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

    public partial class tbl_Month_from_Number : XPLiteObject
    {
        Guid ftbl_Month_from_Number_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid tbl_Month_from_Number_ID
        {
            get { return ftbl_Month_from_Number_ID; }
            set { SetPropertyValue<Guid>(nameof(tbl_Month_from_Number_ID), ref ftbl_Month_from_Number_ID, value); }
        }
        int fMonth_Index;
        public int Month_Index
        {
            get { return fMonth_Index; }
            set { SetPropertyValue<int>(nameof(Month_Index), ref fMonth_Index, value); }
        }
        string fMonth_Name;
        [Size(30)]
        public string Month_Name
        {
            get { return fMonth_Name; }
            set { SetPropertyValue<string>(nameof(Month_Name), ref fMonth_Name, value); }
        }
    }

}