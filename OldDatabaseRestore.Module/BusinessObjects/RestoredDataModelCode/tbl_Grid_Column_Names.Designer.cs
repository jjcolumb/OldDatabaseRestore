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

    public partial class tbl_Grid_Column_Names : XPLiteObject
    {
        Guid fGrid_Column_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid Grid_Column_ID
        {
            get { return fGrid_Column_ID; }
            set { SetPropertyValue<Guid>(nameof(Grid_Column_ID), ref fGrid_Column_ID, value); }
        }
        string fSelect_Name;
        [Size(50)]
        public string Select_Name
        {
            get { return fSelect_Name; }
            set { SetPropertyValue<string>(nameof(Select_Name), ref fSelect_Name, value); }
        }
        int fSelect_Name_ID;
        public int Select_Name_ID
        {
            get { return fSelect_Name_ID; }
            set { SetPropertyValue<int>(nameof(Select_Name_ID), ref fSelect_Name_ID, value); }
        }
        int fSelect_Order_Index;
        public int Select_Order_Index
        {
            get { return fSelect_Order_Index; }
            set { SetPropertyValue<int>(nameof(Select_Order_Index), ref fSelect_Order_Index, value); }
        }
        int fSort_Order;
        public int Sort_Order
        {
            get { return fSort_Order; }
            set { SetPropertyValue<int>(nameof(Sort_Order), ref fSort_Order, value); }
        }
        int fColumn_Name_ID;
        public int Column_Name_ID
        {
            get { return fColumn_Name_ID; }
            set { SetPropertyValue<int>(nameof(Column_Name_ID), ref fColumn_Name_ID, value); }
        }
        decimal fColumn_Reference_ID;
        public decimal Column_Reference_ID
        {
            get { return fColumn_Reference_ID; }
            set { SetPropertyValue<decimal>(nameof(Column_Reference_ID), ref fColumn_Reference_ID, value); }
        }
        string fColumn_Name;
        [Size(50)]
        public string Column_Name
        {
            get { return fColumn_Name; }
            set { SetPropertyValue<string>(nameof(Column_Name), ref fColumn_Name, value); }
        }
        string fColumn_Name_ID_Text;
        [Size(25)]
        public string Column_Name_ID_Text
        {
            get { return fColumn_Name_ID_Text; }
            set { SetPropertyValue<string>(nameof(Column_Name_ID_Text), ref fColumn_Name_ID_Text, value); }
        }
    }

}