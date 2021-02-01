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

    public partial class IM_Price_Sets : XPLiteObject
    {
        Guid fIM_Price_Sets_ID;
        [Key(true)]
        public Guid IM_Price_Sets_ID
        {
            get { return fIM_Price_Sets_ID; }
            set { SetPropertyValue<Guid>(nameof(IM_Price_Sets_ID), ref fIM_Price_Sets_ID, value); }
        }
        IM_Main fIM_Main_ID;
        [Association(@"IM_Price_SetsReferencesIM_Main")]
        public IM_Main IM_Main_ID
        {
            get { return fIM_Main_ID; }
            set { SetPropertyValue<IM_Main>(nameof(IM_Main_ID), ref fIM_Main_ID, value); }
        }
        PS_Main fPS_Main_ID;
        [Association(@"IM_Price_SetsReferencesPS_Main")]
        public PS_Main PS_Main_ID
        {
            get { return fPS_Main_ID; }
            set { SetPropertyValue<PS_Main>(nameof(PS_Main_ID), ref fPS_Main_ID, value); }
        }
        int fSet_Minimum_Order;
        public int Set_Minimum_Order
        {
            get { return fSet_Minimum_Order; }
            set { SetPropertyValue<int>(nameof(Set_Minimum_Order), ref fSet_Minimum_Order, value); }
        }
        int fSet_Multiple_Order;
        public int Set_Multiple_Order
        {
            get { return fSet_Multiple_Order; }
            set { SetPropertyValue<int>(nameof(Set_Multiple_Order), ref fSet_Multiple_Order, value); }
        }
        [Association(@"IM_PricesReferencesIM_Price_Sets")]
        public XPCollection<IM_Prices> IM_Pricess { get { return GetCollection<IM_Prices>(nameof(IM_Pricess)); } }
    }

}