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

    public partial class PO_Main : XPLiteObject
    {
        Guid fPO_Main_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid PO_Main_ID
        {
            get { return fPO_Main_ID; }
            set { SetPropertyValue<Guid>(nameof(PO_Main_ID), ref fPO_Main_ID, value); }
        }
        SD_Main fSD_Main_ID;
        [Association(@"PO_MainReferencesSD_Main")]
        public SD_Main SD_Main_ID
        {
            get { return fSD_Main_ID; }
            set { SetPropertyValue<SD_Main>(nameof(SD_Main_ID), ref fSD_Main_ID, value); }
        }
        int fOld_PO_Number;
        public int Old_PO_Number
        {
            get { return fOld_PO_Number; }
            set { SetPropertyValue<int>(nameof(Old_PO_Number), ref fOld_PO_Number, value); }
        }
        string fPO_Number;
        [Size(20)]
        public string PO_Number
        {
            get { return fPO_Number; }
            set { SetPropertyValue<string>(nameof(PO_Number), ref fPO_Number, value); }
        }
        pl_PO_Status fStatus;
        [Association(@"PO_MainReferencespl_PO_Status")]
        public pl_PO_Status Status
        {
            get { return fStatus; }
            set { SetPropertyValue<pl_PO_Status>(nameof(Status), ref fStatus, value); }
        }
        int fPrint_PO_Status;
        public int Print_PO_Status
        {
            get { return fPrint_PO_Status; }
            set { SetPropertyValue<int>(nameof(Print_PO_Status), ref fPrint_PO_Status, value); }
        }
        DateTime fPrint_PO_Date;
        public DateTime Print_PO_Date
        {
            get { return fPrint_PO_Date; }
            set { SetPropertyValue<DateTime>(nameof(Print_PO_Date), ref fPrint_PO_Date, value); }
        }
        int fPrint_Fly_Status;
        public int Print_Fly_Status
        {
            get { return fPrint_Fly_Status; }
            set { SetPropertyValue<int>(nameof(Print_Fly_Status), ref fPrint_Fly_Status, value); }
        }
        DateTime fPrint_Fly_Date;
        public DateTime Print_Fly_Date
        {
            get { return fPrint_Fly_Date; }
            set { SetPropertyValue<DateTime>(nameof(Print_Fly_Date), ref fPrint_Fly_Date, value); }
        }
        pl_PO_Type fPO_Type;
        [Association(@"PO_MainReferencespl_PO_Type")]
        public pl_PO_Type PO_Type
        {
            get { return fPO_Type; }
            set { SetPropertyValue<pl_PO_Type>(nameof(PO_Type), ref fPO_Type, value); }
        }
        UD_Main fUD_Main_ID;
        [Association(@"PO_MainReferencesUD_Main")]
        public UD_Main UD_Main_ID
        {
            get { return fUD_Main_ID; }
            set { SetPropertyValue<UD_Main>(nameof(UD_Main_ID), ref fUD_Main_ID, value); }
        }
        DateTime fDate_Created;
        public DateTime Date_Created
        {
            get { return fDate_Created; }
            set { SetPropertyValue<DateTime>(nameof(Date_Created), ref fDate_Created, value); }
        }
        DateTime fDate_Last_RCVD;
        public DateTime Date_Last_RCVD
        {
            get { return fDate_Last_RCVD; }
            set { SetPropertyValue<DateTime>(nameof(Date_Last_RCVD), ref fDate_Last_RCVD, value); }
        }
        DateTime fDate_Closed;
        public DateTime Date_Closed
        {
            get { return fDate_Closed; }
            set { SetPropertyValue<DateTime>(nameof(Date_Closed), ref fDate_Closed, value); }
        }
        DateTime fCancel_Date;
        public DateTime Cancel_Date
        {
            get { return fCancel_Date; }
            set { SetPropertyValue<DateTime>(nameof(Cancel_Date), ref fCancel_Date, value); }
        }
        decimal fAmount_First_Cost;
        public decimal Amount_First_Cost
        {
            get { return fAmount_First_Cost; }
            set { SetPropertyValue<decimal>(nameof(Amount_First_Cost), ref fAmount_First_Cost, value); }
        }
        decimal fAmount_Landed_Cost;
        public decimal Amount_Landed_Cost
        {
            get { return fAmount_Landed_Cost; }
            set { SetPropertyValue<decimal>(nameof(Amount_Landed_Cost), ref fAmount_Landed_Cost, value); }
        }
        DateTime fPO_Date_Ordered;
        public DateTime PO_Date_Ordered
        {
            get { return fPO_Date_Ordered; }
            set { SetPropertyValue<DateTime>(nameof(PO_Date_Ordered), ref fPO_Date_Ordered, value); }
        }
        pl_Overseas_Terms fOverseas_Terms;
        [Association(@"PO_MainReferencespl_Overseas_Terms")]
        public pl_Overseas_Terms Overseas_Terms
        {
            get { return fOverseas_Terms; }
            set { SetPropertyValue<pl_Overseas_Terms>(nameof(Overseas_Terms), ref fOverseas_Terms, value); }
        }
        DateTime fShip_Date;
        public DateTime Ship_Date
        {
            get { return fShip_Date; }
            set { SetPropertyValue<DateTime>(nameof(Ship_Date), ref fShip_Date, value); }
        }
        pl_Overseas_Ship_Via fOverseas_Ship_Via;
        [Association(@"PO_MainReferencespl_Overseas_Ship_Via")]
        public pl_Overseas_Ship_Via Overseas_Ship_Via
        {
            get { return fOverseas_Ship_Via; }
            set { SetPropertyValue<pl_Overseas_Ship_Via>(nameof(Overseas_Ship_Via), ref fOverseas_Ship_Via, value); }
        }
        Guid fDP_Main_ID;
        public Guid DP_Main_ID
        {
            get { return fDP_Main_ID; }
            set { SetPropertyValue<Guid>(nameof(DP_Main_ID), ref fDP_Main_ID, value); }
        }
        PE_Main fPE_Main_ID;
        [Association(@"PO_MainReferencesPE_Main")]
        public PE_Main PE_Main_ID
        {
            get { return fPE_Main_ID; }
            set { SetPropertyValue<PE_Main>(nameof(PE_Main_ID), ref fPE_Main_ID, value); }
        }
        string fFOB_Other;
        [Size(50)]
        public string FOB_Other
        {
            get { return fFOB_Other; }
            set { SetPropertyValue<string>(nameof(FOB_Other), ref fFOB_Other, value); }
        }
        DateTime fCreated_Date_Time;
        public DateTime Created_Date_Time
        {
            get { return fCreated_Date_Time; }
            set { SetPropertyValue<DateTime>(nameof(Created_Date_Time), ref fCreated_Date_Time, value); }
        }
        int fCreated_Station;
        public int Created_Station
        {
            get { return fCreated_Station; }
            set { SetPropertyValue<int>(nameof(Created_Station), ref fCreated_Station, value); }
        }
        DateTime fModifiedFlag;
        public DateTime ModifiedFlag
        {
            get { return fModifiedFlag; }
            set { SetPropertyValue<DateTime>(nameof(ModifiedFlag), ref fModifiedFlag, value); }
        }
        pl_Port_Of_Entry fPort_Of_Entry;
        [Association(@"PO_MainReferencespl_Port_Of_Entry")]
        public pl_Port_Of_Entry Port_Of_Entry
        {
            get { return fPort_Of_Entry; }
            set { SetPropertyValue<pl_Port_Of_Entry>(nameof(Port_Of_Entry), ref fPort_Of_Entry, value); }
        }
        DP_Main fPort;
        [Association(@"PO_MainReferencesDP_Main")]
        public DP_Main Port
        {
            get { return fPort; }
            set { SetPropertyValue<DP_Main>(nameof(Port), ref fPort, value); }
        }
        bool fQuePrint;
        [ColumnDbDefaultValue("((0))")]
        public bool QuePrint
        {
            get { return fQuePrint; }
            set { SetPropertyValue<bool>(nameof(QuePrint), ref fQuePrint, value); }
        }
        bool fQuePrintFly;
        [ColumnDbDefaultValue("((0))")]
        public bool QuePrintFly
        {
            get { return fQuePrintFly; }
            set { SetPropertyValue<bool>(nameof(QuePrintFly), ref fQuePrintFly, value); }
        }
        bool fQueInsertItems;
        [ColumnDbDefaultValue("((0))")]
        public bool QueInsertItems
        {
            get { return fQueInsertItems; }
            set { SetPropertyValue<bool>(nameof(QueInsertItems), ref fQueInsertItems, value); }
        }
        int ftempFlag;
        public int tempFlag
        {
            get { return ftempFlag; }
            set { SetPropertyValue<int>(nameof(tempFlag), ref ftempFlag, value); }
        }
        decimal fmysort;
        public decimal mysort
        {
            get { return fmysort; }
            set { SetPropertyValue<decimal>(nameof(mysort), ref fmysort, value); }
        }
        [Association(@"IR_BatchReferencesPO_Main")]
        public XPCollection<IR_Batch> IR_Batchs { get { return GetCollection<IR_Batch>(nameof(IR_Batchs)); } }
        [Association(@"IR_ItemReferencesPO_Main")]
        public XPCollection<IR_Item> IR_Items { get { return GetCollection<IR_Item>(nameof(IR_Items)); } }
        [Association(@"IR_MainReferencesPO_Main")]
        public XPCollection<IR_Main> IR_Mains { get { return GetCollection<IR_Main>(nameof(IR_Mains)); } }
        [Association(@"PO_Line_ItemsReferencesPO_Main")]
        public XPCollection<PO_Line_Items> PO_Line_Itemss { get { return GetCollection<PO_Line_Items>(nameof(PO_Line_Itemss)); } }
        [Association(@"PO_X_Line_ItemsReferencesPO_Main")]
        public XPCollection<PO_X_Line_Items> PO_X_Line_Itemss { get { return GetCollection<PO_X_Line_Items>(nameof(PO_X_Line_Itemss)); } }
    }

}
