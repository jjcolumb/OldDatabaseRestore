using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using OldDatabaseRestore.Module.BusinessObjects.BCI_Database_V2A2013;
using Bogus;

namespace OldDatabaseRestore.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            if (ObjectSpace.GetObjectsCount(typeof(A1),null)==0&& ObjectSpace.GetObjectsCount(typeof(CD_Address), null) ==0)
            {
                //var demoA1Data = new Faker<A1>()
                //    .CustomInstantiator(a1 => new A1(((XPObjectSpace)ObjectSpace).Session))
                //    .RuleFor(o => o.myIndex, bogus => bogus.Random.Int())
                //    .RuleFor(o => o.traceTimeStamp, bogus => bogus.Date.Recent(20))
                //    .RuleFor(o => o.traceComment, bogus => bogus.Lorem.Text())
                //    .RuleFor(o => o.trace_Bool, bogus => bogus.Random.Bool())
                //    .RuleFor(o => o.trace_GUID, bogus => Guid.NewGuid());
                //var a1Data = demoA1Data.Generate(100);

                //var demoAddressData = new Faker<CD_Address>()
                //    .CustomInstantiator(a1 => new CD_Address(((XPObjectSpace)ObjectSpace).Session))
                //    .RuleFor(o => o.Name, bogus => bogus.Name.FirstName())
                //    .RuleFor(o => o.Address, bogus => bogus.Address.Direction())
                //    .RuleFor(o => o.Overflow, bogus => bogus.Lorem.Text())
                //    .RuleFor(o => o.City, bogus => bogus.Address.City())
                //    .RuleFor(o => o.State, bogus => bogus.Address.State());
                //var addressData = demoAddressData.Generate(100);

                ObjectSpace.CommitChanges();
            }

            //ObjectSpace.CommitChanges(); //Uncomment this line to persist created object(s).
        }
        public override void UpdateDatabaseBeforeUpdateSchema() {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
    }
}
