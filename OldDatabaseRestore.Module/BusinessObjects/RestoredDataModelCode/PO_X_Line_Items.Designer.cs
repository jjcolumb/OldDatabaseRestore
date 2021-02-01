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

    public partial class PO_X_Line_Items : XPLiteObject
    {
        Guid fPO_X_Line_Items_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid PO_X_Line_Items_ID
        {
            get { return fPO_X_Line_Items_ID; }
            set { SetPropertyValue<Guid>(nameof(PO_X_Line_Items_ID), ref fPO_X_Line_Items_ID, value); }
        }
        PO_Main fPO_Main_ID;
        [Association(@"PO_X_Line_ItemsReferencesPO_Main")]
        public PO_Main PO_Main_ID
        {
            get { return fPO_Main_ID; }
            set { SetPropertyValue<PO_Main>(nameof(PO_Main_ID), ref fPO_Main_ID, value); }
        }
        PO_Line_Items fPO_Line_Items_ID;
        [Association(@"PO_X_Line_ItemsReferencesPO_Line_Items")]
        public PO_Line_Items PO_Line_Items_ID
        {
            get { return fPO_Line_Items_ID; }
            set { SetPropertyValue<PO_Line_Items>(nameof(PO_Line_Items_ID), ref fPO_Line_Items_ID, value); }
        }
        string fUPC_Code;
        [Size(13)]
        public string UPC_Code
        {
            get { return fUPC_Code; }
            set { SetPropertyValue<string>(nameof(UPC_Code), ref fUPC_Code, value); }
        }
        DateTime fLine_Date;
        public DateTime Line_Date
        {
            get { return fLine_Date; }
            set { SetPropertyValue<DateTime>(nameof(Line_Date), ref fLine_Date, value); }
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
        bool fImprint_Item;
        public bool Imprint_Item
        {
            get { return fImprint_Item; }
            set { SetPropertyValue<bool>(nameof(Imprint_Item), ref fImprint_Item, value); }
        }
        int fItem_Pack_QTY;
        public int Item_Pack_QTY
        {
            get { return fItem_Pack_QTY; }
            set { SetPropertyValue<int>(nameof(Item_Pack_QTY), ref fItem_Pack_QTY, value); }
        }
        pl_Unit fItem_Pack_Each_Unit;
        [Association(@"PO_X_Line_ItemsReferencespl_Unit")]
        public pl_Unit Item_Pack_Each_Unit
        {
            get { return fItem_Pack_Each_Unit; }
            set { SetPropertyValue<pl_Unit>(nameof(Item_Pack_Each_Unit), ref fItem_Pack_Each_Unit, value); }
        }
        int fItem_Pack_Each_BL;
        public int Item_Pack_Each_BL
        {
            get { return fItem_Pack_Each_BL; }
            set { SetPropertyValue<int>(nameof(Item_Pack_Each_BL), ref fItem_Pack_Each_BL, value); }
        }
        pl_How_Each_Packed fItem_Pack_Each;
        [Association(@"PO_X_Line_ItemsReferencespl_How_Each_Packed")]
        public pl_How_Each_Packed Item_Pack_Each
        {
            get { return fItem_Pack_Each; }
            set { SetPropertyValue<pl_How_Each_Packed>(nameof(Item_Pack_Each), ref fItem_Pack_Each, value); }
        }
        int fInner_Pack_QTY_1;
        public int Inner_Pack_QTY_1
        {
            get { return fInner_Pack_QTY_1; }
            set { SetPropertyValue<int>(nameof(Inner_Pack_QTY_1), ref fInner_Pack_QTY_1, value); }
        }
        pl_Unit fInner_Pack_Each_Unit_1;
        [Association(@"PO_X_Line_ItemsReferencespl_Unit1")]
        public pl_Unit Inner_Pack_Each_Unit_1
        {
            get { return fInner_Pack_Each_Unit_1; }
            set { SetPropertyValue<pl_Unit>(nameof(Inner_Pack_Each_Unit_1), ref fInner_Pack_Each_Unit_1, value); }
        }
        int fInner_Pack_Each_BL_1;
        public int Inner_Pack_Each_BL_1
        {
            get { return fInner_Pack_Each_BL_1; }
            set { SetPropertyValue<int>(nameof(Inner_Pack_Each_BL_1), ref fInner_Pack_Each_BL_1, value); }
        }
        pl_How_Each_Packed fInner_Pack_Each_1;
        [Association(@"PO_X_Line_ItemsReferencespl_How_Each_Packed1")]
        public pl_How_Each_Packed Inner_Pack_Each_1
        {
            get { return fInner_Pack_Each_1; }
            set { SetPropertyValue<pl_How_Each_Packed>(nameof(Inner_Pack_Each_1), ref fInner_Pack_Each_1, value); }
        }
        int fInner_Pack_QTY_2;
        public int Inner_Pack_QTY_2
        {
            get { return fInner_Pack_QTY_2; }
            set { SetPropertyValue<int>(nameof(Inner_Pack_QTY_2), ref fInner_Pack_QTY_2, value); }
        }
        pl_Unit fInner_Pack_Each_Unit_2;
        [Association(@"PO_X_Line_ItemsReferencespl_Unit2")]
        public pl_Unit Inner_Pack_Each_Unit_2
        {
            get { return fInner_Pack_Each_Unit_2; }
            set { SetPropertyValue<pl_Unit>(nameof(Inner_Pack_Each_Unit_2), ref fInner_Pack_Each_Unit_2, value); }
        }
        int fInner_Pack_Each_BL_2;
        public int Inner_Pack_Each_BL_2
        {
            get { return fInner_Pack_Each_BL_2; }
            set { SetPropertyValue<int>(nameof(Inner_Pack_Each_BL_2), ref fInner_Pack_Each_BL_2, value); }
        }
        pl_How_Each_Packed fInner_Pack_Each_2;
        [Association(@"PO_X_Line_ItemsReferencespl_How_Each_Packed2")]
        public pl_How_Each_Packed Inner_Pack_Each_2
        {
            get { return fInner_Pack_Each_2; }
            set { SetPropertyValue<pl_How_Each_Packed>(nameof(Inner_Pack_Each_2), ref fInner_Pack_Each_2, value); }
        }
        int fInner_Pack_QTY_3;
        public int Inner_Pack_QTY_3
        {
            get { return fInner_Pack_QTY_3; }
            set { SetPropertyValue<int>(nameof(Inner_Pack_QTY_3), ref fInner_Pack_QTY_3, value); }
        }
        pl_Unit fInner_Pack_Each_Unit_3;
        [Association(@"PO_X_Line_ItemsReferencespl_Unit3")]
        public pl_Unit Inner_Pack_Each_Unit_3
        {
            get { return fInner_Pack_Each_Unit_3; }
            set { SetPropertyValue<pl_Unit>(nameof(Inner_Pack_Each_Unit_3), ref fInner_Pack_Each_Unit_3, value); }
        }
        int fInner_Pack_Each_BL_3;
        public int Inner_Pack_Each_BL_3
        {
            get { return fInner_Pack_Each_BL_3; }
            set { SetPropertyValue<int>(nameof(Inner_Pack_Each_BL_3), ref fInner_Pack_Each_BL_3, value); }
        }
        pl_How_Each_Packed fInner_Pack_Each_3;
        [Association(@"PO_X_Line_ItemsReferencespl_How_Each_Packed3")]
        public pl_How_Each_Packed Inner_Pack_Each_3
        {
            get { return fInner_Pack_Each_3; }
            set { SetPropertyValue<pl_How_Each_Packed>(nameof(Inner_Pack_Each_3), ref fInner_Pack_Each_3, value); }
        }
        pl_Unit fPicking_Unit;
        [Association(@"PO_X_Line_ItemsReferencespl_Unit4")]
        public pl_Unit Picking_Unit
        {
            get { return fPicking_Unit; }
            set { SetPropertyValue<pl_Unit>(nameof(Picking_Unit), ref fPicking_Unit, value); }
        }
        int fPicking_QTY_BL;
        public int Picking_QTY_BL
        {
            get { return fPicking_QTY_BL; }
            set { SetPropertyValue<int>(nameof(Picking_QTY_BL), ref fPicking_QTY_BL, value); }
        }
        int fPicking_QTY;
        public int Picking_QTY
        {
            get { return fPicking_QTY; }
            set { SetPropertyValue<int>(nameof(Picking_QTY), ref fPicking_QTY, value); }
        }
        pl_Unit fCase_Unit;
        [Association(@"PO_X_Line_ItemsReferencespl_Unit5")]
        public pl_Unit Case_Unit
        {
            get { return fCase_Unit; }
            set { SetPropertyValue<pl_Unit>(nameof(Case_Unit), ref fCase_Unit, value); }
        }
        int fCase_QTY_BL;
        public int Case_QTY_BL
        {
            get { return fCase_QTY_BL; }
            set { SetPropertyValue<int>(nameof(Case_QTY_BL), ref fCase_QTY_BL, value); }
        }
        int fCase_QTY;
        public int Case_QTY
        {
            get { return fCase_QTY; }
            set { SetPropertyValue<int>(nameof(Case_QTY), ref fCase_QTY, value); }
        }
        decimal fWeight;
        public decimal Weight
        {
            get { return fWeight; }
            set { SetPropertyValue<decimal>(nameof(Weight), ref fWeight, value); }
        }
        decimal fCase_Cubic_Ft;
        public decimal Case_Cubic_Ft
        {
            get { return fCase_Cubic_Ft; }
            set { SetPropertyValue<decimal>(nameof(Case_Cubic_Ft), ref fCase_Cubic_Ft, value); }
        }
        pl_Unit fSet_2_Sell_Unit;
        [Association(@"PO_X_Line_ItemsReferencespl_Unit6")]
        public pl_Unit Set_2_Sell_Unit
        {
            get { return fSet_2_Sell_Unit; }
            set { SetPropertyValue<pl_Unit>(nameof(Set_2_Sell_Unit), ref fSet_2_Sell_Unit, value); }
        }
        int fSet_2_Sell_BL;
        public int Set_2_Sell_BL
        {
            get { return fSet_2_Sell_BL; }
            set { SetPropertyValue<int>(nameof(Set_2_Sell_BL), ref fSet_2_Sell_BL, value); }
        }
        int fSet_2_Minimum_Order;
        public int Set_2_Minimum_Order
        {
            get { return fSet_2_Minimum_Order; }
            set { SetPropertyValue<int>(nameof(Set_2_Minimum_Order), ref fSet_2_Minimum_Order, value); }
        }
        int fSet_2_Multiple_Order;
        public int Set_2_Multiple_Order
        {
            get { return fSet_2_Multiple_Order; }
            set { SetPropertyValue<int>(nameof(Set_2_Multiple_Order), ref fSet_2_Multiple_Order, value); }
        }
        int fSet_2_QTY_0;
        public int Set_2_QTY_0
        {
            get { return fSet_2_QTY_0; }
            set { SetPropertyValue<int>(nameof(Set_2_QTY_0), ref fSet_2_QTY_0, value); }
        }
        int fSet_2_QTY_1;
        public int Set_2_QTY_1
        {
            get { return fSet_2_QTY_1; }
            set { SetPropertyValue<int>(nameof(Set_2_QTY_1), ref fSet_2_QTY_1, value); }
        }
        int fSet_2_QTY_2;
        public int Set_2_QTY_2
        {
            get { return fSet_2_QTY_2; }
            set { SetPropertyValue<int>(nameof(Set_2_QTY_2), ref fSet_2_QTY_2, value); }
        }
        int fSet_2_QTY_3;
        public int Set_2_QTY_3
        {
            get { return fSet_2_QTY_3; }
            set { SetPropertyValue<int>(nameof(Set_2_QTY_3), ref fSet_2_QTY_3, value); }
        }
        int fSet_2_QTY_4;
        public int Set_2_QTY_4
        {
            get { return fSet_2_QTY_4; }
            set { SetPropertyValue<int>(nameof(Set_2_QTY_4), ref fSet_2_QTY_4, value); }
        }
        decimal fSet_2_Price_0;
        public decimal Set_2_Price_0
        {
            get { return fSet_2_Price_0; }
            set { SetPropertyValue<decimal>(nameof(Set_2_Price_0), ref fSet_2_Price_0, value); }
        }
        decimal fSet_2_Price_1;
        public decimal Set_2_Price_1
        {
            get { return fSet_2_Price_1; }
            set { SetPropertyValue<decimal>(nameof(Set_2_Price_1), ref fSet_2_Price_1, value); }
        }
        decimal fSet_2_Price_2;
        public decimal Set_2_Price_2
        {
            get { return fSet_2_Price_2; }
            set { SetPropertyValue<decimal>(nameof(Set_2_Price_2), ref fSet_2_Price_2, value); }
        }
        decimal fSet_2_Price_3;
        public decimal Set_2_Price_3
        {
            get { return fSet_2_Price_3; }
            set { SetPropertyValue<decimal>(nameof(Set_2_Price_3), ref fSet_2_Price_3, value); }
        }
        decimal fSet_2_Price_4;
        public decimal Set_2_Price_4
        {
            get { return fSet_2_Price_4; }
            set { SetPropertyValue<decimal>(nameof(Set_2_Price_4), ref fSet_2_Price_4, value); }
        }
        int fSet_2_Commission_0;
        public int Set_2_Commission_0
        {
            get { return fSet_2_Commission_0; }
            set { SetPropertyValue<int>(nameof(Set_2_Commission_0), ref fSet_2_Commission_0, value); }
        }
        int fSet_2_Commission_1;
        public int Set_2_Commission_1
        {
            get { return fSet_2_Commission_1; }
            set { SetPropertyValue<int>(nameof(Set_2_Commission_1), ref fSet_2_Commission_1, value); }
        }
        int fSet_2_Commission_2;
        public int Set_2_Commission_2
        {
            get { return fSet_2_Commission_2; }
            set { SetPropertyValue<int>(nameof(Set_2_Commission_2), ref fSet_2_Commission_2, value); }
        }
        int fSet_2_Commission_3;
        public int Set_2_Commission_3
        {
            get { return fSet_2_Commission_3; }
            set { SetPropertyValue<int>(nameof(Set_2_Commission_3), ref fSet_2_Commission_3, value); }
        }
        int fSet_2_Commission_4;
        public int Set_2_Commission_4
        {
            get { return fSet_2_Commission_4; }
            set { SetPropertyValue<int>(nameof(Set_2_Commission_4), ref fSet_2_Commission_4, value); }
        }
        DateTime fSet_2_Effective_Date;
        public DateTime Set_2_Effective_Date
        {
            get { return fSet_2_Effective_Date; }
            set { SetPropertyValue<DateTime>(nameof(Set_2_Effective_Date), ref fSet_2_Effective_Date, value); }
        }
        bool fUpdate_Price_Set;
        public bool Update_Price_Set
        {
            get { return fUpdate_Price_Set; }
            set { SetPropertyValue<bool>(nameof(Update_Price_Set), ref fUpdate_Price_Set, value); }
        }
        bool fPrice_Set_Updated;
        public bool Price_Set_Updated
        {
            get { return fPrice_Set_Updated; }
            set { SetPropertyValue<bool>(nameof(Price_Set_Updated), ref fPrice_Set_Updated, value); }
        }
        bool fImprint_Item_99;
        public bool Imprint_Item_99
        {
            get { return fImprint_Item_99; }
            set { SetPropertyValue<bool>(nameof(Imprint_Item_99), ref fImprint_Item_99, value); }
        }
        int fItem_Imprint_QTY;
        public int Item_Imprint_QTY
        {
            get { return fItem_Imprint_QTY; }
            set { SetPropertyValue<int>(nameof(Item_Imprint_QTY), ref fItem_Imprint_QTY, value); }
        }
        bool fUpdate_Price_Set_1;
        public bool Update_Price_Set_1
        {
            get { return fUpdate_Price_Set_1; }
            set { SetPropertyValue<bool>(nameof(Update_Price_Set_1), ref fUpdate_Price_Set_1, value); }
        }
        bool fFlySheet;
        public bool FlySheet
        {
            get { return fFlySheet; }
            set { SetPropertyValue<bool>(nameof(FlySheet), ref fFlySheet, value); }
        }
        DateTime fFlySheet_Date_Printed;
        public DateTime FlySheet_Date_Printed
        {
            get { return fFlySheet_Date_Printed; }
            set { SetPropertyValue<DateTime>(nameof(FlySheet_Date_Printed), ref fFlySheet_Date_Printed, value); }
        }
        bool fQuePrintFly;
        public bool QuePrintFly
        {
            get { return fQuePrintFly; }
            set { SetPropertyValue<bool>(nameof(QuePrintFly), ref fQuePrintFly, value); }
        }
        string fQueFlySheetHost;
        [Size(128)]
        public string QueFlySheetHost
        {
            get { return fQueFlySheetHost; }
            set { SetPropertyValue<string>(nameof(QueFlySheetHost), ref fQueFlySheetHost, value); }
        }
    }

}