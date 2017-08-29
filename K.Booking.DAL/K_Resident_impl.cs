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

        #region Search
        /// <summary>
        /// Will probably never implement this in the final version - depending on final interface
        /// The search might be happening on the list of objects displayed rather than from the database?
        /// </summary>
        /// <param name="list"></param>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        public List<K_Resident.Simple> SearchResidentListDisplayMember(List<K_Resident.Simple> list, string searchTerm)
        {
            var withSearch = from r in list
                             where r.DisplayMember.Contains(searchTerm)
                             select r;

            return withSearch.ToList<K_Resident.Simple>();
        }

        #endregion

        /// <summary>
        /// My way round not wanting to carry big lists of large objects on the Y's ancient computer 
        /// A sub class contaning only what we need for the lists
        /// </summary>
        public class Simple
        {
            //temporary while I rely on this to display in the form
            public string K_ResidentDisplayMember { get { return FirstName + " " + LastName + " (" + CPR + ")"; } }
            public int K_ResidentID { get { return ID; } }

            public string DisplayMember { get { return FirstName + " " + LastName + " (" + CPR + ")"; } }
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string CPR { get; set; }
        }

        #region Lists
        /// <summary>
        /// List all residents who have not been cancelled (status == 1)
        /// Ordered by FirstName
        /// </summary>
        /// <returns></returns>
        public List<K_Resident.Simple> ListResidentsAll()
        {
            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            where res.K_ResidentStatus == 1
                            orderby res.K_ResidentFirstName
                            select new Simple() { FirstName = res.K_ResidentFirstName, LastName = res.K_ResidentLastName, CPR = res.K_ResidentCPR, ID = res.K_ResidentID };

                return query.ToList<K_Resident.Simple>();
            }
        }

        /// <summary>
        /// Overloadable to take a date, defaulting to DateTime.Now.Date
        /// If you're arriving on that date and have status 1 you'll be in the list
        /// </summary>
        /// <returns></returns>
        public List<K_Resident.Simple> ListResidentsArrivals()
        {
            return ListResidentsArrivals(null);
        }
        public List<K_Resident.Simple> ListResidentsArrivals(DateTime? today)
        {
            if (today is null)
                today = DateTime.Now.Date;

            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            where res.K_ResidentStatus == 1
                            && res.K_ResidentArrivalDate == today
                            orderby res.K_ResidentFirstName
                            select new Simple() { FirstName = res.K_ResidentFirstName, LastName = res.K_ResidentLastName, CPR = res.K_ResidentCPR, ID = res.K_ResidentID };

                return query.ToList<K_Resident.Simple>();
            }
        }

        /// <summary>
        /// Overloadable to take a date, defaulting to DateTime.Now.Date
        /// If you're arriving on any date greater than 'today' and have status 1 you'll be in the list
        /// </summary>
        /// <returns></returns>
        public List<K_Resident.Simple> ListResidentsFuture()
        {
            return ListResidentsFuture(null);
        }
        public List<K_Resident.Simple> ListResidentsFuture(DateTime? today)
        {
            if (today is null)
                today = DateTime.Now.Date;

            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            where res.K_ResidentStatus == 1
                            && res.K_ResidentArrivalDate > today
                            orderby res.K_ResidentFirstName
                            select new Simple() { FirstName = res.K_ResidentFirstName, LastName = res.K_ResidentLastName, CPR = res.K_ResidentCPR, ID = res.K_ResidentID };

                return query.ToList<K_Resident.Simple>();
            }
        }

        /// <summary>
        /// Get everyone departing today (default) or on the date you passed in
        /// Only if status == 1
        /// </summary>
        /// <returns></returns>
        public List<K_Resident.Simple> ListResidentsDeparture()
        {
            return ListResidentsDeparture(null);
        }
        public List<K_Resident.Simple> ListResidentsDeparture(DateTime? today)
        {
            if (today is null)
                today = DateTime.Now.Date;

            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            where res.K_ResidentStatus == 1
                            && res.K_ResidentDepartureDate == today
                            orderby res.K_ResidentFirstName
                            select new Simple() { FirstName = res.K_ResidentFirstName, LastName = res.K_ResidentLastName, CPR = res.K_ResidentCPR, ID = res.K_ResidentID };

                return query.ToList<K_Resident.Simple>();
            }
        }

        /// <summary>
        /// Overloadable for no reason I can think of now, but takes a date.
        /// Having already arrived and not yet left is based on the date, which is defaulted to DateTime.Now.Date if null
        /// You must also be "undecided", "guests" or "short-" or "longerterm" (i.e. not "staff" or "appartment")
        /// to be returned by the query
        /// </summary>
        /// <returns></returns>
        public List<K_Resident.Simple> ListResidentsCurrent()
        {
            return ListResidentsCurrent(null);
        }
        public List<K_Resident.Simple> ListResidentsCurrent(DateTime? today)
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
                            select new Simple() { FirstName = res.K_ResidentFirstName, LastName = res.K_ResidentLastName, CPR = res.K_ResidentCPR, ID = res.K_ResidentID };

                return query.ToList<K_Resident.Simple>();
            }
        }

        public List<K_Resident.Simple> ListResidentsStaff()
        {

            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            join type in km.K_ResidentType on res.K_ResidentID equals type.K_ResidentID
                            where res.K_ResidentStatus == 1
                            && type.K_ResidentTypeActive == 1
                            && (type.K_ResidentType1 == (int)GlobalEnums.ResidentType.Staff)
                            orderby res.K_ResidentFirstName
                            select new Simple() { FirstName = res.K_ResidentFirstName, LastName = res.K_ResidentLastName, CPR = res.K_ResidentCPR, ID = res.K_ResidentID };

                return query.ToList<K_Resident.Simple>();
            }
        }

        public List<K_Resident.Simple> ListResidentsAppartment()
        {

            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            join type in km.K_ResidentType on res.K_ResidentID equals type.K_ResidentID
                            where res.K_ResidentStatus == 1
                            && type.K_ResidentTypeActive == 1
                            && (type.K_ResidentType1 == (int)GlobalEnums.ResidentType.Appartement)
                            orderby res.K_ResidentFirstName
                            select new Simple() { FirstName = res.K_ResidentFirstName, LastName = res.K_ResidentLastName, CPR = res.K_ResidentCPR, ID = res.K_ResidentID };

                return query.ToList<K_Resident.Simple>();
            }
        }

        public List<K_Resident.Simple> ListResidentsAnnulled()
        {

            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            where res.K_ResidentStatus == 0
                            orderby res.K_ResidentFirstName
                            select new Simple() { FirstName = res.K_ResidentFirstName, LastName = res.K_ResidentLastName, CPR = res.K_ResidentCPR, ID = res.K_ResidentID };

                return query.ToList<K_Resident.Simple>();
            }
        }

        public List<K_Resident.Simple> ListResidentsFormer()
        {
            return ListResidentsFormer(null);
        }
        public List<K_Resident.Simple> ListResidentsFormer(DateTime? today)
        {
            if (today is null)
                today = DateTime.Now.Date;

            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            where res.K_ResidentStatus == 1
                            && res.K_ResidentDepartureDate < today
                            orderby res.K_ResidentFirstName
                            select new Simple() { FirstName = res.K_ResidentFirstName, LastName = res.K_ResidentLastName, CPR = res.K_ResidentCPR, ID = res.K_ResidentID };

                return query.ToList<K_Resident.Simple>();
            }
        }
        #endregion
    }
}
