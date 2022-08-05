namespace HastaneTMA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appointment
    {
        public int ID { get; set; }

        public int DoktorID { get; set; }

        public int KlinikID { get; set; }

        public DateTime RandevuSaati { get; set; }

        [Required]
        [StringLength(11)]
        public string TCNo { get; set; }
    }
}
