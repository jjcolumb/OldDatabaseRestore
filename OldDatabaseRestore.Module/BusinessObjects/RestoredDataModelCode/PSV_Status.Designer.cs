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

    public partial class PSV_Status : XPLiteObject
    {
        Guid fPSVStatus_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid PSVStatus_ID
        {
            get { return fPSVStatus_ID; }
            set { SetPropertyValue<Guid>(nameof(PSVStatus_ID), ref fPSVStatus_ID, value); }
        }
        string fDescription;
        [Size(50)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>(nameof(Description), ref fDescription, value); }
        }
        [Association(@"PSV_ResponsesReferencesPSV_Status")]
        public XPCollection<PSV_Responses> PSV_Responsess { get { return GetCollection<PSV_Responses>(nameof(PSV_Responsess)); } }
    }

}
