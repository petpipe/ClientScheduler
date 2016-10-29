namespace ClientScheduler.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientSchedule")]
    public partial class ClientSchedule
    {
        [Key]
        public int ScheduleId { get; set; }

        public int ClientId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ScheduleDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime? DateUpdated { get; set; }

        public virtual Client Client { get; set; }
    }
}
