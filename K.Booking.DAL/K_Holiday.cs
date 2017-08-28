namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_Holiday
    {
        public int K_HolidayID { get; set; }

        public int? K_ResidentID { get; set; }

        public DateTime? K_HolidayFromDate { get; set; }

        public DateTime? K_HolidayToDate { get; set; }
    }
}
