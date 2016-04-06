CREATE TABLE [dbo].[Grupo]
(
	[CodigoAsignatura] VARCHAR(15) NOT NULL , 
    [NumeroGrupo] TINYINT NOT NULL, 
    [CedulaProfesor] CHAR(13) NULL, 
    PRIMARY KEY ([CodigoAsignatura], [NumeroGrupo]), 
    CONSTRAINT [FK_Grupo_ToProfesor] FOREIGN KEY ([CedulaProfesor]) REFERENCES Profesor([CedulaProfesor]), 
    CONSTRAINT [FK_Grupo_ToAsignatura] FOREIGN KEY ([CodigoAsignatura]) REFERENCES Asignatura([CodigoAsignatura])
)
