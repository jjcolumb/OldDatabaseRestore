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

    public partial class IC_Inventory_Audit_Pivot : XPLiteObject
    {
        Guid fIC_Inventory_Audit_Pivot_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid IC_Inventory_Audit_Pivot_ID
        {
            get { return fIC_Inventory_Audit_Pivot_ID; }
            set { SetPropertyValue<Guid>(nameof(IC_Inventory_Audit_Pivot_ID), ref fIC_Inventory_Audit_Pivot_ID, value); }
        }
        DateTime fDate_Created;
        [ColumnDbDefaultValue("(getdate())")]
        public DateTime Date_Created
        {
            get { return fDate_Created; }
            set { SetPropertyValue<DateTime>(nameof(Date_Created), ref fDate_Created, value); }
        }
        int fMax_Counts;
        public int Max_Counts
        {
            get { return fMax_Counts; }
            set { SetPropertyValue<int>(nameof(Max_Counts), ref fMax_Counts, value); }
        }
        Guid fIM_Main_ID;
        public Guid IM_Main_ID
        {
            get { return fIM_Main_ID; }
            set { SetPropertyValue<Guid>(nameof(IM_Main_ID), ref fIM_Main_ID, value); }
        }
        string fItem_Number_Main;
        [Size(25)]
        public string Item_Number_Main
        {
            get { return fItem_Number_Main; }
            set { SetPropertyValue<string>(nameof(Item_Number_Main), ref fItem_Number_Main, value); }
        }
        int fYear_Audit;
        public int Year_Audit
        {
            get { return fYear_Audit; }
            set { SetPropertyValue<int>(nameof(Year_Audit), ref fYear_Audit, value); }
        }
        int fLevel_ID;
        public int Level_ID
        {
            get { return fLevel_ID; }
            set { SetPropertyValue<int>(nameof(Level_ID), ref fLevel_ID, value); }
        }
        string fUser_ID;
        [Size(50)]
        public string User_ID
        {
            get { return fUser_ID; }
            set { SetPropertyValue<string>(nameof(User_ID), ref fUser_ID, value); }
        }
        string fLocation;
        public string Location
        {
            get { return fLocation; }
            set { SetPropertyValue<string>(nameof(Location), ref fLocation, value); }
        }
        int fDefault_BL;
        public int Default_BL
        {
            get { return fDefault_BL; }
            set { SetPropertyValue<int>(nameof(Default_BL), ref fDefault_BL, value); }
        }
        int fCount_1;
        public int Count_1
        {
            get { return fCount_1; }
            set { SetPropertyValue<int>(nameof(Count_1), ref fCount_1, value); }
        }
        bool fAccept_1;
        public bool Accept_1
        {
            get { return fAccept_1; }
            set { SetPropertyValue<bool>(nameof(Accept_1), ref fAccept_1, value); }
        }
        int fCount_2;
        public int Count_2
        {
            get { return fCount_2; }
            set { SetPropertyValue<int>(nameof(Count_2), ref fCount_2, value); }
        }
        bool fAccept_2;
        public bool Accept_2
        {
            get { return fAccept_2; }
            set { SetPropertyValue<bool>(nameof(Accept_2), ref fAccept_2, value); }
        }
        int fCount_3;
        public int Count_3
        {
            get { return fCount_3; }
            set { SetPropertyValue<int>(nameof(Count_3), ref fCount_3, value); }
        }
        bool fAccept_3;
        public bool Accept_3
        {
            get { return fAccept_3; }
            set { SetPropertyValue<bool>(nameof(Accept_3), ref fAccept_3, value); }
        }
        int fCount_4;
        public int Count_4
        {
            get { return fCount_4; }
            set { SetPropertyValue<int>(nameof(Count_4), ref fCount_4, value); }
        }
        bool fAccept_4;
        public bool Accept_4
        {
            get { return fAccept_4; }
            set { SetPropertyValue<bool>(nameof(Accept_4), ref fAccept_4, value); }
        }
        int fCount_5;
        public int Count_5
        {
            get { return fCount_5; }
            set { SetPropertyValue<int>(nameof(Count_5), ref fCount_5, value); }
        }
        bool fAccept_5;
        public bool Accept_5
        {
            get { return fAccept_5; }
            set { SetPropertyValue<bool>(nameof(Accept_5), ref fAccept_5, value); }
        }
        int fCount_6;
        public int Count_6
        {
            get { return fCount_6; }
            set { SetPropertyValue<int>(nameof(Count_6), ref fCount_6, value); }
        }
        bool fAccept_6;
        public bool Accept_6
        {
            get { return fAccept_6; }
            set { SetPropertyValue<bool>(nameof(Accept_6), ref fAccept_6, value); }
        }
        int fCount_7;
        public int Count_7
        {
            get { return fCount_7; }
            set { SetPropertyValue<int>(nameof(Count_7), ref fCount_7, value); }
        }
        bool fAccept_7;
        public bool Accept_7
        {
            get { return fAccept_7; }
            set { SetPropertyValue<bool>(nameof(Accept_7), ref fAccept_7, value); }
        }
        int fCount_8;
        public int Count_8
        {
            get { return fCount_8; }
            set { SetPropertyValue<int>(nameof(Count_8), ref fCount_8, value); }
        }
        bool fAccept_8;
        public bool Accept_8
        {
            get { return fAccept_8; }
            set { SetPropertyValue<bool>(nameof(Accept_8), ref fAccept_8, value); }
        }
        int fCount_9;
        public int Count_9
        {
            get { return fCount_9; }
            set { SetPropertyValue<int>(nameof(Count_9), ref fCount_9, value); }
        }
        bool fAccept_9;
        public bool Accept_9
        {
            get { return fAccept_9; }
            set { SetPropertyValue<bool>(nameof(Accept_9), ref fAccept_9, value); }
        }
        int fCount_10;
        public int Count_10
        {
            get { return fCount_10; }
            set { SetPropertyValue<int>(nameof(Count_10), ref fCount_10, value); }
        }
        bool fAccept_10;
        public bool Accept_10
        {
            get { return fAccept_10; }
            set { SetPropertyValue<bool>(nameof(Accept_10), ref fAccept_10, value); }
        }
        int fCount_11;
        public int Count_11
        {
            get { return fCount_11; }
            set { SetPropertyValue<int>(nameof(Count_11), ref fCount_11, value); }
        }
        bool fAccept_11;
        public bool Accept_11
        {
            get { return fAccept_11; }
            set { SetPropertyValue<bool>(nameof(Accept_11), ref fAccept_11, value); }
        }
        int fCount_12;
        public int Count_12
        {
            get { return fCount_12; }
            set { SetPropertyValue<int>(nameof(Count_12), ref fCount_12, value); }
        }
        bool fAccept_12;
        public bool Accept_12
        {
            get { return fAccept_12; }
            set { SetPropertyValue<bool>(nameof(Accept_12), ref fAccept_12, value); }
        }
        int fCount_13;
        public int Count_13
        {
            get { return fCount_13; }
            set { SetPropertyValue<int>(nameof(Count_13), ref fCount_13, value); }
        }
        bool fAccept_13;
        public bool Accept_13
        {
            get { return fAccept_13; }
            set { SetPropertyValue<bool>(nameof(Accept_13), ref fAccept_13, value); }
        }
        int fCount_14;
        public int Count_14
        {
            get { return fCount_14; }
            set { SetPropertyValue<int>(nameof(Count_14), ref fCount_14, value); }
        }
        bool fAccept_14;
        public bool Accept_14
        {
            get { return fAccept_14; }
            set { SetPropertyValue<bool>(nameof(Accept_14), ref fAccept_14, value); }
        }
        int fCount_15;
        public int Count_15
        {
            get { return fCount_15; }
            set { SetPropertyValue<int>(nameof(Count_15), ref fCount_15, value); }
        }
        bool fAccept_15;
        public bool Accept_15
        {
            get { return fAccept_15; }
            set { SetPropertyValue<bool>(nameof(Accept_15), ref fAccept_15, value); }
        }
        int fCount_16;
        public int Count_16
        {
            get { return fCount_16; }
            set { SetPropertyValue<int>(nameof(Count_16), ref fCount_16, value); }
        }
        bool fAccept_16;
        public bool Accept_16
        {
            get { return fAccept_16; }
            set { SetPropertyValue<bool>(nameof(Accept_16), ref fAccept_16, value); }
        }
        int fCount_17;
        public int Count_17
        {
            get { return fCount_17; }
            set { SetPropertyValue<int>(nameof(Count_17), ref fCount_17, value); }
        }
        bool fAccept_17;
        public bool Accept_17
        {
            get { return fAccept_17; }
            set { SetPropertyValue<bool>(nameof(Accept_17), ref fAccept_17, value); }
        }
        int fCount_18;
        public int Count_18
        {
            get { return fCount_18; }
            set { SetPropertyValue<int>(nameof(Count_18), ref fCount_18, value); }
        }
        bool fAccept_18;
        public bool Accept_18
        {
            get { return fAccept_18; }
            set { SetPropertyValue<bool>(nameof(Accept_18), ref fAccept_18, value); }
        }
        int fCount_19;
        public int Count_19
        {
            get { return fCount_19; }
            set { SetPropertyValue<int>(nameof(Count_19), ref fCount_19, value); }
        }
        bool fAccept_19;
        public bool Accept_19
        {
            get { return fAccept_19; }
            set { SetPropertyValue<bool>(nameof(Accept_19), ref fAccept_19, value); }
        }
        int fCount_20;
        public int Count_20
        {
            get { return fCount_20; }
            set { SetPropertyValue<int>(nameof(Count_20), ref fCount_20, value); }
        }
        bool fAccept_20;
        public bool Accept_20
        {
            get { return fAccept_20; }
            set { SetPropertyValue<bool>(nameof(Accept_20), ref fAccept_20, value); }
        }
        string fCount_1_Text;
        [Size(25)]
        public string Count_1_Text
        {
            get { return fCount_1_Text; }
            set { SetPropertyValue<string>(nameof(Count_1_Text), ref fCount_1_Text, value); }
        }
        string fCount_2_Text;
        [Size(25)]
        public string Count_2_Text
        {
            get { return fCount_2_Text; }
            set { SetPropertyValue<string>(nameof(Count_2_Text), ref fCount_2_Text, value); }
        }
        string fCount_3_Text;
        [Size(25)]
        public string Count_3_Text
        {
            get { return fCount_3_Text; }
            set { SetPropertyValue<string>(nameof(Count_3_Text), ref fCount_3_Text, value); }
        }
        string fCount_4_Text;
        [Size(25)]
        public string Count_4_Text
        {
            get { return fCount_4_Text; }
            set { SetPropertyValue<string>(nameof(Count_4_Text), ref fCount_4_Text, value); }
        }
        string fCount_5_Text;
        [Size(25)]
        public string Count_5_Text
        {
            get { return fCount_5_Text; }
            set { SetPropertyValue<string>(nameof(Count_5_Text), ref fCount_5_Text, value); }
        }
        string fCount_6_Text;
        [Size(25)]
        public string Count_6_Text
        {
            get { return fCount_6_Text; }
            set { SetPropertyValue<string>(nameof(Count_6_Text), ref fCount_6_Text, value); }
        }
        string fCount_7_Text;
        [Size(25)]
        public string Count_7_Text
        {
            get { return fCount_7_Text; }
            set { SetPropertyValue<string>(nameof(Count_7_Text), ref fCount_7_Text, value); }
        }
        string fCount_8_Text;
        [Size(25)]
        public string Count_8_Text
        {
            get { return fCount_8_Text; }
            set { SetPropertyValue<string>(nameof(Count_8_Text), ref fCount_8_Text, value); }
        }
        string fCount_9_Text;
        [Size(25)]
        public string Count_9_Text
        {
            get { return fCount_9_Text; }
            set { SetPropertyValue<string>(nameof(Count_9_Text), ref fCount_9_Text, value); }
        }
        string fCount_10_Text;
        [Size(25)]
        public string Count_10_Text
        {
            get { return fCount_10_Text; }
            set { SetPropertyValue<string>(nameof(Count_10_Text), ref fCount_10_Text, value); }
        }
        string fCount_11_Text;
        [Size(25)]
        public string Count_11_Text
        {
            get { return fCount_11_Text; }
            set { SetPropertyValue<string>(nameof(Count_11_Text), ref fCount_11_Text, value); }
        }
        string fCount_12_Text;
        [Size(25)]
        public string Count_12_Text
        {
            get { return fCount_12_Text; }
            set { SetPropertyValue<string>(nameof(Count_12_Text), ref fCount_12_Text, value); }
        }
        string fCount_13_Text;
        [Size(25)]
        public string Count_13_Text
        {
            get { return fCount_13_Text; }
            set { SetPropertyValue<string>(nameof(Count_13_Text), ref fCount_13_Text, value); }
        }
        string fCount_14_Text;
        [Size(25)]
        public string Count_14_Text
        {
            get { return fCount_14_Text; }
            set { SetPropertyValue<string>(nameof(Count_14_Text), ref fCount_14_Text, value); }
        }
        string fCount_15_Text;
        [Size(25)]
        public string Count_15_Text
        {
            get { return fCount_15_Text; }
            set { SetPropertyValue<string>(nameof(Count_15_Text), ref fCount_15_Text, value); }
        }
        string fCount_16_Text;
        [Size(25)]
        public string Count_16_Text
        {
            get { return fCount_16_Text; }
            set { SetPropertyValue<string>(nameof(Count_16_Text), ref fCount_16_Text, value); }
        }
        string fCount_17_Text;
        [Size(25)]
        public string Count_17_Text
        {
            get { return fCount_17_Text; }
            set { SetPropertyValue<string>(nameof(Count_17_Text), ref fCount_17_Text, value); }
        }
        string fCount_18_Text;
        [Size(25)]
        public string Count_18_Text
        {
            get { return fCount_18_Text; }
            set { SetPropertyValue<string>(nameof(Count_18_Text), ref fCount_18_Text, value); }
        }
        string fCount_19_Text;
        [Size(25)]
        public string Count_19_Text
        {
            get { return fCount_19_Text; }
            set { SetPropertyValue<string>(nameof(Count_19_Text), ref fCount_19_Text, value); }
        }
        string fCount_20_Text;
        [Size(25)]
        public string Count_20_Text
        {
            get { return fCount_20_Text; }
            set { SetPropertyValue<string>(nameof(Count_20_Text), ref fCount_20_Text, value); }
        }
    }

}