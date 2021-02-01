using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace OldDatabaseRestore.Module.BusinessObjects.BCI_Database_V2A2013
{

    public partial class Tran_Data_Info
    {
        public Tran_Data_Info(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
