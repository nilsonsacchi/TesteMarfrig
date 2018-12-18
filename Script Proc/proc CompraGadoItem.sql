ALTER PROCEDURE ..sp_Inserir_CompraGadoItem
(
	@Id int output,
	@Quantidade int,
	@CompraGadoId int, 
	@AnimalId int
)
AS
	INSERT INTO CompraGadoItem (Quantidade, CompraGadoId, AnimalId)
	VALUES
	(@Quantidade, @CompraGadoId, @AnimalId)
	SET @Id = SCOPE_IDENTITY();
GO

ALTER PROCEDURE ..sp_Atualizar_CompraGadoItem
(
	@Id int output,
	@Quantidade int,
	@CompraGadoId int, 
	@AnimalId int
)
AS
	UPDATE CompraGadoItem 
	SET
		Quantidade = @Quantidade,
		CompraGadoId = @CompraGadoId,
		AnimalId = @AnimalId
	WHERE Id = @ID
GO
