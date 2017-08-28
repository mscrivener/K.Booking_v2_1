namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_Stats
    {
        public int K_StatsID { get; set; }

        public DateTime? K_StatsFromDate { get; set; }

        public DateTime? K_StatsToDate { get; set; }

        public DateTime? K_StatsCreatedDate { get; set; }

        public int? K_StatsCreatedBy { get; set; }
    }
}
