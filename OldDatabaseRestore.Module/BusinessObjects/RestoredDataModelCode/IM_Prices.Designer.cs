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

    public partial class IM_Prices : XPLiteObject
    {
        Guid fIM_Prices_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid IM_Prices_ID
        {
            get { return fIM_Prices_ID; }
            set { SetPropertyValue<Guid>(nameof(IM_Prices_ID), ref fIM_Prices_ID, value); }
        }
        IM_Price_Sets fIM_Price_Sets_ID;
        [Association(@"IM_PricesReferencesIM_Price_Sets")]
        public IM_Price_Sets IM_Price_Sets_ID
        {
            get { return fIM_Price_Sets_ID; }
            set { SetPropertyValue<IM_Price_Sets>(nameof(IM_Price_Sets_ID), ref fIM_Price_Sets_ID, value); }
        }
        int fSet_QTY;
        public int Set_QTY
        {
            get { return fSet_QTY; }
            set { SetPropertyValue<int>(nameof(Set_QTY), ref fSet_QTY, value); }
        }
        decimal fSet_Price;
        public decimal Set_Price
        {
            get { return fSet_Price; }
            set { SetPropertyValue<decimal>(nameof(Set_Price), ref fSet_Price, value); }
        }
        int fSet_Commission;
        public int Set_Commission
        {
            get { return fSet_Commission; }
            set { SetPropertyValue<int>(nameof(Set_Commission), ref fSet_Commission, value); }
        }
    }

}