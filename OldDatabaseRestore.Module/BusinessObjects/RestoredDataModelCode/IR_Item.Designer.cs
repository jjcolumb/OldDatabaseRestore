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

    public partial class IR_Item : XPLiteObject
    {
        Guid fIR_Item_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid IR_Item_ID
        {
            get { return fIR_Item_ID; }
            set { SetPropertyValue<Guid>(nameof(IR_Item_ID), ref fIR_Item_ID, value); }
        }
        IR_Batch fIR_Batch_ID;
        [Association(@"IR_ItemReferencesIR_Batch")]
        public IR_Batch IR_Batch_ID
        {
            get { return fIR_Batch_ID; }
            set { SetPropertyValue<IR_Batch>(nameof(IR_Batch_ID), ref fIR_Batch_ID, value); }
        }
        IM_Main fIM_Main_ID;
        [Association(@"IR_ItemReferencesIM_Main")]
        public IM_Main IM_Main_ID
        {
            get { return fIM_Main_ID; }
            set { SetPropertyValue<IM_Main>(nameof(IM_Main_ID), ref fIM_Main_ID, value); }
        }
        int fSell_BL;
        public int Sell_BL
        {
            get { return fSell_BL; }
            set { SetPropertyValue<int>(nameof(Sell_BL), ref fSell_BL, value); }
        }
        string fDescription;
        [Size(250)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>(nameof(Description), ref fDescription, value); }
        }
        int fQTY;
        public int QTY
        {
            get { return fQTY; }
            set { SetPropertyValue<int>(nameof(QTY), ref fQTY, value); }
        }
        decimal fLanded_Cost;
        public decimal Landed_Cost
        {
            get { return fLanded_Cost; }
            set { SetPropertyValue<decimal>(nameof(Landed_Cost), ref fLanded_Cost, value); }
        }
        pl_Vessel_Name fpl_Vessel_Name_ID;
        [Association(@"IR_ItemReferencespl_Vessel_Name")]
        public pl_Vessel_Name pl_Vessel_Name_ID
        {
            get { return fpl_Vessel_Name_ID; }
            set { SetPropertyValue<pl_Vessel_Name>(nameof(pl_Vessel_Name_ID), ref fpl_Vessel_Name_ID, value); }
        }
        PO_Main fPO_Main_ID;
        [Association(@"IR_ItemReferencesPO_Main")]
        public PO_Main PO_Main_ID
        {
            get { return fPO_Main_ID; }
            set { SetPropertyValue<PO_Main>(nameof(PO_Main_ID), ref fPO_Main_ID, value); }
        }
        bool fposted;
        public bool posted
        {
            get { return fposted; }
            set { SetPropertyValue<bool>(nameof(posted), ref fposted, value); }
        }
        bool fmanual_item;
        public bool manual_item
        {
            get { return fmanual_item; }
            set { SetPropertyValue<bool>(nameof(manual_item), ref fmanual_item, value); }
        }
    }

}
