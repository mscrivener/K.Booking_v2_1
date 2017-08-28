namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_Price
    {
        public int K_PriceID { get; set; }

        public double? K_PriceAmount { get; set; }

        public int? K_PriceSetID { get; set; }

        public int? K_PriceDescriptionID { get; set; }
    }
}
