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

    public partial class CM_Chain : XPLiteObject
    {
        Guid fCM_Chain_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid CM_Chain_ID
        {
            get { return fCM_Chain_ID; }
            set { SetPropertyValue<Guid>(nameof(CM_Chain_ID), ref fCM_Chain_ID, value); }
        }
        CM_Main fCM_Main_ID;
        [Association(@"CM_ChainReferencesCM_Main")]
        public CM_Main CM_Main_ID
        {
            get { return fCM_Main_ID; }
            set { SetPropertyValue<CM_Main>(nameof(CM_Main_ID), ref fCM_Main_ID, value); }
        }
        pl_Chain_Store_Name fChain_Store;
        [Association(@"CM_ChainReferencespl_Chain_Store_Name")]
        public pl_Chain_Store_Name Chain_Store
        {
            get { return fChain_Store; }
            set { SetPropertyValue<pl_Chain_Store_Name>(nameof(Chain_Store), ref fChain_Store, value); }
        }
        int fChain_Store_Number;
        public int Chain_Store_Number
        {
            get { return fChain_Store_Number; }
            set { SetPropertyValue<int>(nameof(Chain_Store_Number), ref fChain_Store_Number, value); }
        }
        CM_Main fChain_Store_ID;
        [Association(@"CM_ChainReferencesCM_Main1")]
        public CM_Main Chain_Store_ID
        {
            get { return fChain_Store_ID; }
            set { SetPropertyValue<CM_Main>(nameof(Chain_Store_ID), ref fChain_Store_ID, value); }
        }
    }

}
