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

    public partial class tblSearchSettingDefinition : XPLiteObject
    {
        int fSearchSettingDefinitionID;
        [Key(true)]
        public int SearchSettingDefinitionID
        {
            get { return fSearchSettingDefinitionID; }
            set { SetPropertyValue<int>(nameof(SearchSettingDefinitionID), ref fSearchSettingDefinitionID, value); }
        }
        Guid fSearchGuid;
        public Guid SearchGuid
        {
            get { return fSearchGuid; }
            set { SetPropertyValue<Guid>(nameof(SearchGuid), ref fSearchGuid, value); }
        }
        string fName;
        [Size(250)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fUserID;
        public string UserID
        {
            get { return fUserID; }
            set { SetPropertyValue<string>(nameof(UserID), ref fUserID, value); }
        }
        bool fShowinTree;
        public bool ShowinTree
        {
            get { return fShowinTree; }
            set { SetPropertyValue<bool>(nameof(ShowinTree), ref fShowinTree, value); }
        }
        [Association(@"tblSearchSettingReferencestblSearchSettingDefinition")]
        public XPCollection<tblSearchSetting> tblSearchSettings { get { return GetCollection<tblSearchSetting>(nameof(tblSearchSettings)); } }
    }

}
