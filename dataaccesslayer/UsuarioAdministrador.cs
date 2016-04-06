namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsuarioAdministrador")]
    public partial class UsuarioAdministrador
    {
        [Key]
        [StringLength(20)]
        public string NombreUsuario { get; set; }

        [Required]
        [StringLength(30)]
        public string PassUsuario { get; set; }
    }
}
