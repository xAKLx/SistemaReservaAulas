CREATE VIEW [dbo].[HorarioGruposConAulas]
	AS SELECT b.* FROM Aula a join HorarioGrupo b on a.IDAula = b.IDAula
