namespace HastaneTMA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Diagnostics = new HashSet<Diagnostic>();
            Doctors = new HashSet<Doctor>();
            Users = new HashSet<User>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Ad { get; set; }

        [Required]
        [StringLength(30)]
        public string Soyad { get; set; }

        public bool Cinsiyet { get; set; }

        [Column(TypeName = "date")]
        public DateTime DogumTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime IseGirisTarihi { get; set; }

        public double maas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnostic> Diagnostics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctor> Doctors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
