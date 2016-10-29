namespace ClientScheduler.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientReferralXRef")]
    public partial class ClientReferralXRef
    {
        public int ClientReferralXRefId { get; set; }

        public int ClientId { get; set; }

        public int ReferredByClientId { get; set; }

        public DateTime DateAdded { get; set; }

        public virtual Client Client { get; set; }

        public virtual Client Client1 { get; set; }
    }
}
