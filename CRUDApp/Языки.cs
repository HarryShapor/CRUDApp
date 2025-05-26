namespace CRUDApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Языки
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Языки()
        {
            ЭтническийСостав = new HashSet<ЭтническийСостав>();
        }

        [Key]
        public int Код { get; set; }

        [Required]
        [StringLength(30)]
        public string Название { get; set; }

        [Column("Языковая группа")]
        [StringLength(30)]
        public string Языковая_группа { get; set; }

        [Column("Вид знаковой системы")]
        [StringLength(20)]
        public string Вид_знаковой_системы { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЭтническийСостав> ЭтническийСостав { get; set; }
    }
}
