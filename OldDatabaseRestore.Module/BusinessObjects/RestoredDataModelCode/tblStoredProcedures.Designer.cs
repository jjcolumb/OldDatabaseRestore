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

    public partial class tblStoredProcedures : XPLiteObject
    {
        Guid fspGuid;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid spGuid
        {
            get { return fspGuid; }
            set { SetPropertyValue<Guid>(nameof(spGuid), ref fspGuid, value); }
        }
        string fspName;
        public string spName
        {
            get { return fspName; }
            set { SetPropertyValue<string>(nameof(spName), ref fspName, value); }
        }
        string fspBody;
        [Size(SizeAttribute.Unlimited)]
        public string spBody
        {
            get { return fspBody; }
            set { SetPropertyValue<string>(nameof(spBody), ref fspBody, value); }
        }
        string fspParameters;
        [Size(SizeAttribute.Unlimited)]
        public string spParameters
        {
            get { return fspParameters; }
            set { SetPropertyValue<string>(nameof(spParameters), ref fspParameters, value); }
        }
    }

}
