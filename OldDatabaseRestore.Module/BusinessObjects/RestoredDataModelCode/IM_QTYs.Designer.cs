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

    public partial class IM_QTYs : XPLiteObject
    {
        Guid fIM_QTYs_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid IM_QTYs_ID
        {
            get { return fIM_QTYs_ID; }
            set { SetPropertyValue<Guid>(nameof(IM_QTYs_ID), ref fIM_QTYs_ID, value); }
        }
        IM_Main fIM_Main_ID;
        [Association(@"IM_QTYsReferencesIM_Main")]
        public IM_Main IM_Main_ID
        {
            get { return fIM_Main_ID; }
            set { SetPropertyValue<IM_Main>(nameof(IM_Main_ID), ref fIM_Main_ID, value); }
        }
        int fQTY_On_Hand;
        public int QTY_On_Hand
        {
            get { return fQTY_On_Hand; }
            set { SetPropertyValue<int>(nameof(QTY_On_Hand), ref fQTY_On_Hand, value); }
        }
        int fQTY_On_Order;
        public int QTY_On_Order
        {
            get { return fQTY_On_Order; }
            set { SetPropertyValue<int>(nameof(QTY_On_Order), ref fQTY_On_Order, value); }
        }
        int fQTY_Allocated;
        public int QTY_Allocated
        {
            get { return fQTY_Allocated; }
            set { SetPropertyValue<int>(nameof(QTY_Allocated), ref fQTY_Allocated, value); }
        }
        int fQTY_On_Hold_Customers;
        public int QTY_On_Hold_Customers
        {
            get { return fQTY_On_Hold_Customers; }
            set { SetPropertyValue<int>(nameof(QTY_On_Hold_Customers), ref fQTY_On_Hold_Customers, value); }
        }
        int fQTY_On_Hold_Internally;
        public int QTY_On_Hold_Internally
        {
            get { return fQTY_On_Hold_Internally; }
            set { SetPropertyValue<int>(nameof(QTY_On_Hold_Internally), ref fQTY_On_Hold_Internally, value); }
        }
        int fQTY_Defective;
        public int QTY_Defective
        {
            get { return fQTY_Defective; }
            set { SetPropertyValue<int>(nameof(QTY_Defective), ref fQTY_Defective, value); }
        }
        int fQTY_In_Pick;
        public int QTY_In_Pick
        {
            get { return fQTY_In_Pick; }
            set { SetPropertyValue<int>(nameof(QTY_In_Pick), ref fQTY_In_Pick, value); }
        }
        int fQTY_Open_Orders;
        public int QTY_Open_Orders
        {
            get { return fQTY_Open_Orders; }
            set { SetPropertyValue<int>(nameof(QTY_Open_Orders), ref fQTY_Open_Orders, value); }
        }
        int fQTY_BOs_of_Open;
        public int QTY_BOs_of_Open
        {
            get { return fQTY_BOs_of_Open; }
            set { SetPropertyValue<int>(nameof(QTY_BOs_of_Open), ref fQTY_BOs_of_Open, value); }
        }
        int fQTY_On_Order_with_Suppliers;
        public int QTY_On_Order_with_Suppliers
        {
            get { return fQTY_On_Order_with_Suppliers; }
            set { SetPropertyValue<int>(nameof(QTY_On_Order_with_Suppliers), ref fQTY_On_Order_with_Suppliers, value); }
        }
        int fQTY_On_The_Water;
        public int QTY_On_The_Water
        {
            get { return fQTY_On_The_Water; }
            set { SetPropertyValue<int>(nameof(QTY_On_The_Water), ref fQTY_On_The_Water, value); }
        }
        int fQTY_At_Inventory_Count;
        public int QTY_At_Inventory_Count
        {
            get { return fQTY_At_Inventory_Count; }
            set { SetPropertyValue<int>(nameof(QTY_At_Inventory_Count), ref fQTY_At_Inventory_Count, value); }
        }
        DateTime fDate_Of_Inventory_Count;
        public DateTime Date_Of_Inventory_Count
        {
            get { return fDate_Of_Inventory_Count; }
            set { SetPropertyValue<DateTime>(nameof(Date_Of_Inventory_Count), ref fDate_Of_Inventory_Count, value); }
        }
        int fQTY_Last_Received;
        public int QTY_Last_Received
        {
            get { return fQTY_Last_Received; }
            set { SetPropertyValue<int>(nameof(QTY_Last_Received), ref fQTY_Last_Received, value); }
        }
        int fQTY_Received_MTD;
        public int QTY_Received_MTD
        {
            get { return fQTY_Received_MTD; }
            set { SetPropertyValue<int>(nameof(QTY_Received_MTD), ref fQTY_Received_MTD, value); }
        }
        int fQTY_Received_YTD;
        public int QTY_Received_YTD
        {
            get { return fQTY_Received_YTD; }
            set { SetPropertyValue<int>(nameof(QTY_Received_YTD), ref fQTY_Received_YTD, value); }
        }
        int fScheduled_To_Be_Deleted;
        public int Scheduled_To_Be_Deleted
        {
            get { return fScheduled_To_Be_Deleted; }
            set { SetPropertyValue<int>(nameof(Scheduled_To_Be_Deleted), ref fScheduled_To_Be_Deleted, value); }
        }
        int fReCount_Active;
        public int ReCount_Active
        {
            get { return fReCount_Active; }
            set { SetPropertyValue<int>(nameof(ReCount_Active), ref fReCount_Active, value); }
        }
        int fJob_Lot_Item;
        public int Job_Lot_Item
        {
            get { return fJob_Lot_Item; }
            set { SetPropertyValue<int>(nameof(Job_Lot_Item), ref fJob_Lot_Item, value); }
        }
        int fDelete_Item_EOY;
        public int Delete_Item_EOY
        {
            get { return fDelete_Item_EOY; }
            set { SetPropertyValue<int>(nameof(Delete_Item_EOY), ref fDelete_Item_EOY, value); }
        }
        int fAccepted_OK;
        public int Accepted_OK
        {
            get { return fAccepted_OK; }
            set { SetPropertyValue<int>(nameof(Accepted_OK), ref fAccepted_OK, value); }
        }
        int fQTY_Temp;
        public int QTY_Temp
        {
            get { return fQTY_Temp; }
            set { SetPropertyValue<int>(nameof(QTY_Temp), ref fQTY_Temp, value); }
        }
        int fDelete_Item_EOY_Problem;
        public int Delete_Item_EOY_Problem
        {
            get { return fDelete_Item_EOY_Problem; }
            set { SetPropertyValue<int>(nameof(Delete_Item_EOY_Problem), ref fDelete_Item_EOY_Problem, value); }
        }
        int fQTY_Before_Inventory_Count;
        public int QTY_Before_Inventory_Count
        {
            get { return fQTY_Before_Inventory_Count; }
            set { SetPropertyValue<int>(nameof(QTY_Before_Inventory_Count), ref fQTY_Before_Inventory_Count, value); }
        }
        int fIcon_Check_Flag;
        public int Icon_Check_Flag
        {
            get { return fIcon_Check_Flag; }
            set { SetPropertyValue<int>(nameof(Icon_Check_Flag), ref fIcon_Check_Flag, value); }
        }
        bool fQTYs_Found;
        public bool QTYs_Found
        {
            get { return fQTYs_Found; }
            set { SetPropertyValue<bool>(nameof(QTYs_Found), ref fQTYs_Found, value); }
        }
    }

}
