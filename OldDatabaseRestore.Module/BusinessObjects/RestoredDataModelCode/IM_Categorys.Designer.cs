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

    public partial class IM_Categorys : XPLiteObject
    {
        Guid fIM_Categorys_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid IM_Categorys_ID
        {
            get { return fIM_Categorys_ID; }
            set { SetPropertyValue<Guid>(nameof(IM_Categorys_ID), ref fIM_Categorys_ID, value); }
        }
        IM_Main fItem_Number;
        [Association(@"IM_CategorysReferencesIM_Main")]
        public IM_Main Item_Number
        {
            get { return fItem_Number; }
            set { SetPropertyValue<IM_Main>(nameof(Item_Number), ref fItem_Number, value); }
        }
        CG_Main fCategory_Link;
        [Association(@"IM_CategorysReferencesCG_Main")]
        public CG_Main Category_Link
        {
            get { return fCategory_Link; }
            set { SetPropertyValue<CG_Main>(nameof(Category_Link), ref fCategory_Link, value); }
        }
    }

}