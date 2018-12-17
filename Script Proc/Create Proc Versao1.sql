SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE ..sp_Select_CompraGadoItem
(
	@id int output
)
AS
SELECT 
	a.descricao, cgi.quantidade, a.preco, cgi.quantidade * a.preco AS valortotal
FROM
	CompraGado cg
INNER JOIN CompraGadoItem cgi ON cgi.CompraGadoId = cg.Id
INNER JOIN Animal a ON a.id = cgi.AnimalId
WHERE cg.id = @id
GO

ALTER PROCEDURE ..sp_Inserir_CompraGadoItem
(
	@Quantidade int,
	@CompraGadoId int, 
	@AnimalId int
)
AS
	INSERT INTO CompraGadoItem (Quantidade, CompraGadoId, AnimalId)
	VALUES
	(@Quantidade, @CompraGadoId, @AnimalId) 
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
ALTER PROCEDURE ..sp_Delete_CompraGadoItem
(
	@Id int output
)
AS
	DELETE FROM CompraGadoItem WHERE Id = @Id
GO





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
ALTER PROCEDURE ..sp_Delete_CompraGado
(
	@Id int output
)
AS
	DELETE FROM CompraGado WHERE Id = @Id
GO






ALTER PROCEDURE ..sp_Inserir_Animal
(
	@Descricao varchar(50),
	@Preco numeric(10,2)
)
AS
	INSERT INTO Animal (Descricao, Preco)
	VALUES
	(@Descricao, @Preco)

GO
ALTER PROCEDURE ..sp_Atualizar_Animal
(
	@Id int output,
	@Descricao varchar(50),
	@Preco numeric(10,2)
)
AS
	UPDATE Animal
	SET
		Descricao = @Descricao, 
		Preco = @Preco
	WHERE Id = @ID	

GO
ALTER PROCEDURE ..sp_Delete_Animal
(
	@Id int output
)
AS
	DELETE FROM Animal WHERE Id = @Id
GO

select * from Animal





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
ALTER PROCEDURE ..sp_Delete_Pecuarista
(
	@Id int output
)
AS
	DELETE FROM Pecuarista WHERE Id = @Id
GO
