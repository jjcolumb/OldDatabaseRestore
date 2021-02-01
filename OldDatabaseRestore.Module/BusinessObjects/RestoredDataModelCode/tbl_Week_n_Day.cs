using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace OldDatabaseRestore.Module.BusinessObjects.BCI_Database_V2A2013
{

    public partial class tbl_Week_n_Day
    {
        public tbl_Week_n_Day(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
