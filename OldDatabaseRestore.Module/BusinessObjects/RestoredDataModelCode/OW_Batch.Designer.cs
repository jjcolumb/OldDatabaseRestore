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

    public partial class OW_Batch : XPLiteObject
    {
        Guid fOW_Batch_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid OW_Batch_ID
        {
            get { return fOW_Batch_ID; }
            set { SetPropertyValue<Guid>(nameof(OW_Batch_ID), ref fOW_Batch_ID, value); }
        }
        int fBatch_ID;
        [Indexed(Name = @"IX_OW_Batch_ID")]
        public int Batch_ID
        {
            get { return fBatch_ID; }
            set { SetPropertyValue<int>(nameof(Batch_ID), ref fBatch_ID, value); }
        }
        string fContainer_Number;
        [Size(20)]
        public string Container_Number
        {
            get { return fContainer_Number; }
            set { SetPropertyValue<string>(nameof(Container_Number), ref fContainer_Number, value); }
        }
        pl_Vessel_Name fVessel_ID;
        [Association(@"OW_BatchReferencespl_Vessel_Name")]
        public pl_Vessel_Name Vessel_ID
        {
            get { return fVessel_ID; }
            set { SetPropertyValue<pl_Vessel_Name>(nameof(Vessel_ID), ref fVessel_ID, value); }
        }
        DateTime fExpected_Arrival_Date;
        public DateTime Expected_Arrival_Date
        {
            get { return fExpected_Arrival_Date; }
            set { SetPropertyValue<DateTime>(nameof(Expected_Arrival_Date), ref fExpected_Arrival_Date, value); }
        }
        pl_Vessel_Status fVessel_Status_ID;
        [Association(@"OW_BatchReferencespl_Vessel_Status")]
        public pl_Vessel_Status Vessel_Status_ID
        {
            get { return fVessel_Status_ID; }
            set { SetPropertyValue<pl_Vessel_Status>(nameof(Vessel_Status_ID), ref fVessel_Status_ID, value); }
        }
        DateTime fDate_Entered;
        public DateTime Date_Entered
        {
            get { return fDate_Entered; }
            set { SetPropertyValue<DateTime>(nameof(Date_Entered), ref fDate_Entered, value); }
        }
        bool fDelete_OK;
        public bool Delete_OK
        {
            get { return fDelete_OK; }
            set { SetPropertyValue<bool>(nameof(Delete_OK), ref fDelete_OK, value); }
        }
        [Association(@"IR_BatchReferencesOW_Batch")]
        public XPCollection<IR_Batch> IR_Batchs { get { return GetCollection<IR_Batch>(nameof(IR_Batchs)); } }
    }

}
