namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public int PersonID { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string DoB { get; set; }

        [StringLength(255)]
        public string DKAddress { get; set; }

        [StringLength(4)]
        public string DKPostalCode { get; set; }

        [StringLength(255)]
        public string DKCity { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Phone2 { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public bool? ChronicIllness { get; set; }

        [StringLength(255)]
        public string ChronicIllnessDescription { get; set; }

        [StringLength(255)]
        public string DKContactName { get; set; }

        [StringLength(255)]
        public string DKContactAddress { get; set; }

        [StringLength(50)]
        public string DKContactPhone { get; set; }

        public bool? NewsLetter { get; set; }

        public int? Gender { get; set; }

        public int? Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }
    }
}
