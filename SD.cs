using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem
{
   public static class SD
    {


        public static string NumDec = "N" + 0;// Properties.Settings.Default.PriceDecimalPlaces;
        public static string NumDecQTY = "N" + 0;// Properties.Settings.Default.QtyDecimalPlaces;

        public const string Success_Operation = "Successful Operation";
       
      
        public static string EqualsString = Lang() ? " Equal =" : "تساوي ";
        public static string UnitWord = Lang() ? " Unit : " : " : الوحدة ";
        public static string UnitContinsWord = Lang() ? " Contins " : " تحتوي على ";

        public static  bool Language;
        public static bool Lang()
        {
            if (Properties.Settings.Default.Language == "ar")
            {
                Language = false;
                return false ;
            }
            else
            {
                Language = true;

                return true;

            }

        }

        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
