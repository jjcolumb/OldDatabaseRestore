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

    public partial class ZD_LIST : XPLiteObject
    {
        Guid fZD_LIST_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid ZD_LIST_ID
        {
            get { return fZD_LIST_ID; }
            set { SetPropertyValue<Guid>(nameof(ZD_LIST_ID), ref fZD_LIST_ID, value); }
        }
        decimal fOrdered_Link;
        public decimal Ordered_Link
        {
            get { return fOrdered_Link; }
            set { SetPropertyValue<decimal>(nameof(Ordered_Link), ref fOrdered_Link, value); }
        }
        string fZip_Zone;
        [Size(9)]
        public string Zip_Zone
        {
            get { return fZip_Zone; }
            set { SetPropertyValue<string>(nameof(Zip_Zone), ref fZip_Zone, value); }
        }
        int fZip_Zone_Short;
        public int Zip_Zone_Short
        {
            get { return fZip_Zone_Short; }
            set { SetPropertyValue<int>(nameof(Zip_Zone_Short), ref fZip_Zone_Short, value); }
        }
        string fZip_Zone_ID;
        [Size(9)]
        public string Zip_Zone_ID
        {
            get { return fZip_Zone_ID; }
            set { SetPropertyValue<string>(nameof(Zip_Zone_ID), ref fZip_Zone_ID, value); }
        }
        decimal fOrdered;
        public decimal Ordered
        {
            get { return fOrdered; }
            set { SetPropertyValue<decimal>(nameof(Ordered), ref fOrdered, value); }
        }
    }

}