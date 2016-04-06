CREATE TABLE [dbo].[UsuarioProfesor]
(
	[CedulaProfesor] CHAR(13) NOT NULL PRIMARY KEY,
	[PassUsuario] VARCHAR(30) NOT NULL, 
    CONSTRAINT [FK_UsuarioProfesor_ToProfesor] FOREIGN KEY ([CedulaProfesor]) REFERENCES Profesor([CedulaProfesor])
)
