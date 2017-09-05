namespace K.Booking.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KModel : DbContext
    {
        public KModel()
            : base("name=KModel1")
        {
        }

        public virtual DbSet<K_Bed> K_Bed { get; set; }
        public virtual DbSet<K_Holiday> K_Holiday { get; set; }
        public virtual DbSet<K_Invoice> K_Invoice { get; set; }
        public virtual DbSet<K_InvoiceLine> K_InvoiceLine { get; set; }
        public virtual DbSet<K_Price> K_Price { get; set; }
        public virtual DbSet<K_PriceDescription> K_PriceDescription { get; set; }
        public virtual DbSet<K_PriceSet> K_PriceSet { get; set; }
        public virtual DbSet<K_Resident> K_Resident { get; set; }
        public virtual DbSet<K_ResidentInBed> K_ResidentInBed { get; set; }
        public virtual DbSet<K_ResidentType> K_ResidentType { get; set; }
        public virtual DbSet<K_Room> K_Room { get; set; }
        public virtual DbSet<K_Stats> K_Stats { get; set; }
        public virtual DbSet<K_StatsInvoices> K_StatsInvoices { get; set; }
        public virtual DbSet<K_User> K_User { get; set; }
        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<K_Bed>()
                .Property(e => e.K_BedKey)
                .IsUnicode(false);

            modelBuilder.Entity<K_Bed>()
                .Property(e => e.K_BedDescription)
                .IsUnicode(false);

            modelBuilder.Entity<K_InvoiceLine>()
                .Property(e => e.K_InvoiceLineDescription)
                .IsUnicode(false);

            modelBuilder.Entity<K_PriceDescription>()
                .Property(e => e.K_PriceDescription1)
                .IsUnicode(false);

            modelBuilder.Entity<K_Resident>()
                .Property(e => e.K_ResidentFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<K_Resident>()
                .Property(e => e.K_ResidentLastName)
                .IsUnicode(false);

            modelBuilder.Entity<K_Resident>()
                .Property(e => e.K_ResidentCPR)
                .IsUnicode(false);

            modelBuilder.Entity<K_Resident>()
                .Property(e => e.K_ResidentDKPostalCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<K_Resident>()
                .Property(e => e.K_ResidentPhone)
                .IsUnicode(false);

            modelBuilder.Entity<K_Resident>()
                .Property(e => e.K_ResidentPhone2)
                .IsUnicode(false);

            modelBuilder.Entity<K_Resident>()
                .Property(e => e.K_ResidentDKContactPhone)
                .IsUnicode(false);

            modelBuilder.Entity<K_Room>()
                .Property(e => e.K_RoomKey)
                .IsUnicode(false);

            modelBuilder.Entity<K_Room>()
                .Property(e => e.K_RoomDescription)
                .IsUnicode(false);

            modelBuilder.Entity<K_User>()
                .Property(e => e.K_UserLoginName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.DoB)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.DKPostalCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Phone2)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.DKContactPhone)
                .IsUnicode(false);
        }
    }
}
