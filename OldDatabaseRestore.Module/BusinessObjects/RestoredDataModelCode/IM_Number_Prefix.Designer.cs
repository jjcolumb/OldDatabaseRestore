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

    public partial class IM_Number_Prefix : XPLiteObject
    {
        Guid fIM_Number_Prefix_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid IM_Number_Prefix_ID
        {
            get { return fIM_Number_Prefix_ID; }
            set { SetPropertyValue<Guid>(nameof(IM_Number_Prefix_ID), ref fIM_Number_Prefix_ID, value); }
        }
        string fItem_Prefix;
        [Size(4)]
        public string Item_Prefix
        {
            get { return fItem_Prefix; }
            set { SetPropertyValue<string>(nameof(Item_Prefix), ref fItem_Prefix, value); }
        }
        int fItem_Range_Start;
        public int Item_Range_Start
        {
            get { return fItem_Range_Start; }
            set { SetPropertyValue<int>(nameof(Item_Range_Start), ref fItem_Range_Start, value); }
        }
        int fItem_Range_Stop;
        public int Item_Range_Stop
        {
            get { return fItem_Range_Stop; }
            set { SetPropertyValue<int>(nameof(Item_Range_Stop), ref fItem_Range_Stop, value); }
        }
    }

}