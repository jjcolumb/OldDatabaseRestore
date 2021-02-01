using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace OldDatabaseRestore.Module.BusinessObjects.BCI_Database_V2A2013
{
    
    public partial class A1
    {
        public A1(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
