namespace K.Booking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_Resident
    {
        public int K_ResidentID { get; set; }

        [StringLength(255)]
        public string K_ResidentFirstName { get; set; }

        [StringLength(255)]
        public string K_ResidentLastName { get; set; }

        [StringLength(50)]
        public string K_ResidentCPR { get; set; }

        [StringLength(255)]
        public string K_ResidentDKAddress { get; set; }

        [StringLength(4)]
        public string K_ResidentDKPostalCode { get; set; }

        [StringLength(255)]
        public string K_ResidentDKCity { get; set; }

        [StringLength(50)]
        public string K_ResidentPhone { get; set; }

        [StringLength(50)]
        public string K_ResidentPhone2 { get; set; }

        [StringLength(255)]
        public string K_ResidentEMail { get; set; }

        public bool? K_ResidentChronicIllness { get; set; }

        [StringLength(255)]
        public string K_ResidentChronicIllnessDescription { get; set; }

        [StringLength(255)]
        public string K_ResidentDKContactName { get; set; }

        [StringLength(255)]
        public string K_ResidentDKContactAddress { get; set; }

        [StringLength(50)]
        public string K_ResidentDKContactPhone { get; set; }

        public DateTime? K_ResidentArrivalDate { get; set; }

        public DateTime? K_ResidentDepartureDate { get; set; }

        public bool? K_ResidentNewsLetter { get; set; }

        public int? K_ResidentGender { get; set; }

        public DateTime? K_ResidentPaidUntil { get; set; }

        public int? K_ResidentStatus { get; set; }

        public DateTime? K_ResidentCreatedDate { get; set; }

        public DateTime? K_ResidentUpdatedDate { get; set; }

        public int? K_ResidentCreatedBy { get; set; }

        public int? K_ResidentUpdatedBy { get; set; }
    }
}
