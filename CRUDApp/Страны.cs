namespace CRUDApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Страны
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Страны()
        {
            ЭтническийСостав = new HashSet<ЭтническийСостав>();
        }

        [Key]
        public int Код { get; set; }

        [Required]
        [StringLength(40)]
        public string Название { get; set; }

        [StringLength(20)]
        public string Материк { get; set; }

        [StringLength(40)]
        public string Столица { get; set; }

        [Column("Количество жителей")]
        public long? Количество_жителей { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЭтническийСостав> ЭтническийСостав { get; set; }
    }
}
