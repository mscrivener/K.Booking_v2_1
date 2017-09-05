namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stay")]
    public partial class Stay
    {
        public int StayID { get; set; }

        public int? PersonID { get; set; }

        public DateTime? ArrivalDate { get; set; }

        public DateTime? DepatureDate { get; set; }

        public int? ContractTerms { get; set; }

        public int? Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }
    }
}
