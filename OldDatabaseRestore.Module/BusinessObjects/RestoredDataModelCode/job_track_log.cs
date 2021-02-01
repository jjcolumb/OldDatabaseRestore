using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace OldDatabaseRestore.Module.BusinessObjects.BCI_Database_V2A2013
{

    public partial class job_track_log
    {
        public job_track_log(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
