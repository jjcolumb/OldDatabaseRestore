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

    public partial class pl_New_Locations : XPLiteObject
    {
        Guid fpl_New_Locations_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid pl_New_Locations_ID
        {
            get { return fpl_New_Locations_ID; }
            set { SetPropertyValue<Guid>(nameof(pl_New_Locations_ID), ref fpl_New_Locations_ID, value); }
        }
        string fLocation_Text;
        [Size(25)]
        public string Location_Text
        {
            get { return fLocation_Text; }
            set { SetPropertyValue<string>(nameof(Location_Text), ref fLocation_Text, value); }
        }
        string fmySort;
        [Size(25)]
        public string mySort
        {
            get { return fmySort; }
            set { SetPropertyValue<string>(nameof(mySort), ref fmySort, value); }
        }
    }

}