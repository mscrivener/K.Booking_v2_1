namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_Room
    {
        public int K_RoomID { get; set; }

        [StringLength(50)]
        public string K_RoomKey { get; set; }

        [StringLength(255)]
        public string K_RoomDescription { get; set; }

        public int? K_RoomType { get; set; }

        public int? K_RoomStatus { get; set; }
    }
}
