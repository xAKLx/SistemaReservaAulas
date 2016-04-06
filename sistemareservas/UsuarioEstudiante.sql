CREATE TABLE [dbo].[UsuarioEstudiante]
(
	[MatriculaEstudiante] INT NOT NULL PRIMARY KEY, 
    [PassUsuario] VARCHAR(30) NOT NULL, 
    CONSTRAINT [FK_UsuarioEstudiante_ToEstudiante] FOREIGN KEY (MatriculaEstudiante) REFERENCES Estudiante(MatriculaEstudiante)
)
