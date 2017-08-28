namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_ResidentInBed
    {
        public int K_ResidentInBedID { get; set; }

        public int? K_BedID { get; set; }

        public DateTime? K_ResidentInBedFromDate { get; set; }

        public DateTime? K_ResidentInBedToDate { get; set; }

        public int? K_ResidentID { get; set; }
    }
}
