CREATE TRIGGER [AfterInsertEstudiante]
	ON [dbo].[Estudiante]
	after INSERT
	AS
	BEGIN
		insert UsuarioEstudiante select MatriculaEstudiante, MatriculaEstudiante from inserted
	END
