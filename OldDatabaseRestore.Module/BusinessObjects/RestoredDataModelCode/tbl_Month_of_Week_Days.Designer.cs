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

    public partial class tbl_Month_of_Week_Days : XPLiteObject
    {
        Guid fWeek_Day_Id;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid Week_Day_Id
        {
            get { return fWeek_Day_Id; }
            set { SetPropertyValue<Guid>(nameof(Week_Day_Id), ref fWeek_Day_Id, value); }
        }
        string fWeek_Day_Name;
        [Size(15)]
        public string Week_Day_Name
        {
            get { return fWeek_Day_Name; }
            set { SetPropertyValue<string>(nameof(Week_Day_Name), ref fWeek_Day_Name, value); }
        }
        int fDay_Number;
        public int Day_Number
        {
            get { return fDay_Number; }
            set { SetPropertyValue<int>(nameof(Day_Number), ref fDay_Number, value); }
        }
        int fINDEX_USE;
        public int INDEX_USE
        {
            get { return fINDEX_USE; }
            set { SetPropertyValue<int>(nameof(INDEX_USE), ref fINDEX_USE, value); }
        }
        int fWeek_Index;
        public int Week_Index
        {
            get { return fWeek_Index; }
            set { SetPropertyValue<int>(nameof(Week_Index), ref fWeek_Index, value); }
        }
        string fLink_Key;
        [Size(2)]
        public string Link_Key
        {
            get { return fLink_Key; }
            set { SetPropertyValue<string>(nameof(Link_Key), ref fLink_Key, value); }
        }
    }

}
