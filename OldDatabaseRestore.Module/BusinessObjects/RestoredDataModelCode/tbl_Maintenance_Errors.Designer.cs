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

    public partial class tbl_Maintenance_Errors : XPLiteObject
    {
        Guid fMaintenance_Error_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid Maintenance_Error_ID
        {
            get { return fMaintenance_Error_ID; }
            set { SetPropertyValue<Guid>(nameof(Maintenance_Error_ID), ref fMaintenance_Error_ID, value); }
        }
        tbl_Maintenance_Audit fMaintenance_Audit_ID;
        [Association(@"tbl_Maintenance_ErrorsReferencestbl_Maintenance_Audit")]
        public tbl_Maintenance_Audit Maintenance_Audit_ID
        {
            get { return fMaintenance_Audit_ID; }
            set { SetPropertyValue<tbl_Maintenance_Audit>(nameof(Maintenance_Audit_ID), ref fMaintenance_Audit_ID, value); }
        }
        string fErrorProcedure;
        [Size(SizeAttribute.Unlimited)]
        public string ErrorProcedure
        {
            get { return fErrorProcedure; }
            set { SetPropertyValue<string>(nameof(ErrorProcedure), ref fErrorProcedure, value); }
        }
        string fErrorProcedureStep;
        [Size(SizeAttribute.Unlimited)]
        public string ErrorProcedureStep
        {
            get { return fErrorProcedureStep; }
            set { SetPropertyValue<string>(nameof(ErrorProcedureStep), ref fErrorProcedureStep, value); }
        }
        int fErrorLine;
        public int ErrorLine
        {
            get { return fErrorLine; }
            set { SetPropertyValue<int>(nameof(ErrorLine), ref fErrorLine, value); }
        }
        int fErrorNumber;
        public int ErrorNumber
        {
            get { return fErrorNumber; }
            set { SetPropertyValue<int>(nameof(ErrorNumber), ref fErrorNumber, value); }
        }
        string fErrorMessage;
        [Size(SizeAttribute.Unlimited)]
        public string ErrorMessage
        {
            get { return fErrorMessage; }
            set { SetPropertyValue<string>(nameof(ErrorMessage), ref fErrorMessage, value); }
        }
        int fErrorSeverity;
        public int ErrorSeverity
        {
            get { return fErrorSeverity; }
            set { SetPropertyValue<int>(nameof(ErrorSeverity), ref fErrorSeverity, value); }
        }
        int fErrorState;
        public int ErrorState
        {
            get { return fErrorState; }
            set { SetPropertyValue<int>(nameof(ErrorState), ref fErrorState, value); }
        }
        long fRecordsProcessed;
        public long RecordsProcessed
        {
            get { return fRecordsProcessed; }
            set { SetPropertyValue<long>(nameof(RecordsProcessed), ref fRecordsProcessed, value); }
        }
        long fRecordsAtError;
        public long RecordsAtError
        {
            get { return fRecordsAtError; }
            set { SetPropertyValue<long>(nameof(RecordsAtError), ref fRecordsAtError, value); }
        }
        DateTime fMaintenance_Mark;
        [ColumnDbDefaultValue("(getdate())")]
        public DateTime Maintenance_Mark
        {
            get { return fMaintenance_Mark; }
            set { SetPropertyValue<DateTime>(nameof(Maintenance_Mark), ref fMaintenance_Mark, value); }
        }
    }

}
