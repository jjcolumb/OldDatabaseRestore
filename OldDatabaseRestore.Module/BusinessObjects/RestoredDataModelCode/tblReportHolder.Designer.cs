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

    public partial class tblReportHolder : XPLiteObject
    {
        Guid fReportHolderID;
        [Key(true)]
        public Guid ReportHolderID
        {
            get { return fReportHolderID; }
            set { SetPropertyValue<Guid>(nameof(ReportHolderID), ref fReportHolderID, value); }
        }
        string fReportName;
        [Size(250)]
        public string ReportName
        {
            get { return fReportName; }
            set { SetPropertyValue<string>(nameof(ReportName), ref fReportName, value); }
        }
        string fReportDirectory;
        [Size(2000)]
        public string ReportDirectory
        {
            get { return fReportDirectory; }
            set { SetPropertyValue<string>(nameof(ReportDirectory), ref fReportDirectory, value); }
        }
        string fReportViewName;
        [Size(250)]
        public string ReportViewName
        {
            get { return fReportViewName; }
            set { SetPropertyValue<string>(nameof(ReportViewName), ref fReportViewName, value); }
        }
    }

}
