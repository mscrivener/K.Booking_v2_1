using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Booking.DAL
{
    partial class K_Resident
    {
        public string K_ResidentDisplayMember { get { return K_ResidentFirstName + " " + K_ResidentLastName + " (" + K_ResidentCPR + ")"; } }
        public IEnumerable<K_Resident> ListResidentsAll()
        {
            using (KModel km = new KModel())
            {
                var query = from res in km.K_Resident
                            where res.K_ResidentStatus == 1
                            orderby res.K_ResidentFirstName
                            select res;

                return query.ToList<K_Resident>();
            }
        }
    }
}
