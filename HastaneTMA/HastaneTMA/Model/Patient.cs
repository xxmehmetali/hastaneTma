namespace HastaneTMA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Patient
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Ad { get; set; }

        [Required]
        [StringLength(30)]
        public string Soyad { get; set; }

        public bool Cinsiyet { get; set; }

        public int Yas { get; set; }

        [Required]
        [StringLength(30)]
        public string Ilce { get; set; }

        [Required]
        [StringLength(60)]
        public string Adres { get; set; }

        [Required]
        [StringLength(10)]
        public string PostaKodu { get; set; }

        [Required]
        [StringLength(11)]
        public string TCNo { get; set; }
    }
}
