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

    public partial class tblFormHolder : XPLiteObject
    {
        Guid fFormHolderID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid FormHolderID
        {
            get { return fFormHolderID; }
            set { SetPropertyValue<Guid>(nameof(FormHolderID), ref fFormHolderID, value); }
        }
        Guid fFormHolderParentID;
        public Guid FormHolderParentID
        {
            get { return fFormHolderParentID; }
            set { SetPropertyValue<Guid>(nameof(FormHolderParentID), ref fFormHolderParentID, value); }
        }
        string fFormHolderName;
        [Size(250)]
        public string FormHolderName
        {
            get { return fFormHolderName; }
            set { SetPropertyValue<string>(nameof(FormHolderName), ref fFormHolderName, value); }
        }
        string fFormHolderDescription;
        [Size(SizeAttribute.Unlimited)]
        public string FormHolderDescription
        {
            get { return fFormHolderDescription; }
            set { SetPropertyValue<string>(nameof(FormHolderDescription), ref fFormHolderDescription, value); }
        }
        string fFormHolderLevel;
        [Size(2000)]
        public string FormHolderLevel
        {
            get { return fFormHolderLevel; }
            set { SetPropertyValue<string>(nameof(FormHolderLevel), ref fFormHolderLevel, value); }
        }
        int fFileOwner;
        public int FileOwner
        {
            get { return fFileOwner; }
            set { SetPropertyValue<int>(nameof(FileOwner), ref fFileOwner, value); }
        }
    }

}