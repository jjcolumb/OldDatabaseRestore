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

    public partial class CM_Contacts : XPLiteObject
    {
        Guid fCM_Contacts_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid CM_Contacts_ID
        {
            get { return fCM_Contacts_ID; }
            set { SetPropertyValue<Guid>(nameof(CM_Contacts_ID), ref fCM_Contacts_ID, value); }
        }
        CM_Main fCM_Main_ID;
        [Association(@"CM_ContactsReferencesCM_Main")]
        public CM_Main CM_Main_ID
        {
            get { return fCM_Main_ID; }
            set { SetPropertyValue<CM_Main>(nameof(CM_Main_ID), ref fCM_Main_ID, value); }
        }
        string fContact_Name;
        [Size(50)]
        public string Contact_Name
        {
            get { return fContact_Name; }
            set { SetPropertyValue<string>(nameof(Contact_Name), ref fContact_Name, value); }
        }
        pl_Title fTitle;
        [Association(@"CM_ContactsReferencespl_Title")]
        public pl_Title Title
        {
            get { return fTitle; }
            set { SetPropertyValue<pl_Title>(nameof(Title), ref fTitle, value); }
        }
        pl_Phone_Type fPhone_Type;
        [Association(@"CM_ContactsReferencespl_Phone_Type")]
        public pl_Phone_Type Phone_Type
        {
            get { return fPhone_Type; }
            set { SetPropertyValue<pl_Phone_Type>(nameof(Phone_Type), ref fPhone_Type, value); }
        }
        string fPhone_Number;
        [Size(25)]
        public string Phone_Number
        {
            get { return fPhone_Number; }
            set { SetPropertyValue<string>(nameof(Phone_Number), ref fPhone_Number, value); }
        }
        string fExtension;
        [Size(10)]
        public string Extension
        {
            get { return fExtension; }
            set { SetPropertyValue<string>(nameof(Extension), ref fExtension, value); }
        }
        string fFax_Number;
        [Size(25)]
        public string Fax_Number
        {
            get { return fFax_Number; }
            set { SetPropertyValue<string>(nameof(Fax_Number), ref fFax_Number, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        string fAccount_Number_Main;
        [Size(25)]
        public string Account_Number_Main
        {
            get { return fAccount_Number_Main; }
            set { SetPropertyValue<string>(nameof(Account_Number_Main), ref fAccount_Number_Main, value); }
        }
        int fMax_Return;
        public int Max_Return
        {
            get { return fMax_Return; }
            set { SetPropertyValue<int>(nameof(Max_Return), ref fMax_Return, value); }
        }
        decimal fPhone_Number_Decimal;
        public decimal Phone_Number_Decimal
        {
            get { return fPhone_Number_Decimal; }
            set { SetPropertyValue<decimal>(nameof(Phone_Number_Decimal), ref fPhone_Number_Decimal, value); }
        }
        decimal fExtension_Decimal;
        public decimal Extension_Decimal
        {
            get { return fExtension_Decimal; }
            set { SetPropertyValue<decimal>(nameof(Extension_Decimal), ref fExtension_Decimal, value); }
        }
        decimal fFax_Number_Decimal;
        public decimal Fax_Number_Decimal
        {
            get { return fFax_Number_Decimal; }
            set { SetPropertyValue<decimal>(nameof(Fax_Number_Decimal), ref fFax_Number_Decimal, value); }
        }
    }

}