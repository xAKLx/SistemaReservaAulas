CREATE TRIGGER AfterInsertProfesor
	ON [dbo].Profesor
	After INSERT
	AS
	BEGIN
		insert UsuarioProfesor select CedulaProfesor, CedulaProfesor from inserted
	END
