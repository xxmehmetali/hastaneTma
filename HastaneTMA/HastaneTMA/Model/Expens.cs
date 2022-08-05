namespace HastaneTMA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Expenses")]
    public partial class Expens
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string GiderAdi { get; set; }

        public int Miktar { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }
    }
}
