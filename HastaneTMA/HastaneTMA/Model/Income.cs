namespace HastaneTMA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Income
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string GelirAdi { get; set; }

        public int Miktar { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }
    }
}
