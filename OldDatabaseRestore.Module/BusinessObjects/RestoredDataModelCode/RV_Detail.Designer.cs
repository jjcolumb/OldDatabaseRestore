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

    public partial class RV_Detail : XPLiteObject
    {
        Guid fRV_Detail_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid RV_Detail_ID
        {
            get { return fRV_Detail_ID; }
            set { SetPropertyValue<Guid>(nameof(RV_Detail_ID), ref fRV_Detail_ID, value); }
        }
        int fReport_ID;
        public int Report_ID
        {
            get { return fReport_ID; }
            set { SetPropertyValue<int>(nameof(Report_ID), ref fReport_ID, value); }
        }
        string fReport_Name;
        [Size(50)]
        public string Report_Name
        {
            get { return fReport_Name; }
            set { SetPropertyValue<string>(nameof(Report_Name), ref fReport_Name, value); }
        }
        Guid fBatch_ID;
        public Guid Batch_ID
        {
            get { return fBatch_ID; }
            set { SetPropertyValue<Guid>(nameof(Batch_ID), ref fBatch_ID, value); }
        }
        DateTime fBatch_Time_Date;
        public DateTime Batch_Time_Date
        {
            get { return fBatch_Time_Date; }
            set { SetPropertyValue<DateTime>(nameof(Batch_Time_Date), ref fBatch_Time_Date, value); }
        }
        bool fBatch_Active;
        public bool Batch_Active
        {
            get { return fBatch_Active; }
            set { SetPropertyValue<bool>(nameof(Batch_Active), ref fBatch_Active, value); }
        }
        bool fBatch_Update_Needed;
        public bool Batch_Update_Needed
        {
            get { return fBatch_Update_Needed; }
            set { SetPropertyValue<bool>(nameof(Batch_Update_Needed), ref fBatch_Update_Needed, value); }
        }
        bool fBatch_Update_Processed;
        public bool Batch_Update_Processed
        {
            get { return fBatch_Update_Processed; }
            set { SetPropertyValue<bool>(nameof(Batch_Update_Processed), ref fBatch_Update_Processed, value); }
        }
        Guid fItem_ID;
        public Guid Item_ID
        {
            get { return fItem_ID; }
            set { SetPropertyValue<Guid>(nameof(Item_ID), ref fItem_ID, value); }
        }
    }

}
