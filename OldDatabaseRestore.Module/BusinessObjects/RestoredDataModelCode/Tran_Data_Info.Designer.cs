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

    public partial class Tran_Data_Info : XPLiteObject
    {
        Guid fTranData_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid TranData_ID
        {
            get { return fTranData_ID; }
            set { SetPropertyValue<Guid>(nameof(TranData_ID), ref fTranData_ID, value); }
        }
        string fSymbol;
        [Size(SizeAttribute.Unlimited)]
        public string Symbol
        {
            get { return fSymbol; }
            set { SetPropertyValue<string>(nameof(Symbol), ref fSymbol, value); }
        }
        string fFriendlyName;
        [Size(SizeAttribute.Unlimited)]
        public string FriendlyName
        {
            get { return fFriendlyName; }
            set { SetPropertyValue<string>(nameof(FriendlyName), ref fFriendlyName, value); }
        }
    }

}