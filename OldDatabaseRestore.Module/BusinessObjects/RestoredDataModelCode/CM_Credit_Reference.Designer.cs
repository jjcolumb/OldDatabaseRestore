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

    public partial class CM_Credit_Reference : XPLiteObject
    {
        Guid fCM_Credit_Reference_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid CM_Credit_Reference_ID
        {
            get { return fCM_Credit_Reference_ID; }
            set { SetPropertyValue<Guid>(nameof(CM_Credit_Reference_ID), ref fCM_Credit_Reference_ID, value); }
        }
        CM_Main fCM_Main_ID;
        [Association(@"CM_Credit_ReferenceReferencesCM_Main")]
        public CM_Main CM_Main_ID
        {
            get { return fCM_Main_ID; }
            set { SetPropertyValue<CM_Main>(nameof(CM_Main_ID), ref fCM_Main_ID, value); }
        }
        CD_Main fCD_Main_ID;
        [Association(@"CM_Credit_ReferenceReferencesCD_Main")]
        public CD_Main CD_Main_ID
        {
            get { return fCD_Main_ID; }
            set { SetPropertyValue<CD_Main>(nameof(CD_Main_ID), ref fCD_Main_ID, value); }
        }
    }

}