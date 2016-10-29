namespace ClientScheduler.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClientSchedulerModel : DbContext
    {
        public ClientSchedulerModel()
            : base("name=ClientSchedulerModel")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientReferralXRef> ClientReferralXRefs { get; set; }
        public virtual DbSet<ClientSchedule> ClientSchedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ClientReferralXRefs)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.ClientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ClientReferralXRefs1)
                .WithRequired(e => e.Client1)
                .HasForeignKey(e => e.ReferredByClientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ClientSchedules)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);
        }
    }
}
