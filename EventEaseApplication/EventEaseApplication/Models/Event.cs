namespace EventEaseApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            Bookings = new HashSet<Booking>();
        }

        public int EventId { get; set; }

        [Required]
        [StringLength(500)]
        public string EventName { get; set; }

        public DateTime EventDate { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int VenueId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual Venue Venue { get; set; }
    }
}
