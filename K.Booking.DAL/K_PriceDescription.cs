namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_PriceDescription
    {
        public int K_PriceDescriptionID { get; set; }

        [Column("K_PriceDescription")]
        [StringLength(255)]
        public string K_PriceDescription1 { get; set; }
    }
}
