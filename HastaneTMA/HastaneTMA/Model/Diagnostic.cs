namespace HastaneTMA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diagnostic")]
    public partial class Diagnostic
    {
        public int ID { get; set; }

        public int DoktorID { get; set; }

        [Required]
        [StringLength(11)]
        public string HastaTC { get; set; }

        [Required]
        [StringLength(500)]
        public string Tani { get; set; }

        public DateTime TaniTarihi { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
