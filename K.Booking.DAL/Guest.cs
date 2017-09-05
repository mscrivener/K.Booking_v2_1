namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Guest")]
    public partial class Guest
    {
        public int GuestID { get; set; }

        public int? LeadGuestPersonID { get; set; }

        public DateTime? ArrivalDate { get; set; }

        public DateTime? DepatureDate { get; set; }

        public DateTime? DepositDueDate { get; set; }

        public int? NumberOfGuests { get; set; }

        public int? Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }
    }
}
