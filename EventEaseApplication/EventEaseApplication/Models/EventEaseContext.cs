using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EventEaseApplication.Models
{
    public partial class EventEaseContext : DbContext
    {
        public EventEaseContext()
            : base("name=EventEaseContext")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venue>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Venue)
                .WillCascadeOnDelete(false);
        }
    }
}
