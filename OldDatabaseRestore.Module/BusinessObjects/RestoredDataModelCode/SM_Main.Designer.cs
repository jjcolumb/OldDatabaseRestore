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

    public partial class SM_Main : XPLiteObject
    {
        Guid fSM_Main_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid SM_Main_ID
        {
            get { return fSM_Main_ID; }
            set { SetPropertyValue<Guid>(nameof(SM_Main_ID), ref fSM_Main_ID, value); }
        }
        string fSalesman_Number;
        [Size(10)]
        public string Salesman_Number
        {
            get { return fSalesman_Number; }
            set { SetPropertyValue<string>(nameof(Salesman_Number), ref fSalesman_Number, value); }
        }
        decimal fSalesman_Number_1;
        public decimal Salesman_Number_1
        {
            get { return fSalesman_Number_1; }
            set { SetPropertyValue<decimal>(nameof(Salesman_Number_1), ref fSalesman_Number_1, value); }
        }
        decimal fSalesman_Number_2;
        public decimal Salesman_Number_2
        {
            get { return fSalesman_Number_2; }
            set { SetPropertyValue<decimal>(nameof(Salesman_Number_2), ref fSalesman_Number_2, value); }
        }
        bool fTerritory_Active;
        public bool Territory_Active
        {
            get { return fTerritory_Active; }
            set { SetPropertyValue<bool>(nameof(Territory_Active), ref fTerritory_Active, value); }
        }
        bool fCommission_Protected;
        public bool Commission_Protected
        {
            get { return fCommission_Protected; }
            set { SetPropertyValue<bool>(nameof(Commission_Protected), ref fCommission_Protected, value); }
        }
        string fFirst_Name;
        [Size(50)]
        public string First_Name
        {
            get { return fFirst_Name; }
            set { SetPropertyValue<string>(nameof(First_Name), ref fFirst_Name, value); }
        }
        string fMiddle_Initial;
        [Size(1)]
        public string Middle_Initial
        {
            get { return fMiddle_Initial; }
            set { SetPropertyValue<string>(nameof(Middle_Initial), ref fMiddle_Initial, value); }
        }
        string fLast_Name;
        [Size(50)]
        public string Last_Name
        {
            get { return fLast_Name; }
            set { SetPropertyValue<string>(nameof(Last_Name), ref fLast_Name, value); }
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
        pl_Country fCountry;
        [Association(@"SM_MainReferencespl_Country")]
        public pl_Country Country
        {
            get { return fCountry; }
            set { SetPropertyValue<pl_Country>(nameof(Country), ref fCountry, value); }
        }
        string fCare_Of;
        [Size(50)]
        public string Care_Of
        {
            get { return fCare_Of; }
            set { SetPropertyValue<string>(nameof(Care_Of), ref fCare_Of, value); }
        }
        pl_Phone_Type fPhone_Type_1;
        [Association(@"SM_MainReferencespl_Phone_Type")]
        public pl_Phone_Type Phone_Type_1
        {
            get { return fPhone_Type_1; }
            set { SetPropertyValue<pl_Phone_Type>(nameof(Phone_Type_1), ref fPhone_Type_1, value); }
        }
        string fPhone_Number_1;
        [Size(25)]
        public string Phone_Number_1
        {
            get { return fPhone_Number_1; }
            set { SetPropertyValue<string>(nameof(Phone_Number_1), ref fPhone_Number_1, value); }
        }
        pl_Phone_Type fPhone_Type_2;
        [Association(@"SM_MainReferencespl_Phone_Type1")]
        public pl_Phone_Type Phone_Type_2
        {
            get { return fPhone_Type_2; }
            set { SetPropertyValue<pl_Phone_Type>(nameof(Phone_Type_2), ref fPhone_Type_2, value); }
        }
        string fPhone_Number_2;
        [Size(25)]
        public string Phone_Number_2
        {
            get { return fPhone_Number_2; }
            set { SetPropertyValue<string>(nameof(Phone_Number_2), ref fPhone_Number_2, value); }
        }
        string fFax_Number_1;
        [Size(25)]
        public string Fax_Number_1
        {
            get { return fFax_Number_1; }
            set { SetPropertyValue<string>(nameof(Fax_Number_1), ref fFax_Number_1, value); }
        }
        string fComment_Alt;
        [Size(80)]
        public string Comment_Alt
        {
            get { return fComment_Alt; }
            set { SetPropertyValue<string>(nameof(Comment_Alt), ref fComment_Alt, value); }
        }
        string fName_Alt;
        [Size(50)]
        public string Name_Alt
        {
            get { return fName_Alt; }
            set { SetPropertyValue<string>(nameof(Name_Alt), ref fName_Alt, value); }
        }
        string fAddress_Alt;
        [Size(50)]
        public string Address_Alt
        {
            get { return fAddress_Alt; }
            set { SetPropertyValue<string>(nameof(Address_Alt), ref fAddress_Alt, value); }
        }
        string fOverflow_Alt;
        [Size(50)]
        public string Overflow_Alt
        {
            get { return fOverflow_Alt; }
            set { SetPropertyValue<string>(nameof(Overflow_Alt), ref fOverflow_Alt, value); }
        }
        string fCity_Alt;
        [Size(50)]
        public string City_Alt
        {
            get { return fCity_Alt; }
            set { SetPropertyValue<string>(nameof(City_Alt), ref fCity_Alt, value); }
        }
        string fState_Alt;
        [Size(2)]
        public string State_Alt
        {
            get { return fState_Alt; }
            set { SetPropertyValue<string>(nameof(State_Alt), ref fState_Alt, value); }
        }
        string fZip_Code_Alt;
        [Size(9)]
        public string Zip_Code_Alt
        {
            get { return fZip_Code_Alt; }
            set { SetPropertyValue<string>(nameof(Zip_Code_Alt), ref fZip_Code_Alt, value); }
        }
        int fZone_Alt;
        public int Zone_Alt
        {
            get { return fZone_Alt; }
            set { SetPropertyValue<int>(nameof(Zone_Alt), ref fZone_Alt, value); }
        }
        pl_Country fCountry_Alt;
        [Association(@"SM_MainReferencespl_Country1")]
        public pl_Country Country_Alt
        {
            get { return fCountry_Alt; }
            set { SetPropertyValue<pl_Country>(nameof(Country_Alt), ref fCountry_Alt, value); }
        }
        string fCare_Of_Alt;
        [Size(50)]
        public string Care_Of_Alt
        {
            get { return fCare_Of_Alt; }
            set { SetPropertyValue<string>(nameof(Care_Of_Alt), ref fCare_Of_Alt, value); }
        }
        pl_Phone_Type fPhone_Type_Alt_1;
        [Association(@"SM_MainReferencespl_Phone_Type2")]
        public pl_Phone_Type Phone_Type_Alt_1
        {
            get { return fPhone_Type_Alt_1; }
            set { SetPropertyValue<pl_Phone_Type>(nameof(Phone_Type_Alt_1), ref fPhone_Type_Alt_1, value); }
        }
        string fPhone_Number_1_Alt;
        [Size(25)]
        public string Phone_Number_1_Alt
        {
            get { return fPhone_Number_1_Alt; }
            set { SetPropertyValue<string>(nameof(Phone_Number_1_Alt), ref fPhone_Number_1_Alt, value); }
        }
        pl_Phone_Type fPhone_Type_Alt_2;
        [Association(@"SM_MainReferencespl_Phone_Type3")]
        public pl_Phone_Type Phone_Type_Alt_2
        {
            get { return fPhone_Type_Alt_2; }
            set { SetPropertyValue<pl_Phone_Type>(nameof(Phone_Type_Alt_2), ref fPhone_Type_Alt_2, value); }
        }
        string fPhone_Number_2_Alt;
        [Size(25)]
        public string Phone_Number_2_Alt
        {
            get { return fPhone_Number_2_Alt; }
            set { SetPropertyValue<string>(nameof(Phone_Number_2_Alt), ref fPhone_Number_2_Alt, value); }
        }
        string fFax_Number_1_Alt;
        [Size(25)]
        public string Fax_Number_1_Alt
        {
            get { return fFax_Number_1_Alt; }
            set { SetPropertyValue<string>(nameof(Fax_Number_1_Alt), ref fFax_Number_1_Alt, value); }
        }
        bool fModified_Status;
        public bool Modified_Status
        {
            get { return fModified_Status; }
            set { SetPropertyValue<bool>(nameof(Modified_Status), ref fModified_Status, value); }
        }
        string fEmail_Primary;
        public string Email_Primary
        {
            get { return fEmail_Primary; }
            set { SetPropertyValue<string>(nameof(Email_Primary), ref fEmail_Primary, value); }
        }
        string fEmail_Secondary;
        public string Email_Secondary
        {
            get { return fEmail_Secondary; }
            set { SetPropertyValue<string>(nameof(Email_Secondary), ref fEmail_Secondary, value); }
        }
        string fSalesman_Picture;
        [Size(1000)]
        public string Salesman_Picture
        {
            get { return fSalesman_Picture; }
            set { SetPropertyValue<string>(nameof(Salesman_Picture), ref fSalesman_Picture, value); }
        }
        string fShort_Name;
        [Size(53)]
        public string Short_Name
        {
            get { return fShort_Name; }
            set { SetPropertyValue<string>(nameof(Short_Name), ref fShort_Name, value); }
        }
        string fName;
        [Size(101)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fDescription_Combo;
        [Size(107)]
        public string Description_Combo
        {
            get { return fDescription_Combo; }
            set { SetPropertyValue<string>(nameof(Description_Combo), ref fDescription_Combo, value); }
        }
        string fFirst_N_Last;
        [Size(101)]
        public string First_N_Last
        {
            get { return fFirst_N_Last; }
            set { SetPropertyValue<string>(nameof(First_N_Last), ref fFirst_N_Last, value); }
        }
        int fTerritory_Number;
        public int Territory_Number
        {
            get { return fTerritory_Number; }
            set { SetPropertyValue<int>(nameof(Territory_Number), ref fTerritory_Number, value); }
        }
        [Association(@"RM_OptionsReferencesSM_Main")]
        public XPCollection<RM_Options> RM_Optionss { get { return GetCollection<RM_Options>(nameof(RM_Optionss)); } }
        [Association(@"RM_OptionsReferencesSM_Main1")]
        public XPCollection<RM_Options> RM_Optionss1 { get { return GetCollection<RM_Options>(nameof(RM_Optionss1)); } }
        [Association(@"SL_MainReferencesSM_Main")]
        public XPCollection<SL_Main> SL_Mains { get { return GetCollection<SL_Main>(nameof(SL_Mains)); } }
    }

}
