////////////////////////////////////Disclaimer////////////////////////////////////////////
///This library has been wrote by : Anas Reslan Bahsas  if you are going to use it		//	
///please dont remove this line .														//					
///you have to add this class to a asp.net web project to work well.					//		//	
///I will be grateful to receive any commments or suggestion to anasbahsas@hotmail.com	//								//	
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Globalization;
using System.Web;

namespace ExmonSystem
{
    /// <summary>
    /// Summary description for Dates.
    /// </summary>
    public class Dates
    {
        private HttpContext cur;

        private const int startGreg = 1900;
        private const int endGreg = 2100;
        private string[] allFormats = { "yyyy/MM/dd", "yyyy/M/d", "dd/MM/yyyy", "d/M/yyyy", "dd/M/yyyy", "d/MM/yyyy", "yyyy-MM-dd", "yyyy-M-d", "dd-MM-yyyy", "d-M-yyyy", "dd-M-yyyy", "d-MM-yyyy", "yyyy MM dd", "yyyy M d", "dd MM yyyy", "d M yyyy", "dd M yyyy", "d MM yyyy" };
        private CultureInfo arCul;
        private CultureInfo enCul;
        private HijriCalendar h;
        private GregorianCalendar g;

        public Dates()
        {
            cur = HttpContext.Current;

            arCul = new CultureInfo("ar-SA");
            //  enCul = new CultureInfo("en-US");
            enCul = CultureInfo.CurrentCulture;
            h = new HijriCalendar();
            g = new GregorianCalendar(GregorianCalendarTypes.USEnglish);
            arCul.DateTimeFormat.Calendar = h;
            try
            {
                enCul.DateTimeFormat.Calendar = g;
            }
            catch { return; }
        }

        /// <summary>
        /// Check if string is hijri date and then return true 
        /// </summary>
        /// <param name="hijri"></param>
        /// <returns></returns>
        public bool IsHijri(string hijri)
        {
            if (hijri.Length <= 0)
            {

                cur.Trace.Warn("IsHijri Error: Date String is Empty");
                return false;
            }
            try
            {
                DateTime tempDate = DateTime.ParseExact(hijri, allFormats, arCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);
                if (tempDate.Year >= startGreg && tempDate.Year <= endGreg)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                cur.Trace.Warn("IsHijri Error :" + hijri.ToString() + "\n" + ex.Message);
                return false;
            }

        }



        public string GetDateTypee()
        {
            DateTime myDatee = DateTime.Now;

            if (myDatee.Year > 1990)
            {
                //	System.Windows.Forms.MessageBox.Show(HijriToGreg(HijriLibrary.HijriDate.FromGregorianDate(myDatee).ToString("yyyy/MM/dd")));

                return "«· «—ÌŒ «·„Ì·«œÌ :" + myDatee.ToString("yyyy/MM/dd") + " «· «—ÌŒ «·ÂÃ—Ì  :" + HijriLibrary.HijriDate.FromGregorianDate(myDatee);
            }
            if (myDatee.Year < 1600)
            {
                return "«· «—ÌŒ «·ÂÃ—Ì :" + HijriToGreg(myDatee.ToString("yyyy/MM/dd")) + " «· «—ÌŒ «·ÂÃ—Ì  :" + myDatee.ToString("yyyy/MM/dd");

            }
            else
            {

                return HijriLibrary.HijriDate.Now.ToString("yyyy-MM-dd");

            }


        }


        /// <summary>
        /// Check if string is Gregorian date and then return true 
        /// </summary>
        /// <param name="greg"></param>
        /// <returns></returns>
        public bool IsGreg(string greg)
        {
            if (greg.Length <= 0)
            {

                cur.Trace.Warn("IsGreg :Date String is Empty");
                return false;
            }
            try
            {
                DateTime tempDate = DateTime.ParseExact(greg, allFormats, enCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);

                //System.Windows.Forms.MessageBox.Show(tempDate.ToString()+"  year-- "+tempDate.Year);
                if (tempDate.Year >= startGreg && tempDate.Year <= endGreg)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                cur.Trace.Warn("IsGreg Error :" + greg.ToString() + "\n" + ex.Message);
                return false;
            }

        }

        /// <summary>
        /// Return Formatted Hijri date string 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public string FormatHijri(string date, string format)
        {
            if (date.Length <= 0)
            {

                cur.Trace.Warn("Format :Date String is Empty");
                return "";
            }
            try
            {
                DateTime tempDate = DateTime.ParseExact(date, allFormats, arCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);
                return tempDate.ToString(format, arCul.DateTimeFormat);

            }
            catch (Exception ex)
            {
                cur.Trace.Warn("Date :\n" + ex.Message);
                return "";
            }

        }
        /// <summary>
        /// Returned Formatted Gregorian date string
        /// </summary>
        /// <param name="date"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public string FormatGreg(string date, string format)
        {
            if (date.Length <= 0)
            {

                cur.Trace.Warn("Format :Date String is Empty");
                return "";
            }
            try
            {
                DateTime tempDate = DateTime.ParseExact(date, allFormats, enCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);
                return tempDate.ToString(format, enCul.DateTimeFormat);

            }
            catch (Exception ex)
            {
                cur.Trace.Warn("Date :\n" + ex.Message);
                return "";
            }

        }
        /// <summary>
        /// Return Today Gregorian date and return it in yyyy/MM/dd format
        /// </summary>
        /// <returns></returns>
        public string GDateNow()
        {
            try
            {
                return DateTime.Now.ToString("yyyy/MM/dd", enCul.DateTimeFormat);
            }
            catch (Exception ex)
            {
                //cur.Trace.Warn("GDateNow :\n"+ex.Message);
                return HijriToGreg(HDateNow("yyyy/MM/dd"), "yyyy/MM/dd");
            }
        }
        /// <summary>
        /// Return formatted today Gregorian date based on your format
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public string GDateNow(string format)
        {
            try
            {
                return DateTime.Now.ToString(format, enCul.DateTimeFormat);
            }
            catch (Exception ex)
            {
                //cur.Trace.Warn("GDateNow :\n"+ex.Message);
                return HijriToGreg(DateTime.Now.ToString("yyyy/MM/dd"), "yyyy/MM/dd");
            }
        }

