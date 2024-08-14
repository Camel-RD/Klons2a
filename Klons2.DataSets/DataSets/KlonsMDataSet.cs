namespace KlonsF.DataSets
{


    partial class KlonsMDataSet
    {
        partial class M_ACCOUNTSRow
        {
            public KlonsM.Classes.EAccountType XAccountType
            {
                get => (KlonsM.Classes.EAccountType)TP;
                set => TP = (int)value;
            }
        }


        partial class M_STORESRow
        {
            public KlonsM.Classes.EStoreType XStoreType
            {
                get => (KlonsM.Classes.EStoreType)TP;
                set => TP = (int)value;
            }

            public KlonsM.Classes.EPVNType XStorePVNType
            {
                get => (KlonsM.Classes.EPVNType)PVNTP;
                set => PVNTP = (int)value;
            }
        }

        partial class M_DOCSRow
        {
            public KlonsM.Classes.EDocState XState
            {
                get => (KlonsM.Classes.EDocState)STATE;
                set => STATE = (int)value;
            }

            public KlonsM.Classes.EPVNType XPVNType
            {
                get => (KlonsM.Classes.EPVNType)PVNTYPE;
                set => PVNTYPE = (int)value;
            }

            public KlonsM.Classes.EDocType XDocType
            {
                get => (KlonsM.Classes.EDocType)TP;
                set => TP = (int)value;
            }

            public KlonsM.Classes.EDocType2 XDocType2
            {
                get => (KlonsM.Classes.EDocType2)IDTRANSACTIONTYPE;
                set => IDTRANSACTIONTYPE = (int)value;
            }

            public KlonsM.Classes.EStoreType XStoreInType =>
                    M_STORESRowByFK_M_DOCS_IDSTOREIN1.XStoreType;

            public KlonsM.Classes.EStoreType XStoreOutType =>
                    M_STORESRowByFK_M_DOCS_IDSTOREOUT1.XStoreType;

            public KlonsM.Classes.EPVNType XStoreInPVNType =>
                    M_STORESRowByFK_M_DOCS_IDSTOREIN1.XStorePVNType;

            public KlonsM.Classes.EPVNType XStoreOutPVNType =>
                    M_STORESRowByFK_M_DOCS_IDSTOREOUT1.XStorePVNType;

            public KlonsM.Classes.EAccountingType XAccountingType
            {
                get => (KlonsM.Classes.EAccountingType)ACCOUNTINGTP;
                set => ACCOUNTINGTP = (short)value;
            }

            public bool XDoAutoFinOps
            {
                get => ACCTP1 == 1;
                set => ACCTP1 = (short)(value ? 1 : 0);
            }

            public bool XIncludeInCostCalc
            {
                get => ACCTP2 == 1;
                set => ACCTP2 = (short)(value ? 1 : 0);
            }

            public bool XWeVATPayer
            {
                get => WEVATPAYER == 1;
                set => WEVATPAYER = (short)(value ? 1 : 0);
            }

            public string DocSrNr => $"{SR ?? ""} {NR ?? ""}".Trim();

            public bool IsOpenForChanges =>
                XState == KlonsM.Classes.EDocState.Melnraksts ||
                XState == KlonsM.Classes.EDocState.Atvērts;
        }

        public partial class M_ROWSRow
        {
            public bool XIsServices => this.M_ITEMSRow.XIsServices;

        }


        public partial class M_ITEMSRow
        {
            public bool XIsServices => this.M_ITEMS_CATRow.XIsServices;
            public bool XIsProduced => this.M_ITEMS_CATRow.XIsProduced;
        }

        public partial class M_ITEMS_CATRow
        {
            public KlonsM.Classes.EStoreCalcMethod XMethod
            {
                get => (KlonsM.Classes.EStoreCalcMethod)METHOD;
                set => METHOD = (int)value;
            }

            public bool XIsServices
            {
                get => ISSERVICES == 1;
                set => ISSERVICES = value ? 1 : 0;
            }

            public bool XIsProduced
            {
                get => ISPRODUCED == 1;
                set => ISPRODUCED = value ? 1 : 0;
            }
        }

        partial class M_PVNRATES2Row
        {
            public KlonsM.Classes.EPVNType XPvnType
            {
                get => (KlonsM.Classes.EPVNType)IDTP;
                set => IDTP = (int)value;
            }

            public KlonsM.Classes.EDocType XDocType
            {
                get => (KlonsM.Classes.EDocType)IDTRTP;
                set => IDTRTP = (int)value;
            }

            public KlonsM.Classes.EAccountsForTemplates XBaseDebFin
            {
                get => (KlonsM.Classes.EAccountsForTemplates)BASE_DEB_FIN;
                set => BASE_DEB_FIN = (int)value;
            }

            public KlonsM.Classes.EAccountsForTemplates XBaseCredFin
            {
                get => (KlonsM.Classes.EAccountsForTemplates)BASE_CRED_FIN;
                set => BASE_CRED_FIN = (int)value;
            }

            public KlonsM.Classes.EAccountsForTemplates XPvnDebFin
            {
                get => (KlonsM.Classes.EAccountsForTemplates)PVN_DEB_FIN;
                set => PVN_DEB_FIN = (int)value;
            }

            public KlonsM.Classes.EAccountsForTemplates XPvnCredFin
            {
                get => (KlonsM.Classes.EAccountsForTemplates)PVN_CRED_FIN;
                set => PVN_CRED_FIN = (int)value;
            }

            public bool XInCurrentMonth
            {
                get => INCURMT == 1;
                set => INCURMT = value ? 1 : 0;
            }

            public bool XChangeSign
            {
                get => CHANGESIGN == 1;
                set => CHANGESIGN = value ? 1 : 0;
            }
        }

        partial class M_INV_DOCSRow
        {
            public KlonsM.Classes.EInventoryDocState XState
            {
                get => (KlonsM.Classes.EInventoryDocState)STATE;
                set => STATE = (int)value;
            }
        }

    }
}

