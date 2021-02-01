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

    public partial class pl_Delivery_Type : XPLiteObject
    {
        Guid fpl_Delivery_Type_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid pl_Delivery_Type_ID
        {
            get { return fpl_Delivery_Type_ID; }
            set { SetPropertyValue<Guid>(nameof(pl_Delivery_Type_ID), ref fpl_Delivery_Type_ID, value); }
        }
        decimal fSort_Order;
        [Indexed(@"Description", Name = @"IX_pl_Delivery_Type")]
        [ColumnDbDefaultValue("((0))")]
        public decimal Sort_Order
        {
            get { return fSort_Order; }
            set { SetPropertyValue<decimal>(nameof(Sort_Order), ref fSort_Order, value); }
        }
        string fDescription;
        [Size(50)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>(nameof(Description), ref fDescription, value); }
        }
        string fDescription_Short;
        [Size(50)]
        public string Description_Short
        {
            get { return fDescription_Short; }
            set { SetPropertyValue<string>(nameof(Description_Short), ref fDescription_Short, value); }
        }
        string fOptional_Data_Text;
        [Size(50)]
        public string Optional_Data_Text
        {
            get { return fOptional_Data_Text; }
            set { SetPropertyValue<string>(nameof(Optional_Data_Text), ref fOptional_Data_Text, value); }
        }
        int fOptional_Data_Int;
        public int Optional_Data_Int
        {
            get { return fOptional_Data_Int; }
            set { SetPropertyValue<int>(nameof(Optional_Data_Int), ref fOptional_Data_Int, value); }
        }
        int fUser_Select_UI;
        public int User_Select_UI
        {
            get { return fUser_Select_UI; }
            set { SetPropertyValue<int>(nameof(User_Select_UI), ref fUser_Select_UI, value); }
        }
        bool fDeleted_Item;
        public bool Deleted_Item
        {
            get { return fDeleted_Item; }
            set { SetPropertyValue<bool>(nameof(Deleted_Item), ref fDeleted_Item, value); }
        }
        decimal fLookup_ID;
        public decimal Lookup_ID
        {
            get { return fLookup_ID; }
            set { SetPropertyValue<decimal>(nameof(Lookup_ID), ref fLookup_ID, value); }
        }
    }

}
