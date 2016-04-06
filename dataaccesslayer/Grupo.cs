namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Grupo")]
    public partial class Grupo
    {
        public Grupo()
        {
            HorarioGrupoes = new HashSet<HorarioGrupo>();
            Estudiantes = new HashSet<Estudiante>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string CodigoAsignatura { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte NumeroGrupo { get; set; }

        [StringLength(13)]
        public string CedulaProfesor { get; set; }

        public virtual Asignatura Asignatura { get; set; }

        public virtual Profesor Profesor { get; set; }

        public virtual ICollection<HorarioGrupo> HorarioGrupoes { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
