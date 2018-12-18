ALTER PROCEDURE ..sp_Inserir_CompraGado
(
	@Id INT = NULL OUTPUT,
	@DataEntrega datetime,
	@PecuaristaId int
)
AS
	INSERT INTO CompraGado (DataEntrega, PecuaristaId)
	VALUES
	(@DataEntrega, @PecuaristaId) 
	SET @Id = SCOPE_IDENTITY();

GO

ALTER PROCEDURE ..sp_Atualizar_CompraGado
(
	@Id int output,
	@DataEntrega datetime,
	@PecuaristaId int
)
AS
	UPDATE CompraGado
	SET
		DataEntrega = @DataEntrega, 
		PecuaristaId = @PecuaristaId
	WHERE Id = @ID	
GO

ALTER PROCEDURE ..sp_Atualizar_CompraGadoImpresso
(
	@Id int output
)
AS
	UPDATE CompraGado
	SET
		Impresso = 1
	WHERE Id = @ID	
GO
