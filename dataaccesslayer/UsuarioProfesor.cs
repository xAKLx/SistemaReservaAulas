namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsuarioProfesor")]
    public partial class UsuarioProfesor
    {
        [Key]
        [StringLength(13)]
        public string CedulaProfesor { get; set; }

        [Required]
        [StringLength(30)]
        public string PassUsuario { get; set; }

        public virtual Profesor Profesor { get; set; }
    }
}
