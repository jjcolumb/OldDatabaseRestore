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

    public partial class CG_Items : XPLiteObject
    {
        Guid fCG_Items_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid CG_Items_ID
        {
            get { return fCG_Items_ID; }
            set { SetPropertyValue<Guid>(nameof(CG_Items_ID), ref fCG_Items_ID, value); }
        }
        string fCategory;
        [Size(60)]
        public string Category
        {
            get { return fCategory; }
            set { SetPropertyValue<string>(nameof(Category), ref fCategory, value); }
        }
        [Association(@"CG_MainReferencesCG_Items")]
        public XPCollection<CG_Main> CG_Mains { get { return GetCollection<CG_Main>(nameof(CG_Mains)); } }
        [Association(@"CG_MainReferencesCG_Items1")]
        public XPCollection<CG_Main> CG_Mains1 { get { return GetCollection<CG_Main>(nameof(CG_Mains1)); } }
    }

}
