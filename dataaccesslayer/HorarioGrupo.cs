namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HorarioGrupo")]
    public partial class HorarioGrupo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string CodigoAsignatura { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte NumeroGrupo { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte NumeroHorario { get; set; }

        public byte DiaHorario { get; set; }

        public TimeSpan InicioHorario { get; set; }

        public TimeSpan FinHorario { get; set; }

        public int? IDAula { get; set; }

        public virtual Aula Aula { get; set; }

        public virtual Grupo Grupo { get; set; }
    }
}
