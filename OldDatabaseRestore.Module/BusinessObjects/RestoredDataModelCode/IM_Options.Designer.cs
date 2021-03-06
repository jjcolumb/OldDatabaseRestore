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

    public partial class IM_Options : XPLiteObject
    {
        Guid fIM_Options_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid IM_Options_ID
        {
            get { return fIM_Options_ID; }
            set { SetPropertyValue<Guid>(nameof(IM_Options_ID), ref fIM_Options_ID, value); }
        }
        IM_Main fIM_Main_ID;
        [Association(@"IM_OptionsReferencesIM_Main")]
        public IM_Main IM_Main_ID
        {
            get { return fIM_Main_ID; }
            set { SetPropertyValue<IM_Main>(nameof(IM_Main_ID), ref fIM_Main_ID, value); }
        }
        string fPage_Number_1;
        [Size(25)]
        public string Page_Number_1
        {
            get { return fPage_Number_1; }
            set { SetPropertyValue<string>(nameof(Page_Number_1), ref fPage_Number_1, value); }
        }
        string fPage_Number_2;
        [Size(25)]
        public string Page_Number_2
        {
            get { return fPage_Number_2; }
            set { SetPropertyValue<string>(nameof(Page_Number_2), ref fPage_Number_2, value); }
        }
        string fPage_Number_3;
        [Size(25)]
        public string Page_Number_3
        {
            get { return fPage_Number_3; }
            set { SetPropertyValue<string>(nameof(Page_Number_3), ref fPage_Number_3, value); }
        }
        string fCatalogue_Copy;
        [Size(SizeAttribute.Unlimited)]
        public string Catalogue_Copy
        {
            get { return fCatalogue_Copy; }
            set { SetPropertyValue<string>(nameof(Catalogue_Copy), ref fCatalogue_Copy, value); }
        }
        bool fCopywrited;
        public bool Copywrited
        {
            get { return fCopywrited; }
            set { SetPropertyValue<bool>(nameof(Copywrited), ref fCopywrited, value); }
        }
        bool fTrademarked;
        public bool Trademarked
        {
            get { return fTrademarked; }
            set { SetPropertyValue<bool>(nameof(Trademarked), ref fTrademarked, value); }
        }
        DateTime fCopywrite_Date;
        public DateTime Copywrite_Date
        {
            get { return fCopywrite_Date; }
            set { SetPropertyValue<DateTime>(nameof(Copywrite_Date), ref fCopywrite_Date, value); }
        }
        DateTime fTrademark_Date;
        public DateTime Trademark_Date
        {
            get { return fTrademark_Date; }
            set { SetPropertyValue<DateTime>(nameof(Trademark_Date), ref fTrademark_Date, value); }
        }
        bool fSupplier_Comments;
        public bool Supplier_Comments
        {
            get { return fSupplier_Comments; }
            set { SetPropertyValue<bool>(nameof(Supplier_Comments), ref fSupplier_Comments, value); }
        }
        bool fBuyers_Comments;
        public bool Buyers_Comments
        {
            get { return fBuyers_Comments; }
            set { SetPropertyValue<bool>(nameof(Buyers_Comments), ref fBuyers_Comments, value); }
        }
        UD_Main fUD_Main_ID;
        [Association(@"IM_OptionsReferencesUD_Main")]
        public UD_Main UD_Main_ID
        {
            get { return fUD_Main_ID; }
            set { SetPropertyValue<UD_Main>(nameof(UD_Main_ID), ref fUD_Main_ID, value); }
        }
        bool fBO_Item;
        public bool BO_Item
        {
            get { return fBO_Item; }
            set { SetPropertyValue<bool>(nameof(BO_Item), ref fBO_Item, value); }
        }
        bool fAllocate_Item;
        public bool Allocate_Item
        {
            get { return fAllocate_Item; }
            set { SetPropertyValue<bool>(nameof(Allocate_Item), ref fAllocate_Item, value); }
        }
        bool fPrint_Price_Card;
        public bool Print_Price_Card
        {
            get { return fPrint_Price_Card; }
            set { SetPropertyValue<bool>(nameof(Print_Price_Card), ref fPrint_Price_Card, value); }
        }
        bool fAllow_Duplicate_Items_On_Orders;
        public bool Allow_Duplicate_Items_On_Orders
        {
            get { return fAllow_Duplicate_Items_On_Orders; }
            set { SetPropertyValue<bool>(nameof(Allow_Duplicate_Items_On_Orders), ref fAllow_Duplicate_Items_On_Orders, value); }
        }
        bool fImprint_Item;
        public bool Imprint_Item
        {
            get { return fImprint_Item; }
            set { SetPropertyValue<bool>(nameof(Imprint_Item), ref fImprint_Item, value); }
        }
        bool fDelete_Item;
        public bool Delete_Item
        {
            get { return fDelete_Item; }
            set { SetPropertyValue<bool>(nameof(Delete_Item), ref fDelete_Item, value); }
        }
        bool fOK_To_Delete_Item;
        public bool OK_To_Delete_Item
        {
            get { return fOK_To_Delete_Item; }
            set { SetPropertyValue<bool>(nameof(OK_To_Delete_Item), ref fOK_To_Delete_Item, value); }
        }
        int fShipping_Class;
        public int Shipping_Class
        {
            get { return fShipping_Class; }
            set { SetPropertyValue<int>(nameof(Shipping_Class), ref fShipping_Class, value); }
        }
        SD_Main fSD_Main_ID;
        [Association(@"IM_OptionsReferencesSD_Main")]
        public SD_Main SD_Main_ID
        {
            get { return fSD_Main_ID; }
            set { SetPropertyValue<SD_Main>(nameof(SD_Main_ID), ref fSD_Main_ID, value); }
        }
        pl_Country fCountry;
        [Association(@"IM_OptionsReferencespl_Country")]
        public pl_Country Country
        {
            get { return fCountry; }
            set { SetPropertyValue<pl_Country>(nameof(Country), ref fCountry, value); }
        }
        string fSuppliers_Item_Number;
        [Size(50)]
        public string Suppliers_Item_Number
        {
            get { return fSuppliers_Item_Number; }
            set { SetPropertyValue<string>(nameof(Suppliers_Item_Number), ref fSuppliers_Item_Number, value); }
        }
        string fItem_Size;
        [Size(SizeAttribute.Unlimited)]
        public string Item_Size
        {
            get { return fItem_Size; }
            set { SetPropertyValue<string>(nameof(Item_Size), ref fItem_Size, value); }
        }
        string fItem_Color;
        [Size(SizeAttribute.Unlimited)]
        public string Item_Color
        {
            get { return fItem_Color; }
            set { SetPropertyValue<string>(nameof(Item_Color), ref fItem_Color, value); }
        }
        bool fAssort_For_Price;
        public bool Assort_For_Price
        {
            get { return fAssort_For_Price; }
            set { SetPropertyValue<bool>(nameof(Assort_For_Price), ref fAssort_For_Price, value); }
        }
        int fAssort_For_Price_Tag;
        public int Assort_For_Price_Tag
        {
            get { return fAssort_For_Price_Tag; }
            set { SetPropertyValue<int>(nameof(Assort_For_Price_Tag), ref fAssort_For_Price_Tag, value); }
        }
        Guid fBuyers_Code;
        public Guid Buyers_Code
        {
            get { return fBuyers_Code; }
            set { SetPropertyValue<Guid>(nameof(Buyers_Code), ref fBuyers_Code, value); }
        }
        string fSupplier_Comment;
        [Size(SizeAttribute.Unlimited)]
        public string Supplier_Comment
        {
            get { return fSupplier_Comment; }
            set { SetPropertyValue<string>(nameof(Supplier_Comment), ref fSupplier_Comment, value); }
        }
        string fBuyer_Comment;
        [Size(SizeAttribute.Unlimited)]
        public string Buyer_Comment
        {
            get { return fBuyer_Comment; }
            set { SetPropertyValue<string>(nameof(Buyer_Comment), ref fBuyer_Comment, value); }
        }
        bool fMIXEDCASE;
        public bool MIXEDCASE
        {
            get { return fMIXEDCASE; }
            set { SetPropertyValue<bool>(nameof(MIXEDCASE), ref fMIXEDCASE, value); }
        }
        string fSuppliers_Description;
        [Size(50)]
        public string Suppliers_Description
        {
            get { return fSuppliers_Description; }
            set { SetPropertyValue<string>(nameof(Suppliers_Description), ref fSuppliers_Description, value); }
        }
    }

}
