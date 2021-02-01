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

    public partial class DP_Main : XPLiteObject
    {
        Guid fDP_Main_ID;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid DP_Main_ID
        {
            get { return fDP_Main_ID; }
            set { SetPropertyValue<Guid>(nameof(DP_Main_ID), ref fDP_Main_ID, value); }
        }
        string fPort_of_Departure;
        [Size(50)]
        [Persistent(@"Port_of_Departure ")]
        public string Port_of_Departure
        {
            get { return fPort_of_Departure; }
            set { SetPropertyValue<string>(nameof(Port_of_Departure), ref fPort_of_Departure, value); }
        }
        string fPort_of_Departure_Short;
        [Size(10)]
        [Persistent(@"Port_of_Departure _Short")]
        public string Port_of_Departure_Short
        {
            get { return fPort_of_Departure_Short; }
            set { SetPropertyValue<string>(nameof(Port_of_Departure_Short), ref fPort_of_Departure_Short, value); }
        }
        decimal fDefault_Duty_Rate;
        public decimal Default_Duty_Rate
        {
            get { return fDefault_Duty_Rate; }
            set { SetPropertyValue<decimal>(nameof(Default_Duty_Rate), ref fDefault_Duty_Rate, value); }
        }
        decimal fCost_20_Container;
        public decimal Cost_20_Container
        {
            get { return fCost_20_Container; }
            set { SetPropertyValue<decimal>(nameof(Cost_20_Container), ref fCost_20_Container, value); }
        }
        decimal fCost_40_Container;
        public decimal Cost_40_Container
        {
            get { return fCost_40_Container; }
            set { SetPropertyValue<decimal>(nameof(Cost_40_Container), ref fCost_40_Container, value); }
        }
        decimal fCost_40HQ_Container;
        public decimal Cost_40HQ_Container
        {
            get { return fCost_40HQ_Container; }
            set { SetPropertyValue<decimal>(nameof(Cost_40HQ_Container), ref fCost_40HQ_Container, value); }
        }
        decimal fCost_CB_Ft_20_Container;
        public decimal Cost_CB_Ft_20_Container
        {
            get { return fCost_CB_Ft_20_Container; }
            set { SetPropertyValue<decimal>(nameof(Cost_CB_Ft_20_Container), ref fCost_CB_Ft_20_Container, value); }
        }
        decimal fCost_CB_Ft_40_Container;
        public decimal Cost_CB_Ft_40_Container
        {
            get { return fCost_CB_Ft_40_Container; }
            set { SetPropertyValue<decimal>(nameof(Cost_CB_Ft_40_Container), ref fCost_CB_Ft_40_Container, value); }
        }
        decimal fCost_CB_Ft_40HQ_Container;
        public decimal Cost_CB_Ft_40HQ_Container
        {
            get { return fCost_CB_Ft_40HQ_Container; }
            set { SetPropertyValue<decimal>(nameof(Cost_CB_Ft_40HQ_Container), ref fCost_CB_Ft_40HQ_Container, value); }
        }
        int fPort_of_Entry_ID;
        public int Port_of_Entry_ID
        {
            get { return fPort_of_Entry_ID; }
            set { SetPropertyValue<int>(nameof(Port_of_Entry_ID), ref fPort_of_Entry_ID, value); }
        }
        int fPort;
        public int Port
        {
            get { return fPort; }
            set { SetPropertyValue<int>(nameof(Port), ref fPort, value); }
        }
        decimal fOrdered;
        public decimal Ordered
        {
            get { return fOrdered; }
            set { SetPropertyValue<decimal>(nameof(Ordered), ref fOrdered, value); }
        }
        [Association(@"PO_MainReferencesDP_Main")]
        public XPCollection<PO_Main> PO_Mains { get { return GetCollection<PO_Main>(nameof(PO_Mains)); } }
    }

}