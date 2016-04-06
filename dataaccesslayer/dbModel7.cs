namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbModel7 : DbContext
    {
        public dbModel7()
            : base("name=dbModel7")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Asignatura> Asignaturas { get; set; }
        public virtual DbSet<Aula> Aulas { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Grupo> Grupoes { get; set; }
        public virtual DbSet<HorarioGrupo> HorarioGrupoes { get; set; }
        public virtual DbSet<Profesor> Profesors { get; set; }
        public virtual DbSet<UsuarioAdministrador> UsuarioAdministradors { get; set; }
        public virtual DbSet<UsuarioEstudiante> UsuarioEstudiantes { get; set; }
        public virtual DbSet<UsuarioProfesor> UsuarioProfesors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asignatura>()
                .Property(e => e.CodigoAsignatura)
                .IsUnicode(false);

            modelBuilder.Entity<Asignatura>()
                .Property(e => e.NombreAsignatura)
                .IsUnicode(false);

            modelBuilder.Entity<Asignatura>()
                .HasMany(e => e.Grupoes)
                .WithRequired(e => e.Asignatura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Aula>()
                .Property(e => e.CaracteristicasAula)
                .IsFixedLength();

            modelBuilder.Entity<Estudiante>()
                .HasOptional(e => e.UsuarioEstudiante)
                .WithRequired(e => e.Estudiante);

            modelBuilder.Entity<Estudiante>()
                .HasMany(e => e.Grupoes)
                .WithMany(e => e.Estudiantes)
                .Map(m => m.ToTable("EstudianteGrupo").MapLeftKey("MatriculaEstudiante").MapRightKey(new[] { "CodigoAsignatura", "NumeroGrupo" }));

            modelBuilder.Entity<Grupo>()
                .Property(e => e.CodigoAsignatura)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.CedulaProfesor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .HasMany(e => e.HorarioGrupoes)
                .WithRequired(e => e.Grupo)
                .HasForeignKey(e => new { e.CodigoAsignatura, e.NumeroGrupo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HorarioGrupo>()
                .Property(e => e.CodigoAsignatura)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.CedulaProfesor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .HasOptional(e => e.UsuarioProfesor)
                .WithRequired(e => e.Profesor);

            modelBuilder.Entity<UsuarioAdministrador>()
                .Property(e => e.NombreUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioAdministrador>()
                .Property(e => e.PassUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioEstudiante>()
                .Property(e => e.PassUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioProfesor>()
                .Property(e => e.CedulaProfesor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioProfesor>()
                .Property(e => e.PassUsuario)
                .IsUnicode(false);
        }
    }
}
