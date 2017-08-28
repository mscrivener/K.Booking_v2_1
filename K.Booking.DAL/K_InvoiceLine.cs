namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_InvoiceLine
    {
        public int K_InvoiceLineID { get; set; }

        public int? K_InvoiceID { get; set; }

        [StringLength(255)]
        public string K_InvoiceLineDescription { get; set; }

        public double? K_InvoiceLineAmount { get; set; }

        public int? K_InvoicePriceID { get; set; }

        public DateTime? K_InvoiceLineFrom { get; set; }

        public DateTime? K_InvoiceLineTo { get; set; }

        public int? K_InvoiceLineStatus { get; set; }
    }
}
