using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K.Booking.Data;

namespace K.Booking.DAL
{
    partial class K_Resident
    {
        #region Properties
        public string K_ResidentDisplayMember { get { return K_ResidentFirstName + " " + K_ResidentLastName + " (" + K_ResidentCPR + ")"; } }
        #endregion

        #region Lists
        /// <summary>
        /// List all residents who have not been cancelled (status == 1)
        /// Ordered by FirstName
        /// </summary>
        /// <returns></returns>
        public IEnumerable<K_Resident> ListResidentsAll(string searchTerm)
        {
            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            where res.K_ResidentStatus == 1
                            && (res.K_ResidentFirstName == "%Bjarne%")
                            orderby res.K_ResidentFirstName
                            select res;

                return query.ToList<K_Resident>();
            }
        }

        /// <summary>
        /// Overloadable to take a date, defaulting to DateTime.Now.Date
        /// If you're arriving on that date and have status 1 you'll be in the list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<K_Resident> ListResidentsArrivals()
        {
            return ListResidentsArrivals(null);
        }
        public IEnumerable<K_Resident> ListResidentsArrivals(DateTime? today)
        {
            if (today is null)
                today = DateTime.Now.Date;

            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            where res.K_ResidentStatus == 1
                            && res.K_ResidentArrivalDate == today
                            orderby res.K_ResidentFirstName
                            select res;

                return query.ToList<K_Resident>();
            }
        }

        /// <summary>
        /// Overloadable to take a date, defaulting to DateTime.Now.Date
        /// If you're arriving on any date greater than 'today' and have status 1 you'll be in the list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<K_Resident> ListResidentsFuture()
        {
            return ListResidentsFuture(null);
        }
        public IEnumerable<K_Resident> ListResidentsFuture(DateTime? today)
        {
            if (today is null)
                today = DateTime.Now.Date;

            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            where res.K_ResidentStatus == 1
                            && res.K_ResidentArrivalDate > today
                            orderby res.K_ResidentFirstName
                            select res;

                return query.ToList<K_Resident>();
            }
        }

        /// <summary>
        /// Overloadable for no reason I can think of now, but takes a date.
        /// Having already arrived and not yet left is based on the date, which is defaulted to DateTime.Now.Date if null
        /// You must also be "undecided", "guests" or "short-" or "longerterm" (i.e. not "staff" or "appartment")
        /// to be returned by the query
        /// </summary>
        /// <returns></returns>
        public IEnumerable<K_Resident> ListResidentsCurrent()
        {
            return ListResidentsCurrent(null);
        }
        public IEnumerable<K_Resident> ListResidentsCurrent(DateTime? today)
        {
            if (today is null)
                today = DateTime.Now.Date;

            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            join type in km.K_ResidentType on res.K_ResidentID equals type.K_ResidentID
                            where res.K_ResidentStatus == 1
                            && res.K_ResidentArrivalDate < today
                            && res.K_ResidentDepartureDate >= today
                            && type.K_ResidentTypeActive == 1
                            && (type.K_ResidentType1 == (int)GlobalEnums.ResidentType.Undecided
                            || type.K_ResidentType1 == (int)GlobalEnums.ResidentType.Guest
                            || type.K_ResidentType1 == (int)GlobalEnums.ResidentType.ShortTerm
                            || type.K_ResidentType1 == (int)GlobalEnums.ResidentType.LongTerm)
                            orderby res.K_ResidentFirstName
                            select res;

                return query.ToList<K_Resident>();
            }
        }
        #endregion
    }
}
