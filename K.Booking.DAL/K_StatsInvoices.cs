namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_StatsInvoices
    {
        public int K_StatsInvoicesID { get; set; }

        public int? K_StatsID { get; set; }

        public int? K_InvoiceID { get; set; }
    }
}
