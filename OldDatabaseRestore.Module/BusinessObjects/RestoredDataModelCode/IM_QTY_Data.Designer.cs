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

    public partial class IM_QTY_Data : XPLiteObject
    {
        Guid fIM_QTY_DATA_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid IM_QTY_DATA_ID
        {
            get { return fIM_QTY_DATA_ID; }
            set { SetPropertyValue<Guid>(nameof(IM_QTY_DATA_ID), ref fIM_QTY_DATA_ID, value); }
        }
        Guid fIM_Main_ID;
        [ColumnDbDefaultValue("(newid())")]
        public Guid IM_Main_ID
        {
            get { return fIM_Main_ID; }
            set { SetPropertyValue<Guid>(nameof(IM_Main_ID), ref fIM_Main_ID, value); }
        }
        DateTime fLast_Updated;
        public DateTime Last_Updated
        {
            get { return fLast_Updated; }
            set { SetPropertyValue<DateTime>(nameof(Last_Updated), ref fLast_Updated, value); }
        }
        int fQTY_On_Hand;
        public int QTY_On_Hand
        {
            get { return fQTY_On_Hand; }
            set { SetPropertyValue<int>(nameof(QTY_On_Hand), ref fQTY_On_Hand, value); }
        }
        int fQTY_Ordered;
        public int QTY_Ordered
        {
            get { return fQTY_Ordered; }
            set { SetPropertyValue<int>(nameof(QTY_Ordered), ref fQTY_Ordered, value); }
        }
        int fQTY_In_Picking;
        public int QTY_In_Picking
        {
            get { return fQTY_In_Picking; }
            set { SetPropertyValue<int>(nameof(QTY_In_Picking), ref fQTY_In_Picking, value); }
        }
        int fQTY_Open_Orders;
        public int QTY_Open_Orders
        {
            get { return fQTY_Open_Orders; }
            set { SetPropertyValue<int>(nameof(QTY_Open_Orders), ref fQTY_Open_Orders, value); }
        }
        int fQTY_Open_BOs;
        public int QTY_Open_BOs
        {
            get { return fQTY_Open_BOs; }
            set { SetPropertyValue<int>(nameof(QTY_Open_BOs), ref fQTY_Open_BOs, value); }
        }
        int fQTY_On_Water;
        public int QTY_On_Water
        {
            get { return fQTY_On_Water; }
            set { SetPropertyValue<int>(nameof(QTY_On_Water), ref fQTY_On_Water, value); }
        }
        int fQTY_Remaining;
        public int QTY_Remaining
        {
            get { return fQTY_Remaining; }
            set { SetPropertyValue<int>(nameof(QTY_Remaining), ref fQTY_Remaining, value); }
        }
        int fQTY_Allocated;
        public int QTY_Allocated
        {
            get { return fQTY_Allocated; }
            set { SetPropertyValue<int>(nameof(QTY_Allocated), ref fQTY_Allocated, value); }
        }
        int fQTY_Hold_Order;
        public int QTY_Hold_Order
        {
            get { return fQTY_Hold_Order; }
            set { SetPropertyValue<int>(nameof(QTY_Hold_Order), ref fQTY_Hold_Order, value); }
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
        int fQTY_Required;
        public int QTY_Required
        {
            get { return fQTY_Required; }
            set { SetPropertyValue<int>(nameof(QTY_Required), ref fQTY_Required, value); }
        }
        int fQTY_Surplus;
        public int QTY_Surplus
        {
            get { return fQTY_Surplus; }
            set { SetPropertyValue<int>(nameof(QTY_Surplus), ref fQTY_Surplus, value); }
        }
        int fDefault_BL;
        public int Default_BL
        {
            get { return fDefault_BL; }
            set { SetPropertyValue<int>(nameof(Default_BL), ref fDefault_BL, value); }
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
        int fReorders_MTD;
        public int Reorders_MTD
        {
            get { return fReorders_MTD; }
            set { SetPropertyValue<int>(nameof(Reorders_MTD), ref fReorders_MTD, value); }
        }
        int fReorders_YTD;
        public int Reorders_YTD
        {
            get { return fReorders_YTD; }
            set { SetPropertyValue<int>(nameof(Reorders_YTD), ref fReorders_YTD, value); }
        }
        int fReorders_Line_To_Date;
        public int Reorders_Line_To_Date
        {
            get { return fReorders_Line_To_Date; }
            set { SetPropertyValue<int>(nameof(Reorders_Line_To_Date), ref fReorders_Line_To_Date, value); }
        }
        int fQTY_Before_Inventory_Count;
        public int QTY_Before_Inventory_Count
        {
            get { return fQTY_Before_Inventory_Count; }
            set { SetPropertyValue<int>(nameof(QTY_Before_Inventory_Count), ref fQTY_Before_Inventory_Count, value); }
        }
        string fQTY_On_Hand_Text;
        [Size(25)]
        public string QTY_On_Hand_Text
        {
            get { return fQTY_On_Hand_Text; }
            set { SetPropertyValue<string>(nameof(QTY_On_Hand_Text), ref fQTY_On_Hand_Text, value); }
        }
        string fQTY_Ordered_Text;
        [Size(25)]
        public string QTY_Ordered_Text
        {
            get { return fQTY_Ordered_Text; }
            set { SetPropertyValue<string>(nameof(QTY_Ordered_Text), ref fQTY_Ordered_Text, value); }
        }
        string fQTY_In_Picking_Text;
        [Size(25)]
        public string QTY_In_Picking_Text
        {
            get { return fQTY_In_Picking_Text; }
            set { SetPropertyValue<string>(nameof(QTY_In_Picking_Text), ref fQTY_In_Picking_Text, value); }
        }
        string fQTY_Open_Orders_Text;
        [Size(25)]
        public string QTY_Open_Orders_Text
        {
            get { return fQTY_Open_Orders_Text; }
            set { SetPropertyValue<string>(nameof(QTY_Open_Orders_Text), ref fQTY_Open_Orders_Text, value); }
        }
        string fQTY_Open_BOs_Text;
        [Size(25)]
        public string QTY_Open_BOs_Text
        {
            get { return fQTY_Open_BOs_Text; }
            set { SetPropertyValue<string>(nameof(QTY_Open_BOs_Text), ref fQTY_Open_BOs_Text, value); }
        }
        string fQTY_On_Water_Text;
        [Size(25)]
        public string QTY_On_Water_Text
        {
            get { return fQTY_On_Water_Text; }
            set { SetPropertyValue<string>(nameof(QTY_On_Water_Text), ref fQTY_On_Water_Text, value); }
        }
        string fQTY_Remaining_Text;
        [Size(25)]
        public string QTY_Remaining_Text
        {
            get { return fQTY_Remaining_Text; }
            set { SetPropertyValue<string>(nameof(QTY_Remaining_Text), ref fQTY_Remaining_Text, value); }
        }
        string fQTY_Allocated_Text;
        [Size(25)]
        public string QTY_Allocated_Text
        {
            get { return fQTY_Allocated_Text; }
            set { SetPropertyValue<string>(nameof(QTY_Allocated_Text), ref fQTY_Allocated_Text, value); }
        }
        string fQTY_Hold_Order_Text;
        [Size(25)]
        public string QTY_Hold_Order_Text
        {
            get { return fQTY_Hold_Order_Text; }
            set { SetPropertyValue<string>(nameof(QTY_Hold_Order_Text), ref fQTY_Hold_Order_Text, value); }
        }
        string fQTY_On_Hold_Internally_Text;
        [Size(25)]
        public string QTY_On_Hold_Internally_Text
        {
            get { return fQTY_On_Hold_Internally_Text; }
            set { SetPropertyValue<string>(nameof(QTY_On_Hold_Internally_Text), ref fQTY_On_Hold_Internally_Text, value); }
        }
        string fQTY_Defective_Text;
        [Size(25)]
        public string QTY_Defective_Text
        {
            get { return fQTY_Defective_Text; }
            set { SetPropertyValue<string>(nameof(QTY_Defective_Text), ref fQTY_Defective_Text, value); }
        }
        string fQTY_Required_Text;
        [Size(25)]
        public string QTY_Required_Text
        {
            get { return fQTY_Required_Text; }
            set { SetPropertyValue<string>(nameof(QTY_Required_Text), ref fQTY_Required_Text, value); }
        }
        string fQTY_Surplus_Text;
        [Size(25)]
        public string QTY_Surplus_Text
        {
            get { return fQTY_Surplus_Text; }
            set { SetPropertyValue<string>(nameof(QTY_Surplus_Text), ref fQTY_Surplus_Text, value); }
        }
        string fQTY_At_Inventory_Count_Text;
        [Size(25)]
        public string QTY_At_Inventory_Count_Text
        {
            get { return fQTY_At_Inventory_Count_Text; }
            set { SetPropertyValue<string>(nameof(QTY_At_Inventory_Count_Text), ref fQTY_At_Inventory_Count_Text, value); }
        }
        string fReorders_MTD_Text;
        [Size(25)]
        public string Reorders_MTD_Text
        {
            get { return fReorders_MTD_Text; }
            set { SetPropertyValue<string>(nameof(Reorders_MTD_Text), ref fReorders_MTD_Text, value); }
        }
        string fReorders_YTD_Text;
        [Size(25)]
        public string Reorders_YTD_Text
        {
            get { return fReorders_YTD_Text; }
            set { SetPropertyValue<string>(nameof(Reorders_YTD_Text), ref fReorders_YTD_Text, value); }
        }
        string fReorders_Line_To_Date_Text;
        [Size(25)]
        public string Reorders_Line_To_Date_Text
        {
            get { return fReorders_Line_To_Date_Text; }
            set { SetPropertyValue<string>(nameof(Reorders_Line_To_Date_Text), ref fReorders_Line_To_Date_Text, value); }
        }
        string fQTY_Before_Inventory_Count_Text;
        [Size(25)]
        public string QTY_Before_Inventory_Count_Text
        {
            get { return fQTY_Before_Inventory_Count_Text; }
            set { SetPropertyValue<string>(nameof(QTY_Before_Inventory_Count_Text), ref fQTY_Before_Inventory_Count_Text, value); }
        }
    }

}
