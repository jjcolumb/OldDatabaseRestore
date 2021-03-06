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

    public partial class tblSchedule : XPLiteObject
    {
        Guid fRowGuid;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid RowGuid
        {
            get { return fRowGuid; }
            set { SetPropertyValue<Guid>(nameof(RowGuid), ref fRowGuid, value); }
        }
        string fNameSpace;
        [Size(250)]
        public string NameSpace
        {
            get { return fNameSpace; }
            set { SetPropertyValue<string>(nameof(NameSpace), ref fNameSpace, value); }
        }
        string fScreenName;
        [Size(250)]
        public string ScreenName
        {
            get { return fScreenName; }
            set { SetPropertyValue<string>(nameof(ScreenName), ref fScreenName, value); }
        }
        DateTime fNextRunTime;
        public DateTime NextRunTime
        {
            get { return fNextRunTime; }
            set { SetPropertyValue<DateTime>(nameof(NextRunTime), ref fNextRunTime, value); }
        }
        string fScheduleType;
        public string ScheduleType
        {
            get { return fScheduleType; }
            set { SetPropertyValue<string>(nameof(ScheduleType), ref fScheduleType, value); }
        }
        string fScheduleTime;
        [Size(50)]
        public string ScheduleTime
        {
            get { return fScheduleTime; }
            set { SetPropertyValue<string>(nameof(ScheduleTime), ref fScheduleTime, value); }
        }
        string fRunDay;
        [Size(50)]
        public string RunDay
        {
            get { return fRunDay; }
            set { SetPropertyValue<string>(nameof(RunDay), ref fRunDay, value); }
        }
        DateTime fLastRunTime;
        public DateTime LastRunTime
        {
            get { return fLastRunTime; }
            set { SetPropertyValue<DateTime>(nameof(LastRunTime), ref fLastRunTime, value); }
        }
        bool fEnabled;
        public bool Enabled
        {
            get { return fEnabled; }
            set { SetPropertyValue<bool>(nameof(Enabled), ref fEnabled, value); }
        }
        bool fExclusive;
        public bool Exclusive
        {
            get { return fExclusive; }
            set { SetPropertyValue<bool>(nameof(Exclusive), ref fExclusive, value); }
        }
        string fHostName;
        [Size(250)]
        public string HostName
        {
            get { return fHostName; }
            set { SetPropertyValue<string>(nameof(HostName), ref fHostName, value); }
        }
        string fUserName;
        [Size(250)]
        public string UserName
        {
            get { return fUserName; }
            set { SetPropertyValue<string>(nameof(UserName), ref fUserName, value); }
        }
        byte[] fResource;
        [Size(SizeAttribute.Unlimited)]
        [MemberDesignTimeVisibility(true)]
        public byte[] Resource
        {
            get { return fResource; }
            set { SetPropertyValue<byte[]>(nameof(Resource), ref fResource, value); }
        }
        string fStringValue;
        [Size(SizeAttribute.Unlimited)]
        public string StringValue
        {
            get { return fStringValue; }
            set { SetPropertyValue<string>(nameof(StringValue), ref fStringValue, value); }
        }
        string fActiveHostName;
        [Size(250)]
        public string ActiveHostName
        {
            get { return fActiveHostName; }
            set { SetPropertyValue<string>(nameof(ActiveHostName), ref fActiveHostName, value); }
        }
        DateTime fHeartBeat;
        public DateTime HeartBeat
        {
            get { return fHeartBeat; }
            set { SetPropertyValue<DateTime>(nameof(HeartBeat), ref fHeartBeat, value); }
        }
        string fJobName;
        [Size(250)]
        public string JobName
        {
            get { return fJobName; }
            set { SetPropertyValue<string>(nameof(JobName), ref fJobName, value); }
        }
        DateTime fScheduleDate;
        public DateTime ScheduleDate
        {
            get { return fScheduleDate; }
            set { SetPropertyValue<DateTime>(nameof(ScheduleDate), ref fScheduleDate, value); }
        }
        bool fWeekDaysOnly;
        public bool WeekDaysOnly
        {
            get { return fWeekDaysOnly; }
            set { SetPropertyValue<bool>(nameof(WeekDaysOnly), ref fWeekDaysOnly, value); }
        }
        bool fWeekEndsOnly;
        public bool WeekEndsOnly
        {
            get { return fWeekEndsOnly; }
            set { SetPropertyValue<bool>(nameof(WeekEndsOnly), ref fWeekEndsOnly, value); }
        }
        bool fOfficeHoursOnly;
        public bool OfficeHoursOnly
        {
            get { return fOfficeHoursOnly; }
            set { SetPropertyValue<bool>(nameof(OfficeHoursOnly), ref fOfficeHoursOnly, value); }
        }
    }

}
