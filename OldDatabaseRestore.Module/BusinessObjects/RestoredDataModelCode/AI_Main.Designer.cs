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

    public partial class AI_Main : XPLiteObject
    {
        Guid fAI_Main_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid AI_Main_ID
        {
            get { return fAI_Main_ID; }
            set { SetPropertyValue<Guid>(nameof(AI_Main_ID), ref fAI_Main_ID, value); }
        }
        CM_Main fCM_Main_ID;
        [Association(@"AI_MainReferencesCM_Main")]
        public CM_Main CM_Main_ID
        {
            get { return fCM_Main_ID; }
            set { SetPropertyValue<CM_Main>(nameof(CM_Main_ID), ref fCM_Main_ID, value); }
        }
        string fTransaction_Number;
        [Size(20)]
        public string Transaction_Number
        {
            get { return fTransaction_Number; }
            set { SetPropertyValue<string>(nameof(Transaction_Number), ref fTransaction_Number, value); }
        }
        pl_Adjustment_Types fAdjustment_Type;
        [Association(@"AI_MainReferencespl_Adjustment_Types")]
        public pl_Adjustment_Types Adjustment_Type
        {
            get { return fAdjustment_Type; }
            set { SetPropertyValue<pl_Adjustment_Types>(nameof(Adjustment_Type), ref fAdjustment_Type, value); }
        }
        DateTime fTransaction_Date;
        public DateTime Transaction_Date
        {
            get { return fTransaction_Date; }
            set { SetPropertyValue<DateTime>(nameof(Transaction_Date), ref fTransaction_Date, value); }
        }
        decimal fPaid_Amount;
        public decimal Paid_Amount
        {
            get { return fPaid_Amount; }
            set { SetPropertyValue<decimal>(nameof(Paid_Amount), ref fPaid_Amount, value); }
        }
        decimal fRemaining_Amount;
        public decimal Remaining_Amount
        {
            get { return fRemaining_Amount; }
            set { SetPropertyValue<decimal>(nameof(Remaining_Amount), ref fRemaining_Amount, value); }
        }
        string fCM_Name;
        public string CM_Name
        {
            get { return fCM_Name; }
            set { SetPropertyValue<string>(nameof(CM_Name), ref fCM_Name, value); }
        }
        string fCM_Account_Number_Text;
        [Size(25)]
        public string CM_Account_Number_Text
        {
            get { return fCM_Account_Number_Text; }
            set { SetPropertyValue<string>(nameof(CM_Account_Number_Text), ref fCM_Account_Number_Text, value); }
        }
        AB_Main fAB_Main_ID;
        [Association(@"AI_MainReferencesAB_Main")]
        public AB_Main AB_Main_ID
        {
            get { return fAB_Main_ID; }
            set { SetPropertyValue<AB_Main>(nameof(AB_Main_ID), ref fAB_Main_ID, value); }
        }
        int fOrderby;
        public int Orderby
        {
            get { return fOrderby; }
            set { SetPropertyValue<int>(nameof(Orderby), ref fOrderby, value); }
        }
        bool fLock_Paid_Amount;
        public bool Lock_Paid_Amount
        {
            get { return fLock_Paid_Amount; }
            set { SetPropertyValue<bool>(nameof(Lock_Paid_Amount), ref fLock_Paid_Amount, value); }
        }
        pl_Transaction fTransaction_Type;
        [Association(@"AI_MainReferencespl_Transaction")]
        public pl_Transaction Transaction_Type
        {
            get { return fTransaction_Type; }
            set { SetPropertyValue<pl_Transaction>(nameof(Transaction_Type), ref fTransaction_Type, value); }
        }
        [Association(@"AI_ItemsReferencesAI_Main")]
        public XPCollection<AI_Items> AI_Itemss { get { return GetCollection<AI_Items>(nameof(AI_Itemss)); } }
    }

}
