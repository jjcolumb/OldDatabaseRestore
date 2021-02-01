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

    public partial class OB_Main : XPLiteObject
    {
        int fOB_Main_ID;
        [Key(true)]
        public int OB_Main_ID
        {
            get { return fOB_Main_ID; }
            set { SetPropertyValue<int>(nameof(OB_Main_ID), ref fOB_Main_ID, value); }
        }
        pl_Batch_Type fpl_Batch_Type_ID;
        [Association(@"OB_MainReferencespl_Batch_Type")]
        public pl_Batch_Type pl_Batch_Type_ID
        {
            get { return fpl_Batch_Type_ID; }
            set { SetPropertyValue<pl_Batch_Type>(nameof(pl_Batch_Type_ID), ref fpl_Batch_Type_ID, value); }
        }
        pl_Batch_Status fpl_Batch_Status_ID;
        [Association(@"OB_MainReferencespl_Batch_Status")]
        public pl_Batch_Status pl_Batch_Status_ID
        {
            get { return fpl_Batch_Status_ID; }
            set { SetPropertyValue<pl_Batch_Status>(nameof(pl_Batch_Status_ID), ref fpl_Batch_Status_ID, value); }
        }
        DateTime fBatch_DateTime;
        public DateTime Batch_DateTime
        {
            get { return fBatch_DateTime; }
            set { SetPropertyValue<DateTime>(nameof(Batch_DateTime), ref fBatch_DateTime, value); }
        }
        int fTransaction_Count;
        public int Transaction_Count
        {
            get { return fTransaction_Count; }
            set { SetPropertyValue<int>(nameof(Transaction_Count), ref fTransaction_Count, value); }
        }
        decimal fTransaction_Amount;
        public decimal Transaction_Amount
        {
            get { return fTransaction_Amount; }
            set { SetPropertyValue<decimal>(nameof(Transaction_Amount), ref fTransaction_Amount, value); }
        }
        int fManual_Transaction_Count;
        public int Manual_Transaction_Count
        {
            get { return fManual_Transaction_Count; }
            set { SetPropertyValue<int>(nameof(Manual_Transaction_Count), ref fManual_Transaction_Count, value); }
        }
        decimal fManual_Transaction_Amount;
        public decimal Manual_Transaction_Amount
        {
            get { return fManual_Transaction_Amount; }
            set { SetPropertyValue<decimal>(nameof(Manual_Transaction_Amount), ref fManual_Transaction_Amount, value); }
        }
        string fTransaction_Count_Valid;
        [Size(50)]
        public string Transaction_Count_Valid
        {
            get { return fTransaction_Count_Valid; }
            set { SetPropertyValue<string>(nameof(Transaction_Count_Valid), ref fTransaction_Count_Valid, value); }
        }
        string fTransaction_Amount_Valid;
        [Size(50)]
        public string Transaction_Amount_Valid
        {
            get { return fTransaction_Amount_Valid; }
            set { SetPropertyValue<string>(nameof(Transaction_Amount_Valid), ref fTransaction_Amount_Valid, value); }
        }
        string fBatch_Valid;
        [Size(50)]
        public string Batch_Valid
        {
            get { return fBatch_Valid; }
            set { SetPropertyValue<string>(nameof(Batch_Valid), ref fBatch_Valid, value); }
        }
        int fAutoPayCount;
        public int AutoPayCount
        {
            get { return fAutoPayCount; }
            set { SetPropertyValue<int>(nameof(AutoPayCount), ref fAutoPayCount, value); }
        }
        decimal fAutoPayAmount;
        public decimal AutoPayAmount
        {
            get { return fAutoPayAmount; }
            set { SetPropertyValue<decimal>(nameof(AutoPayAmount), ref fAutoPayAmount, value); }
        }
        [Association(@"OI_MainReferencesOB_Main")]
        public XPCollection<OI_Main> OI_Mains { get { return GetCollection<OI_Main>(nameof(OI_Mains)); } }
    }

}