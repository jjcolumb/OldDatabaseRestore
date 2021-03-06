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

    public partial class UD_Logon : XPLiteObject
    {
        Guid fUD_Logon_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid UD_Logon_ID
        {
            get { return fUD_Logon_ID; }
            set { SetPropertyValue<Guid>(nameof(UD_Logon_ID), ref fUD_Logon_ID, value); }
        }
        UD_Main fUD_Main_ID;
        [Association(@"UD_LogonReferencesUD_Main")]
        public UD_Main UD_Main_ID
        {
            get { return fUD_Main_ID; }
            set { SetPropertyValue<UD_Main>(nameof(UD_Main_ID), ref fUD_Main_ID, value); }
        }
        string fInitials;
        [Size(4)]
        public string Initials
        {
            get { return fInitials; }
            set { SetPropertyValue<string>(nameof(Initials), ref fInitials, value); }
        }
        string fLogon_Name;
        [Size(50)]
        public string Logon_Name
        {
            get { return fLogon_Name; }
            set { SetPropertyValue<string>(nameof(Logon_Name), ref fLogon_Name, value); }
        }
        string fPassword;
        [Size(50)]
        public string Password
        {
            get { return fPassword; }
            set { SetPropertyValue<string>(nameof(Password), ref fPassword, value); }
        }
        string fSBPassword1;
        [Size(50)]
        public string SBPassword1
        {
            get { return fSBPassword1; }
            set { SetPropertyValue<string>(nameof(SBPassword1), ref fSBPassword1, value); }
        }
        string fSBPassword2;
        [Size(50)]
        public string SBPassword2
        {
            get { return fSBPassword2; }
            set { SetPropertyValue<string>(nameof(SBPassword2), ref fSBPassword2, value); }
        }
        DateTime fLast_LogON_Date_Time;
        public DateTime Last_LogON_Date_Time
        {
            get { return fLast_LogON_Date_Time; }
            set { SetPropertyValue<DateTime>(nameof(Last_LogON_Date_Time), ref fLast_LogON_Date_Time, value); }
        }
        DateTime fLast_LogOFF_Date_Time;
        public DateTime Last_LogOFF_Date_Time
        {
            get { return fLast_LogOFF_Date_Time; }
            set { SetPropertyValue<DateTime>(nameof(Last_LogOFF_Date_Time), ref fLast_LogOFF_Date_Time, value); }
        }
        string fLast_Station_Name;
        [Size(50)]
        public string Last_Station_Name
        {
            get { return fLast_Station_Name; }
            set { SetPropertyValue<string>(nameof(Last_Station_Name), ref fLast_Station_Name, value); }
        }
    }

}
