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

    public partial class Zone_On_Zip_Code_Range : XPLiteObject
    {
        Guid fZone_On_ZipRange_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid Zone_On_ZipRange_ID
        {
            get { return fZone_On_ZipRange_ID; }
            set { SetPropertyValue<Guid>(nameof(Zone_On_ZipRange_ID), ref fZone_On_ZipRange_ID, value); }
        }
        string fLow_Zip_Code;
        [Indexed(Name = @"IX_Zone_On_Zip_Code_Range_Low")]
        [Size(9)]
        public string Low_Zip_Code
        {
            get { return fLow_Zip_Code; }
            set { SetPropertyValue<string>(nameof(Low_Zip_Code), ref fLow_Zip_Code, value); }
        }
        string fHigh_Zip_Code;
        [Indexed(Name = @"IX_Zone_On_Zip_Code_Range_High")]
        [Size(9)]
        public string High_Zip_Code
        {
            get { return fHigh_Zip_Code; }
            set { SetPropertyValue<string>(nameof(High_Zip_Code), ref fHigh_Zip_Code, value); }
        }
        int fZone;
        public int Zone
        {
            get { return fZone; }
            set { SetPropertyValue<int>(nameof(Zone), ref fZone, value); }
        }
    }

}
