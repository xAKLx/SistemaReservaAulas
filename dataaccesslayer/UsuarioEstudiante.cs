namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsuarioEstudiante")]
    public partial class UsuarioEstudiante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatriculaEstudiante { get; set; }

        [Required]
        [StringLength(30)]
        public string PassUsuario { get; set; }

        public virtual Estudiante Estudiante { get; set; }
    }
}
