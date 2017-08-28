namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_ResidentType
    {
        public int K_ResidentTypeID { get; set; }

        public int? K_ResidentID { get; set; }

        [Column("K_ResidentType")]
        public int? K_ResidentType1 { get; set; }

        public int? K_ResidentNumberOfGuests { get; set; }

        public DateTime? K_ResidentTypeFromDate { get; set; }

        public DateTime? K_ResidentCreatedDate { get; set; }

        public DateTime? K_ResidentUpdatedDate { get; set; }

        public int? K_ResidentCreatedBy { get; set; }

        public int? K_ResidentUpdatedBy { get; set; }

        public int? K_ResidentTypeActive { get; set; }

        public int? K_ResidentTypeStatus { get; set; }
    }
}
