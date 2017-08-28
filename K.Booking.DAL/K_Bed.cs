namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_Bed
    {
        public int K_BedID { get; set; }

        [StringLength(50)]
        public string K_BedKey { get; set; }

        [StringLength(50)]
        public string K_BedDescription { get; set; }

        public int? K_RoomID { get; set; }

        public bool? K_BedIsPermanent { get; set; }
    }
}
