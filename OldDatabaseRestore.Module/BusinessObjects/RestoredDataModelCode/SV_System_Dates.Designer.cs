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

    public partial class SV_System_Dates : XPLiteObject
    {
        Guid fSpecial_Dates_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid Special_Dates_ID
        {
            get { return fSpecial_Dates_ID; }
            set { SetPropertyValue<Guid>(nameof(Special_Dates_ID), ref fSpecial_Dates_ID, value); }
        }
        int fWhat_Year;
        public int What_Year
        {
            get { return fWhat_Year; }
            set { SetPropertyValue<int>(nameof(What_Year), ref fWhat_Year, value); }
        }
        string fIndex_Type;
        [Size(10)]
        public string Index_Type
        {
            get { return fIndex_Type; }
            set { SetPropertyValue<string>(nameof(Index_Type), ref fIndex_Type, value); }
        }
        int fIndex_Number;
        public int Index_Number
        {
            get { return fIndex_Number; }
            set { SetPropertyValue<int>(nameof(Index_Number), ref fIndex_Number, value); }
        }
        DateTime fFirst_Day;
        public DateTime First_Day
        {
            get { return fFirst_Day; }
            set { SetPropertyValue<DateTime>(nameof(First_Day), ref fFirst_Day, value); }
        }
        DateTime fFirst_Work_Day;
        public DateTime First_Work_Day
        {
            get { return fFirst_Work_Day; }
            set { SetPropertyValue<DateTime>(nameof(First_Work_Day), ref fFirst_Work_Day, value); }
        }
        DateTime fLast_Day;
        public DateTime Last_Day
        {
            get { return fLast_Day; }
            set { SetPropertyValue<DateTime>(nameof(Last_Day), ref fLast_Day, value); }
        }
        DateTime fLast_Work_Day;
        public DateTime Last_Work_Day
        {
            get { return fLast_Work_Day; }
            set { SetPropertyValue<DateTime>(nameof(Last_Work_Day), ref fLast_Work_Day, value); }
        }
    }

}