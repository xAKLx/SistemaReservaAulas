namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Asignatura")]
    public partial class Asignatura
    {
        public Asignatura()
        {
            Grupoes = new HashSet<Grupo>();
        }

        [Key]
        [StringLength(15)]
        public string CodigoAsignatura { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreAsignatura { get; set; }

        public virtual ICollection<Grupo> Grupoes { get; set; }
    }
}
