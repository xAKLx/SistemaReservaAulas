CREATE TABLE [dbo].[HorarioGrupo]
(
	[CodigoAsignatura] VARCHAR(15) NOT NULL , 
    [NumeroGrupo] TINYINT NOT NULL, 
    [NumeroHorario] TINYINT NOT NULL, 
    [DiaHorario] TINYINT NOT NULL, 
    [InicioHorario] TIME NOT NULL, 
    [FinHorario] TIME NOT NULL, 
    [IDAula] INT NULL, 
    CONSTRAINT [PK_HorarioGrupo] PRIMARY KEY ([CodigoAsignatura], [NumeroGrupo], [NumeroHorario]), 
    CONSTRAINT [FK_HorarioGrupo_ToGrupo] FOREIGN KEY ([CodigoAsignatura], [NumeroGrupo]) REFERENCES [Grupo]([CodigoAsignatura], [NumeroGrupo]), 
    CONSTRAINT [CK_HorarioGrupo_InicioFin] CHECK (InicioHorario < FinHorario), 
    CONSTRAINT [FK_HorarioGrupo_ToAula] FOREIGN KEY ([IDAula]) REFERENCES [Aula]([IDAula]), 
)
