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

    public partial class CM_History_Sales_Data : XPLiteObject
    {
        Guid fCM_History_Sales_Data_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid CM_History_Sales_Data_ID
        {
            get { return fCM_History_Sales_Data_ID; }
            set { SetPropertyValue<Guid>(nameof(CM_History_Sales_Data_ID), ref fCM_History_Sales_Data_ID, value); }
        }
        int fDatabase_Index;
        public int Database_Index
        {
            get { return fDatabase_Index; }
            set { SetPropertyValue<int>(nameof(Database_Index), ref fDatabase_Index, value); }
        }
        int fScheduled_Move_or_Delete;
        public int Scheduled_Move_or_Delete
        {
            get { return fScheduled_Move_or_Delete; }
            set { SetPropertyValue<int>(nameof(Scheduled_Move_or_Delete), ref fScheduled_Move_or_Delete, value); }
        }
        bool fRecord_Closed;
        public bool Record_Closed
        {
            get { return fRecord_Closed; }
            set { SetPropertyValue<bool>(nameof(Record_Closed), ref fRecord_Closed, value); }
        }
        Guid fCM_Main_ID;
        public Guid CM_Main_ID
        {
            get { return fCM_Main_ID; }
            set { SetPropertyValue<Guid>(nameof(CM_Main_ID), ref fCM_Main_ID, value); }
        }
        int fYear_Invoiced;
        public int Year_Invoiced
        {
            get { return fYear_Invoiced; }
            set { SetPropertyValue<int>(nameof(Year_Invoiced), ref fYear_Invoiced, value); }
        }
        int fSales_Count_01;
        public int Sales_Count_01
        {
            get { return fSales_Count_01; }
            set { SetPropertyValue<int>(nameof(Sales_Count_01), ref fSales_Count_01, value); }
        }
        int fSales_Count_02;
        public int Sales_Count_02
        {
            get { return fSales_Count_02; }
            set { SetPropertyValue<int>(nameof(Sales_Count_02), ref fSales_Count_02, value); }
        }
        int fSales_Count_03;
        public int Sales_Count_03
        {
            get { return fSales_Count_03; }
            set { SetPropertyValue<int>(nameof(Sales_Count_03), ref fSales_Count_03, value); }
        }
        int fSales_Count_04;
        public int Sales_Count_04
        {
            get { return fSales_Count_04; }
            set { SetPropertyValue<int>(nameof(Sales_Count_04), ref fSales_Count_04, value); }
        }
        int fSales_Count_05;
        public int Sales_Count_05
        {
            get { return fSales_Count_05; }
            set { SetPropertyValue<int>(nameof(Sales_Count_05), ref fSales_Count_05, value); }
        }
        int fSales_Count_06;
        public int Sales_Count_06
        {
            get { return fSales_Count_06; }
            set { SetPropertyValue<int>(nameof(Sales_Count_06), ref fSales_Count_06, value); }
        }
        int fSales_Count_07;
        public int Sales_Count_07
        {
            get { return fSales_Count_07; }
            set { SetPropertyValue<int>(nameof(Sales_Count_07), ref fSales_Count_07, value); }
        }
        int fSales_Count_08;
        public int Sales_Count_08
        {
            get { return fSales_Count_08; }
            set { SetPropertyValue<int>(nameof(Sales_Count_08), ref fSales_Count_08, value); }
        }
        int fSales_Count_09;
        public int Sales_Count_09
        {
            get { return fSales_Count_09; }
            set { SetPropertyValue<int>(nameof(Sales_Count_09), ref fSales_Count_09, value); }
        }
        int fSales_Count_10;
        public int Sales_Count_10
        {
            get { return fSales_Count_10; }
            set { SetPropertyValue<int>(nameof(Sales_Count_10), ref fSales_Count_10, value); }
        }
        int fSales_Count_11;
        public int Sales_Count_11
        {
            get { return fSales_Count_11; }
            set { SetPropertyValue<int>(nameof(Sales_Count_11), ref fSales_Count_11, value); }
        }
        int fSales_Count_12;
        public int Sales_Count_12
        {
            get { return fSales_Count_12; }
            set { SetPropertyValue<int>(nameof(Sales_Count_12), ref fSales_Count_12, value); }
        }
        int fSales_Count_YTD;
        public int Sales_Count_YTD
        {
            get { return fSales_Count_YTD; }
            set { SetPropertyValue<int>(nameof(Sales_Count_YTD), ref fSales_Count_YTD, value); }
        }
        int fBackOrder_Count_01;
        public int BackOrder_Count_01
        {
            get { return fBackOrder_Count_01; }
            set { SetPropertyValue<int>(nameof(BackOrder_Count_01), ref fBackOrder_Count_01, value); }
        }
        int fBackOrder_Count_02;
        public int BackOrder_Count_02
        {
            get { return fBackOrder_Count_02; }
            set { SetPropertyValue<int>(nameof(BackOrder_Count_02), ref fBackOrder_Count_02, value); }
        }
        int fBackOrder_Count_03;
        public int BackOrder_Count_03
        {
            get { return fBackOrder_Count_03; }
            set { SetPropertyValue<int>(nameof(BackOrder_Count_03), ref fBackOrder_Count_03, value); }
        }
        int fBackOrder_Count_04;
        public int BackOrder_Count_04
        {
            get { return fBackOrder_Count_04; }
            set { SetPropertyValue<int>(nameof(BackOrder_Count_04), ref fBackOrder_Count_04, value); }
        }
        int fBackOrder_Count_05;
        public int BackOrder_Count_05
        {
            get { return fBackOrder_Count_05; }
            set { SetPropertyValue<int>(nameof(BackOrder_Count_05), ref fBackOrder_Count_05, value); }
        }
        int fBackOrder_Count_06;
        public int BackOrder_Count_06
        {
            get { return fBackOrder_Count_06; }
            set { SetPropertyValue<int>(nameof(BackOrder_Count_06), ref fBackOrder_Count_06, value); }
        }
        int fBackOrder_Count_07;
        public int BackOrder_Count_07
        {
            get { return fBackOrder_Count_07; }
            set { SetPropertyValue<int>(nameof(BackOrder_Count_07), ref fBackOrder_Count_07, value); }
        }
        int fBackOrder_Count_08;
        public int BackOrder_Count_08
        {
            get { return fBackOrder_Count_08; }
            set { SetPropertyValue<int>(nameof(BackOrder_Count_08), ref fBackOrder_Count_08, value); }
        }
        int fBackOrder_Count_09;
        public int BackOrder_Count_09
        {
            get { return fBackOrder_Count_09; }
            set { SetPropertyValue<int>(nameof(BackOrder_Count_09), ref fBackOrder_Count_09, value); }
        }
        int fBackOrder_Count_10;
        public int BackOrder_Count_10
        {
            get { return fBackOrder_Count_10; }
            set { SetPropertyValue<int>(nameof(BackOrder_Count_10), ref fBackOrder_Count_10, value); }
        }
        int fBackOrder_Count_11;
        public int BackOrder_Count_11
        {
            get { return fBackOrder_Count_11; }
            set { SetPropertyValue<int>(nameof(BackOrder_Count_11), ref fBackOrder_Count_11, value); }
        }
        int fBackOrder_Count_12;
        public int BackOrder_Count_12
        {
            get { return fBackOrder_Count_12; }
            set { SetPropertyValue<int>(nameof(BackOrder_Count_12), ref fBackOrder_Count_12, value); }
        }
        int fBackorder_Count_YTD;
        public int Backorder_Count_YTD
        {
            get { return fBackorder_Count_YTD; }
            set { SetPropertyValue<int>(nameof(Backorder_Count_YTD), ref fBackorder_Count_YTD, value); }
        }
        decimal fSales_01;
        public decimal Sales_01
        {
            get { return fSales_01; }
            set { SetPropertyValue<decimal>(nameof(Sales_01), ref fSales_01, value); }
        }
        decimal fSales_02;
        public decimal Sales_02
        {
            get { return fSales_02; }
            set { SetPropertyValue<decimal>(nameof(Sales_02), ref fSales_02, value); }
        }
        decimal fSales_03;
        public decimal Sales_03
        {
            get { return fSales_03; }
            set { SetPropertyValue<decimal>(nameof(Sales_03), ref fSales_03, value); }
        }
        decimal fSales_04;
        public decimal Sales_04
        {
            get { return fSales_04; }
            set { SetPropertyValue<decimal>(nameof(Sales_04), ref fSales_04, value); }
        }
        decimal fSales_05;
        public decimal Sales_05
        {
            get { return fSales_05; }
            set { SetPropertyValue<decimal>(nameof(Sales_05), ref fSales_05, value); }
        }
        decimal fSales_06;
        public decimal Sales_06
        {
            get { return fSales_06; }
            set { SetPropertyValue<decimal>(nameof(Sales_06), ref fSales_06, value); }
        }
        decimal fSales_07;
        public decimal Sales_07
        {
            get { return fSales_07; }
            set { SetPropertyValue<decimal>(nameof(Sales_07), ref fSales_07, value); }
        }
        decimal fSales_08;
        public decimal Sales_08
        {
            get { return fSales_08; }
            set { SetPropertyValue<decimal>(nameof(Sales_08), ref fSales_08, value); }
        }
        decimal fSales_09;
        public decimal Sales_09
        {
            get { return fSales_09; }
            set { SetPropertyValue<decimal>(nameof(Sales_09), ref fSales_09, value); }
        }
        decimal fSales_10;
        public decimal Sales_10
        {
            get { return fSales_10; }
            set { SetPropertyValue<decimal>(nameof(Sales_10), ref fSales_10, value); }
        }
        decimal fSales_11;
        public decimal Sales_11
        {
            get { return fSales_11; }
            set { SetPropertyValue<decimal>(nameof(Sales_11), ref fSales_11, value); }
        }
        decimal fSales_12;
        public decimal Sales_12
        {
            get { return fSales_12; }
            set { SetPropertyValue<decimal>(nameof(Sales_12), ref fSales_12, value); }
        }
        decimal fSales_YTD;
        public decimal Sales_YTD
        {
            get { return fSales_YTD; }
            set { SetPropertyValue<decimal>(nameof(Sales_YTD), ref fSales_YTD, value); }
        }
        decimal fCost_01;
        public decimal Cost_01
        {
            get { return fCost_01; }
            set { SetPropertyValue<decimal>(nameof(Cost_01), ref fCost_01, value); }
        }
        decimal fCost_02;
        public decimal Cost_02
        {
            get { return fCost_02; }
            set { SetPropertyValue<decimal>(nameof(Cost_02), ref fCost_02, value); }
        }
        decimal fCost_03;
        public decimal Cost_03
        {
            get { return fCost_03; }
            set { SetPropertyValue<decimal>(nameof(Cost_03), ref fCost_03, value); }
        }
        decimal fCost_04;
        public decimal Cost_04
        {
            get { return fCost_04; }
            set { SetPropertyValue<decimal>(nameof(Cost_04), ref fCost_04, value); }
        }
        decimal fCost_05;
        public decimal Cost_05
        {
            get { return fCost_05; }
            set { SetPropertyValue<decimal>(nameof(Cost_05), ref fCost_05, value); }
        }
        decimal fCost_06;
        public decimal Cost_06
        {
            get { return fCost_06; }
            set { SetPropertyValue<decimal>(nameof(Cost_06), ref fCost_06, value); }
        }
        decimal fCost_07;
        public decimal Cost_07
        {
            get { return fCost_07; }
            set { SetPropertyValue<decimal>(nameof(Cost_07), ref fCost_07, value); }
        }
        decimal fCost_08;
        public decimal Cost_08
        {
            get { return fCost_08; }
            set { SetPropertyValue<decimal>(nameof(Cost_08), ref fCost_08, value); }
        }
        decimal fCost_09;
        public decimal Cost_09
        {
            get { return fCost_09; }
            set { SetPropertyValue<decimal>(nameof(Cost_09), ref fCost_09, value); }
        }
        decimal fCost_10;
        public decimal Cost_10
        {
            get { return fCost_10; }
            set { SetPropertyValue<decimal>(nameof(Cost_10), ref fCost_10, value); }
        }
        decimal fCost_11;
        public decimal Cost_11
        {
            get { return fCost_11; }
            set { SetPropertyValue<decimal>(nameof(Cost_11), ref fCost_11, value); }
        }
        decimal fCost_12;
        public decimal Cost_12
        {
            get { return fCost_12; }
            set { SetPropertyValue<decimal>(nameof(Cost_12), ref fCost_12, value); }
        }
        decimal fCost_YTD;
        public decimal Cost_YTD
        {
            get { return fCost_YTD; }
            set { SetPropertyValue<decimal>(nameof(Cost_YTD), ref fCost_YTD, value); }
        }
        decimal fSales_GP_01;
        public decimal Sales_GP_01
        {
            get { return fSales_GP_01; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_01), ref fSales_GP_01, value); }
        }
        decimal fSales_GP_02;
        public decimal Sales_GP_02
        {
            get { return fSales_GP_02; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_02), ref fSales_GP_02, value); }
        }
        decimal fSales_GP_03;
        public decimal Sales_GP_03
        {
            get { return fSales_GP_03; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_03), ref fSales_GP_03, value); }
        }
        decimal fSales_GP_04;
        public decimal Sales_GP_04
        {
            get { return fSales_GP_04; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_04), ref fSales_GP_04, value); }
        }
        decimal fSales_GP_05;
        public decimal Sales_GP_05
        {
            get { return fSales_GP_05; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_05), ref fSales_GP_05, value); }
        }
        decimal fSales_GP_06;
        public decimal Sales_GP_06
        {
            get { return fSales_GP_06; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_06), ref fSales_GP_06, value); }
        }
        decimal fSales_GP_07;
        public decimal Sales_GP_07
        {
            get { return fSales_GP_07; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_07), ref fSales_GP_07, value); }
        }
        decimal fSales_GP_08;
        public decimal Sales_GP_08
        {
            get { return fSales_GP_08; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_08), ref fSales_GP_08, value); }
        }
        decimal fSales_GP_09;
        public decimal Sales_GP_09
        {
            get { return fSales_GP_09; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_09), ref fSales_GP_09, value); }
        }
        decimal fSales_GP_10;
        public decimal Sales_GP_10
        {
            get { return fSales_GP_10; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_10), ref fSales_GP_10, value); }
        }
        decimal fSales_GP_11;
        public decimal Sales_GP_11
        {
            get { return fSales_GP_11; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_11), ref fSales_GP_11, value); }
        }
        decimal fSales_GP_12;
        public decimal Sales_GP_12
        {
            get { return fSales_GP_12; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_12), ref fSales_GP_12, value); }
        }
        decimal fSales_GP_YTD;
        public decimal Sales_GP_YTD
        {
            get { return fSales_GP_YTD; }
            set { SetPropertyValue<decimal>(nameof(Sales_GP_YTD), ref fSales_GP_YTD, value); }
        }
        decimal fHandeling_01;
        public decimal Handeling_01
        {
            get { return fHandeling_01; }
            set { SetPropertyValue<decimal>(nameof(Handeling_01), ref fHandeling_01, value); }
        }
        decimal fHandeling_02;
        public decimal Handeling_02
        {
            get { return fHandeling_02; }
            set { SetPropertyValue<decimal>(nameof(Handeling_02), ref fHandeling_02, value); }
        }
        decimal fHandeling_03;
        public decimal Handeling_03
        {
            get { return fHandeling_03; }
            set { SetPropertyValue<decimal>(nameof(Handeling_03), ref fHandeling_03, value); }
        }
        decimal fHandeling_04;
        public decimal Handeling_04
        {
            get { return fHandeling_04; }
            set { SetPropertyValue<decimal>(nameof(Handeling_04), ref fHandeling_04, value); }
        }
        decimal fHandeling_05;
        public decimal Handeling_05
        {
            get { return fHandeling_05; }
            set { SetPropertyValue<decimal>(nameof(Handeling_05), ref fHandeling_05, value); }
        }
        decimal fHandeling_06;
        public decimal Handeling_06
        {
            get { return fHandeling_06; }
            set { SetPropertyValue<decimal>(nameof(Handeling_06), ref fHandeling_06, value); }
        }
        decimal fHandeling_07;
        public decimal Handeling_07
        {
            get { return fHandeling_07; }
            set { SetPropertyValue<decimal>(nameof(Handeling_07), ref fHandeling_07, value); }
        }
        decimal fHandeling_08;
        public decimal Handeling_08
        {
            get { return fHandeling_08; }
            set { SetPropertyValue<decimal>(nameof(Handeling_08), ref fHandeling_08, value); }
        }
        decimal fHandeling_09;
        public decimal Handeling_09
        {
            get { return fHandeling_09; }
            set { SetPropertyValue<decimal>(nameof(Handeling_09), ref fHandeling_09, value); }
        }
        decimal fHandeling_10;
        public decimal Handeling_10
        {
            get { return fHandeling_10; }
            set { SetPropertyValue<decimal>(nameof(Handeling_10), ref fHandeling_10, value); }
        }
        decimal fHandeling_11;
        public decimal Handeling_11
        {
            get { return fHandeling_11; }
            set { SetPropertyValue<decimal>(nameof(Handeling_11), ref fHandeling_11, value); }
        }
        decimal fHandeling_12;
        public decimal Handeling_12
        {
            get { return fHandeling_12; }
            set { SetPropertyValue<decimal>(nameof(Handeling_12), ref fHandeling_12, value); }
        }
        decimal fHandeling_YTD;
        public decimal Handeling_YTD
        {
            get { return fHandeling_YTD; }
            set { SetPropertyValue<decimal>(nameof(Handeling_YTD), ref fHandeling_YTD, value); }
        }
        decimal fInsurance_01;
        public decimal Insurance_01
        {
            get { return fInsurance_01; }
            set { SetPropertyValue<decimal>(nameof(Insurance_01), ref fInsurance_01, value); }
        }
        decimal fInsurance_02;
        public decimal Insurance_02
        {
            get { return fInsurance_02; }
            set { SetPropertyValue<decimal>(nameof(Insurance_02), ref fInsurance_02, value); }
        }
        decimal fInsurance_03;
        public decimal Insurance_03
        {
            get { return fInsurance_03; }
            set { SetPropertyValue<decimal>(nameof(Insurance_03), ref fInsurance_03, value); }
        }
        decimal fInsurance_04;
        public decimal Insurance_04
        {
            get { return fInsurance_04; }
            set { SetPropertyValue<decimal>(nameof(Insurance_04), ref fInsurance_04, value); }
        }
        decimal fInsurance_05;
        public decimal Insurance_05
        {
            get { return fInsurance_05; }
            set { SetPropertyValue<decimal>(nameof(Insurance_05), ref fInsurance_05, value); }
        }
        decimal fInsurance_06;
        public decimal Insurance_06
        {
            get { return fInsurance_06; }
            set { SetPropertyValue<decimal>(nameof(Insurance_06), ref fInsurance_06, value); }
        }
        decimal fInsurance_07;
        public decimal Insurance_07
        {
            get { return fInsurance_07; }
            set { SetPropertyValue<decimal>(nameof(Insurance_07), ref fInsurance_07, value); }
        }
        decimal fInsurance_08;
        public decimal Insurance_08
        {
            get { return fInsurance_08; }
            set { SetPropertyValue<decimal>(nameof(Insurance_08), ref fInsurance_08, value); }
        }
        decimal fInsurance_09;
        public decimal Insurance_09
        {
            get { return fInsurance_09; }
            set { SetPropertyValue<decimal>(nameof(Insurance_09), ref fInsurance_09, value); }
        }
        decimal fInsurance_10;
        public decimal Insurance_10
        {
            get { return fInsurance_10; }
            set { SetPropertyValue<decimal>(nameof(Insurance_10), ref fInsurance_10, value); }
        }
        decimal fInsurance_11;
        public decimal Insurance_11
        {
            get { return fInsurance_11; }
            set { SetPropertyValue<decimal>(nameof(Insurance_11), ref fInsurance_11, value); }
        }
        decimal fInsurance_12;
        public decimal Insurance_12
        {
            get { return fInsurance_12; }
            set { SetPropertyValue<decimal>(nameof(Insurance_12), ref fInsurance_12, value); }
        }
        decimal fInsurance_YTD;
        public decimal Insurance_YTD
        {
            get { return fInsurance_YTD; }
            set { SetPropertyValue<decimal>(nameof(Insurance_YTD), ref fInsurance_YTD, value); }
        }
        decimal fFreight_01;
        public decimal Freight_01
        {
            get { return fFreight_01; }
            set { SetPropertyValue<decimal>(nameof(Freight_01), ref fFreight_01, value); }
        }
        decimal fFreight_02;
        public decimal Freight_02
        {
            get { return fFreight_02; }
            set { SetPropertyValue<decimal>(nameof(Freight_02), ref fFreight_02, value); }
        }
        decimal fFreight_03;
        public decimal Freight_03
        {
            get { return fFreight_03; }
            set { SetPropertyValue<decimal>(nameof(Freight_03), ref fFreight_03, value); }
        }
        decimal fFreight_04;
        public decimal Freight_04
        {
            get { return fFreight_04; }
            set { SetPropertyValue<decimal>(nameof(Freight_04), ref fFreight_04, value); }
        }
        decimal fFreight_05;
        public decimal Freight_05
        {
            get { return fFreight_05; }
            set { SetPropertyValue<decimal>(nameof(Freight_05), ref fFreight_05, value); }
        }
        decimal fFreight_06;
        public decimal Freight_06
        {
            get { return fFreight_06; }
            set { SetPropertyValue<decimal>(nameof(Freight_06), ref fFreight_06, value); }
        }
        decimal fFreight_07;
        public decimal Freight_07
        {
            get { return fFreight_07; }
            set { SetPropertyValue<decimal>(nameof(Freight_07), ref fFreight_07, value); }
        }
        decimal fFreight_08;
        public decimal Freight_08
        {
            get { return fFreight_08; }
            set { SetPropertyValue<decimal>(nameof(Freight_08), ref fFreight_08, value); }
        }
        decimal fFreight_09;
        public decimal Freight_09
        {
            get { return fFreight_09; }
            set { SetPropertyValue<decimal>(nameof(Freight_09), ref fFreight_09, value); }
        }
        decimal fFreight_10;
        public decimal Freight_10
        {
            get { return fFreight_10; }
            set { SetPropertyValue<decimal>(nameof(Freight_10), ref fFreight_10, value); }
        }
        decimal fFreight_11;
        public decimal Freight_11
        {
            get { return fFreight_11; }
            set { SetPropertyValue<decimal>(nameof(Freight_11), ref fFreight_11, value); }
        }
        decimal fFreight_12;
        public decimal Freight_12
        {
            get { return fFreight_12; }
            set { SetPropertyValue<decimal>(nameof(Freight_12), ref fFreight_12, value); }
        }
        decimal fFreight_YTD;
        public decimal Freight_YTD
        {
            get { return fFreight_YTD; }
            set { SetPropertyValue<decimal>(nameof(Freight_YTD), ref fFreight_YTD, value); }
        }
        int fInvoice_Count_01;
        public int Invoice_Count_01
        {
            get { return fInvoice_Count_01; }
            set { SetPropertyValue<int>(nameof(Invoice_Count_01), ref fInvoice_Count_01, value); }
        }
        int fInvoice_Count_02;
        public int Invoice_Count_02
        {
            get { return fInvoice_Count_02; }
            set { SetPropertyValue<int>(nameof(Invoice_Count_02), ref fInvoice_Count_02, value); }
        }
        int fInvoice_Count_03;
        public int Invoice_Count_03
        {
            get { return fInvoice_Count_03; }
            set { SetPropertyValue<int>(nameof(Invoice_Count_03), ref fInvoice_Count_03, value); }
        }
        int fInvoice_Count_04;
        public int Invoice_Count_04
        {
            get { return fInvoice_Count_04; }
            set { SetPropertyValue<int>(nameof(Invoice_Count_04), ref fInvoice_Count_04, value); }
        }
        int fInvoice_Count_05;
        public int Invoice_Count_05
        {
            get { return fInvoice_Count_05; }
            set { SetPropertyValue<int>(nameof(Invoice_Count_05), ref fInvoice_Count_05, value); }
        }
        int fInvoice_Count_06;
        public int Invoice_Count_06
        {
            get { return fInvoice_Count_06; }
            set { SetPropertyValue<int>(nameof(Invoice_Count_06), ref fInvoice_Count_06, value); }
        }
        int fInvoice_Count_07;
        public int Invoice_Count_07
        {
            get { return fInvoice_Count_07; }
            set { SetPropertyValue<int>(nameof(Invoice_Count_07), ref fInvoice_Count_07, value); }
        }
        int fInvoice_Count_08;
        public int Invoice_Count_08
        {
            get { return fInvoice_Count_08; }
            set { SetPropertyValue<int>(nameof(Invoice_Count_08), ref fInvoice_Count_08, value); }
        }
        int fInvoice_Count_09;
        public int Invoice_Count_09
        {
            get { return fInvoice_Count_09; }
            set { SetPropertyValue<int>(nameof(Invoice_Count_09), ref fInvoice_Count_09, value); }
        }
        int fInvoice_Count_10;
        public int Invoice_Count_10
        {
            get { return fInvoice_Count_10; }
            set { SetPropertyValue<int>(nameof(Invoice_Count_10), ref fInvoice_Count_10, value); }
        }
        int fInvoice_Count_11;
        public int Invoice_Count_11
        {
            get { return fInvoice_Count_11; }
            set { SetPropertyValue<int>(nameof(Invoice_Count_11), ref fInvoice_Count_11, value); }
        }
        int fInvoice_Count_12;
        public int Invoice_Count_12
        {
            get { return fInvoice_Count_12; }
            set { SetPropertyValue<int>(nameof(Invoice_Count_12), ref fInvoice_Count_12, value); }
        }
        decimal fCredit_GP_01;
        public decimal Credit_GP_01
        {
            get { return fCredit_GP_01; }
            set { SetPropertyValue<decimal>(nameof(Credit_GP_01), ref fCredit_GP_01, value); }
        }
        decimal fCredit_GP_02;
        public decimal Credit_GP_02
        {
            get { return fCredit_GP_02; }
            set { SetPropertyValue<decimal>(nameof(Credit_GP_02), ref fCredit_GP_02, value); }
        }
        decimal fCredit_GP_03;
        public decimal Credit_GP_03
        {
            get { return fCredit_GP_03; }
            set { SetPropertyValue<decimal>(nameof(Credit_GP_03), ref fCredit_GP_03, value); }
        }
        decimal fCredit_GP_04;
        public decimal Credit_GP_04
        {
            get { return fCredit_GP_04; }
            set { SetPropertyValue<decimal>(nameof(Credit_GP_04), ref fCredit_GP_04, value); }
        }
        decimal fCredit_GP_05;
        public decimal Credit_GP_05
        {
            get { return fCredit_GP_05; }
            set { SetPropertyValue<decimal>(nameof(Credit_GP_05), ref fCredit_GP_05, value); }
        }
        decimal fCredit_GP_06;
        public decimal Credit_GP_06
        {
            get { return fCredit_GP_06; }
            set { SetPropertyValue<decimal>(nameof(Credit_GP_06), ref fCredit_GP_06, value); }
        }
        decimal fCredit_GP_07;
        public decimal Credit_GP_07
        {
            get { return fCredit_GP_07; }
            set { SetPropertyValue<decimal>(nameof(Credit_GP_07), ref fCredit_GP_07, value); }
        }
        decimal fCredit_GP_08;
        public decimal Credit_GP_08
        {
            get { return fCredit_GP_08; }
            set { SetPropertyValue<decimal>(nameof(Credit_GP_08), ref fCredit_GP_08, value); }
        }
        decimal fCredit_GP_09;
        public decimal Credit_GP_09
        {
            get { return fCredit_GP_09; }
            set { SetPropertyValue<decimal>(nameof(Credit_GP_09), ref fCredit_GP_09, value); }
        }
        decimal fCredit_GP_10;
        public decimal Credit_GP_10
        {
            get { return fCredit_GP_10; }
            set { SetPropertyValue<decimal>(nameof(Credit_GP_10), ref fCredit_GP_10, value); }
        }
        decimal fCredit_GP_11;
        public decimal Credit_GP_11
        {
            get { return fCredit_GP_11; }
            set { SetPropertyValue<decimal>(nameof(Credit_GP_11), ref fCredit_GP_11, value); }
        }
        decimal fCredit_GP_12;
        public decimal Credit_GP_12
        {
            get { return fCredit_GP_12; }
            set { SetPropertyValue<decimal>(nameof(Credit_GP_12), ref fCredit_GP_12, value); }
        }
    }

}