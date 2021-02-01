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

    public partial class IA_Main : XPLiteObject
    {
        Guid fIA_Main_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid IA_Main_ID
        {
            get { return fIA_Main_ID; }
            set { SetPropertyValue<Guid>(nameof(IA_Main_ID), ref fIA_Main_ID, value); }
        }
        string fReason;
        [Size(250)]
        public string Reason
        {
            get { return fReason; }
            set { SetPropertyValue<string>(nameof(Reason), ref fReason, value); }
        }
        pl_Adjustment_Types fpl_Adjustment_Types_ID;
        [Association(@"IA_MainReferencespl_Adjustment_Types")]
        public pl_Adjustment_Types pl_Adjustment_Types_ID
        {
            get { return fpl_Adjustment_Types_ID; }
            set { SetPropertyValue<pl_Adjustment_Types>(nameof(pl_Adjustment_Types_ID), ref fpl_Adjustment_Types_ID, value); }
        }
        int fQTY;
        public int QTY
        {
            get { return fQTY; }
            set { SetPropertyValue<int>(nameof(QTY), ref fQTY, value); }
        }
        decimal fCost;
        public decimal Cost
        {
            get { return fCost; }
            set { SetPropertyValue<decimal>(nameof(Cost), ref fCost, value); }
        }
        bool fposted;
        public bool posted
        {
            get { return fposted; }
            set { SetPropertyValue<bool>(nameof(posted), ref fposted, value); }
        }
        IM_Main fIM_Main_ID;
        [Association(@"IA_MainReferencesIM_Main")]
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
        DateTime fDate;
        public DateTime Date
        {
            get { return fDate; }
            set { SetPropertyValue<DateTime>(nameof(Date), ref fDate, value); }
        }
        bool fAuto_Post;
        public bool Auto_Post
        {
            get { return fAuto_Post; }
            set { SetPropertyValue<bool>(nameof(Auto_Post), ref fAuto_Post, value); }
        }
        bool fAllow_Zero_QTY;
        public bool Allow_Zero_QTY
        {
            get { return fAllow_Zero_QTY; }
            set { SetPropertyValue<bool>(nameof(Allow_Zero_QTY), ref fAllow_Zero_QTY, value); }
        }
        bool fAllow_Zero_Cost;
        public bool Allow_Zero_Cost
        {
            get { return fAllow_Zero_Cost; }
            set { SetPropertyValue<bool>(nameof(Allow_Zero_Cost), ref fAllow_Zero_Cost, value); }
        }
        bool fgrid_Item_Visible;
        public bool grid_Item_Visible
        {
            get { return fgrid_Item_Visible; }
            set { SetPropertyValue<bool>(nameof(grid_Item_Visible), ref fgrid_Item_Visible, value); }
        }
        int fQTY_Before;
        public int QTY_Before
        {
            get { return fQTY_Before; }
            set { SetPropertyValue<int>(nameof(QTY_Before), ref fQTY_Before, value); }
        }
        int fQTY_After;
        public int QTY_After
        {
            get { return fQTY_After; }
            set { SetPropertyValue<int>(nameof(QTY_After), ref fQTY_After, value); }
        }
        decimal fCost_Before;
        public decimal Cost_Before
        {
            get { return fCost_Before; }
            set { SetPropertyValue<decimal>(nameof(Cost_Before), ref fCost_Before, value); }
        }
        decimal fCost_After;
        public decimal Cost_After
        {
            get { return fCost_After; }
            set { SetPropertyValue<decimal>(nameof(Cost_After), ref fCost_After, value); }
        }
        Guid fUser_ID;
        public Guid User_ID
        {
            get { return fUser_ID; }
            set { SetPropertyValue<Guid>(nameof(User_ID), ref fUser_ID, value); }
        }
    }

}
