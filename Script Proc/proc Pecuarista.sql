ALTER PROCEDURE ..sp_Inserir_Pecuarista
(
	@Nome varchar(100)
)
AS
	INSERT INTO Pecuarista (Nome)
	VALUES (@Nome)
GO

ALTER PROCEDURE ..sp_Atualizar_Pecuarista
(
	@Id int output,
	@Nome varchar(100)
)
AS
	UPDATE Pecuarista
	SET
		Nome = @Nome
	WHERE Id = @ID	
GO
