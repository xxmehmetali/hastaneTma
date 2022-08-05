namespace HastaneTMA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(30)]
        public string Sifre { get; set; }

        public int RolNo { get; set; }

        public int CalisanNo { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
