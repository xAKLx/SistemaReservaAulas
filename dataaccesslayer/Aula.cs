namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aula")]
    public partial class Aula
    {
        public Aula()
        {
            HorarioGrupoes = new HashSet<HorarioGrupo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDAula { get; set; }

        [StringLength(50)]
        public string CaracteristicasAula { get; set; }

        public virtual ICollection<HorarioGrupo> HorarioGrupoes { get; set; }
    }
}
