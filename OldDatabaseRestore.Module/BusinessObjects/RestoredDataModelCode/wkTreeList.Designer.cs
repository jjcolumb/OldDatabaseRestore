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

    public partial class wkTreeList : XPLiteObject
    {
        Guid fwkTreeList_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid wkTreeList_ID
        {
            get { return fwkTreeList_ID; }
            set { SetPropertyValue<Guid>(nameof(wkTreeList_ID), ref fwkTreeList_ID, value); }
        }
        int fAutoID_Security;
        public int AutoID_Security
        {
            get { return fAutoID_Security; }
            set { SetPropertyValue<int>(nameof(AutoID_Security), ref fAutoID_Security, value); }
        }
        string fTreeName;
        [Size(250)]
        public string TreeName
        {
            get { return fTreeName; }
            set { SetPropertyValue<string>(nameof(TreeName), ref fTreeName, value); }
        }
        string fSecurityID;
        [Size(250)]
        public string SecurityID
        {
            get { return fSecurityID; }
            set { SetPropertyValue<string>(nameof(SecurityID), ref fSecurityID, value); }
        }
        bool fLoadatStart;
        public bool LoadatStart
        {
            get { return fLoadatStart; }
            set { SetPropertyValue<bool>(nameof(LoadatStart), ref fLoadatStart, value); }
        }
        bool fFilter;
        public bool Filter
        {
            get { return fFilter; }
            set { SetPropertyValue<bool>(nameof(Filter), ref fFilter, value); }
        }
        bool fFilterBar;
        public bool FilterBar
        {
            get { return fFilterBar; }
            set { SetPropertyValue<bool>(nameof(FilterBar), ref fFilterBar, value); }
        }
        bool fSearchBar;
        public bool SearchBar
        {
            get { return fSearchBar; }
            set { SetPropertyValue<bool>(nameof(SearchBar), ref fSearchBar, value); }
        }
        bool fHidden;
        public bool Hidden
        {
            get { return fHidden; }
            set { SetPropertyValue<bool>(nameof(Hidden), ref fHidden, value); }
        }
    }

}