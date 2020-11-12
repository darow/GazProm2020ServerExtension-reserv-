using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateServerExtension1.Helpers
{
    public static class HelperDictionary
    {
        public static class BaseUniversalItemCard
        {

            public static class Name1
            {
                public static readonly Guid Id = new Guid("ECB1E9F3-B4C1-44EE-ADED-F1C2BF2B64A5");
                public static readonly string AgreementEmployees = "AgreementEmployees";
            }
        }

        public static class Document
        {
            public static class MainInfo
            {
                public static readonly Guid Id = new Guid("{30EB9B87-822B-4753-9A50-A1825DCA1B74}");
                
                public static readonly string HoldingSigner = "HoldingSigner";
            }

            public static class Contract
            {
                public static readonly Guid Id = new Guid("{3997861D-4FF5-496A-B8A2-D16617DE91D7}");

                /// <summary>
                /// SignerFromThePartner (Подписант от Контрагента) field
                /// </summary>
                public static readonly string SignerFromThePartner = "SignerFromThePartner";
                /// <summary>
                /// PartnerAdress (Адрес Контрагента) field
                /// </summary>
                public static readonly string PartnerAddress = "PartnerAdress";
                /// <summary>
                /// PartnerINNStr (ИНН Контрагента) field
                /// </summary>
                public static readonly string PartnerINNStr = "PartnerINNStr";
                /// <summary>
                /// PartnerAcc (Банковские реквизиты Контрагента) field
                /// </summary>
                public static readonly string PartnerAcc = "PartnerAcc";
                /// <summary>
                /// SumNDS (Сумма (без НДС)) field
                /// </summary>
                public static readonly string SumNDS = "SumNDS";
            }
        }
    }
}