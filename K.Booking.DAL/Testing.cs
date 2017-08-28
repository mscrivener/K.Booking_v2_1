using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Booking.DAL
{
    public class Testing
    {
        public K_Bed GetBed()
        {
            var model = new KModel();
            K_Bed b = model.K_Bed.Find(1);

            return b;
        }
    }
}
