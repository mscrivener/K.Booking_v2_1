using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K.Booking.Data
{
    public class Misc
    {
        public static int ConvertToInt(object objInt)
        {
            try
            {
                return int.Parse(objInt.ToString());
            }
            catch (Exception)
            {
            }
            return 0;
        }

        public static double ConvertToDouble(object objDouble)
        {
            double dbl = 0;
            double.TryParse(objDouble.ToString(), out dbl);
            return dbl;
        }

        public static string ConvertToString(object objString)
        {
            try
            {
                return ((string)(objString));
            }
            catch (Exception)
            {
            }
            return "";
        }

        public static bool ConvertToBoolean(object objBoolean)
        {
            try
            {
                return ((bool)(objBoolean));
            }
            catch (Exception)
            {
            }
            return true;
        }

        public static DateTime DefaultDate
        {
            get
            {
                return new DateTime(1900, 1, 1);
            }
        }

        public static DateTime ConvertToDateTime(object objDateTime)
        {
            DateTime dt;
            if (!DateTime.TryParse(objDateTime.ToString(), out dt))
                dt = DefaultDate;
            return dt;
        }

        public static string DataBaseDateFormat()
        {
            return "yyyy.MM.dd"; //"MM/dd/yyyy";
        }

        public static string DataBaseDateFormatLong()
        {
            return "yyyy.MM.dd HH:mm:ss"; //"MM/dd/yyyy";
        }

        public static string GetHomeAddress()
        {
            return ("Dansk KFUK" + ("\r\n" + ("43 Maresfield Gardens" + ("\r\n" + ("London NW3 5TF" + ("\r\n" + "Tel. +44 (0) 207 435 7232"))))));
        }

        public static string GetPrintInvoiceNo(int iInvoiceID)
        {
            return iInvoiceID.ToString().PadLeft(6, '0');
        }

 
    }
}
