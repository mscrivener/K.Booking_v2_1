namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_User
    {
        public int K_UserID { get; set; }

        [StringLength(255)]
        public string K_UserFullName { get; set; }

        [StringLength(50)]
        public string K_UserLoginName { get; set; }

        [StringLength(50)]
        public string K_UserPassword { get; set; }

        public bool? K_UserActive { get; set; }
    }
}
