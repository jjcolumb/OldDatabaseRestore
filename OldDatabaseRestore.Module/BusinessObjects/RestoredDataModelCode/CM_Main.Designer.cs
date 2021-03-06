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

    public partial class CM_Main : XPLiteObject
    {
        Guid fCM_Main_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid CM_Main_ID
        {
            get { return fCM_Main_ID; }
            set { SetPropertyValue<Guid>(nameof(CM_Main_ID), ref fCM_Main_ID, value); }
        }
        decimal fAccount_Number;
        public decimal Account_Number
        {
            get { return fAccount_Number; }
            set { SetPropertyValue<decimal>(nameof(Account_Number), ref fAccount_Number, value); }
        }
        string fAccount_Number_Text;
        [Size(25)]
        public string Account_Number_Text
        {
            get { return fAccount_Number_Text; }
            set { SetPropertyValue<string>(nameof(Account_Number_Text), ref fAccount_Number_Text, value); }
        }
        string fAccount_Number_Main;
        [Indexed(Name = @"IX_CM_Main")]
        [Size(25)]
        public string Account_Number_Main
        {
            get { return fAccount_Number_Main; }
            set { SetPropertyValue<string>(nameof(Account_Number_Main), ref fAccount_Number_Main, value); }
        }
        string fAccount_Number_Suffex;
        [Size(25)]
        public string Account_Number_Suffex
        {
            get { return fAccount_Number_Suffex; }
            set { SetPropertyValue<string>(nameof(Account_Number_Suffex), ref fAccount_Number_Suffex, value); }
        }
        decimal fBillTo_Account_Number;
        public decimal BillTo_Account_Number
        {
            get { return fBillTo_Account_Number; }
            set { SetPropertyValue<decimal>(nameof(BillTo_Account_Number), ref fBillTo_Account_Number, value); }
        }
        decimal fShipTo_Account_Number;
        public decimal ShipTo_Account_Number
        {
            get { return fShipTo_Account_Number; }
            set { SetPropertyValue<decimal>(nameof(ShipTo_Account_Number), ref fShipTo_Account_Number, value); }
        }
        decimal fNew_Account_Number;
        public decimal New_Account_Number
        {
            get { return fNew_Account_Number; }
            set { SetPropertyValue<decimal>(nameof(New_Account_Number), ref fNew_Account_Number, value); }
        }
        DateTime fDate_Time_Created;
        public DateTime Date_Time_Created
        {
            get { return fDate_Time_Created; }
            set { SetPropertyValue<DateTime>(nameof(Date_Time_Created), ref fDate_Time_Created, value); }
        }
        Guid fAccount_Priority;
        public Guid Account_Priority
        {
            get { return fAccount_Priority; }
            set { SetPropertyValue<Guid>(nameof(Account_Priority), ref fAccount_Priority, value); }
        }
        Guid fAccount_Manager;
        public Guid Account_Manager
        {
            get { return fAccount_Manager; }
            set { SetPropertyValue<Guid>(nameof(Account_Manager), ref fAccount_Manager, value); }
        }
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fAddress;
        public string Address
        {
            get { return fAddress; }
            set { SetPropertyValue<string>(nameof(Address), ref fAddress, value); }
        }
        string fOverflow;
        public string Overflow
        {
            get { return fOverflow; }
            set { SetPropertyValue<string>(nameof(Overflow), ref fOverflow, value); }
        }
        string fCity;
        [Size(50)]
        public string City
        {
            get { return fCity; }
            set { SetPropertyValue<string>(nameof(City), ref fCity, value); }
        }
        string fState;
        [Size(2)]
        public string State
        {
            get { return fState; }
            set { SetPropertyValue<string>(nameof(State), ref fState, value); }
        }
        string fZip_Code;
        [Size(9)]
        public string Zip_Code
        {
            get { return fZip_Code; }
            set { SetPropertyValue<string>(nameof(Zip_Code), ref fZip_Code, value); }
        }
        int fZone;
        public int Zone
        {
            get { return fZone; }
            set { SetPropertyValue<int>(nameof(Zone), ref fZone, value); }
        }
        Guid fCountry;
        public Guid Country
        {
            get { return fCountry; }
            set { SetPropertyValue<Guid>(nameof(Country), ref fCountry, value); }
        }
        Guid fAddress_Type;
        public Guid Address_Type
        {
            get { return fAddress_Type; }
            set { SetPropertyValue<Guid>(nameof(Address_Type), ref fAddress_Type, value); }
        }
        Guid fSM_Main_ID;
        public Guid SM_Main_ID
        {
            get { return fSM_Main_ID; }
            set { SetPropertyValue<Guid>(nameof(SM_Main_ID), ref fSM_Main_ID, value); }
        }
        bool fDelete_Flag;
        public bool Delete_Flag
        {
            get { return fDelete_Flag; }
            set { SetPropertyValue<bool>(nameof(Delete_Flag), ref fDelete_Flag, value); }
        }
        decimal fNew_Account_Number1;
        public decimal New_Account_Number1
        {
            get { return fNew_Account_Number1; }
            set { SetPropertyValue<decimal>(nameof(New_Account_Number1), ref fNew_Account_Number1, value); }
        }
        Guid fAddress_ShipType;
        public Guid Address_ShipType
        {
            get { return fAddress_ShipType; }
            set { SetPropertyValue<Guid>(nameof(Address_ShipType), ref fAddress_ShipType, value); }
        }
        string fFull_Address_5_Lines;
        [Size(1000)]
        public string Full_Address_5_Lines
        {
            get { return fFull_Address_5_Lines; }
            set { SetPropertyValue<string>(nameof(Full_Address_5_Lines), ref fFull_Address_5_Lines, value); }
        }
        Guid fNode_Link_ID;
        public Guid Node_Link_ID
        {
            get { return fNode_Link_ID; }
            set { SetPropertyValue<Guid>(nameof(Node_Link_ID), ref fNode_Link_ID, value); }
        }
        string fSearch_Results_Info;
        [Size(8000)]
        public string Search_Results_Info
        {
            get { return fSearch_Results_Info; }
            set { SetPropertyValue<string>(nameof(Search_Results_Info), ref fSearch_Results_Info, value); }
        }
        int fGood_Zip;
        public int Good_Zip
        {
            get { return fGood_Zip; }
            set { SetPropertyValue<int>(nameof(Good_Zip), ref fGood_Zip, value); }
        }
        bool fDelete_Flag_Check;
        public bool Delete_Flag_Check
        {
            get { return fDelete_Flag_Check; }
            set { SetPropertyValue<bool>(nameof(Delete_Flag_Check), ref fDelete_Flag_Check, value); }
        }
        string fOld_Account_Number;
        [Size(25)]
        public string Old_Account_Number
        {
            get { return fOld_Account_Number; }
            set { SetPropertyValue<string>(nameof(Old_Account_Number), ref fOld_Account_Number, value); }
        }
        decimal fAccount_Number_Main_Sort;
        public decimal Account_Number_Main_Sort
        {
            get { return fAccount_Number_Main_Sort; }
            set { SetPropertyValue<decimal>(nameof(Account_Number_Main_Sort), ref fAccount_Number_Main_Sort, value); }
        }
        decimal fAccount_Number_Full_Sort;
        public decimal Account_Number_Full_Sort
        {
            get { return fAccount_Number_Full_Sort; }
            set { SetPropertyValue<decimal>(nameof(Account_Number_Full_Sort), ref fAccount_Number_Full_Sort, value); }
        }
        string fAlpha;
        public string Alpha
        {
            get { return fAlpha; }
            set { SetPropertyValue<string>(nameof(Alpha), ref fAlpha, value); }
        }
        string fAN_Alpha;
        [Size(1)]
        public string AN_Alpha
        {
            get { return fAN_Alpha; }
            set { SetPropertyValue<string>(nameof(AN_Alpha), ref fAN_Alpha, value); }
        }
        int fAccount_Number_Suffex_Int;
        public int Account_Number_Suffex_Int
        {
            get { return fAccount_Number_Suffex_Int; }
            set { SetPropertyValue<int>(nameof(Account_Number_Suffex_Int), ref fAccount_Number_Suffex_Int, value); }
        }
        string fAccount_Number_Main_Full;
        [Size(31)]
        public string Account_Number_Main_Full
        {
            get { return fAccount_Number_Main_Full; }
            set { SetPropertyValue<string>(nameof(Account_Number_Main_Full), ref fAccount_Number_Main_Full, value); }
        }
        string fDisplay_Address_Info;
        [Size(244)]
        public string Display_Address_Info
        {
            get { return fDisplay_Address_Info; }
            set { SetPropertyValue<string>(nameof(Display_Address_Info), ref fDisplay_Address_Info, value); }
        }
        int fzip_zone;
        public int zip_zone
        {
            get { return fzip_zone; }
            set { SetPropertyValue<int>(nameof(zip_zone), ref fzip_zone, value); }
        }
        string fDate_n_Time_Created_FMT;
        [Size(31)]
        public string Date_n_Time_Created_FMT
        {
            get { return fDate_n_Time_Created_FMT; }
            set { SetPropertyValue<string>(nameof(Date_n_Time_Created_FMT), ref fDate_n_Time_Created_FMT, value); }
        }
        string fAddress_5_Line;
        [Size(1000)]
        public string Address_5_Line
        {
            get { return fAddress_5_Line; }
            set { SetPropertyValue<string>(nameof(Address_5_Line), ref fAddress_5_Line, value); }
        }
        decimal fAccount_Number_Main_Decimal;
        public decimal Account_Number_Main_Decimal
        {
            get { return fAccount_Number_Main_Decimal; }
            set { SetPropertyValue<decimal>(nameof(Account_Number_Main_Decimal), ref fAccount_Number_Main_Decimal, value); }
        }
        string fSearch_Name;
        [Size(255)]
        public string Search_Name
        {
            get { return fSearch_Name; }
            set { SetPropertyValue<string>(nameof(Search_Name), ref fSearch_Name, value); }
        }
        [Association(@"AI_ItemsReferencesCM_Main")]
        public XPCollection<AI_Items> AI_Itemss { get { return GetCollection<AI_Items>(nameof(AI_Itemss)); } }
        [Association(@"AI_MainReferencesCM_Main")]
        public XPCollection<AI_Main> AI_Mains { get { return GetCollection<AI_Main>(nameof(AI_Mains)); } }
        [Association(@"CM_ChainReferencesCM_Main")]
        public XPCollection<CM_Chain> CM_Chains { get { return GetCollection<CM_Chain>(nameof(CM_Chains)); } }
        [Association(@"CM_ChainReferencesCM_Main1")]
        public XPCollection<CM_Chain> CM_Chains1 { get { return GetCollection<CM_Chain>(nameof(CM_Chains1)); } }
        [Association(@"CM_CommentsReferencesCM_Main")]
        public XPCollection<CM_Comments> CM_Commentss { get { return GetCollection<CM_Comments>(nameof(CM_Commentss)); } }
        [Association(@"CM_ContactsReferencesCM_Main")]
        public XPCollection<CM_Contacts> CM_Contactss { get { return GetCollection<CM_Contacts>(nameof(CM_Contactss)); } }
        [Association(@"CM_Credit_ReferenceReferencesCM_Main")]
        public XPCollection<CM_Credit_Reference> CM_Credit_References { get { return GetCollection<CM_Credit_Reference>(nameof(CM_Credit_References)); } }
        [Association(@"CM_Credit_TrackingReferencesCM_Main")]
        public XPCollection<CM_Credit_Tracking> CM_Credit_Trackings { get { return GetCollection<CM_Credit_Tracking>(nameof(CM_Credit_Trackings)); } }
        [Association(@"CM_HistoryReferencesCM_Main")]
        public XPCollection<CM_History> CM_Historys { get { return GetCollection<CM_History>(nameof(CM_Historys)); } }
        [Association(@"CM_OptionsReferencesCM_Main")]
        public XPCollection<CM_Options> CM_Optionss { get { return GetCollection<CM_Options>(nameof(CM_Optionss)); } }
        [Association(@"CM_XrefReferencesCM_Main")]
        public XPCollection<CM_Xref> CM_Xrefs { get { return GetCollection<CM_Xref>(nameof(CM_Xrefs)); } }
        [Association(@"IV_MainReferencesCM_Main")]
        public XPCollection<IV_Main> IV_Mains { get { return GetCollection<IV_Main>(nameof(IV_Mains)); } }
        [Association(@"Leslie1ReferencesCM_Main")]
        public XPCollection<Leslie1> Leslie1s { get { return GetCollection<Leslie1>(nameof(Leslie1s)); } }
        [Association(@"OI_ItemsReferencesCM_Main")]
        public XPCollection<OI_Items> OI_Itemss { get { return GetCollection<OI_Items>(nameof(OI_Itemss)); } }
        [Association(@"OI_MainReferencesCM_Main")]
        public XPCollection<OI_Main> OI_Mains { get { return GetCollection<OI_Main>(nameof(OI_Mains)); } }
        [Association(@"OI_UnappliedReferencesCM_Main")]
        public XPCollection<OI_Unapplied> OI_Unapplieds { get { return GetCollection<OI_Unapplied>(nameof(OI_Unapplieds)); } }
        [Association(@"RM_MainReferencesCM_Main")]
        public XPCollection<RM_Main> RM_Mains { get { return GetCollection<RM_Main>(nameof(RM_Mains)); } }
        [Association(@"RM_MainReferencesCM_Main1")]
        public XPCollection<RM_Main> RM_Mains1 { get { return GetCollection<RM_Main>(nameof(RM_Mains1)); } }
    }

}
