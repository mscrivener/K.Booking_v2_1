namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_PriceSet
    {
        public int K_PriceSetID { get; set; }

        public DateTime? K_PriceSetValidFrom { get; set; }
    }
}
