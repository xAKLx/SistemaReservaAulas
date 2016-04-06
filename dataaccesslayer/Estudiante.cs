namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estudiante")]
    public partial class Estudiante
    {
        public Estudiante()
        {
            Grupoes = new HashSet<Grupo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatriculaEstudiante { get; set; }

        public virtual UsuarioEstudiante UsuarioEstudiante { get; set; }

        public virtual ICollection<Grupo> Grupoes { get; set; }
    }
}