        /// <summary>
        /// Return Today Hijri date and return it in yyyy/MM/dd format
        /// </summary>
        /// <returns></returns>
        public string HDateNow()
        {
            try
            {
                return DateTime.Now.ToString("yyyy/MM/dd", arCul.DateTimeFormat);
            }
            catch (Exception ex)
            {
                cur.Trace.Warn("HDateNow :\n" + ex.Message);
                return "";
            }
        }
        /// <summary>
        /// Return formatted today hijri date based on your format
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>

        public string HDateNow(string format)
        {
            try
            {
                return DateTime.Now.ToString(format, arCul.DateTimeFormat);
            }
            catch (Exception ex)
            {
                cur.Trace.Warn("HDateNow :\n" + ex.Message);
                return "";
            }

        }

        /// <summary>
        /// Convert Hijri Date to it's equivalent Gregorian Date
        /// </summary>
        /// <param name="hijri"></param>
        /// <returns></returns>
        public string HijriToGreg(string hijri)
        {

            if (hijri.Length <= 0)
            {

                cur.Trace.Warn("HijriToGreg :Date String is Empty");
                return "";
            }
            try
            {
                DateTime tempDate = DateTime.ParseExact(hijri, allFormats, arCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);
                return tempDate.ToString("yyyy/MM/dd", enCul.DateTimeFormat);
            }
            catch (Exception ex)
            {
                cur.Trace.Warn("HijriToGreg :" + hijri.ToString() + "\n" + ex.Message);
                return "";
            }
        }
        /// <summary>
        /// Convert Hijri Date to it's equivalent Gregorian Date and return it in specified format
        /// </summary>
        /// <param name="hijri"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public string HijriToGreg(string hijri, string format)
        {

            if (hijri.Length <= 0)
            {

                cur.Trace.Warn("HijriToGreg :Date String is Empty");
                return "";
            }
            try
            {
                DateTime tempDate = DateTime.ParseExact(hijri, allFormats, arCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);
                return tempDate.ToString(format, enCul.DateTimeFormat);

            }
            catch (Exception ex)
            {
                cur.Trace.Warn("HijriToGreg :" + hijri.ToString() + "\n" + ex.Message);
                return "";
            }
        }
        /// <summary>
        /// Convert Gregoian Date to it's equivalent Hijir Date
        /// </summary>
        /// <param name="greg"></param>
        /// <returns></returns>
        public string GregToHijri(string greg)
        {

            if (greg.Length <= 0)
            {

                cur.Trace.Warn("GregToHijri :Date String is Empty");
                return "";
            }
            try
            {
                DateTime tempDate = DateTime.ParseExact(greg, allFormats, enCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);
                return tempDate.ToString("yyyy/MM/dd", arCul.DateTimeFormat);

            }
            catch (Exception ex)
            {
                cur.Trace.Warn("GregToHijri :" + greg.ToString() + "\n" + ex.Message);
                return "";
            }
        }
        /// <summary>
        /// Convert Hijri Date to it's equivalent Gregorian Date and return it in specified format
        /// </summary>
        /// <param name="greg"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public string GregToHijri(string greg, string format)
        {

            if (greg.Length <= 0)
            {

                cur.Trace.Warn("GregToHijri :Date String is Empty");
                return "";
            }
            try
            {

                DateTime tempDate = DateTime.ParseExact(greg, allFormats, enCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);
                return tempDate.ToString(format, arCul.DateTimeFormat);

            }
            catch (Exception ex)
            {
                cur.Trace.Warn("GregToHijri :" + greg.ToString() + "\n" + ex.Message);
                return "";
            }
        }

        /// <summary>
        /// Return Gregrian Date Time as digit stamp
        /// </summary>
        /// <returns></returns>
        public string GTimeStamp()
        {
            return GDateNow("yyyyMMddHHmmss");
        }
        /// <summary>
        /// Return Hijri Date Time as digit stamp
        /// </summary>
        /// <returns></returns>
        public string GDateStamp(string HDate)
        {
            return FormatGreg(HDate, "yyyyMMdd");
        }
        /// Return Hijri Date Time as digit stamp
        /// </summary>
        /// <returns></returns>
        public string HDateStamp()
        {
            return HDateNow("yyyyMMdd");
        }

        /// <summary>
        /// Compare if the Hijri date between  other financial year and return True if within , False in not within
        /// </summary>
        /// <param name="dt">Data Table contain start date and end date ,,start date is the first column in table , end date is the second column in table</param>
        /// <param name="fromDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>


        /// <summary>
        /// Compare two instaces of string date and return indication of thier values 
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns>positive d1 is greater than d2,negative d1 is smaller than d2, 0 both are equal</returns>
        public int Compare(string d1, string d2)
        {
            try
            {
                DateTime date1 = DateTime.ParseExact(d1, allFormats, enCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);
                DateTime date2 = DateTime.ParseExact(d2, allFormats, enCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);
                return DateTime.Compare(date1, date2);
            }
            catch (Exception ex)
            {
                cur.Trace.Warn("Compare :" + "\n" + ex.Message);
                return -1;
            }

        }


    }
}
