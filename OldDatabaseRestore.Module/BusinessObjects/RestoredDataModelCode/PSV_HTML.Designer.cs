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

    public partial class PSV_HTML : XPLiteObject
    {
        int fautoid;
        [Key(true)]
        public int autoid
        {
            get { return fautoid; }
            set { SetPropertyValue<int>(nameof(autoid), ref fautoid, value); }
        }
        string fhtml;
        [Size(SizeAttribute.Unlimited)]
        public string html
        {
            get { return fhtml; }
            set { SetPropertyValue<string>(nameof(html), ref fhtml, value); }
        }
    }

}
