namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_Invoice
    {
        public int K_InvoiceID { get; set; }

        public int? K_ResidentID { get; set; }

        public DateTime? K_InvoiceDate { get; set; }

        public int? K_InvoiceCreatedBy { get; set; }
    }
}
