using System;

namespace ExmonSystem
{
    public class CurrencyInfo
    {
        public enum Currencies { SaudiArabia, YE, Iraq, USD, Gold };

        #region Constructors

        public CurrencyInfo(Currencies currency)
        {
            switch (currency)
            {
                case Currencies.SaudiArabia:
                    CurrencyID = 0;
                    CurrencyCode = "SAR";
                    IsCurrencyNameFeminine = true;
                   EnglishCurrencyName = "Saudi Riyal";
                    EnglishPluralCurrencyName = "Saudi Riyals";
                    EnglishCurrencyPartName = "Halala";
                    EnglishPluralCurrencyPartName = "Halalas";
                    Arabic1CurrencyName = "ريال سعودي";
                    Arabic2CurrencyName = "ريالان سعوديان";
                    Arabic310CurrencyName = "ريالات سعودية";
                    Arabic1199CurrencyName = "ريالاً سعودياً";
                    Arabic1CurrencyPartName = "هللة";
                    Arabic2CurrencyPartName = "هللتان";
                    Arabic310CurrencyPartName = "هللات";
                    Arabic1199CurrencyPartName = "هللة";
                    PartPrecision = 1;
                    IsCurrencyPartNameFeminine = true;
                    break;

                case Currencies.YE:
                    CurrencyID = 2;
                    CurrencyCode = "YER";
                    IsCurrencyNameFeminine = true;
                    EnglishCurrencyName = "Yemeni Riyal";
                    EnglishPluralCurrencyName = "Yemeni Riyals";
                    EnglishCurrencyPartName = "Fils";
                    EnglishPluralCurrencyPartName = "Aflas";
                    Arabic1CurrencyName = "ريال يمني";
                    Arabic2CurrencyName = "ريالان يمنيان";
                    Arabic310CurrencyName = "ريالات يمنية";
                    Arabic1199CurrencyName = "ريالاً يمنيآ";
                    Arabic1CurrencyPartName = "فلس";
                    Arabic2CurrencyPartName = "فلسان";
                    Arabic310CurrencyPartName = "أفلاس";
                    Arabic1199CurrencyPartName = "فلس";
                    PartPrecision = 1;
                    IsCurrencyPartNameFeminine = false;
                   
                    break;

                case Currencies.Iraq:
                    CurrencyID = 3;
                    CurrencyCode = "IQD";
                    IsCurrencyNameFeminine = true;
                    EnglishCurrencyName = "Iraqi Dinar";
                    EnglishPluralCurrencyName = "Iraqi Dinars";
                    EnglishCurrencyPartName = "Fils";
                    EnglishPluralCurrencyPartName = "Aflas";
                    Arabic1CurrencyName = "دينار عراقي";
                    Arabic2CurrencyName = "ديناران عراقي";
                    Arabic310CurrencyName = "دنانير عراقية";
                    Arabic1199CurrencyName = "دينار عراقي";
                    Arabic1CurrencyPartName = "فلس";
                    Arabic2CurrencyPartName = "فلسان";
                    Arabic310CurrencyPartName = "افلاس";
                    Arabic1199CurrencyPartName = "فلس";
                    PartPrecision = 1;
                    IsCurrencyPartNameFeminine = false;
                    break;

                case Currencies.USD:
                    CurrencyID = 1;
                    CurrencyCode = "USA";
                    IsCurrencyNameFeminine = true;
                    EnglishCurrencyName = "US Dolar";
                    EnglishPluralCurrencyName = "US Dolars";
                    EnglishCurrencyPartName = "Cent";
                    EnglishPluralCurrencyPartName = "Cents";
                    Arabic1CurrencyName = "دولار أمريكي";
                    Arabic2CurrencyName = "دولاران أمريكي";
                    Arabic310CurrencyName = "دولارات أمريكية";
                    Arabic1199CurrencyName = "دولار أمريكي";
                    Arabic1CurrencyPartName = "سنت";
                    Arabic2CurrencyPartName = "سنتان";
                    Arabic310CurrencyPartName = "سنتات";
                    Arabic1199CurrencyPartName = "سنت";
                    PartPrecision = 2;
                    IsCurrencyPartNameFeminine = false;
                    break;

                case Currencies.Gold:
                    CurrencyID = 0;
                    CurrencyCode = "SAR";
                    IsCurrencyNameFeminine = true;
                    EnglishCurrencyName = "Saudi Riyal";
                    EnglishPluralCurrencyName = "Saudi Riyals";
                    EnglishCurrencyPartName = "Halala";
                    EnglishPluralCurrencyPartName = "Halalas";
                    Arabic1CurrencyName = "ريال سعودي";
                    Arabic2CurrencyName = "ريالان سعوديان";
                    Arabic310CurrencyName = "ريالات سعودية";
                    Arabic1199CurrencyName = "ريالاً سعودياً";
                    Arabic1CurrencyPartName = "هللة";
                    Arabic2CurrencyPartName = "هللتان";
                    Arabic310CurrencyPartName = "هللات";
                    Arabic1199CurrencyPartName = "هللة";
                    PartPrecision = 1;
                    IsCurrencyPartNameFeminine = false;
                    
                    break;

            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Currency ID
        /// </summary>
        public int CurrencyID { get; set; }

        /// <summary>
        /// Standard Code
        /// Syrian Pound: SYP
        /// UAE Dirham: AED
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Is the currency name feminine ( Mua'anath مؤنث)
        /// ليرة سورية : مؤنث = true
        /// درهم : مذكر = false
        /// </summary>
        public Boolean IsCurrencyNameFeminine { get; set; }

        /// <summary>
        /// English Currency Name for single use
        /// Syrian Pound
        /// UAE Dirham
        /// </summary>
        public string EnglishCurrencyName { get; set; }

        /// <summary>
        /// English Plural Currency Name for Numbers over 1
        /// Syrian Pounds
        /// UAE Dirhams
        /// </summary>
        public string EnglishPluralCurrencyName { get; set; }

        /// <summary>
        /// Arabic Currency Name for 1 unit only
        /// ليرة سورية
        /// درهم إماراتي
        /// </summary>
        public string Arabic1CurrencyName { get; set; }

        /// <summary>
        /// Arabic Currency Name for 2 units only
        /// ليرتان سوريتان
        /// درهمان إماراتيان
        /// </summary>
        public string Arabic2CurrencyName { get; set; }

        /// <summary>
        /// Arabic Currency Name for 3 to 10 units
        /// خمس ليرات سورية
        /// خمسة دراهم إماراتية
        /// </summary>
        public string Arabic310CurrencyName { get; set; }

        /// <summary>
        /// Arabic Currency Name for 11 to 99 units
        /// خمس و سبعون ليرةً سوريةً
        /// خمسة و سبعون درهماً إماراتياً
        /// </summary>
        public string Arabic1199CurrencyName { get; set; }

        /// <summary>
        /// Decimal Part Precision
        /// for Syrian Pounds: 2 ( 1 SP = 100 parts)
        /// for Tunisian Dinars: 3 ( 1 TND = 1000 parts)
        /// </summary>
        public Byte PartPrecision { get; set; }

        /// <summary>
        /// Is the currency part name feminine ( Mua'anath مؤنث)
        /// هللة : مؤنث = true
        /// قرش : مذكر = false
        /// </summary>
        public Boolean IsCurrencyPartNameFeminine { get; set; }

        /// <summary>
        /// English Currency Part Name for single use
        /// Piaster
        /// Fils
        /// </summary>
        public string EnglishCurrencyPartName { get; set; }

        /// <summary>
        /// English Currency Part Name for Plural
        /// Piasters
        /// Fils
        /// </summary>
        public string EnglishPluralCurrencyPartName { get; set; }

        /// <summary>
        /// Arabic Currency Part Name for 1 unit only
        /// قرش
        /// هللة
        /// </summary>
        public string Arabic1CurrencyPartName { get; set; }

        /// <summary>
        /// Arabic Currency Part Name for 2 unit only
        /// قرشان
        /// هللتان
        /// </summary>
        public string Arabic2CurrencyPartName { get; set; }

        /// <summary>
        /// Arabic Currency Part Name for 3 to 10 units
        /// قروش
        /// هللات
        /// </summary>
        public string Arabic310CurrencyPartName { get; set; }

        /// <summary>
        /// Arabic Currency Part Name for 11 to 99 units
        /// قرشاً
        /// هللةً
        /// </summary>
        public string Arabic1199CurrencyPartName { get; set; }
        #endregion
    }
}
