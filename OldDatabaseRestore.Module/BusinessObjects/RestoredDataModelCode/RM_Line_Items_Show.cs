﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace OldDatabaseRestore.Module.BusinessObjects.BCI_Database_V2A2013
{

    public partial class RM_Line_Items_Show
    {
        public RM_Line_Items_Show(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}