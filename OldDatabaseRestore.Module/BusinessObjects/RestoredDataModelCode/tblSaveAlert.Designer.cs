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

    public partial class tblSaveAlert : XPLiteObject
    {
        int fSaveAlertID;
        [Key(true)]
        public int SaveAlertID
        {
            get { return fSaveAlertID; }
            set { SetPropertyValue<int>(nameof(SaveAlertID), ref fSaveAlertID, value); }
        }
        string fSaveAlert;
        [Size(2000)]
        public string SaveAlert
        {
            get { return fSaveAlert; }
            set { SetPropertyValue<string>(nameof(SaveAlert), ref fSaveAlert, value); }
        }
        string fHostName;
        [Size(50)]
        public string HostName
        {
            get { return fHostName; }
            set { SetPropertyValue<string>(nameof(HostName), ref fHostName, value); }
        }
    }

}