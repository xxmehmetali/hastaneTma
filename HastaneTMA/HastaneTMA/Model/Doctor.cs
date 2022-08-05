namespace HastaneTMA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doctor
    {
        public int ID { get; set; }

        public int KlinikID { get; set; }

        public int DoktorID { get; set; }

        public virtual Clinic Clinic { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
