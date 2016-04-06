namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Profesor")]
    public partial class Profesor
    {
        public Profesor()
        {
            Grupoes = new HashSet<Grupo>();
        }

        [Key]
        [StringLength(13)]
        public string CedulaProfesor { get; set; }

        public virtual ICollection<Grupo> Grupoes { get; set; }

        public virtual UsuarioProfesor UsuarioProfesor { get; set; }
    }
}
