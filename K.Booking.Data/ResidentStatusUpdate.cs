using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K.Booking.Data
{
    public class ResidentStatusUpdate
    {
        public static bool UpdateResStatus()
        {
            return Update("ResidentStatusFile", "UPDATE K_Resident SET K_ResidentStatus = {0} WHERE K_ResidentIDOrig = {1}");
        }

        public static bool UpdateResType()
        {
            return Update("ResidentTypeFile", "UPDATE K_ResidentType SET K_ResidentTypeActive = {0} WHERE K_ResidentTypeIDOrig = {1}");
        }

        private static bool Update(string fileConfigName, string SQL)
        {
            bool success = false;

            try
            {
                string[] users = System.IO.File.ReadAllLines(System.Configuration.ConfigurationManager.AppSettings[fileConfigName]);

                K.Booking.Data.Access access = new Access();

                for (int i = 0; i < users.Length; i++)
                {
                    string[] u = users[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    access.Save(string.Format(SQL, u[1], u[0]));
                }
                success = true;
            }
            catch (Exception)
            {

            }


            return success;
        }

    }
}
