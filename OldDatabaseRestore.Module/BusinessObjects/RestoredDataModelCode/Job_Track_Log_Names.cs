using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace OldDatabaseRestore.Module.BusinessObjects.BCI_Database_V2A2013
{

    public partial class Job_Track_Log_Names
    {
        public Job_Track_Log_Names(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
