CREATE TABLE [dbo].[EstudianteGrupo]
(
	[MatriculaEstudiante] INT NOT NULL ,
	[CodigoAsignatura] VARCHAR(15) NOT NULL , 
    [NumeroGrupo] TINYINT NOT NULL, 
    PRIMARY KEY ([MatriculaEstudiante], [CodigoAsignatura], [NumeroGrupo]), 
    CONSTRAINT [FK_EstudianteGrupo_ToEstudiante] FOREIGN KEY ([MatriculaEstudiante]) REFERENCES [Estudiante]([MatriculaEstudiante]), 
    CONSTRAINT [FK_EstudianteGrupo_ToGrupo] FOREIGN KEY ([CodigoAsignatura], [NumeroGrupo]) REFERENCES [Grupo]([CodigoAsignatura], [NumeroGrupo])
)
