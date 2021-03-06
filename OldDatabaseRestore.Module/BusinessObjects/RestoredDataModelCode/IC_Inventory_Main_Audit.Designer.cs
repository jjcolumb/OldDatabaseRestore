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

    public partial class IC_Inventory_Main_Audit : XPLiteObject
    {
        Guid fIC_Inventory_Main_Audit_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid IC_Inventory_Main_Audit_ID
        {
            get { return fIC_Inventory_Main_Audit_ID; }
            set { SetPropertyValue<Guid>(nameof(IC_Inventory_Main_Audit_ID), ref fIC_Inventory_Main_Audit_ID, value); }
        }
        int fYear_Audit;
        public int Year_Audit
        {
            get { return fYear_Audit; }
            set { SetPropertyValue<int>(nameof(Year_Audit), ref fYear_Audit, value); }
        }
        int fItems_Count;
        public int Items_Count
        {
            get { return fItems_Count; }
            set { SetPropertyValue<int>(nameof(Items_Count), ref fItems_Count, value); }
        }
        int fScanns_Count;
        public int Scanns_Count
        {
            get { return fScanns_Count; }
            set { SetPropertyValue<int>(nameof(Scanns_Count), ref fScanns_Count, value); }
        }
        int fBase_Count;
        public int Base_Count
        {
            get { return fBase_Count; }
            set { SetPropertyValue<int>(nameof(Base_Count), ref fBase_Count, value); }
        }
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>(nameof(Comment), ref fComment, value); }
        }
        string fNotes;
        [Size(SizeAttribute.Unlimited)]
        public string Notes
        {
            get { return fNotes; }
            set { SetPropertyValue<string>(nameof(Notes), ref fNotes, value); }
        }
        pl_Inventory_Count_Status fCount_Status_ID;
        [Association(@"IC_Inventory_Main_AuditReferencespl_Inventory_Count_Status")]
        public pl_Inventory_Count_Status Count_Status_ID
        {
            get { return fCount_Status_ID; }
            set { SetPropertyValue<pl_Inventory_Count_Status>(nameof(Count_Status_ID), ref fCount_Status_ID, value); }
        }
        bool fClosed_Locked;
        public bool Closed_Locked
        {
            get { return fClosed_Locked; }
            set { SetPropertyValue<bool>(nameof(Closed_Locked), ref fClosed_Locked, value); }
        }
        DateTime fCount_Start;
        public DateTime Count_Start
        {
            get { return fCount_Start; }
            set { SetPropertyValue<DateTime>(nameof(Count_Start), ref fCount_Start, value); }
        }
        DateTime fCount_Finish;
        public DateTime Count_Finish
        {
            get { return fCount_Finish; }
            set { SetPropertyValue<DateTime>(nameof(Count_Finish), ref fCount_Finish, value); }
        }
        DateTime fCount_Posted;
        public DateTime Count_Posted
        {
            get { return fCount_Posted; }
            set { SetPropertyValue<DateTime>(nameof(Count_Posted), ref fCount_Posted, value); }
        }
        UD_Main fApproved_By_ID;
        [Association(@"IC_Inventory_Main_AuditReferencesUD_Main")]
        public UD_Main Approved_By_ID
        {
            get { return fApproved_By_ID; }
            set { SetPropertyValue<UD_Main>(nameof(Approved_By_ID), ref fApproved_By_ID, value); }
        }
        int fItems_Count_Live;
        public int Items_Count_Live
        {
            get { return fItems_Count_Live; }
            set { SetPropertyValue<int>(nameof(Items_Count_Live), ref fItems_Count_Live, value); }
        }
        int fScans_Count_Live;
        public int Scans_Count_Live
        {
            get { return fScans_Count_Live; }
            set { SetPropertyValue<int>(nameof(Scans_Count_Live), ref fScans_Count_Live, value); }
        }
        int fScan_Count_Visible;
        public int Scan_Count_Visible
        {
            get { return fScan_Count_Visible; }
            set { SetPropertyValue<int>(nameof(Scan_Count_Visible), ref fScan_Count_Visible, value); }
        }
        int fScan_Count_Live_Visible;
        public int Scan_Count_Live_Visible
        {
            get { return fScan_Count_Live_Visible; }
            set { SetPropertyValue<int>(nameof(Scan_Count_Live_Visible), ref fScan_Count_Live_Visible, value); }
        }
        int fFinal_Base_Count;
        public int Final_Base_Count
        {
            get { return fFinal_Base_Count; }
            set { SetPropertyValue<int>(nameof(Final_Base_Count), ref fFinal_Base_Count, value); }
        }
        bool fDelete_Flag;
        public bool Delete_Flag
        {
            get { return fDelete_Flag; }
            set { SetPropertyValue<bool>(nameof(Delete_Flag), ref fDelete_Flag, value); }
        }
        bool fShow_Description;
        public bool Show_Description
        {
            get { return fShow_Description; }
            set { SetPropertyValue<bool>(nameof(Show_Description), ref fShow_Description, value); }
        }
        bool fShow_Count_Data;
        public bool Show_Count_Data
        {
            get { return fShow_Count_Data; }
            set { SetPropertyValue<bool>(nameof(Show_Count_Data), ref fShow_Count_Data, value); }
        }
        [Association(@"IC_Inventory_Item_AuditReferencesIC_Inventory_Main_Audit")]
        public XPCollection<IC_Inventory_Item_Audit> IC_Inventory_Item_Audits { get { return GetCollection<IC_Inventory_Item_Audit>(nameof(IC_Inventory_Item_Audits)); } }
    }

}
