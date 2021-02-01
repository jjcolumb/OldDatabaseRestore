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

    public partial class PS_Main : XPLiteObject
    {
        Guid fPS_Main_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid PS_Main_ID
        {
            get { return fPS_Main_ID; }
            set { SetPropertyValue<Guid>(nameof(PS_Main_ID), ref fPS_Main_ID, value); }
        }
        string fPrice_Set_Description;
        [Size(250)]
        public string Price_Set_Description
        {
            get { return fPrice_Set_Description; }
            set { SetPropertyValue<string>(nameof(Price_Set_Description), ref fPrice_Set_Description, value); }
        }
        DateTime fSet_Valid_From_Date;
        public DateTime Set_Valid_From_Date
        {
            get { return fSet_Valid_From_Date; }
            set { SetPropertyValue<DateTime>(nameof(Set_Valid_From_Date), ref fSet_Valid_From_Date, value); }
        }
        DateTime fSet_Valid_To_Date;
        public DateTime Set_Valid_To_Date
        {
            get { return fSet_Valid_To_Date; }
            set { SetPropertyValue<DateTime>(nameof(Set_Valid_To_Date), ref fSet_Valid_To_Date, value); }
        }
        int fSet_Priority;
        public int Set_Priority
        {
            get { return fSet_Priority; }
            set { SetPropertyValue<int>(nameof(Set_Priority), ref fSet_Priority, value); }
        }
        pl_Price_Set_Type fPrice_Set_Type_ID;
        [Association(@"PS_MainReferencespl_Price_Set_Type")]
        public pl_Price_Set_Type Price_Set_Type_ID
        {
            get { return fPrice_Set_Type_ID; }
            set { SetPropertyValue<pl_Price_Set_Type>(nameof(Price_Set_Type_ID), ref fPrice_Set_Type_ID, value); }
        }
        [Association(@"IM_Price_SetsReferencesPS_Main")]
        public XPCollection<IM_Price_Sets> IM_Price_Setss { get { return GetCollection<IM_Price_Sets>(nameof(IM_Price_Setss)); } }
    }

}
